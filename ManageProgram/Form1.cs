using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ManageProgram
{
    public partial class Form1 : Form
    {
        public static Form1 form1;
        bool result = false;
        MySqlDataReader rdr;
        PeopleInfo peopleInfo = new PeopleInfo();
        MariaDB mariaDB = new MariaDB();
        TbxOptions tbxOptions = new TbxOptions();
        isRight isright = new isRight();

        public bool isOld = false;

        public Form1()
        {
            InitializeComponent();
            dtpBirthday.MaxDate = DateTime.Now;
            dtpBirthday.Value = DateTime.Today;
            form1 = this;

            refreshForm();
        }

        private void refreshForm()
        {
            result = mariaDB.DBConnection();
            if (result == true)
            {
                rdr = mariaDB.Select_Sql("Select * from zaioninfo order by tagnum;");
                while (rdr.Read())
                {
                    string name = rdr.GetString("name");
                    lBMemberList.Items.Add(name);
                }
            }
            else
            {
                MessageBox.Show("DB 연결에 오류가 있습니다.");
                mariaDB.connClose();
            }
        }

        private void btnNew_Click(object sender, System.EventArgs e)
        {
            isOld = false;
            tbxOptions.tbxClear();
            tbxOptions.tbxOn();
            tbxId.ReadOnly = false;
        }

        private void btnModi_Click(object sender, System.EventArgs e)
        {
            isOld = true;
            if (tbxName.Text != "")
            {
                tbxOptions.tbxOn();
            }
            else
            {
                tbxOptions.tbxOff();
                tbxId.ReadOnly = true;
                MessageBox.Show("수정할 항목이 선택되지 않았습니다.");
            }
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (tbxName.ReadOnly == true)
                MessageBox.Show("등록/ 수정을 먼저 선택해주세요.");
            else if (string.IsNullOrEmpty(tbxNum.Text) || string.IsNullOrEmpty(tbxName.Text) || string.IsNullOrEmpty(tbxPosition.Text) || string.IsNullOrEmpty(tbxPhoneNumber.Text)
                    || string.IsNullOrEmpty(tbxEmail.Text))
            {
                MessageBox.Show("입력되지 않은 항목이 있습니다.");

            }
            else
            { 
                isright.IsRight();
            }


            mariaDB.connClose();

            lBMemberList.Items.Clear();
            refreshForm();
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            
            SqlRunning sqlRunning = new SqlRunning();
            sqlRunning.deleteSQL();
            

            mariaDB.connClose();

            lBMemberList.Items.Clear();
            refreshForm();
        }


        private void lBMemberList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (isOld == false)
            {
                tbxOptions.tbxOff();
            }

            int select_index = -1;
            Point point = e.Location;
            select_index = lBMemberList.IndexFromPoint(point);
            if (select_index != -1)
            {
                string selectedItem = lBMemberList.Items[select_index] as string;
                result = mariaDB.DBConnection();
                if (result == true)
                {
                    try
                    {
                        rdr = mariaDB.Select_Sql("Select * from zaioninfo where name = '" + selectedItem + "';");

                        while (rdr.Read())
                        {
                            peopleInfo.Name = rdr.GetString("name");
                            peopleInfo.Position = rdr.GetString("position");
                            peopleInfo.Birthday = rdr.GetDateTime("birthday");
                            peopleInfo.PhoneNumber = rdr.GetString("phonenum");
                            peopleInfo.Email = rdr.GetString("email");
                            peopleInfo.Num = rdr.GetInt32("tagnum");
                            peopleInfo.Id = rdr.GetString("id");

                            this.tbxName.Text = peopleInfo.Name;
                            this.tbxPosition.Text = peopleInfo.Position;
                            this.tbxEmail.Text = peopleInfo.Email;
                            this.tbxPhoneNumber.Text = peopleInfo.PhoneNumber;
                            this.dtpBirthday.Value = peopleInfo.Birthday;
                            this.tbxNum.Text = peopleInfo.Num.ToString();
                            this.tbxId.Text = peopleInfo.Id.ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("DB 연결에 오류가 있습니다.");
                    mariaDB.connClose();
                }

            }
        }

    }
}

