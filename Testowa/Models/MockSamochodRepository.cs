using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Testowa.Models
{
    public class MockSamochodRepository : ISamochodRepository
    {
        private List<Samochod> samochody;

        public MockSamochodRepository()
        {
            if(samochody == null)
            {
                ZaladujSamochody();
            }
        }

        private void ZaladujSamochody()
        {
            samochody = new List<Samochod>
            {
                new Samochod{ id=1, marka="ford", model="mustang", rokProdukcji = 1980, przebieg="400 000", pojemnosc ="2.0", rodzajPaliwa="benzyna", moc="150kw", opis="mustang jest the best", cena = 40000, jestSochodemTygodnia=true, miniaturkaUrl="", zdjecieUrl=""}
                new Samochod{ id=2, marka="opel", model="astra", rokProdukcji = 2020, przebieg="0", pojemnosc ="1.5", rodzajPaliwa="benzyna", moc="110kw", opis="mustang jest the best", cena = 60000, jestSochodemTygodnia=false, miniaturkaUrl="", zdjecieUrl=""}
            };
        }

        public Samochod PobierzSamochodPoId(int samochodId)
        {
            return samochody.FirstOrDefault(s => s.id == samochodId);
        }

        public IEnumerable<Samochod> PobierzSamochody()
        {
            throw new NotImplementedException();
        }
    }
}
