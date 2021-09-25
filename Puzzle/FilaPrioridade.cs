using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzle
{
    public class Elemento
    {
        public int[,] matriz = new int[3, 3];
        public int custoTotal;
        public Elemento prox;

        public Elemento(){}
    }

    public class FilaPrioridade
    {
        
        public static Elemento newNode(int[,] matriz, int custoTotal)
        {
            Elemento temp = new Elemento();
            temp.matriz = matriz;
            temp.custoTotal = custoTotal;
            temp.prox = null;
            return temp;
        }

        public static Elemento newNode()
        {
            Elemento temp = new Elemento();
            temp.matriz = null;
            temp.custoTotal = 0;
            temp.prox = null;
            return temp;
        }

        public static int[,] top(Elemento cabeça)
        {
            return (cabeça).matriz;
        }

        public static Elemento dequeue(Elemento cabeça)
        {
            (cabeça) = (cabeça).prox;
            return cabeça;
        }

        public static Elemento enqueue(Elemento cabeça,
                                int[,] matriz, int custoTotal)
        {
            Elemento novoNo = newNode();
            Elemento aux;
            if(novoNo != null)
            {
                novoNo.matriz = matriz;
                novoNo.custoTotal = custoTotal;
                novoNo.prox = null;
                if(cabeça == null)
                {
                    cabeça = novoNo;
                }
                else
                {
                    aux = cabeça;
                    Elemento ant = aux; 
                    while(aux.prox != null && aux.custoTotal <= custoTotal)
                    {
                        ant = aux;
                        aux = aux.prox;
                    }
                    if(ant == aux)
                    {
                        cabeça.prox = novoNo;
                        novoNo.prox = null;
                    }
                    else
                    {
                        ant.prox = novoNo;
                        novoNo.prox = aux;
                    }
                    
                }
            }
            
            return cabeça;
        }
        public static bool isEmpty(Elemento cabeça)
        {
            return cabeça == null;
        }
    }
}
