namespace DesignPatterns.Creational.Builder.Product
{
    public class Car
    {
        public bool IsAutomationAdded { get; set; } = false;

        public bool IsAudioSystemAdded { get; set; } = false;
        public bool IsCameraSystemAdded { get; set; } = false;

        public bool IsEngineAdded { get; set; } = false;
        public bool IsBodyAdded { get; set; } = false;
        public bool IsSteeringAdded { get; set; } = false;
        public Car() { }

        public override string ToString()
        {
            return $"Car Details: \n Added Body: {IsBodyAdded}; " +
                $"\n Added Engine: {IsEngineAdded}; " +
                $"\n Added Steering: {IsSteeringAdded}; " +
                $"\n Added AudioSystem: {IsAudioSystemAdded}; " +
                $"\n Added CameraSystem: {IsCameraSystemAdded}; " +
                $"\n Added Automation: {IsAutomationAdded}; ";
        }
    }
}
