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
    public partial class Strona1 : ContentPage
    {
        FirebaseHelper dziennik = new FirebaseHelper();
        public Strona1()
        {
            InitializeComponent();

        }

        async void Reje(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new strona2());
        }

        async void logo(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new strona3());
        }



    }
}