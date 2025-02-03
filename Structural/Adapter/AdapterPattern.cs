using DesignPatterns.Structural.Adapter.Adaptee;
using DesignPatterns.Structural.Adapter.Adapter;
using DesignPatterns.Structural.Adapter.Adapter.PersonalDetails;
using DesignPatterns.Structural.Adapter.Adapter.WorkDetails;

namespace DesignPatterns.Structural.Adapter
{
    public class AdapterPattern
    {
        public static void Call()
        {
            Console.WriteLine("From Adaptee");
            UserDetailProvider userDetailProvider = new UserDetailProvider();
            Console.WriteLine(userDetailProvider.GetUserDetails(1).ToString());

            Console.WriteLine("From Adapters");
            IUserDetailProviderAdapter<UserPersonalDetail> userPersonalDetailProviderAdapter = new UserPersonalDetailProvider(userDetailProvider);
            Console.WriteLine(userPersonalDetailProviderAdapter.GetUserDetails(1).ToString());

            IUserDetailProviderAdapter<UserWorkDetail> userWorkDetailProviderAdapter = new UserWorkDetailProvider(userDetailProvider);
            Console.WriteLine(userWorkDetailProviderAdapter.GetUserDetails(1).ToString());
        }
    }
}
