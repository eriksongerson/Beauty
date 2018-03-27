using Beauty.Helpers;

namespace Beauty
{
    public class Client
    {
        public int id { get; set; }
        public int number { get; set; }
        public string secondName { get; set; }
        public string firstName { get; set; }
        public string patronymic { get; set; }
        public string phone { get; set; }
        public int age { get; set; }

        public Client()
        {

        }

        public Client(string secondName, string firstName, string patronymic, string phone, int age)
        {
            this.secondName = secondName;
            this.firstName = firstName;
            this.patronymic = patronymic;
            this.phone = phone;
            this.age = age;
            this.id = DatabaseHelper.getClientId();
            bool isUnique = false;
            while (!isUnique)
            {
                this.number = RandomHelper.getNumber();
                isUnique = DatabaseHelper.CheckUniqueNumberClient(this.number);
            }
        } 

        public Client(int id, int number, string secondName, string firstName, string patronymic, string phone, int age)
        {
            this.id = id;
            this.number = number;
            this.secondName = secondName;
            this.firstName = firstName;
            this.patronymic = patronymic;
            this.phone = phone;
            this.age = age;
        }

        public string getFullName()
        {
            return this.secondName + " " + this.firstName + " " + patronymic;
        }
        public void setFullName(string fullName)
        {
            var name = fullName.Split(' ');
            this.secondName = name[0];
            this.firstName = name[1];
            this.patronymic = name[2];
        }

    }
}
