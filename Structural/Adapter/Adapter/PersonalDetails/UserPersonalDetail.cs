namespace DesignPatterns.Structural.Adapter.Adapter.PersonalDetails
{
    public class UserPersonalDetail
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public string? Email { get; set; }
        public string? BloodGroup { get; set; }
        public string? HomeAddress { get; set; }


        public override string ToString()
        {
            return $"User Personal Details:\n" +
                $"Name: {FirstName} {LastName} \n" +
                $"BirthDate {Birthdate.ToShortDateString()}\n" +
                $"Personal Email: {Email} \n" +
                $"BloodGroup: {BloodGroup} \n" +
                $"Home Address: {HomeAddress} \n";
        }
    }
}
