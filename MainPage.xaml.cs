using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Arvestus_Eerik_Sidorov
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        int counter = 0;
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            String username = "admin";
            String password = "Passw0rd";
            String a = "Sisse logimine õnnestus";
            String b = "Vale";
            if (counter < 2)
            {
                if (userBox.Text == username && passwordBox.Password == password)
                {
                    resultBox.Text = a;
                    


                }
                else if (resultBox.Text == a)
                {
                    
                }
                else
                {
                    resultBox.Text = b;
                    counter++;
                }

            }
            else
            {
                resultBox.Text = "Sisselogimine ebaõnnestus. Rohkem katseid sisenemiseks ei ole";
                button1.IsEnabled = false;



              
            }
        }
    }
}
