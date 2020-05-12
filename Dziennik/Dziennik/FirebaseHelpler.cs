using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziennik

{
    public partial class FirebaseHelper
    {
        FirebaseClient firebase = new FirebaseClient("https://dziennik-d7a08.firebaseio.com/");

        public async Task<List<pobieranie>> GetPlace()
        {
            return (await firebase
              .Child("Dziennik")
              .OnceAsync<pobieranie>()).Select(item => new pobieranie
              {
                  Imie = item.Object.Imie,
                  Nazwisko = item.Object.Nazwisko,
                  Hasło = item.Object.Hasło,
                  Klasa = item.Object.Klasa,
                  Szkoła = item.Object.Szkoła,
                  Numertelefonu = item.Object.Numertelefonu,
                  Email = item.Object.Email,
                  Typ = item.Object.Typ
              }).ToList();
        }

        public async Task Adduczen(string imie, string nazwisko, string hasło, string email, string typ)
        {

            await firebase
              .Child("Dziennik")
              .PostAsync(new pobieranie()
              {
                  Imie = imie,
                  Nazwisko = nazwisko,
                  Hasło = hasło,
                  Email = email,
                  Typ = typ
              });
        }


        public async Task Adduczen2(string email, string imie, string nazwisko, string hasło, string typ)
        {

            await firebase
              .Child("Dziennik")
              .PostAsync(new pobieranie()
              {
                  Email = email,
                  Imie = imie,
                  Nazwisko = nazwisko,
                  Hasło = hasło,
                  Typ = typ
              });
        }


        public async Task Addnauczyciel(string imie, string nazwisko, string hasło, string klasa, string szkoła, double numertelefonu, string email, string typ)
        {

            await firebase
              .Child("Dziennik")
              .PostAsync(new pobieranie()
              {
                  Imie = imie,
                  Nazwisko = nazwisko,
                  Hasło = hasło,
                  Klasa = klasa,
                  Szkoła = szkoła,
                  Numertelefonu = numertelefonu,
                  Email = email,
                  Typ = typ
              });
        }

        public async Task Addnauczyciel2(string email, string imie, string nazwisko, string hasło, string typ)
        {

            await firebase
             .Child("Dziennik")
             .PostAsync(new pobieranie()
             {
                 Email = email,
                 Imie = imie,
                 Nazwisko = nazwisko,
                 Hasło = hasło,
                 Typ = typ
             });
        }


        public async Task Adddyrektor(string imie, string nazwisko, string hasło, string klasa, string szkoła, double numertelefonu, string email, string typ)
        {

            await firebase
              .Child("Dziennik")
              .PostAsync(new pobieranie()
              {
                  Imie = imie,
                  Nazwisko = nazwisko,
                  Hasło = hasło,
                  Klasa = klasa,
                  Szkoła = szkoła,
                  Numertelefonu = numertelefonu,
                  Email = email,
                  Typ = typ
              });
        }

        public async Task Adddyrektor2(string email, string imie, string nazwisko, string hasło, string typ)
        {

            await firebase
              .Child("Dziennik")
              .PostAsync(new pobieranie()
              {
                  Email = email,
                  Imie = imie,
                  Nazwisko = nazwisko,
                  Hasło = hasło,
                  Typ = typ
              });
        }


        public async Task DeleteDziennik()
        {
            await firebase
                .Child("Dziennik")
                .DeleteAsync();
        }
    }
}
