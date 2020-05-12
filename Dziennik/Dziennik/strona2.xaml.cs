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
    public partial class strona2 : ContentPage
    {
        FirebaseHelper dziennik = new FirebaseHelper();
        public strona2()
        {
            InitializeComponent();
        }
        async void Ucz(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new uczen());
        }
        async void naucz(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new nauczyciel());
        }
        async void dyr(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new dyrektor());
        }
    }
}