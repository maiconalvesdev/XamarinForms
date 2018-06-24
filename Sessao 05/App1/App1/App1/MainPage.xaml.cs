using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1.servico.modelo;
using Xamarin.Forms;

namespace App1
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		    btnbusca.Clicked += BuscarCep;

		}

	    private void BuscarCep(object sender, EventArgs e)
	    {
	        string cep = busca.Text.Trim();
	        if (isValidCep(cep))
	        {
	            Endereco end = ViaCepServico.BuscarEnderecoViaCep(cep);

	            textosaida.Text = "Endereço: " + end.localidade;
	        }
	    }

	    private bool isValidCep(string cep)
	    {
	        if (cep.Length == 8) return true;
	        DisplayAlert("ERRO", "Cep deve ser de 8 caracteres", "OK");
	        return false;
	    }
	}
}
