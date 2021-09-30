using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzle
{
     public class Fila
    {
        public No inicio; 

        public Fila()
        {
            inicio = null;
        }

        public No GetInicio()
        {
            return inicio;
        }

        public void SetInicio(No inicio)
        {
            this.inicio = inicio;
        }

        public void Enqueue(No no)
        {
            No aux, ant;
            no.Prox = null;
            if (inicio == null)
                inicio = no;
            else
            {
                if (no.Prioridade < inicio.Prioridade)
                {
                    no.Prox = inicio;
                    inicio = no;
                }
                else
                {
                    aux = inicio;
                    ant = aux;
                    while (aux.Prox != null && no.Prioridade >= aux.Prioridade)
                    {
                        ant = aux;
                        aux = aux.Prox;
                    }
                    if (aux.Prox == null && no.Prioridade >= aux.Prioridade)
                    {
                        aux.Prox=no;
                        no.Ant=aux;
                    }
                    else
                    {
                        no.Prox=aux;
                        no.Ant = ant;
                        ant.Prox = no;
                        aux.Ant = no;
                    }
                }
            }
        }


        public No Dequeue()
        {
            No aux = null;
            if (inicio != null)
            {
                aux = inicio;
                if (inicio.Prox != null)
                {
                    inicio.Prox.Ant = null;
                    inicio = inicio.Prox;
                }
                else
                {
                    inicio = null;
                }
            }
            return aux;
        }

        public bool IsEmpty()
        {
            return inicio == null;
        }
    }
}
