using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ControleXF.Modelo;

namespace ControleXF.Controles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage : ContentPage
    {
        public ListViewPage()
        {
            InitializeComponent();

            List<Pessoa> lista = new List<Pessoa>();
            lista.Add(new Pessoa { Nome = "José", Idade = "18" });
            lista.Add(new Pessoa { Nome = "Maria", Idade = "23" });
            lista.Add(new Pessoa { Nome = "Eva", Idade = "28" });
            lista.Add(new Pessoa { Nome = "Sebastião", Idade = "30" });
            lista.Add(new Pessoa { Nome = "Marcio", Idade = "36" });

            ListaPessoas.ItemsSource = lista;
        }
    }
}