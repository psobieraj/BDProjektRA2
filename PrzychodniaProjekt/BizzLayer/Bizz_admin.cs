using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BizzLayer
{
    public class Bizz_admin
    {
        public static IQueryable<User> FilterUser(string pattern)
        {
            DataClassesClinicDataContext dc = new DataClassesClinicDataContext();
            var user = (from u in dc.Users
                        where u.login.Contains(pattern)
                        select u);
            return user;
        }

        public static void AddUser(string haslo, string rola, string login, System.DateTime data_wyg)
        {
            DataClassesClinicDataContext dc = new DataClassesClinicDataContext();
            User user = new User();
            user.login = login;
            user.haslo = Bizz_MD5hash.GetHash(haslo);
            user.Rola = rola;
            user.dat_wyg = data_wyg;

            dc.Users.InsertOnSubmit(user);
            dc.SubmitChanges();

        }
    }
}
