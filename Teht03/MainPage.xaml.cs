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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Teht03
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            double value = double.Parse(leveys.Text);
            double value2 = double.Parse(korkeus.Text);
            double value3 = double.Parse(karminleveys.Text);

            double iala = (value * value2)/10;
            double piiri = ((value * 2) + (value2 * 2))/10;
            double lala = ((value - (value3 * 2)) * (value2 - (value3 * 2)))/10;

            ikkunanpintaala.Text = iala.ToString() + " cm^2";
            lasinpintala.Text = lala.ToString() + " cm^2";
            karminpiiri.Text = piiri.ToString() + " cm^2";
        }
    }
}
