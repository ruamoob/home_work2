using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
  public enum Type : byte { prose, poetry, story };
  public enum Genre : byte { history, fiction, novel, detectives };

    public class Edition
    {
        String name;
        String book;
        float price;
        int year;
        String publishing;
        String adress;
        Type podType;
        Genre genreType;

        public Edition(string name, string book, float price, int year, string publishing, string adress)
        {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.book = book ?? throw new ArgumentNullException(nameof(book));
            this.price = price;
            this.year = year;
            this.publishing = publishing ?? throw new ArgumentNullException(nameof(publishing));
            this.adress = adress ?? throw new ArgumentNullException(nameof(adress));
        }
    }
}
