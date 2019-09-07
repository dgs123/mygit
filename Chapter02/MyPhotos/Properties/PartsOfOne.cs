using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotos.Properties
{
    // Days of week(values 0 to 6)
    enum DaysOfWeek1
    { Sun,Mon,Tue,Wed,Thu,Fri,Sat }

    // Days of week as unsigned short type (values 1 to 7)
    enum DaysOfWeeks { Sunday = 1,Monday,Tuesday,wednesday,Thursday,Friday,Saturday}

    // Multiples of 10 enumeration
    enum TensTable
    {
        Ten=10,Twenty=20,Thirty=30,Forty=40,Fifty=50,
        Sixty=60,Seventy=70,Eighty=80,Ninety=90
    }
    public class PartsOfOne
    {
        protected delegate int deleFindIndex(string name);
        public delegate void EventHandler(object sender, EventArgs e);
        
        private ulong _parts;
        PartsOfOne(ulong parts)
        {
            _parts = parts;
        }

        // Indexer to return nth part as a Fraction between 0 and 1
        
    }
}
