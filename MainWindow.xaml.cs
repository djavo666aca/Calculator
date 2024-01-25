using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double temp = 0;

        string operation = "";

        string output = "";
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = this;
        }

        private void Broj7_Click(object sender, RoutedEventArgs e)
        {
            string name = ((Button)sender).Name;

            switch (name)
            {
                case "Broj1":

                    output += "1";
                    Ispis_na_ekranu.Text = output;
                    break;

                case "Broj2":

                    output += "2";
                    Ispis_na_ekranu.Text = output;
                    break;

                case "Broj3":

                    output += "3";
                    Ispis_na_ekranu.Text = output;
                    break;

                case "Broj4":

                    output += "4";
                    Ispis_na_ekranu.Text = output;
                    break;

                case "Broj5":

                    output += "5";
                    Ispis_na_ekranu.Text = output;
                    break;

                case "Broj6":

                    output += "6";
                    Ispis_na_ekranu.Text = output;
                    break;

                case "Broj7":

                    output += "7";
                    Ispis_na_ekranu.Text = output;
                    break;

                case "Broj8":

                    output += "8";
                    Ispis_na_ekranu.Text = output;
                    break;

                case "Broj9":

                    output += "9";
                    Ispis_na_ekranu.Text = output;
                    break;

                case "Broj0":

                    output += "0";
                    Ispis_na_ekranu.Text = output;
                    break;
            }




        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = double.Parse(output);

                output = "";
                operation = "minus";
            }
        }

        private void jednako_Click(object sender, RoutedEventArgs e)
        {
            double outputTemp;

            switch (operation)
            {
                case "minus":

                    outputTemp = temp - double.Parse(output);
                    output = outputTemp.ToString();
                    Ispis_na_ekranu.Text = output;
                    break;

                case "plus":

                    outputTemp = temp + double.Parse(output);
                    output = outputTemp.ToString();
                    Ispis_na_ekranu.Text = output;
                    break;

                case "mnozenje":

                    outputTemp = temp * double.Parse(output);
                    output = outputTemp.ToString();
                    Ispis_na_ekranu.Text = output;
                    break;

                case "deljenje":
                    if (double.Parse(output) != 0)
                    {
                        outputTemp = temp / double.Parse(output);
                        output = outputTemp.ToString();
                        Ispis_na_ekranu.Text = output;
                    }
                        break;
                    
            }
        }

        private void deljenje_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = double.Parse(output);

                output = "";
                operation = "deljenje";
            }
        }

        private void mnozenje_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = double.Parse(output);

                output = "";
                operation = "mnozenje";
            }
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = double.Parse(output);

                output = "";
                operation = "plus";
            }
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            output = "";
            Ispis_na_ekranu.Text = output;
        }

        private void naKvadrat_Click(object sender, RoutedEventArgs e)
        {
            double naKvadrat = double.Parse(output);
            output = (naKvadrat * naKvadrat).ToString();
            Ispis_na_ekranu.Text = output;
        }
    }
}
