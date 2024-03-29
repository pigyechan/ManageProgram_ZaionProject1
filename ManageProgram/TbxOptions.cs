using System;

namespace ManageProgram
{
    class TbxOptions
    {
        public void tbxClear()
        {
            Form1.form1.tbxName.Clear();
            Form1.form1.tbxPosition.Clear();
            Form1.form1.tbxPhoneNumber.Clear();
            Form1.form1.tbxEmail.Clear();
            Form1.form1.tbxNum.Clear();
            Form1.form1.dtpBirthday.Value = DateTime.Today;
            Form1.form1.tbxId.Clear();
        }

        public void tbxOn()
        {
            Form1.form1.tbxName.ReadOnly = false;
            Form1.form1.tbxPosition.ReadOnly = false;
            Form1.form1.tbxPhoneNumber.ReadOnly = false;
            Form1.form1.tbxEmail.ReadOnly = false;
            Form1.form1.tbxNum.ReadOnly = false;
            Form1.form1.dtpBirthday.Enabled = true;
        }

        public void tbxOff()
        {
            Form1.form1.tbxName.ReadOnly = true;
            Form1.form1.tbxPosition.ReadOnly = true;
            Form1.form1.tbxPhoneNumber.ReadOnly = true;
            Form1.form1.tbxEmail.ReadOnly = true;
            Form1.form1.tbxNum.ReadOnly = true;
            Form1.form1.dtpBirthday.Enabled = false;
            Form1.form1.tbxId.ReadOnly = true;
        }
    }
}
