using System.Net.Security;
using WFADelegate_0.Models;

namespace WFADelegate_0
{
    public partial class Form1 : Form
    {
        //Delegate : Delegate birden fazla metodu veya bir metodu kapsülleyen ve tetiklemenizi saglayan bir yapýdýr...  

        //Action
        //Predicate
        //Func  --Þuana kadar görüdüðümüz..

        delegate void TestDelegate();
        delegate int DenemneDelegate(int number);
        delegate void AkademikGorev();
        delegate void ProjeGorevi();

        public Form1()
        {
            InitializeComponent();
        }

        public void MufredatHazirla()
        {

        }
        public void DersAnlat()
        {

        }
        public void EtutYap()
        {

        }
        public void ProjeYaz()
        {

        }
        public void KurumsalEgitim()
        {

        }
        public void MerkeziDestekVer()
        {

        }
        public void Selamla()
        {
            MessageBox.Show("Heelo World");
        }
        public void Sor()
        {
            MessageBox.Show("Nasilsin??");
        }

        public int KareAl(int number)
        {
            return number * number;
        }
        public int YarisiniAl(int number)
        {
            return number / 2;
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            #region DelegateNotlarý
            TestDelegate testDelegate = new(Selamla); //Burada dikkat edeceðiniz kýsým, Selamla isimli metodu caðýrmýyoruz..Fark ettiyseniz o yüzden parntezlerini vermiyoruz..Metodu bir yapý olarak Delgate'e veriyoruz..(ona eklemiþ oluyoruz)
            testDelegate += Sor; //Eðer oluþturulan bir Delegate'e baska bir metot daha eklemek isterseniz '+=' operatötürünü kullanýrsýnýz.. Böylece muticast delegate yapmýþ oluruz.. !!Delegate will execute the methods in order!!
            DenemneDelegate denemneDelegate = new(KareAl);
            denemneDelegate += YarisiniAl;

            //testDelegate.Invoke();
            Text = denemneDelegate.Invoke(4).ToString();
            Egitmen<AkademikGorev> egt = new();
            Egitmen<ProjeGorevi> egt2 = new();
            #endregion
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AkademikGorev aG = new(DersAnlat);
            aG += MufredatHazirla;
            aG += EtutYap;

            ProjeGorevi pG = new(KurumsalEgitim);
            pG += ProjeYaz;
            pG += MerkeziDestekVer;
        }
    }
}
