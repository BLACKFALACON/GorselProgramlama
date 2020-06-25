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
using System.Windows.Shapes;

namespace HaliSaha
{
    /// <summary>
    /// SahaEkle.xaml etkileşim mantığı
    /// </summary>
    public partial class SahaEkle : Window
    {
        HalıSahaEntities db = new HalıSahaEntities();
        public SahaEkle()
        {
            InitializeComponent();
            dgsaha.ItemsSource = db.SahaBilgis.ToList();
        }

        private void Button_Ekle(object sender, RoutedEventArgs e)
        {
            SahaBilgi sh = new SahaBilgi();
            sh.sahaAdı = txtsahaad.Text;
            sh.fiyat = txtsahafiyat.Text;
            sh.kapasite = txtsahakapasite.Text;
            sh.konum = txtsahakonum.Text;
            db.SahaBilgis.Add(sh);
            db.SaveChanges();
            dgsaha.ItemsSource = db.SahaBilgis.ToList();
        }

        private void Button_Sil(object sender, RoutedEventArgs e)
        {
            int silinecek = Convert.ToInt32(txtsahaid.Text);
            var silineceksaha = db.SahaBilgis.Where(w => w.id == silinecek).FirstOrDefault();
            db.SahaBilgis.Remove(silineceksaha);
            db.SaveChanges();
            dgsaha.ItemsSource = db.SahaBilgis.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Hide();
        }

        private void dgsaha_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
