using Lesson5.Models;

namespace Lesson5.Services
{
    public interface ICountryService
    {
        public Guid AddCountry(string name);
        public bool UpdateCountry(Guid id);
        public bool DeleteCountry(Guid id);
        public Country? GetCountryById(Guid countryId);
        public List<Country> GetAllCountries();

    }
}
