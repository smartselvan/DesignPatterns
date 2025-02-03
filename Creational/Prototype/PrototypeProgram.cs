namespace DesignPatterns.Creational.Prototype
{
    public class PrototypeProgram
    {
        public static void Call()
        {
            Student student = new Student(1, "Student1", "ComputerScience");
            Console.WriteLine(student.ToString());

            Console.WriteLine("Cloning the student");
            Student clonedStudent = student.Clone();
            Console.WriteLine(clonedStudent.ToString());

        }
    }
}
