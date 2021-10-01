using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzle
{
    public class No
    {
        private No pai;
        private int[,] estado;
        private int prioridade;
        private No prox;
        private No ant;

        public int[,] Estado { get => estado; set => estado = value; }
        public int Prioridade { get => prioridade; set => prioridade = value; }
        public No Prox { get => prox; set => prox = value; }
        public No Ant { get => ant; set => ant = value; }

        public No(No pai, int[,] estado, int prioridade)
        {
            this.pai = pai;
            this.estado = estado;
            this.prioridade = prioridade;
            prox = null;
            ant = null;
        }

        public No()
        {
            prox = null;
            ant = null;
        }
    }
}
