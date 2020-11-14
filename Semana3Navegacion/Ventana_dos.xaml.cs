using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana3Navegacion
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Ventana_dos : ContentPage
    {
        public Ventana_dos(string user, string pass)
        {
            InitializeComponent();
            lblUser.Text = user;
            txtPass.Text = pass;
        }
    }
}