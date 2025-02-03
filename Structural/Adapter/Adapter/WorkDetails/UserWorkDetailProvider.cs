using DesignPatterns.Structural.Adapter.Adaptee;

namespace DesignPatterns.Structural.Adapter.Adapter.WorkDetails
{
    public class UserWorkDetailProvider : IUserDetailProviderAdapter<UserWorkDetail>
    {
        UserDetailProvider userDetailProvider;
        public UserWorkDetailProvider(UserDetailProvider userDetailProvider)
        {
            this.userDetailProvider = userDetailProvider;
        }

        public UserWorkDetail GetUserDetails(int userId)
        {
            User user = userDetailProvider.GetUserDetails(userId);
            UserWorkDetail userWorkDetails = new UserWorkDetail
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                WorkEmail = user.WorkEmail,
                Company = user.Company,
                OfficeAddress = user.OfficeAddress
            };
            return userWorkDetails;
        }
    }
}
