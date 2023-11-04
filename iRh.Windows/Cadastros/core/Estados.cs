using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Cadastros.core
{
    public class Estados
    {
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public List<Estados> ObterTodosOsEstados()
        {
            var listaDeEstados = new List<Estados>();
            listaDeEstados.Add(new Estados
            {
                Nome = "Rondônia",
                Sigla = "RO"
            });
            listaDeEstados.Add(new Estados
            {
                Nome = "Acre",
                Sigla = "AC"
            });
            listaDeEstados.Add(new Estados
            {
                Nome = "Espírito Santo",
                Sigla = "ES"
            });
            listaDeEstados.Add(new Estados
            {
                Nome = "Rio de Janeiro",
                Sigla = "RG"
            });
            listaDeEstados.Add(new Estados
            {
                Nome = "São Paulo",
                Sigla = "SP"
            });
            listaDeEstados.Add(new Estados
            {
                Nome = "Amazonas",
                Sigla = "AM"
            });
            listaDeEstados.Add(new Estados
            {
                Nome = "Pará",
                Sigla = "PA"
            });
            listaDeEstados.Add(new Estados
            {
                Nome = "Bahia",
                Sigla = "BA"
            });
            listaDeEstados.Add(new Estados
            {
                Nome = "Minas Gerais",
                Sigla = "MG"
            });
            listaDeEstados.Add(new Estados
            {
                Nome = "Maranhão",
                Sigla = "MA"
            });
            listaDeEstados.Add(new Estados
            {
                Nome = "Santa Catarina",
                Sigla = "SC"
            });
            listaDeEstados.Add(new Estados
            {
                Nome = "Pernanbuco",
                Sigla = "PE"
            });
            listaDeEstados.Add(new Estados
            {
                Nome = "Goiás",
                Sigla = "GO"
            });
            listaDeEstados.Add(new Estados
            {
                Nome = "Distrito Federal",
                Sigla = "DF"
            });
            listaDeEstados.Add(new Estados
            {
                Nome = "Paraíba",
                Sigla = "PB"
            });
            listaDeEstados.Add(new Estados
            {
                Nome = "Piauí",
                Sigla = "PI"
            });
            listaDeEstados.Add(new Estados
            {
                Nome = "Alagoas",
                Sigla = "AL"
            });
            listaDeEstados.Add(new Estados
            {
                Nome = "Amapá",
                Sigla = "AP"
            });
            listaDeEstados.Add(new Estados
            {
                Nome = "Ceará",
                Sigla = "CE"
            });
            listaDeEstados.Add(new Estados
            {
                Nome = "Mato Grosso",
                Sigla = "MT"
            });
            listaDeEstados.Add(new Estados
            {
                Nome = "Mato Grosso Do Sul",
                Sigla = "MS"
            });
            listaDeEstados.Add(new Estados
            {
                Nome = "Paraná",
                Sigla = "PR"
            });
            listaDeEstados.Add(new Estados
            {
                Nome = "Rio Grande do Norte",
                Sigla = "RN"
            });
            listaDeEstados.Add(new Estados
            {
                Nome = "Rio Grande do Sul",
                Sigla = "RS"
            });
            listaDeEstados.Add(new Estados
            {
                Nome = "Roraima",
                Sigla = "RR"
            });
            listaDeEstados.Add(new Estados
            {
                Nome = "Sergipe",
                Sigla = "SE"
            });
            listaDeEstados.Add(new Estados
            {
                Nome = "Tocantins",
                Sigla = "TO"
            });
            return listaDeEstados;


        }

        internal static object obterTodosOsEstados()
        {
            throw new NotImplementedException();
        }
    }
}
