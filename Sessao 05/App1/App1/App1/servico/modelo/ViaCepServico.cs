using System;
using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using Newtonsoft.Json;

namespace App1.servico.modelo
{
    public class ViaCepServico
    {
        private static string EnderecoUrl = "https://viacep.com.br/ws/{0}/json/";

        public static Endereco BuscarEnderecoViaCep(string cep)
        {
            string NovoEndereco = string.Format(EnderecoUrl, cep);
            WebClient wc = new WebClient();
            string Conteudo = wc.DownloadString(NovoEndereco);

            Endereco end = JsonConvert.DeserializeObject<Endereco>(Conteudo);
            return end;
        } 
    }
}
