using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        int count;
        string mensage;
        Button button1;
        Random rndm = new Random(); 
        public MainPage()
        {
            InitializeComponent();
            count = 0;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if(button1 == null)
            {
                button1 = ((Button)sender);
            }
            count++;
            mensage = "Numero de veces clikeado: {0}";
            button1.Text = string.Format(mensage,count);
            button1.BackgroundColor = Color.FromRgb(rndm.Next(256), rndm.Next(256), rndm.Next(256));
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            mensage = "Click";
            count = 0;
            if (button1 != null)
            {
                button1.Text = mensage;
            }
        }
    }
}
