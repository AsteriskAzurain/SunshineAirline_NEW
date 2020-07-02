using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application0701.global
{
    static class SqlHelper
    {
        static string datasource = "localhost";
        static string database = "Session1";
        static string uid = "sa";
        static string pwd = "NSC2018";

        static string connstr = string.Format("Data Source={0}; database={1}; uid={2}; pwd={3}", datasource, database, uid, pwd);

        public static int ExecuteQuery(string sql, params SqlParameter[] pms)
        {
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (pms != null) cmd.Parameters.AddRange(pms);
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static object ExecuteScalar(string sql, params SqlParameter[] pms)
        {
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (pms != null) cmd.Parameters.AddRange(pms);
                    conn.Open();
                    return cmd.ExecuteScalar();
                }
            }
        }

        public static DataTable ExecuteDatatable(string sql, params SqlParameter[] pms)
        {
            DataTable dt = new DataTable();
            using (SqlDataAdapter adapter = new SqlDataAdapter(sql, connstr))
            {
                adapter.Fill(dt);
            }
            return dt;
        }
    }
}
