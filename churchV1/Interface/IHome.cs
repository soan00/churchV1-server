using churchV1.Models;

namespace churchV1.Interface
{
    public interface IHome
    {
        Task<IEnumerable<NavbarModel>> GetAllNevbar();
        Task<Dictionary<string, object>> GetContents(int pageNumber, int pageSize);
        Task<IEnumerable<EventModel>> GetEvents();
        Task<bool> postPrayerRequest(PrayerModel prayer);
    }
}
