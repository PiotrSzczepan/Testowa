
namespace Testowa.Models
{
    public class Samochod
    {
        public int id { get; set; }
        public string marka { get; set; }
        public string model { get; set; }
        public int rokProdukcji { get; set; }
        public string przebieg { get; set; }
        public string pojemnosc { get; set; }
        public string rodzajPaliwa { get; set; }
        public string moc { get; set; }
        public string opis { get; set; }
        public decimal cena { get; set; }
        public string zdjecieUrl { get; set; }
        public string miniaturkaUrl { get; set; }
        public bool jestSochodemTygodnia { get; set; }
    }
}
