using System;

using Xamarin.Forms;

namespace PracticaCalculadora
{
    public class Pagina2 : ContentPage
    {
        public Pagina2()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

