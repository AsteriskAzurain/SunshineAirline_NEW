using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Usercontrol
{
    static class SqlHelper
    {
        static string sql_dataSource = "localhost";
        static string sql_database = "Session1";
        static string sql_uid = "sa";
        static string sql_pwd = "NSC2018";

        private static readonly string connStr = string.Format("Data Source={0}; database={1}; uid={2}; pwd={3}", sql_dataSource, sql_database, sql_uid, sql_pwd);

        //1 执行添删改查的方法: ExecuteonQuery
        public static int ExecuteonQuery(string sql, params SqlParameter[] pms) {
            using (SqlConnection conn = new SqlConnection(connStr)) {
                using (SqlCommand cmd = new SqlCommand(sql, conn)) {
                    if (pms != null) {
                        cmd.Parameters.AddRange(pms);
                    }
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        //2 返回单个对象: ExecuteScalar
        public static object ExecuteScalar(string sql, params SqlParameter[] pms) {
            using (SqlConnection conn = new SqlConnection(connStr)) {
                using (SqlCommand cmd = new SqlCommand(sql, conn)) {
                    if (pms != null) {
                        cmd.Parameters.AddRange(pms);
                    }
                    conn.Open();
                    return cmd.ExecuteScalar();
                    //当select语句无记录返回时，ExecuteScalar()返回NULL值，无法再将null值赋给任何对象或者变量，否则出现异常
                }
            }
        }

        //4 执行返回DataTable的方法
        public static DataTable ExecuteDataTable(string sql, params SqlParameter[] pms) {
            DataTable dt = new DataTable();
            using (SqlDataAdapter adapter = new SqlDataAdapter(sql, connStr))
            {
                adapter.Fill(dt);
            }
            return dt;
        }

        //DataSet和SQLServer之间的桥接器 联合DataSet使用
        public static SqlDataAdapter Adapt(string tsql_cmd) {
            SqlDataAdapter sql_da = new SqlDataAdapter(tsql_cmd, connStr);
            return sql_da;
        }
    }
}
