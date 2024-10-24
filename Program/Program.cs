using Task1;
using Task2;
namespace Program
{
    public class Program
    {
        public static void Main()
        {
            Student student1 = new Student(1, "Иванов", "Иван", "Иванович", "18.01.2002", "Москва, ул. Пушкина, д. 1", "1234567890");
            Student student2 = new Student(2, "Петров", "Петр", "Петрович", "18.01.2001", "Санкт - Петербург, ул. Ленина, д. 2", "0987654321");
            Student student3 = new Student(3, "Сидоров", "Сидор", "Сидорович", "18.11.2002", "Казань, ул. Горького, д. 3", "1122334455");

            GroupSt group = new GroupSt(101);

            GroupSt.Add(group, student1);
            GroupSt.Add(group, student2);
            GroupSt.Add(group, student3);

            Console.WriteLine("Информация о группе после добавления студентов:");
            Console.WriteLine(GroupSt.GetInfo(group));

            GroupSt.Remove(group, 2);

            Console.WriteLine("\nИнформация о группе после удаления студента Петров Петр:");
            Console.WriteLine(GroupSt.GetInfo(group));

            Student foundStudent = GroupSt.GetStudent(group, 1);
            if (foundStudent != null)
            {
                Console.Write("\nНайден студент:");
                Console.WriteLine(foundStudent.ToString());
            }
            else
            {
                Console.WriteLine("\nСтудент с таким ID не найден.");
            }
        }
    }
}