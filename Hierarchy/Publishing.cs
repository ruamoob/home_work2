using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
   public class Publishing
    {
        String name;
        String city;
        String paint;
        String publishing;
        String adress;

        public Publishing(string name, string city, string paint, string publishing, string adress)
        {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.city = city ?? throw new ArgumentNullException(nameof(city));
            this.paint = paint ?? throw new ArgumentNullException(nameof(paint));
            this.publishing = publishing ?? throw new ArgumentNullException(nameof(publishing));
            this.adress = adress ?? throw new ArgumentNullException(nameof(adress));
        }
    }
}
