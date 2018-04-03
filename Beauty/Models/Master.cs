using Beauty.Helpers;

namespace Beauty
{
    public class Master
    {
        public int id { get; set; }
        public int number { get; set; }
        public string secondName { get; set; }
        public string firstName { get; set; }
        public string patronymic { get; set; }
        public string experience { get; set; }
        public string position { get; set; }
        // конструкторы класса
        public Master(){}
        public Master(string Surname, string Name, string Patronymic, string experience, string position)
        {
            this.secondName = Surname;
            this.firstName = Name;
            this.patronymic = Patronymic;
            this.experience = experience;
            this.position = position;
            this.id = DatabaseHelper.getMasterId();
            bool isUnique = false;
            while (!isUnique)
            {
                this.number = RandomHelper.getNumber();
                isUnique = DatabaseHelper.CheckUniqueNumberClient(this.number);
            }
        }
        public Master(int id, int number, string secondName, string firstName, string patronymic, string experience, string position)
        {
            this.id = id;
            this.number = number;
            this.secondName = secondName;
            this.firstName = firstName;
            this.patronymic = patronymic;
            this.experience = experience;
            this.position = position;
        }
        // функция получения полного имени мастера
        public string getFullName()
        {
            return this.secondName + " " + this.firstName + " " + patronymic;
        }
        // и его установки
        public void setFullName(string secondName, string firstName, string patronymic)
        {
            this.secondName = secondName;
            this.firstName = firstName;
            this.patronymic = patronymic;
        }
    }
}
