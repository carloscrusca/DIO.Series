using System;
using System.Collections.Generic;


namespace DIO.Series
{
       public class Serie : EntidadeBase
    {
        // Atributos

        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }

        private bool Excluido {get; set;}

        private bool GanhouOscar {get; set;}

        // Métodos

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
            this.GanhouOscar = false;
        }

        public override string ToString()
        {
            string retorno ="";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo : " + this.Titulo + Environment.NewLine;
            retorno += "Descrição : " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
            retorno += "Excluido " + this.Excluido  + Environment.NewLine;
            retorno += "Vencedor do Oscar " + this.GanhouOscar;
            return retorno;
            
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public int retornaId()
        {
            return this.Id;
        }

        public void Excluir() 
        {
            this.Excluido = true;
        }

        public void ganhouOscar() 
        {
            this.GanhouOscar = true;
        }
        

         public bool retornaExcluido()
        {
            return this.Excluido;
        }

         public bool retornaOscar()
        {
            return this.GanhouOscar;
        }

        
    }
}