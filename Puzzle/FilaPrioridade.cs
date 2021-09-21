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
            public int[,] matriz = new int[3,3];
            public int custo;
            public Elemento prox;

            public Elemento()
            {

            }
        }

        public static Elemento elemento = new Elemento();

        public static Elemento newNode(int[,] matriz, int custo)
        {
            Elemento temp = new Elemento();
            temp.matriz = matriz;
            temp.custo = custo;
            temp.prox = null;
            return temp;
        }

        public static int[,] top(Elemento cabeça)
        {
            return (cabeça).matriz;
        }

        public static Elemento pop(Elemento cabeça)
        {
            Elemento temp = cabeça;
            (cabeça) = (cabeça).prox;
            return cabeça;
        }

        public static Elemento push(Elemento cabeça,
                                int[,] matriz, int custo)
        {
            Elemento start = (cabeça);
            Elemento temp = newNode(matriz, custo);
            if ((cabeça).custo > custo)
            {
                temp.prox = cabeça;
                (cabeça) = temp;
            }
            else
            {
                while (start.prox != null &&
                    start.prox.custo < custo)
                {
                    start = start.prox;
                }
                temp.prox = start.prox;
                start.prox = temp;
            }
            return cabeça;
        }
        public static int isEmpty(Elemento cabeça)
        {
            return ((cabeça) == null) ? 1 : 0;
        }
    }
}
