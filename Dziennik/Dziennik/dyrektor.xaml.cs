using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Dziennik
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class dyrektor : ContentPage
    {
        FirebaseHelper dziennik = new FirebaseHelper();
        public dyrektor()
        {
            InitializeComponent();
        }
        async void rejestracja(object sender, EventArgs e)
        {

            var b = new pobieranie { Email = Email.Text, Hasło = Hasło.Text };


            var c = gdypopr(b);
            if (c)
            {
                await dziennik.Adddyrektor2(b.Email, b.Imie, b.Nazwisko, b.Hasło, "dyrektor");
            }
            else
            {
                autoryzac.Text = "BŁĄD REJESTRACJI";
            }


        }



        bool gdypopr(pobieranie b)
        {
            return !string.IsNullOrWhiteSpace(b.Email) && !string.IsNullOrWhiteSpace(b.Hasło);
        }


    }
}
