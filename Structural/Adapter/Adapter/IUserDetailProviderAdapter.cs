namespace DesignPatterns.Structural.Adapter.Adapter
{
    public interface IUserDetailProviderAdapter<T>
    {
        T GetUserDetails(int userId);
    }
}
