using System;

namespace Modelos
{
    public class Celular
    {
        private int id;
        private string marca;
        private string modelo;
        private string qualidadeTela;
        private int tamanho;
        // private DateTime data; 


        public Celular()
        {

        }

        public Celular(int id, string marca, string modelo, string qualidadeTela, int tamanho)
        {
            this.id = id;
            this.marca = marca;
            this.modelo = modelo;
            this.qualidadeTela = qualidadeTela;
            this.tamanho = tamanho;
        }

        public Celular(string marca, string modelo, string qualidadeTela, int tamanho)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.qualidadeTela = qualidadeTela;
            this.tamanho = tamanho;
        }

        public int Id { get => id; set => id = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string QualidadeTela { get => qualidadeTela; set => qualidadeTela = value; }
        public int Tamanho { get => tamanho; set => tamanho = value; }
       


    }
}
