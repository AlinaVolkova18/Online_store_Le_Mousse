using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Mobile_Store
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        
        private async void Button1_Click(object sender, EventArgs e)
        {
            Profile p = new Profile();
            await Navigation.PushAsync(p);
        }
    }
}
