using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klausur_Troppenauer_2024_MovieMaker_
{
    internal class KidsRentalStore : RentalStore
    {
        public KidsRentalStore(List<Movie> movies) : base(movies)
        {
            Movie _m1 = new Movie("My little Pony- Friendship is Magic", "Cheese cake", false);
            Movie _m2 = new Movie("How to Tame your Dragons", "Some Director", false);
            Movie _m3 = new Movie("Ice Age", "Mammut Manny", false);
            Movie _m4 = new Movie("Kung Fu Panda", "Jack Black", false);
            Movie _m5 = new Movie("Cats vs Dogs", "Animal friend", false);
            addMovie(_m1);
            addMovie(_m2);
            addMovie(_m3);
            addMovie(_m4);
            addMovie(_m5);
        }
    }
}
