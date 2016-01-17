using System.Collections.Generic;

namespace cleancode.ui.Models
{
    public interface IWorldRepository
    {
        IEnumerable<Country> GetAllCountry();
    }
}