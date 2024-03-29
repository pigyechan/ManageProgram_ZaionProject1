using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ManageProgram
{
    class isRight
    {
        private int isName;
        private int isPosition;
        private bool isPhonenum;
        private bool isEmail;
        private int isId;

        public int IsName { get; set; }
        public int IsPosition { get; set; } 
        public bool IsPhonenum { get; set; } 
        public bool IsEmail { get; set; }
        public int IsId { get; set; }

        SqlRunning sqlRunning = new SqlRunning();

        public void IsRight() 
        {
            IsPhonenum = Regex.IsMatch(Form1.form1.tbxPhoneNumber.Text, @"01\d-\d{3,4}-\d{4}");
            IsEmail = Regex.IsMatch(Form1.form1.tbxEmail.Text, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");

            if (IsName <= 10 && IsPosition <= 10 && IsPhonenum)
            {
                sqlRunning.UpdateOrInsert();

            }
            else 
            {
                if (!IsPhonenum)
                {
                    MessageBox.Show("전화번호 형식이 맞지 않습니다.");
                }
                if (!IsEmail)
                {
                    MessageBox.Show("이메일 형식이 맞지 않습니다.");
                }
            }

        }
    }
}
