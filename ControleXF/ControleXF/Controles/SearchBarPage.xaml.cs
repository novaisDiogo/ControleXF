using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControleXF.Controles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchBarPage : ContentPage
    {
        private List<string> empresasTi;
        public SearchBarPage()
        {
            InitializeComponent();
            empresasTi = new List<string>();
            empresasTi.Add("Microsoft");
            empresasTi.Add("Apple");
            empresasTi.Add("Oracle");
            empresasTi.Add("IBM");
            empresasTi.Add("SAP");
            empresasTi.Add("Uber");
            empresasTi.Add("99Taxi");

            Preencher(empresasTi);
        }
        private void PesquisarButton(object sender, EventArgs args)
        {
            var resultado = empresasTi.Where(a => a.Contains(((SearchBar)sender).Text)).ToList<String>();

            Preencher(resultado);
        }
        private void Pesquisar(object sender, TextChangedEventArgs args)
        {
            var resultado = empresasTi.Where(a => a.Contains(args.NewTextValue)).ToList<String>();

            Preencher(resultado);
        }
        private void Preencher(List<String> empresasTi)
        {
            ListResult.Children.Clear();
            foreach (var emp in empresasTi)
            {
                ListResult.Children.Add(new Label { Text = emp });
            }
        }
    }
}