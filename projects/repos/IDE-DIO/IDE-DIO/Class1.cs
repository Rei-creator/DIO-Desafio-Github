using System;
using System.Collections.Generic;
using System.Text;

namespace IDE_DIO
{
    enum Pessoas
    {
        Giovanna,
        Hugo,
        João,
        Gustavo,
        Mariana
    }
    interface Ianimal
    {
        void Nome(string nome);
        void Dono(string nomeDono);
        void Especie(string especie);
    }

    class Animal : Ianimal
    {
        public string Nome { get; set; }
        public string NomeDono { get; set; }
        public string Especie { get; set; }

        void Ianimal.Nome(string nome)
        {
            this.Nome = nome;
        }

        void Ianimal.Dono(string nomeDono)
        {
            this.NomeDono = nomeDono;
        }

        void Ianimal.Especie(string especie)
        {
            this.Especie = especie;
        }
    } 
    class Pessoa
    {
        public string Nome { get; set; }
        public string Estado { get; set; }
        public int Idade { get; set; }
    }
}
