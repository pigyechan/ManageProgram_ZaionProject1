using MySql.Data.MySqlClient;
using System;

namespace ManageProgram
{
    class PeopleInfo
    {
        private string name;
        public string Name { get; set; }

        private string position;
        public string Position { get; set; }

        private string phoneNumber;
        public string PhoneNumber { get; set; }

        private string email;
        public string Email { get; set; }

        private int num;
        public int Num { get; set; }

        private DateTime birthday;
        public DateTime Birthday { get; set; }

        private string id;
        public string Id { get; set; }

        private MySqlCommand cmd;
        public MySqlCommand Cmd { get; set; }
    }
}
