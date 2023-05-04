using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PıızaOtosn
{
    public class Form1 : Pizza
    {
        private object cmdEbat;
        private object listPizzalar;
        private object rdbInceKenar;
        private object groupBox1;
        private object nudAdet;

        public int Carpan { get; private set; }

        public Form1()
        {
            InitializeComponent();      // formları oluşturduğumuzda Form Tasarımcısı tarafından otomatik olarak yazılan bir yöntemdir.
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

          Ebat kucuk = new Ebat(Adi = "Kucuk", Carpan = 1);

            Ebat orta = new Ebat(Adi = "Orta", Carpan = 1.25);

            Ebat buyuk = new Ebat(Adi = "Büyük", Carpan = 1.75);

            Ebat max = new Ebat(Adi = "Max", Carpan = 2);

            object value = cmdEbat.Items.Add(kucuk);
            cmdEbat.Items.Add(orta);
            cmdEbat.Items.Add(buyuk);
            cmdEbat.Items.Add(max);

            
            Pizza klasik = new Pizza { Adi = "Klasik", Fiyat = 14 };


            Pizza karisik = new Pizza { Adi = "Karışık", Fiyat = 17 };


            Pizza tekli  = new Pizza { Adi = "Tekli", Fiyat = 20 };

            Pizza tuna = new Pizza { Adi = "Tuna", Fiyat=25 };

            Pizza akdeniz = new Pizza { Adi = "Akdeniz", Fiyat = 18 };

            Pizza karadeniz = new Pizza { Adi = "Karadeniz", Fiyat = 22 };

            listPizzalar.Items.Add(klasik);
            listPizzalar.Items.Add(karisik);
            listPizzalar.Items.Add(tekli);
            listPizzalar.Items.Add(tuna);
            listPizzalar.Items.Add(akdeniz);
            listPizzalar.Items.Add(karadeniz);


            KenarTip ince = new KenarTip { Adi = "İnce Kenar", EkFİyat = 0 };

            rdbInceKenar.Tag = ince;

            KenarTip kalin = new KenarTip { Adi = "Kalın Kenar", EkFİyat = 2 };

            rdbInceKenar.Tag = kalin;
        }

        Siparis s;
        private object listSepet;
        private object lblToplamTutar;

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            Pizza p = (Pizza)listPizzalar.SelectedItem;

            p.Ebati =(Ebat) cmdEbat.SelectedItem;

            p.KenarTip = rdbInceKenar.Checked ? (KenarTip)

                rdbInceKenar.Tag : (KenarTip)rdbInceKenar.Tag;

            p.Malzemeler = new List<string>();


            foreach (Control item in groupBox1.Controls)
            {
                checkBox c = (checkBox)ctrl;
                if (ctrl.Checked)
                {
                    p.Malzemeler.Add(ctrl.Text);
                }
            }
            decimal tutar = nudAdet.Value*p.Tutar;
            txtTutar.Text = tutar.ToString();

            s = new Siparis();
            s.Pizza= p;
            s.Adet = (int)nudAdet.Value;
        }
        
        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            if (s != null)
            {
                listSepet.Items.Add(s);
            }

        }

        private void btnSiparisOnay_Click(object sender, EventArgs e)
        {
            decimal toplamTutar = 0;
            int adet = 0;
            foreach (Siparis spr in listSepet.Items)
            {
                toplamTutar += spr.Adet * spr.Pizza.Tutar;
                adet++;
            }
            lblToplamTutar.Text = toplamTutar.ToString();

            Console.WriteLine("Toplam sipariş adedi : {0} {1} Toplam sipariş tutarı {2}", adet, Environment.NewLine, toplamTutar);
        }

    }

   
}
