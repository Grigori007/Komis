using Komis.Models;
using System.Collections.Generic;

//klasa ta bedzie gromadzic w sobie wszystkie dane, ktore bedzie wyswietlac widok
namespace Komis.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; }
        public List<Car> CarList { get; set; }
    }
}
