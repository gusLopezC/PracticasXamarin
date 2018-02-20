using Xamarin.Forms;

namespace PracticaCalculadora
{
    public partial class PracticaCalculadoraPage : ContentPage
    {

        public PracticaCalculadoraPage()
        {
            InitializeComponent();
        }
        public void click_btn1(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Pagina2(n1.Text,n2.Text));
        }
        public void click_btn2(object sender, System.EventArgs e)
        {
            n1.
        }
    }
}
