﻿using System;
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

namespace Teht02
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

        private void markoiksi_Click(object sender, RoutedEventArgs e)
        {
            double value = double.Parse(eurot.Text);
            value = value * 5.94573;
            markat.Text = value.ToString("0.00");
            
        }

        private void euroiksi_Click(object sender, RoutedEventArgs e)
        {
            double value = double.Parse(markat2.Text);
            value = value / 5.94573;
            eurot2.Text = value.ToString("0.00");
        }
    }
}
