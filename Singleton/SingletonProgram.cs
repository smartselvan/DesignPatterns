namespace Singleton
{
    public class SingletonProgram
    {
        public static void Call()
        {
            Parallel.Invoke(
                MessageFromTeacher,
                MessageFromStudent
            );
        }

        private static void MessageFromTeacher()
        {
            Singleton teacherInstance = Singleton.Instance;
            teacherInstance.LogMessage("Message from Teacher");
        }
        private static void MessageFromStudent()
        {
            Singleton studentInstance = Singleton.Instance;
            studentInstance.LogMessage("Message from Student");
        }
    }
}