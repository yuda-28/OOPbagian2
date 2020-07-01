namespace Inheritance
{
    public class Program
    {

        static void Main(string[] args)
        {
            Person person = new Person("ahmad", 19);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("bayu", 50, "6946", "chemistry");
            teacher.GetNameAndAge();

            Student student = new Student("ayu", 20, "3301", "ayu97@gmail.com");
            student.GetNameAndAge();
        }
    }
}