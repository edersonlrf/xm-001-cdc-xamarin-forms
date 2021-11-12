using Modulo1.Dal;
using Modulo1.Modelo;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Modulo1.Paginas.TiposItensCardapio
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TiposItensCardapioListPage : ContentPage
    {
        private TipoItemCardapioDAL dalTipoItemCardapio = TipoItemCardapioDAL.GetInstance();

        public TiposItensCardapioListPage()
        {
            InitializeComponent();
            lvTiposItensCardapio.ItemsSource = dalTipoItemCardapio.GetAll();
        }
    }
}
