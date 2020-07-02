using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application0601.global
{
    static class SQLhelper
    {
        static string datasource = "localhost";
        static string database = "Session1";
        static string uid = "sa";
        static string pswd = "NSC2018";

        private static string connStr = string.Format("Data Source={0}; database={1}; uid={2}; pwd={3}", datasource, database, uid, pswd);

        // 1 execute query
        public static int ExecuteQuery(string sql, params SqlParameter[] pms) {
            using(SqlConnection conn = new SqlConnection(connStr)){
                using (SqlCommand cmd = new SqlCommand(sql, conn)) {
                    if (pms != null) {
                        cmd.Parameters.AddRange(pms);
                    }
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        // 2 return obj
        public static object ExecuteScalar(string sql, params SqlParameter[] pms) {
            using (SqlConnection conn = new SqlConnection(connStr)) {
                using (SqlCommand cmd = new SqlCommand(sql, conn)) {
                    if (pms != null) cmd.Parameters.AddRange(pms);
                    conn.Open();
                    // if select sql == null: return null;
                    return cmd.ExecuteScalar();
                }
            }

        }

        // 3 return datatable
        public static DataTable ExecuteDatatable(string sql, params SqlParameter[] pms) {
            DataTable dt = new DataTable();
            using (SqlDataAdapter adapter = new SqlDataAdapter(sql, connStr)) {
                adapter.Fill(dt);
            }
                return dt;
        }

        // the adapter between the dataset and sqlserver
        public static SqlDataAdapter Adapt(string tsql_cmd) {
            SqlDataAdapter sql_da = new SqlDataAdapter(tsql_cmd, connStr);
            return sql_da;
        }

    }
}
