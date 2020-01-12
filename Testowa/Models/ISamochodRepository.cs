
using System.Collections.Generic;


namespace Testowa.Models
{
    public interface ISamochodRepository
    {
        IEnumerable<Samochod> PobierzSamochody();

        Samochod PobierzSamochodPoId(int samochodId);

    }
}
