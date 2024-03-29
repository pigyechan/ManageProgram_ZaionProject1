using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;


namespace ManageProgram
{
    class SqlRunning
    {
        PeopleInfo peopleInfo = new PeopleInfo();
        MariaDB mariaDB = new MariaDB();
        TbxOptions tbxOptions = new TbxOptions();

        public void IUDsql(string SQL)
        {
            bool result = mariaDB.DBConnection();
            if (result == true)
            {
                int n = 0;
                bool isNumeric = int.TryParse(Form1.form1.tbxNum.Text, out n);
                if (!isNumeric)
                {
                    MessageBox.Show("표시 순번은 숫자형태 입니다.");
                }
                else
                {
                    peopleInfo.Num = n;
                    peopleInfo.Name = Form1.form1.tbxName.Text;
                    peopleInfo.Position = Form1.form1.tbxPosition.Text;
                    peopleInfo.PhoneNumber = Form1.form1.tbxPhoneNumber.Text;
                    peopleInfo.Email = Form1.form1.tbxEmail.Text;
                    peopleInfo.Birthday = Form1.form1.dtpBirthday.Value;
                    peopleInfo.Id = Form1.form1.tbxId.Text;

                    string queryInsert = SQL;
                    peopleInfo.Cmd = mariaDB.CUDQry(queryInsert);
                    DBparameters();
                }
            }
            else
                MessageBox.Show("DB 연결에 오류가 있습니다.");
        }

        public void UpdateOrInsert()
        {
            if (Form1.form1.isOld)
            {
                IUDsql("Update zaioninfo set name = @name, position = @position, birthday = @birthday, phonenum = @phoneNumber, email = @email, tagnum = @num where id = @id");
                Form1.form1.isOld = false;
            }
            else
            {
                IUDsql("Insert into zaioninfo(name, position, birthday, phonenum, email, tagnum, id) values (@name, @position, @birthday, @phoneNumber, @email, @num, @id)");
            }
        }

        public void deleteSQL()
        {
            IUDsql("Delete from zaioninfo where id = @id");
        }

        public void DBparameters()
        {
            MySqlParameter paramName = new MySqlParameter("@name", MySqlDbType.VarChar, 10);
            paramName.Value = peopleInfo.Name;
            peopleInfo.Cmd.Parameters.Add(paramName);

            MySqlParameter paraPosition = new MySqlParameter("@position", MySqlDbType.VarChar, 10);
            paraPosition.Value = peopleInfo.Position;
            peopleInfo.Cmd.Parameters.Add(paraPosition);

            MySqlParameter paraBirthday = new MySqlParameter("@birthday", MySqlDbType.DateTime);
            paraBirthday.Value = peopleInfo.Birthday;
            peopleInfo.Cmd.Parameters.Add(paraBirthday);

            MySqlParameter paraPhonenum = new MySqlParameter("@phoneNumber", MySqlDbType.VarChar, 15);
            paraPhonenum.Value = peopleInfo.PhoneNumber;
            peopleInfo.Cmd.Parameters.Add(paraPhonenum);

            MySqlParameter paraEmail = new MySqlParameter("@email", MySqlDbType.VarChar, 100);
            paraEmail.Value = peopleInfo.Email;
            peopleInfo.Cmd.Parameters.Add(paraEmail);

            MySqlParameter paraNum = new MySqlParameter("@num", MySqlDbType.Int64);
            paraNum.Value = peopleInfo.Num;
            peopleInfo.Cmd.Parameters.Add(paraNum);

            MySqlParameter paraId = new MySqlParameter("@id", MySqlDbType.VarChar, 100);
            paraId.Value = peopleInfo.Id;
            peopleInfo.Cmd.Parameters.Add(paraId);

            try 
            {
                int result1 = peopleInfo.Cmd.ExecuteNonQuery();
                Console.WriteLine($"result: {result1}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
            tbxOptions.tbxOff();
            tbxOptions.tbxClear();
        }
    }
}

        
