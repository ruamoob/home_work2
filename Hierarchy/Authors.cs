using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    public class Authors
    {
        String lastName;
        String firstname;
        String patronymic;
        int telefon;
        String adress;

        public Authors(string lastName, string firstname, string patronymic, int telefon, string adress)
        {
            this.lastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
            this.firstname = firstname ?? throw new ArgumentNullException(nameof(firstname));
            this.patronymic = patronymic ?? throw new ArgumentNullException(nameof(patronymic));
            this.telefon = telefon;
            this.adress = adress ?? throw new ArgumentNullException(nameof(adress));
        }
    }
}
