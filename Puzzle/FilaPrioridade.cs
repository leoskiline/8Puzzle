using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzle
{
    public class FilaPrioridade
    {
        public class Elemento
        {
            public int[,] matriz = new int[3, 3];
            public int custo;
            public int distHeuristica;
            public Elemento prox;

            public Elemento()
            {

            }
        }

        public static Elemento newNode(int[,] matriz, int custo, int dist)
        {
            Elemento temp = new Elemento();
            temp.matriz = matriz;
            temp.custo = custo;
            temp.distHeuristica = dist;
            temp.prox = null;
            return temp;
        }

        public static int[,] top(Elemento cabeça)
        {
            return (cabeça).matriz;
        }

        public static Elemento pop(Elemento cabeça)
        {
            (cabeça) = (cabeça).prox;
            return cabeça;
        }

        public static Elemento push(Elemento cabeça,
                                int[,] matriz, int custo, int dist)
        {
            Elemento start = (cabeça);
            Elemento aux = newNode(matriz, custo, dist);
            if ((cabeça).distHeuristica > dist)
            {
                aux.prox = cabeça;
                (cabeça) = aux;
            }
            else
            {
                while (start.prox != null &&
                    start.prox.distHeuristica < dist)
                {
                    start = start.prox;
                }
                aux.prox = start.prox;
                start.prox = aux;
            }
            return cabeça;
        }
        public static bool isEmpty(Elemento cabeça)
        {
            return cabeça == null;
        }
    }
}
