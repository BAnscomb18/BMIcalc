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

namespace BMIcalulator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public MainPage()
        {
            this.InitializeComponent();
            string height = textBlock1.Text;
            string weight = textBlock2.Text;
            double w = Convert.ToDouble(weight);
            double h = Convert.ToDouble(height);
            
        }

        private void textBlock1_SelectionChanged(System.Object sender, RoutedEventArgs e) 
        {

        }

        private void textBlock2_SelectionChanged(System.Object sender, RoutedEventArgs e)
        {

        }

        private void textBox1_TextChanged(System.Object sender, TextChangedEventArgs e)
        {

        }

        private void textBox2_TextChanged(System.Object sender, TextChangedEventArgs e)
        {

        }

        private void textBox2_TextChanged_1(System.Object sender, TextChangedEventArgs e)
        {

        }
    }
}
