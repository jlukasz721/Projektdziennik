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
    public partial class strona3 : ContentPage
    {
        FirebaseHelper dziennik = new FirebaseHelper();
        public strona3()
        {
            InitializeComponent();
        }

    }
}