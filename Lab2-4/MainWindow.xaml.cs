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

namespace Lab2_4
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DollarResult.Text = (Convert.ToDouble(DollarRate.Text) * Convert.ToDouble(DollarCount.Text)).ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            EuroResult.Text = (Convert.ToDouble(EuroRate.Text) * Convert.ToDouble(EuroCount.Text)).ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            GrivnResult.Text = (Convert.ToDouble(GrivnRate.Text) * Convert.ToDouble(GrivnCount.Text)).ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

            ADramResult.Text = (Convert.ToDouble(ADramRate.Text) * Convert.ToDouble(ADramCount.Text)).ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            InchResult.Text = (Convert.ToDouble(InchCount.Text) * 0.0254).ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            FutResult.Text = (Convert.ToDouble(FutCount.Text) * 0.3048).ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            MiliResult.Text = (Convert.ToDouble(MiliCount.Text) * 1609.34).ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            VerstResult.Text = (Convert.ToDouble(VerstCount.Text) * 1066.8).ToString();
        }
    }
}
