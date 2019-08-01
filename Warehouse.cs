using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
  public class Warehouse
    {
        String nameWarehouse;
        String adress;
        String city;
        String area;
        int postCode;

        public Warehouse(string nameWarehouse, string adress, string city, string area, int postCode)
        {
            this.nameWarehouse = nameWarehouse ?? throw new ArgumentNullException(nameof(nameWarehouse));
            this.adress = adress ?? throw new ArgumentNullException(nameof(adress));
            this.city = city ?? throw new ArgumentNullException(nameof(city));
            this.area = area ?? throw new ArgumentNullException(nameof(area));
            this.postCode = postCode;
        }
    }
}
