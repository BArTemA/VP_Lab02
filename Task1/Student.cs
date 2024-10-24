namespace Task1
{
    public class Student
    {
        public int id { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string patronymic { get; set; }
        public string dateOfBirth { get; set; }
        public string adres { get; set; }
        public string phoneNumber { get; set; }

        public Student(int id, String lastName, String firstName, String patronymic, String dateOfBirth, String adres, String phoneNumber)
        {
            this.id = id;
            this.lastName = lastName;
            this.firstName = firstName;
            this.patronymic = patronymic;
            this.dateOfBirth = dateOfBirth;
            this.adres = adres;
            this.phoneNumber = phoneNumber;
        }

        public override bool Equals(object obj) //если не использовать obj, то для перегрузки метода equals не виден
        {
            if (obj == null || !(obj is Student)) //проверка на нулл и что объект точно класса студент. Я хз как по-другому
            {
                return false;
            }
            Student other = (Student)obj;
            return this.id == other.id &&
               this.lastName == other.lastName &&
               this.firstName == other.firstName &&
               this.patronymic == other.patronymic &&
               this.dateOfBirth == other.dateOfBirth &&
               this.adres == other.adres &&
               this.phoneNumber == other.phoneNumber;
        }
        public static Boolean operator ==(Student st1, Student st2)
        {
            return st1.Equals(st2);
        }

        public static Boolean operator !=(Student st1, Student st2)
        {
            return !st1.Equals(st2);
        }
        public override string ToString()
        {
            return $"ID:  {id}, Фамилия:  {lastName}, Имя: {firstName}, Отчество: {patronymic}, \n" +
                $"Дата рождения: {dateOfBirth}, Адрес: {adres}, Телефон: {phoneNumber}";
        }
    }
}

