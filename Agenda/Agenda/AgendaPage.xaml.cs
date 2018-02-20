using System.Collections.Generic;
using Xamarin.Forms;

namespace Agenda
{
    public partial class AgendaPage : ContentPage
    {
        List<Amigo> amigos;
        public AgendaPage()
        {
            InitializeComponent();
            btnAgregar.Clicked += BtnAgregar_Clicked;
            amigos = new List<Amigo>();

        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            lstAmigos.ItemsSource = null;
            lstAmigos.ItemsSource = amigos;
        }

        private void BtnAgregar_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Detalle(amigos));
        }
    }
}
