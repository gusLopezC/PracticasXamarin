using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PracticaCalculadora
{
    public partial class Pagina2 : ContentPage
    {
        public Pagina2(string n1,string n2)
        {
            int suma, resta, multi, divi;
            int num1 = int.Parse(n1);
            int num2 = int.Parse(n2);
            InitializeComponent();


            suma = num1 + num2;
            resta = num1 - num2;
            multi = num1 * num2;
            divi = num1 / num2;

            rsum.Text = suma.ToString();
            rres.Text = resta.ToString();
            rmul.Text = multi.ToString();
            rdiv.Text = divi.ToString();



        }

    }
}
