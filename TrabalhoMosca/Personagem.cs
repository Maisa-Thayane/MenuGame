using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoMosca
{
    public class Personagem
    {
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public string Raca { get; set; }
        public int Nivel { get; set; }
        public string ImagemPath { get; set; }

        public Personagem(string nome, string tipo, string raca, int nivel, string imagemPath)
        {
            Nome = nome;
            Tipo = tipo;
            Raca = raca;
            Nivel = nivel;
            ImagemPath = imagemPath;
        }

        public string ExibirResumo()
        {
            return $"Nome: {Nome}\nTipo: {Tipo}\nRaça: {Raca}\nNível: {Nivel}";
        }
    }
}
