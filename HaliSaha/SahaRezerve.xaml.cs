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
    /// SahaRezerve.xaml etkileşim mantığı
    /// </summary>
    public partial class SahaRezerve : Window
    {
        HalıSahaEntities db = new HalıSahaEntities();
        public SahaRezerve()
        {
            InitializeComponent();
            

            var sahalar = db.SahaBilgis.ToList();

            foreach (var sh in sahalar)
            {
                cmbSaha.Items.Add(new { sh.sahaAdı });
            }
        }

        private void rezerve_Click(object sender, RoutedEventArgs e)
        {
            if (cmbSaat.SelectedItem == null || cmbSaha.SelectedItem == null || tarih == null)
            {
                MessageBox.Show("Tüm alanları eksiksiz giriniz.");
            }
            else
            {
                bool durum = true;
                string sahaid = cmbSaha.SelectedIndex.ToString();
                int sahaidC = Convert.ToInt32(sahaid);
                var  saat= ((ComboBoxItem)(cmbSaat.SelectedItem)).Content.ToString();
                var sorgu = from d in db.SahaRezerves where d.SahaId == (sahaidC + 1) select new { d.Tarih, d.Saat ,d.Durum};
                foreach (var x in sorgu)
                {
                   if(x.Tarih == tarih  && x.Saat == saat )
                   {
                      durum =false;
                        if(x.Durum == "Boş")
                            durum =true;
                   }
             
                }

                if (durum)
                {
                    SahaRezerve sb = new SahaRezerve();
                    sb.SahaId = sahaidC + 1;
                    sb.Tarih = tarih;
                    sb.Saat = saat;
                    sb.Nott = note.Text;
                    sb.Durum = "Dolu";
                    db.SahaRezerves.Add(sb);
                    db.SaveChanges();
                    MessageBox.Show("Rezerve Edildi");
                }
                else
                {
                    MessageBox.Show("Lütfen başka tarih veya saat seçiniz");
                }
              
            }
        }

        string tarih = "";
        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            var picker = sender as DatePicker;
            DateTime? date = picker.SelectedDate;
            tarih = date.Value.ToShortDateString();
        }

        private void Anasayfa_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Hide();
        }

        private void CmbSaha_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string sahaid = cmbSaha.SelectedIndex.ToString();
            int sahaidC = Convert.ToInt32(sahaid);       
            var fiyat = from d in db.SahaBilgis where d.id == (sahaidC + 1) select d.fiyat ;
            var konum = from d in db.SahaBilgis where d.id == (sahaidC + 1) select d.konum;
            var kapasite = from d in db.SahaBilgis where d.id == (sahaidC + 1) select d.kapasite;
            sahaFiyat.Text = fiyat.First();
            sahaKonum.Text = konum.First();
            sahaKapasite.Text = kapasite.First();   
        }
    }
}
