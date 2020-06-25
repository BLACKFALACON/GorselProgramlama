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
    /// SahaOdeme.xaml etkileşim mantığı
    /// </summary>
    public partial class SahaOdeme : Window
    {
        HalıSahaEntities db = new HalıSahaEntities();
        public SahaOdeme()
        {
            InitializeComponent();
            dgsaha.ItemsSource = db.SahaRezerves.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Hide();
        }

        private void Button_Click_Ode(object sender, RoutedEventArgs e)
        {
            int saharezid= Convert.ToInt32(txtsaharezid.Text);
            int sahaid = Convert.ToInt32(txtsahaid.Text);
            var fiyat = from d in db.SahaBilgis where d.id == sahaid  select d.fiyat;
            SahaOdeme sd = new SahaOdeme();
            sd.SahaId = sahaid;
            sd.SahaOdeme1 = Convert.ToInt32(fiyat.First());
            db.SahaOdemes.Add(sd);
            db.SaveChanges();
            var guncelle = db.SahaRezerves.Where(w => w.Id == saharezid).FirstOrDefault();
            guncelle.Durum = "Boş";
            db.SaveChanges();
            dgsaha.ItemsSource = db.SahaRezerves.ToList();
            MessageBox.Show("Halı Saha Boş Duruma Getirildi");

        }
    }
}
