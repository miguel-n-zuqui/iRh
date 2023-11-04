using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Cadastros.core
{
    internal class Endereco
    {
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public string Uf { get; set; }
        public string Ibge { get; set; }
        public string Gia { get; set; }
        public string Ddd { get; set; }
        public string Siafi { get; set; }
        public bool Erro { get; set; }
        public Endereco obterPorCep(string cep)
        {
            var enderecoDaApi = new Endereco();
            try
            {
                //Instancia http que permite obter informacoes da internet atravez de uma URL
                var http = new HttpClient();

                var url = new Uri("https://Viacep.com.br/ws/" + cep + "/json/");
                var result = http.GetAsync(url).GetAwaiter().GetResult();

                //Converter o resutlado obtido em uma string
                var resultContent = result.Content.ReadAsStringAsync().GetAwaiter().GetResult();

                //converter a string json para nossa classe vaiCep Wrapper
                enderecoDaApi = JsonConvert.DeserializeObject<Endereco>(resultContent);
                if(enderecoDaApi.Erro)
                {
                    return null;
                }
                return enderecoDaApi;
            }
            catch(Exception)
            {
                return null;
            }
        }



    }
}
