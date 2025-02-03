using DesignPatterns.Structural.Adapter.Adaptee;

namespace DesignPatterns.Structural.Adapter.Adapter.PersonalDetails
{
    public class UserPersonalDetailProvider : IUserDetailProviderAdapter<UserPersonalDetail>
    {
        UserDetailProvider userDetailProvider;
        public UserPersonalDetailProvider(UserDetailProvider userDetailProvider)
        {
            this.userDetailProvider = userDetailProvider;
        }

        public UserPersonalDetail GetUserDetails(int userId)
        {
            User user = userDetailProvider.GetUserDetails(userId);
            UserPersonalDetail userPersonalDetails = new UserPersonalDetail
            {
                Birthdate = user.Birthdate,
                BloodGroup = user.BloodGroup,
                Email = user.Email,
                FirstName = user.FirstName,
                HomeAddress = user.HomeAddress,
                LastName = user.LastName
            };
            return userPersonalDetails;
        }
    }
}
