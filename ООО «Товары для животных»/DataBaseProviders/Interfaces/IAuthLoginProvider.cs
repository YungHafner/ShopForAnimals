namespace ООО__Товары_для_животных_.DataBaseProviders.Interfaces
{
    public interface IAuthLoginProvider
    {
        void DbGetAuthWithLoginPassword(string login, string pass);
    }
}