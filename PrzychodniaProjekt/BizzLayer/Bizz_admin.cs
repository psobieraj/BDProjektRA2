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

        public static void AddUser(string haslo, string rola, string login)
        {
            DataClassesClinicDataContext dc = new DataClassesClinicDataContext();
            User user = new User();
            user.login = login;
            user.haslo = Bizz_MD5hash.GetHash(haslo);
            user.Rola = rola;
            

            dc.Users.InsertOnSubmit(user);
            dc.SubmitChanges();

        }

        public static void UpdateUser(int id, string haslo, string rola, string login, System.DateTime data_wyg, bool dateExpired)
        {
            DataClassesClinicDataContext dc = new DataClassesClinicDataContext();

            //var user = (from u in dc.Users
            //            where u.login == login
            //            select u);

            //foreach (users u in user)
            //{
            //    user.login = login;
            //    user.haslo = Bizz_MD5hash.GetHash(haslo);
            //    user.Rola = rola;
            //    user.dat_wyg = data_wyg;
            //}

            User user = (from u in dc.Users
                            where u.Id_user == id
                            select u).Single();
            user.login = login;
            if (haslo != string.Empty)
            {
                user.haslo = Bizz_MD5hash.GetHash(haslo);
            }
            user.Rola = rola;
            if (dateExpired == true)
            {
                user.dat_wyg = data_wyg;
            }

            dc.SubmitChanges();


            dc.SubmitChanges();

        }
    }
}
