using System.Threading.Tasks;

namespace Task2;
using Task1;
public class GroupSt
{
    public int groupNum { get; set; }
    private List<Student> Students { get; set; }
    public GroupSt(int gn)
    {
        groupNum = gn;
        Students = new List<Student>();
    }

    public static void Add(GroupSt group, Student student)
    {
        if (student != null)
        {
            bool exists = false;
            foreach (var s in group.Students)
            {
                if (s.id == student.id)
                {
                    exists = true;
                    break;
                }
            }

            if (!exists)
            {
                group.Students.Add(student);
            }
        }
    }

    public static void Remove(GroupSt group, int studentID)
    {
        Student studentToRemove = null;
        foreach (var s in group.Students)
        {
            if (s.id == studentID)
            {
                studentToRemove = s;
                break;
            }
        }

        if (studentToRemove != null)
        {
            group.Students.Remove(studentToRemove);
        }
    }

    public static Student GetStudent(GroupSt group, int studentID)
    {
        foreach (var s in group.Students)
        {
            if (s.id == studentID)
            {
                return s;
            }
        }
        return null;
    }

    public static string GetInfo(GroupSt group)
    {
        List<Student> sortedStudents = new List<Student>(group.Students);
        sortedStudents.Sort((s1, s2) =>
        {
            int lastNameComparison = s1.lastName.CompareTo(s2.lastName);
            if (lastNameComparison == 0)
            {
                return s1.firstName.CompareTo(s2.firstName);
            }
            return lastNameComparison;
        });

        List<string> studentInfo = new List<string>();
        foreach (var s in sortedStudents)
        {
            studentInfo.Add(s.ToString());
        }

        return $"Номер группы: {group.groupNum}\n Студенты:\n{string.Join("\n", studentInfo)}";
    }
}