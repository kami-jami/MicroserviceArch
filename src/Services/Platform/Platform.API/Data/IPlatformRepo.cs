namespace Platform.API.Data
{
    public interface IPlatformRepo
    {
        bool SaveChanges();

        IEnumerable<Models.Platform> GetAllPlatforms();
        Models.Platform GetPlatformById(int id);
        void CreatePlatform(Models.Platform platform);
    }
}
