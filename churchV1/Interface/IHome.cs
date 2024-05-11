using churchV1.Models;

namespace churchV1.Interface
{
    public interface IHome
    {
        Task<IEnumerable<NavbarModel>> GetAllNevbar();
        Task<IEnumerable<ContentModel>> GetContents();
        Task<IEnumerable<EventModel>> GetEvents();
        Task<bool> postPrayerRequest(PrayerModel prayer);
    }
}
