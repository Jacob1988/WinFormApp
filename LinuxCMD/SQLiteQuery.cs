using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.Common;
using System.Data.SQLite;
namespace LinuxCMD
{
    /// <summary> 
    /// 说明：这是一个针对System.Data.SQLite的数据库常规操作封装的通用类。 
    /// </summary> 
    public class SQLiteQuery
    {
        private SQLiteConnection DBConnect;
        private string DBConnectStr = string.Empty;
        private string DBSqlStr = string.Empty;
        private SQLiteCommand DBCommand;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="dbPath">数据库文件路径</param>
        public SQLiteQuery(string dbPath)
        {
            if (dbPath == string.Empty)
                return;
            this.DBConnectStr = "Data Source=" + dbPath + ";Version=3;";
            DBConnect = new SQLiteConnection(DBConnectStr);
            DBConnect.Open();
        }

        /// <summary> 
        /// 执行一个查询语句，返回一个包含查询结果的DataTable 
        /// </summary> 
        /// <param name="sql">要执行的查询语句</param> 
        /// <param name="parameters">执行SQL查询语句所需要的参数，参数必须以它们在SQL语句中的顺序为准</param> 
        /// <returns></returns> 
        public DataTable ExecuteDataTable(string sql, SQLiteParameter[] parameters)
        {
            using (SQLiteConnection connect = new SQLiteConnection(DBConnectStr))
            {
                using (SQLiteCommand command = new SQLiteCommand(sql, connect))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                    DataTable data = new DataTable();
                    adapter.Fill(data);
                    return data;
                }
            }
        }
    }
}