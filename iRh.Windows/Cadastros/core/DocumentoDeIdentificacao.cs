using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Cadastros.core
{
    public class DocumentoDeIdentificacao
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public List<DocumentoDeIdentificacao> ObterTodosOsDocumentos()
        {
            var listaDeEDocumentos = new List<DocumentoDeIdentificacao>();
            listaDeEDocumentos.Add(new DocumentoDeIdentificacao { Id = 1, Descricao = "Carteira de Identidade" });
            listaDeEDocumentos.Add(new DocumentoDeIdentificacao { Id = 2, Descricao = "Passaporte" });
            listaDeEDocumentos.Add(new DocumentoDeIdentificacao { Id = 3, Descricao = "Carteira de Habilitação" });
            listaDeEDocumentos.Add(new DocumentoDeIdentificacao { Id = 4, Descricao = "Registro Nacional de Estrangeiro" });
            listaDeEDocumentos.Add(new DocumentoDeIdentificacao { Id = 5, Descricao = "Carteira de Trabalho" });
            listaDeEDocumentos.Add(new DocumentoDeIdentificacao { Id = 6, Descricao = "Documento de identificação militar" });
            listaDeEDocumentos.Add(new DocumentoDeIdentificacao { Id = 6, Descricao = "Carteiras funcionais emitidas por órgãos públicos" });
            return listaDeEDocumentos;



        }
    }
}
