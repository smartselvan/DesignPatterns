namespace DesignPatterns.Creational.Prototype
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Course { get; set; }
        public Student(int id, string name, string course)
        {
            Id = id;
            Name = name;
            Course = course;
        }

        public Student Clone()
        {
            return new Student(Id, Name, Course);
        }

        public override string ToString()
        {
            return $"Student Name: {Name} \nCourse: {Course} \n";
        }
    }
}
