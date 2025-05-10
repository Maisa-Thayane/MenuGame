using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoMosca
{
    public static class PersonagemLista
    {
        private static List<Personagem> lista = new List<Personagem>();

        public static void Add(Personagem p) => lista.Add(p);
        public static void Update(int i, Personagem p) => lista[i] = p;
        public static void Remover(int i) => lista.RemoveAt(i);
        public static List<Personagem> ObterTodos() => lista;
    }
}
