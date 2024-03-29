using MySql.Data.MySqlClient;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ManageProgram
{
    class MariaDB
    {
        private MySqlConnection conn; 
        public MySqlConnection Conn { get; set; }

        // DB 연결 부분
        public Boolean DBConnection()
        {
            // CharSet=utf8 설정을 안하면 한글 입출력시 물음표(?)로 인식
            string connectString = "Server=localhost;Database=zaionsoft;Uid=root;Password=0916;CharSet=utf8;";
            try
            {
                Conn = new MySqlConnection(connectString);  // DB 설정
                Conn.Open();    // DB 연결
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Boolean temp = Conn.Ping();

            if (temp == true)
            {
                return temp;
            }
            else { return temp; }
        }

        public MySqlConnection getConnection()
        {
            if (Conn == null)
                DBConnection();
            return Conn;
        }

        // DB 연결 부분
        
        // SQL 처리부분
        public Boolean Sql(string SQL)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL, Conn);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
                Conn.Close();
                return false;
            }
            
        }

        // Select 결과값 return
        public MySqlDataReader Select_Sql(string SQL)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL, Conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                return rdr;
            }

            catch (Exception e)
            {
                MessageBox.Show(Convert.ToString(e));
                Conn.Close();
                return null;
            }
        }

        public MySqlCommand CUDQry(string SQL)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL, Conn);
                return cmd;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
                Conn.Close();
                return null;
            }
        }

        public void connClose()
        {
            Conn.Close();
        }

        
    }
}

