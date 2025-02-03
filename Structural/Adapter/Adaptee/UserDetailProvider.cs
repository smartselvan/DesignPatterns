namespace DesignPatterns.Structural.Adapter.Adaptee
{
    public class UserDetailProvider
    {
        public User GetUserDetails(int id)
        {
            User user = new User { 
                Id = 1,
                FirstName = "Selvakumar",
                LastName = "G",
                Birthdate = DateTime.Parse("01/01/1990"),
                BloodGroup = "O+",
                Company = "Alphabet",
                Email ="email@gmail.com",
                WorkEmail = "email@google.com",
                HomeAddress = "Coimbatore",
                OfficeAddress = "Bangalore"
            };
            return user;
        }
    }

}
