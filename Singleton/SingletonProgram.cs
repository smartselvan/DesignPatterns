using DesignPatterns.Singleton;

namespace Singleton
{
    public class SingletonProgram
    {
        public static void Call()
        {
            Parallel.Invoke(
                MessageFromTeacher,
                MessageFromStudent,
                MessageFromStudent1
            );
        }

        private static void MessageFromTeacher()
        {
            Logger teacherInstance = Logger.Instance;
            teacherInstance.LogMessage("Message from Teacher");
        }

        private static void MessageFromStudent()
        {
            Logger studentInstance = Logger.Instance;
            studentInstance.LogMessage("Message from Student");
        }

        private static void MessageFromStudent1()
        {
            Logger studentInstance = Logger.Instance;
            studentInstance.LogMessage("Message from Student1");
        }
    }
}