using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO_Series.Classes
{
    public class Serie : EntidadeBase
    {


        // Atributos
        private Genero Genero { get; set; }
        public string Titulo { get; private set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        public bool Excluido { get; private set; }

        public Serie(int id ,Genero genero, string titulo, string descricao, int ano)
        {

            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }


        public override string ToString()
        {
            
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;  // Environment.NewLine -> interpreta como o sistema operacional pula uma linha (/n)
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
            return retorno;
        }
    
        public int retornaId()
        {
            return this.Id;
        }

   
    
        public void Excluir()
        {
            this.Excluido = true;
        }


    }
}
