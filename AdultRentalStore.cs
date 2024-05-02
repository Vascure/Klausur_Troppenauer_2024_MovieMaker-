using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klausur_Troppenauer_2024_MovieMaker_
{
    internal class AdultRentalStore : RentalStore
    {
        public AdultRentalStore(List<Movie> movies) : base(movies)
        {
            Movie _m1 = new Movie("Easy A","Emma Stone", false);
            Movie _m2 = new Movie("Dungeons and Dragons: Honor among Thieves", "Wizards of the Coast", false);
            Movie _m3 = new Movie("Interstellar", "Christopher Nolan", false);
            Movie _m4 = new Movie("Inception", "Christopher Nolan", false);
            Movie _m5 = new Movie("Jaws", "Steven Spielberg", false);
            addMovie(_m1);  
            addMovie(_m2);  
            addMovie(_m3);  
            addMovie(_m4);  
            addMovie(_m5);  
    }
    }
}
