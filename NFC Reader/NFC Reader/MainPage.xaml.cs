using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NFC_Reader
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ReadButton_Clicked(object sender, EventArgs e)
        {

            DisplayAlert("Reading Tag", "The Tag is: ", "Close");
        }

        private void WriteButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}
