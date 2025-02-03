namespace DesignPatterns.Structural.Adapter.Adapter.WorkDetails
{
    public class UserWorkDetail
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? WorkEmail { get; set; }
        public string? Company { get; set; }
        public string? OfficeAddress { get; set; }

        public override string ToString()
        {
            return $"User Work Details:\n" +
                $"Name: {FirstName} {LastName} \n" +
                $"Work Email: {WorkEmail} \n" +
                $"Company: {Company} \n" +
                $"Office Address: {OfficeAddress} \n";
        }
    }
}
