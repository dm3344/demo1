
using MySql.Data.MySqlClient;

namespace updateBattery
{
   public  class Program
    {
        private static readonly string SqlConnect = "Server=localhost;Database=bluetooth;Uid=root;Pwd=Ed987654;default command timeout=20;Connection Timeout=5;Charset=utf8;Allow User Variables=True;";

        static void Main(string[] args)
        {
           update();
        }

        private static bool update()
        {
            string sql = "";

            using (var conn = new MySqlConnection(SqlConnect))
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand();
                command.CommandText = "select *from t_dev where id =@id";
                command.CommandType = System.Data.CommandType.Text;
                command.Connection = conn;
                command.Parameters.Add(new MySqlParameter("@id", "447"));
                object obj = command.ExecuteReader();
            }

            return true;
        }
    }
}
