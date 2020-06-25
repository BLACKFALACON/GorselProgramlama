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

namespace HaliSaha
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Ekle_Click(object sender, RoutedEventArgs e)
        {
            SahaEkle she = new SahaEkle();
            she.Show();
            this.Hide();
        }

        private void Rezerve_Click(object sender, RoutedEventArgs e)
        {
            SahaRezerve shr = new SahaRezerve();
            shr.Show();
            this.Hide();
        }

        private void Odeme_Click(object sender, RoutedEventArgs e)
        {
            SahaOdeme sho = new SahaOdeme();
            sho.Show();
            this.Hide();
        }
    }
}
