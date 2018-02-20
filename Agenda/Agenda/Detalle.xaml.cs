using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Agenda
{
    public partial class Detalle : ContentPage
    {
        List<Amigo> ListaAmigos;
        public Detalle(List<Amigo> amigos)
        {
            InitializeComponent();
            btnGuardar.Clicked += BtnGuardar_Clicked;
            ListaAmigos = amigos;

        }

        private void BtnGuardar_Clicked(object sender, EventArgs e)
        {
            ListaAmigos.Add(new Amigo()
            {
                Apodo= txbApodo.Text,Email = txbEmail.Text, Nombre = txbNombre.Text, Telefono = txbTelefono.Text
            });
            Navigation.PopAsync();
        }
    }
}
