using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Snake
{
    #region 相关数据类型定义
    /// <summary>
    /// 蛇身属性
    /// </summary>
    public enum SnakeProperty
    {
        Food,           //0食物
        Head,           //1蛇头
        Body,           //2身体
        Wall,           //3墙壁
        Null            //空白
    };

    //蛇头方向
    public enum SnakeDirection
    {
        Up,
        Down,
        Left,
        Right
    };

    public enum SnakeLife
    {
        Live,//存活
        Die,//死亡
        Win,//胜利
    }
    #endregion

    public class GameSnake
    {
        #region 相关数据类型定义
        /// <summary>
        /// 表述蛇身的结构体
        /// </summary>
        private struct SnakeBody
        {
            public int x;
            public int y;
            public Color color;
            public bool exist;
            public SnakeProperty proty;

            public SnakeBody(int _x, int _y, Color _col, bool _ex, SnakeProperty _p)
            {
                x = _x;
                y = _y;
                color = _col;
                exist = _ex;
                proty = _p;
            }
        };
        #endregion

        #region 蛇身相关属性
        private int _BodySize = 20;//蛇头大小，默认为20
        private SnakeDirection _Direction = SnakeDirection.Right;//蛇头方向，初始为右
        private SnakeLife _Life = SnakeLife.Live;//蛇的生命值，初始为生存
        private int _Score = 0;//游戏得分，初始为0
        private bool _CrossWall = true;//是否允许穿墙, 默认允许
        private List<SnakeBody> _SnakeList = new List<SnakeBody>();//蛇身
        private SnakeBody _Food = new SnakeBody(0, 0, Color.White, true, SnakeProperty.Food);//食物
        #endregion

        #region 用于绘制游戏窗口的属性
        private Control _Windows;//画布
        private Graphics _Graphics;//绘图
        private Color _SColor = Color.Red;//蛇身颜色
        #endregion

        #region 属性的get、set方法
        /// <summary>
        /// 获取或设置蛇身大小
        /// </summary>
        public int BodySize
        {
            get
            {
                return _BodySize;
            }
            set
            {
                //设置蛇身大小
                int min = (_Windows.Size.Width <= _Windows.Size.Height) ?
                   _Windows.Size.Width : _Windows.Size.Height;

                if ((value <= 0) || (value >= (min / 5)))
                {
                    _BodySize = min / 20;
                }
                else
                {
                    _BodySize = value;
                }

                //重新设置蛇身大小后会产生缩放问题,
                //需要重新产生食物，不然画面上的食物会“消失”
                //重新产生化食物
                //int fx = 0, fy = 0;
                //_Food.color = _SColor;
                //_Food.exist = true;
                //_Food.proty = SnakeProperty.Food;
                //_SnakeGetRandomXY(out fx, out fy);
                //_Food.x = fx;
                //_Food.y = fy;
                //重绘游戏画面
                _SnakeClearWindow();
                _SnakeReDrawGame();
            }
        }

        /// <summary>
        /// 获取或设置蛇头方向
        /// </summary>
        public SnakeDirection Direction
        {
            get
            {
                return _Direction;
            }
            set
            {
                if ((value == SnakeDirection.Up) && (_Direction != SnakeDirection.Down) ||
                (value == SnakeDirection.Down) && (_Direction != SnakeDirection.Up) ||
                (value == SnakeDirection.Left) && (_Direction != SnakeDirection.Right) ||
                (value == SnakeDirection.Right) && (_Direction != SnakeDirection.Left))
                {
                    _Direction = value;
                }
            }
        }

        /// <summary>
        /// 设置指定控件，游戏将会绘制在指定的控件上
        /// </summary>
        public Control Windows
        {
            set
            {
                _Windows = value;
            }
        }

        /// <summary>
        /// 设置蛇身颜色
        /// </summary>
        public Color SColor
        {
            get
            {
                return _SColor;
            }
            set
            {
                _SColor = value;
                _Food.color = _SColor;
                SnakeBody t = new SnakeBody(); ;
                for (int i = 0; i < _SnakeList.Count; i++)
                {
                    t = _SnakeList[i];
                    t.color = _SColor;
                    _SnakeList[i] = t;
                }
                //重绘游戏画面
                _SnakeClearWindow();
                _SnakeReDrawGame();
            }
        }

        /// <summary>
        /// 获取蛇的生命值
        /// </summary>
        public SnakeLife Life
        {
            get { return _Life; }
        }

        /// <summary>
        /// 获取游戏得分
        /// </summary>
        public int Score
        {
            get { return _Score; }
        }

        /// <summary>
        /// 设置是否允许穿墙
        /// </summary>
        public bool CrossWall
        {
            get { return _CrossWall; }
            set { _CrossWall = value; }
        }
        #endregion

        #region 类的构造函数
        /// <summary>
        /// 类的构造函数
        /// </summary>
        /// <param name="Ctrl">用于绘制蛇的画布</param>
        /// <param name="bdyc">蛇身颜色</param>
        public GameSnake(Control Ctrl, Color Col, int bdSize)
        {
            //画布画刷初始化
            _Windows = Ctrl;
            _SColor = Col;
            _Graphics = _Windows.CreateGraphics();

            //设置蛇身大小
            int min = (_Windows.Size.Width <= _Windows.Size.Height) ?
               _Windows.Size.Width : _Windows.Size.Height;

            if ((bdSize <= 0) || (bdSize >= (min / 5)))
            {
                _BodySize = min / 20;
            }
            else
            {
                _BodySize = bdSize;
            }

            SnakeGameRenew();//游戏初始化
        }
        #endregion

        #region 工具类方法
        /// <summary>
        /// 更具方向获取x轴和y轴的增量
        /// </summary>
        /// <param name="dir">方向</param>
        /// <param name="dx">x增量</param>
        /// <param name="dy">y增量</param>
        private void _GetVariation(SnakeDirection dir, out int dx, out int dy)
        {
            switch (dir)
            {
                case SnakeDirection.Up:
                    dx = 0;
                    dy = -1;
                    break;
                case SnakeDirection.Down:
                    dx = 0;
                    dy = 1;
                    break;
                case SnakeDirection.Left:
                    dx = -1;
                    dy = 0;
                    break;
                case SnakeDirection.Right:
                    dx = 1;
                    dy = 0;
                    break;
                default:
                    dx = 1;
                    dy = 0;
                    break;
            }
        }

        /// <summary>
        /// 把游戏画面中真实的坐标转换为蛇身坐标
        /// </summary>
        /// <param name="x">游戏画面中真实的x坐标</param>
        /// <param name="y">游戏画面中真实的y坐标</param>
        /// <param name="_x">蛇身x坐标</param>
        /// <param name="_y">蛇身y坐标</param>
        private void _GetRealPoint(int x, int y, out int _x, out int _y)
        {
            _x = x / _BodySize;
            _y = y / _BodySize;
        }

        /// <summary>
        /// 把蛇身坐标转换为游戏画面中真实的坐标
        /// </summary>
        /// <param name="x">蛇身x坐标</param>
        /// <param name="y">蛇身y坐标</param>
        /// <param name="_x">游戏画面中真实的x坐标</param>
        /// <param name="_y">游戏画面中真实的y坐标</param>
        private void _ToRealPoint(int x, int y, out int _x, out int _y)
        {
            _x = x * _BodySize;
            _y = y * _BodySize;
        }

        /// <summary>
        /// 判断两个坐标点是否相等
        /// </summary>
        /// <param name="x">点1的x坐标</param>
        /// <param name="y">点1的y坐标</param>
        /// <param name="_x">点2的x坐标</param>
        /// <param name="_y">点2的y坐标</param>
        /// <returns></returns>
        private bool _IsPointEqual(int x, int y, int _x, int _y)
        {
            if ((x == _x) && (y == _y))
                return true;
            else
                return false;
        }

        /// <summary>
        /// 获取指定坐标点对应的属性(蛇头/蛇身/食物/空)
        /// </summary>
        /// <param name="x">x坐标</param>
        /// <param name="y">y坐标</param>
        /// <returns>该坐标点的属性</returns>
        private SnakeProperty _SnakeGetPointProperty(int x, int y)
        {
            if (_IsPointEqual(_Food.x, _Food.y, x, y) == true)
            {//判断是否是食物
                return SnakeProperty.Food;
            }
            else
            {
                for (int i = (_SnakeList.Count - 1); i > 0; i--)
                {//判断是否是蛇身
                    if (_IsPointEqual(_SnakeList[i].x, _SnakeList[i].y, x, y) == true)
                    {
                        return SnakeProperty.Body;
                    }
                }

                if (_IsPointEqual(_SnakeList[0].x, _SnakeList[0].y, x, y) == true)
                {//判断是否是蛇头
                    return SnakeProperty.Head;
                }
                return SnakeProperty.Null;
            }
        }

        /// <summary>
        /// 根据指定的参数绘制一个"点"
        /// </summary>
        /// <param name="bdy">蛇身点</param>
        private void _SnakeDrawPoint(SnakeBody bdy)
        {
            int x = 0, y = 0;
            _ToRealPoint(bdy.x, bdy.y, out x, out y);
            Rectangle rect = new Rectangle(x, y, _BodySize, _BodySize);
            SolidBrush brush = new SolidBrush(bdy.color);//颜色
            if (bdy.exist)
            {
                switch (bdy.proty)//根据属性绘制形状
                {
                    case SnakeProperty.Food://食物是圆形
                        _Graphics.FillEllipse(brush, rect);
                        break;
                    case SnakeProperty.Head://蛇头是正方形
                    case SnakeProperty.Body://蛇身是正方形
                        _Graphics.FillRectangle(brush, rect);
                        break;
                    case SnakeProperty.Wall:
                        break;
                    case SnakeProperty.Null:
                        break;
                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// 根据指定的参数清除一个"点"
        /// </summary>
        /// <param name="bdy">蛇身点</param>
        private void _SnakeClearPoint(SnakeBody bdy)
        {
            int x = 0, y = 0;
            _ToRealPoint(bdy.x, bdy.y, out x, out y);
            Rectangle rect = new Rectangle(x, y, _BodySize, _BodySize);
            SolidBrush brush = new SolidBrush(_Windows.BackColor);//用背景颜色覆盖当前点
            if (bdy.exist)
            {
                //不需要考虑形状，全部用正方形填充
                _Graphics.FillRectangle(brush, rect);
            }
        }

        /// <summary>
        /// 清除屏幕
        /// </summary>
        private void _SnakeClearWindow()
        {
            _Graphics.Clear(_Windows.BackColor);
        }

        /// <summary>
        /// 重绘游戏画面
        /// </summary>
        private void _SnakeReDrawGame()
        {
            //_Graphics.Clear(_Windows.BackColor);//清除屏幕
            _SnakeDrawPoint(_Food);//重绘食物
            foreach (var item in _SnakeList)//重绘蛇身
            {
                _SnakeDrawPoint(item);
            }
        }

        /// <summary>
        /// 生成一个随机的坐标点
        /// </summary>
        /// <returns></returns>
        private bool _SnakeGetRandomXY(out int _x, out int _y)
        {
            int _maxX = _Windows.Size.Width / _BodySize;
            int _maxY = _Windows.Size.Height / _BodySize;
            Random r = new Random();
            int x = 0, y = 0, n = _maxX * _maxY;
            while (n > 0)//直到找到合适的位置，退出
            {
                n--;
                x = r.Next(0, _maxX);
                y = r.Next(0, _maxY);
                //Console.WriteLine("RandomX={0}, RandomY={1}", x, y);
                if (_SnakeGetPointProperty(x, y) != SnakeProperty.Null)//防止重叠
                {
                    continue;
                }
                else
                {
                    _x = x;
                    _y = y;
                    return true;
                }
            }
            _x = 0;
            _y = 0;
            return false;
        }
        #endregion

        /// <summary>
        /// 蛇身前进一步
        /// </summary>
        /// <param name="dir">前进方向</param>
        /// <returns>蛇生命值</returns>
        private SnakeLife SnakeMoveStep(SnakeDirection dir)
        {
            SnakeBody tail = new SnakeBody(0, 0, _SColor, true, SnakeProperty.Body);
            tail.x = _SnakeList[_SnakeList.Count - 1].x;//保存蛇尾坐标
            tail.y = _SnakeList[_SnakeList.Count - 1].y;


            SnakeBody body_t = new SnakeBody(0, 0, _SColor, true, SnakeProperty.Body);
            for (int i = (_SnakeList.Count - 1); i > 0; i--)
            {//更新蛇身坐标
                body_t.x = _SnakeList[i - 1].x;
                body_t.y = _SnakeList[i - 1].y;
                _SnakeList[i] = body_t;
            }

            int dx = 0, dy = 0;
            _GetVariation(dir, out dx, out dy);//根据移动方向获取移动xy轴上的增量
            SnakeBody body_h = new SnakeBody(0, 0, _SColor, true, SnakeProperty.Head);//更新蛇头坐标
            body_h.x = _SnakeList[0].x + dx;
            body_h.y = _SnakeList[0].y + dy;

            //穿墙处理
            int _maxX = _Windows.Size.Width / _BodySize;
            int _maxY = _Windows.Size.Height / _BodySize;

            if (_CrossWall == false)
            {
                if ((body_h.x >= _maxX) || (body_h.x < 0) ||
                        (body_h.y >= _maxY) || (body_h.y < 0))
                {
                    _Life = SnakeLife.Die;
                }
            }

            if (body_h.x >= _maxX)
                body_h.x = 0;
            if (body_h.x < 0)
                body_h.x = _maxX - 1;
            if (body_h.y >= _maxY)
                body_h.y = 0;
            if (body_h.y < 0)
                body_h.y = _maxY - 1;

            _SnakeList[0] = body_h;//更新蛇头坐标

            //判断是否吃到食物或咬到自己（在未更新坐标之前预判）
            int foodx = 0, foody = 0;
            SnakeProperty p = _SnakeGetPointProperty(_SnakeList[0].x, _SnakeList[0].y);
            switch (p)
            {
                case SnakeProperty.Food:
                    Console.WriteLine("SnakeProperty: " + p.ToString() + " SnakeLife: " + _Life.ToString());
                    //吃到食物后产生一个食物，蛇身长度增加
                    if (_SnakeGetRandomXY(out foodx, out foody))//创建食物
                    {
                        _Food.x = foodx;
                        _Food.y = foody;
                        _SnakeList.Add(tail);//增加蛇身长度
                        _Score++;//得分增加
                        _Life = SnakeLife.Live;
                    }
                    else
                    {
                        _Life = SnakeLife.Win;
                        //return _Life;
                    }
                    break;

                case SnakeProperty.Body:
                case SnakeProperty.Wall:
                    Console.WriteLine("SnakeProperty: " + p.ToString() + " SnakeLife: " + _Life.ToString());
                    _Life = SnakeLife.Die;//死亡
                    //return _Life;
                    break;
                case SnakeProperty.Head:
                case SnakeProperty.Null:
                default:
                    _Life = SnakeLife.Live;
                    break;
            }

            _SnakeClearPoint(tail);//清除蛇尾
            _SnakeReDrawGame();//更新显示蛇身

            return _Life;
        }

        /// <summary>
        /// 开始运行游戏
        /// </summary>
        public void SnakeGameRun()
        {
            _Life = SnakeMoveStep(_Direction);
        }

        /// <summary>
        /// 贪吃蛇游戏初始化
        /// </summary>
        public void SnakeGameRenew()
        {
            SnakeBody _body;
            _SnakeList.Clear();//清空所有数据

            //初始化游戏运行数据
            _Direction = SnakeDirection.Right;
            _Life = SnakeLife.Live;
            _Score = 0;

            //初始化蛇头
            _body = new SnakeBody(0, 0, _SColor, true, SnakeProperty.Head);
            _SnakeList.Add(_body);

            //创建初始蛇身
            int initLength = 3;
            if (initLength > 1)
            {
                int dx = 0, dy = 0;
                int x = _SnakeList[0].x, y = _SnakeList[0].y;
                _GetVariation(_Direction, out dy, out dy);
                for (int i = 1; i < initLength; i++)
                {
                    x -= (dx * _BodySize);
                    y -= (dy * _BodySize);
                    _body = new SnakeBody(x, y, _SColor, true, SnakeProperty.Body);
                    _SnakeList.Add(_body);
                }
            }

            //初始化食物
            int fx = 0, fy = 0;
            _Food.color = _SColor;
            _Food.exist = true;
            _Food.proty = SnakeProperty.Food;
            _SnakeGetRandomXY(out fx, out fy);
            _Food.x = fx;
            _Food.y = fy;

            //重绘游戏画面
            _SnakeClearWindow();
            _SnakeReDrawGame();
        }
    }
}
