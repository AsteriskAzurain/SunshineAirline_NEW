using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application0618.global
{
    static class SqlHelper
    {
        static string datasource = "localhost";
        static string database = "Session1";
        static string uid = "sa";
        static string pswd = "NSC2018";

        static string connstr = string.Format("Data Source={0}; database={1}; uid={2}; pwd={3}",datasource,database,uid,pswd);

        public static int ExecuteQuery(string sql, params SqlParameter[] pms) {
            using (SqlConnection conn = new SqlConnection(connstr)) {
                using (SqlCommand cmd = new SqlCommand(sql, conn)) {
                    if (pms != null) cmd.Parameters.AddRange(pms);
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static object ExecuteScalar(string sql, params SqlParameter[] pms) {
            using (SqlConnection conn = new SqlConnection(connstr)) {
                using (SqlCommand cmd = new SqlCommand(sql, conn)) {
                    if (pms != null) cmd.Parameters.AddRange(pms);
                    conn.Open();
                    return cmd.ExecuteScalar();
                }
            }
        }
    }
}
