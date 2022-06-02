using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigiLibV2.Entidades
{
    public class Livros
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editora { get; set; }
        public int Ano_Lancamento { get; set; }
        public int Edicao { get; set; }
        public string Palavra_Chave { get; set; }

        internal bool Ano_Lancamento(string query) {
            throw new NotImplementedException();
        }

        internal bool Edicao(string query) {
            throw new NotImplementedException();
        }

        internal bool Palavra_Chave(string query) {
            throw new NotImplementedException();
        }
    }
}
