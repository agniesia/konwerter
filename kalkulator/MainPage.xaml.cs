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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace kalkulator
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
        

        private void liczba_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            dokonwersji.Text += b.Content.ToString();
            
        }

        private double konwertujnadouble(String text)
        {

            return Convert.ToDouble(text);
        }
        private String konwertujnaString(double liczba)
        {
            return Convert.ToString(liczba);
        }
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            
            
            dokonwersji.Text = "";


        }

        private void CE_Click(object sender, RoutedEventArgs e)
        {
            if (dokonwersji.Text.Length > 0)
            {
                dokonwersji.Text = dokonwersji.Text.Substring(0, dokonwersji.Text.Length - 1);
            }
        }

        private double convertfirststep(int index, double konwersowaliczba)
        {
            double zwrot = 0;
            switch (index)
            {
                case 0:
                    zwrot = konwersowaliczba /1000;
                    break;
                case 1:
                    zwrot = konwersowaliczba / 100;
                    break;
                    
                case 2:
                    zwrot = konwersowaliczba / 10;
                    break;
                case 3:
                    zwrot = konwersowaliczba;
                    break;
                case 4:
                    zwrot = konwersowaliczba *1000;
                    break;
                case 5:
                    zwrot = konwersowaliczba *0.0254;
                    break;

                case 6:
                    zwrot = konwersowaliczba * 0.3048;
                    break;
                case 7:
                    zwrot = konwersowaliczba*0.9144;
                    break;
                case 8:
                    zwrot = konwersowaliczba *1609.344;
                    break;


            }
            return zwrot;
        }
        private double convertsecondstep(int index, double konwersowaliczba)
        {
            double zwrot = 0;
            switch (index)
            {
                case 0:
                    zwrot = konwersowaliczba *1000;
                    break;
                case 1:
                    zwrot = konwersowaliczba * 100;
                    break;

                case 2:
                    zwrot = konwersowaliczba * 10;
                    break;
                case 3:
                    zwrot = konwersowaliczba;
                    break;
                case 4:
                    zwrot = konwersowaliczba / 1000;
                    break;
                case 5:
                    zwrot = konwersowaliczba /0.0254;
                    break;

                case 6:
                    zwrot = konwersowaliczba / 0.3048;
                    break;
                case 7:
                    zwrot = konwersowaliczba/0.9144;
                    break;
                case 8:
                    zwrot = konwersowaliczba / 1609.344;
                    break;


            }
            return zwrot;
        }
               
        
        private void konwertuj_Click(object sender, RoutedEventArgs e)
        {
            
            try

            {
                int index = jednostka.SelectedIndex;
                double wartosc = konwertujnadouble(dokonwersji.Text);
                var metr = convertsecondstep(jednostka_zmiana.SelectedIndex, convertfirststep(index, wartosc));
                pokonwersji.Text = konwertujnaString(metr);
            }
            catch (Exception t)
            {
                pokonwersji.Text = "ERROR!";
            }
            
            
        }
        

    }
}
