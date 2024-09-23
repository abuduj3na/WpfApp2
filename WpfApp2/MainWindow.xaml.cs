﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        double straal;
        double omtrek;
        double oppervlakte;

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            straalTextbox.Text = "Straal";
            omtrekTextbox.Text = "Omtrek";
            oppervlakteTextbox.Text = "Oppervlakte";

        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            straal = Convert.ToInt32(straalTextbox.Text);
            omtrek = Math.Round(2 * straal * Math.PI,2);
            omtrekTextbox.Text = $"{omtrek}";

            oppervlakte = Math.Round(Math.PI * Math.Pow(straal, 2), 2);
            oppervlakteTextbox.Text = $"{oppervlakte}";
        }
    }
}

