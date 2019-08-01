using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
   public class Sales_department
    {
     public enum Payments : byte { urgent, medium, low };

        DateTime dateSale;
        int countBook;
        float summSale;
        String paymentType;
        Payments PaymentsType;

        public Sales_department(DateTime dateSale, int countBook, float summSale, string paymentType)
        {
            this.dateSale = dateSale;
            this.countBook = countBook;
            this.summSale = summSale;
            this.paymentType = paymentType ?? throw new ArgumentNullException(nameof(paymentType));
        }

      
    }
}
