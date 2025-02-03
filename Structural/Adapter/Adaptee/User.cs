namespace DesignPatterns.Structural.Adapter.Adaptee
{
    public class User
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public string? Email { get; set; }
        public string? WorkEmail { get; set; }
        public string? BloodGroup { get; set; }
        public string? Company { get; set; }
        public string? OfficeAddress { get; set; }
        public string? HomeAddress { get; set; }


        public override string ToString()
        {
            return $"User Complete Details:\n" +
                $"Name: {FirstName} {LastName} \n" +
                $"BirthDate {Birthdate.ToShortDateString() }\n" +
                $"Personal Email: {Email} \n" +
                $"Work Email: {WorkEmail} \n" +
                $"BloodGroup: {BloodGroup} \n" +
                $"Company: {Company} \n" +
                $"Home Address: {HomeAddress} \n" +
                $"Office Address: {OfficeAddress} \n";
        }

    }

}
