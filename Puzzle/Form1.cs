﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Puzzle.FilaPrioridade;

namespace Puzzle
{
    public partial class Form1 : Form
    {
        int[,] MatrizEmbaralhada = new int[3, 3];
        int[,] MatrizFinal = new int[3, 3];
        int countFinal = 0;

        List<int[,]> listaEstadosUsados = new List<int[,]>();

        FilaPrioridade Fila = new FilaPrioridade();

        public Form1()
        {
            InitializeComponent();
        }

        private void EmbaralharTudo()
        {
            int repeticoes = 20000, linha, coluna, aux;
            MatrizEmbaralhada = MatrizFinal;
            for (int num = 0; num < repeticoes; num++)
            {
                (linha, coluna) = procurarVazio(MatrizEmbaralhada);

                Random numeroAleatorio = new Random();
                int direcao = numeroAleatorio.Next(1, 5);
                /// 1 - Esquerda
                /// 2 - Cima
                /// 3 - Direita
                /// 4 - Baixo
                switch (direcao)
                {
                    case 1:
                        if (coluna > 0)
                        {
                            aux = MatrizEmbaralhada[linha, coluna];
                            MatrizEmbaralhada[linha, coluna] = MatrizEmbaralhada[linha, coluna - 1];
                            MatrizEmbaralhada[linha, coluna - 1] = aux;
                        }
                        break;
                    case 2:
                        if (linha > 0)
                        {
                            aux = MatrizEmbaralhada[linha, coluna];
                            MatrizEmbaralhada[linha, coluna] = MatrizEmbaralhada[linha - 1, coluna];
                            MatrizEmbaralhada[linha - 1, coluna] = aux;
                        }
                        break;
                    case 3:
                        if (coluna < 2)
                        {
                            aux = MatrizEmbaralhada[linha, coluna];
                            MatrizEmbaralhada[linha, coluna] = MatrizEmbaralhada[linha, coluna + 1];
                            MatrizEmbaralhada[linha, coluna + 1] = aux;
                        }
                        break;
                    case 4:
                        if (linha < 2)
                        {
                            aux = MatrizEmbaralhada[linha, coluna];
                            MatrizEmbaralhada[linha, coluna] = MatrizEmbaralhada[linha + 1, coluna];
                            MatrizEmbaralhada[linha + 1, coluna] = aux;
                        }
                        break;
                }
            }
            popularBotoes();
        }

        private (int, int) procurarVazio(int[,] matriz)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (matriz[i, j] == 0)
                    {
                        return (i, j);
                    }
                }
            }
            return (2, 2);
        }

        private void popularBotoes()
        {
            btnI1.Text = MatrizEmbaralhada[0, 0].ToString();
            btnI2.Text = MatrizEmbaralhada[0, 1].ToString();
            btnI3.Text = MatrizEmbaralhada[0, 2].ToString();
            btnI4.Text = MatrizEmbaralhada[1, 0].ToString();
            btnI5.Text = MatrizEmbaralhada[1, 1].ToString();
            btnI6.Text = MatrizEmbaralhada[1, 2].ToString();
            btnI7.Text = MatrizEmbaralhada[2, 0].ToString();
            btnI8.Text = MatrizEmbaralhada[2, 1].ToString();
            btnI0.Text = MatrizEmbaralhada[2, 2].ToString();
        }

        private void preencherFinal(Button btn)
        {
            if (this.countFinal == 0)
            {
                btnF1.Text = btn.Text;
                this.countFinal++;
            }
            else
            if (this.countFinal == 1)
            {
                btnF2.Text = btn.Text;
                this.countFinal++;
            }
            else
            if (this.countFinal == 2)
            {
                btnF3.Text = btn.Text;
                this.countFinal++;
            }
            else
            if (this.countFinal == 3)
            {
                btnF4.Text = btn.Text;
                this.countFinal++;
            }
            else
            if (this.countFinal == 4)
            {
                btnF5.Text = btn.Text;
                this.countFinal++;
            }
            else
            if (this.countFinal == 5)
            {
                btnF6.Text = btn.Text;
                this.countFinal++;
            }
            else
            if (this.countFinal == 6)
            {
                btnF7.Text = btn.Text;
                this.countFinal++;
            }
            else
            if (this.countFinal == 7)
            {
                btnF8.Text = btn.Text;
                this.countFinal++;
            }
            else
            if (this.countFinal == 8)
            {
                btnF0.Text = btn.Text;
                this.countFinal++;
            }
        }

        private void btnEF1_Click(object sender, EventArgs e)
        {
            this.preencherFinal(btnEF1);
            btnEF1.Enabled = false;
        }

        private void btnEF2_Click(object sender, EventArgs e)
        {
            this.preencherFinal(btnEF2);
            btnEF2.Enabled = false;
        }

        private void btnEF3_Click(object sender, EventArgs e)
        {
            this.preencherFinal(btnEF3);
            btnEF3.Enabled = false;
        }

        private void btnEF4_Click(object sender, EventArgs e)
        {
            this.preencherFinal(btnEF4);
            btnEF4.Enabled = false;
        }

        private void btnEF5_Click(object sender, EventArgs e)
        {
            this.preencherFinal(btnEF5);
            btnEF5.Enabled = false;
        }

        private void btnEF6_Click(object sender, EventArgs e)
        {
            this.preencherFinal(btnEF6);
            btnEF6.Enabled = false;
        }

        private void btnEF7_Click(object sender, EventArgs e)
        {
            this.preencherFinal(btnEF7);
            btnEF7.Enabled = false;
        }

        private void btnEF_Click(object sender, EventArgs e)
        {
            this.preencherFinal(btnEF8);
            btnEF8.Enabled = false;
        }

        private void btnEF0_Click(object sender, EventArgs e)
        {
            this.preencherFinal(btnEF0);
            btnEF0.Enabled = false;
        }

        private void btnRestartEF_Click(object sender, EventArgs e)
        {
            this.countFinal = 0;
            btnEF0.Enabled = true;
            btnF0.Text = "";
            btnEF1.Enabled = true;
            btnF1.Text = "";
            btnEF2.Enabled = true;
            btnF2.Text = "";
            btnEF3.Enabled = true;
            btnF3.Text = "";
            btnEF4.Enabled = true;
            btnF4.Text = "";
            btnEF5.Enabled = true;
            btnF5.Text = "";
            btnEF6.Enabled = true;
            btnF6.Text = "";
            btnEF7.Enabled = true;
            btnF7.Text = "";
            btnEF8.Enabled = true;
            btnF8.Text = "";
        }

        private void btnDefinirEF_Click(object sender, EventArgs e)
        {
            MatrizFinal[0, 0] = Convert.ToInt32(btnF1.Text);
            MatrizFinal[0, 1] = Convert.ToInt32(btnF2.Text);
            MatrizFinal[0, 2] = Convert.ToInt32(btnF3.Text);
            MatrizFinal[1, 0] = Convert.ToInt32(btnF4.Text);
            MatrizFinal[1, 1] = Convert.ToInt32(btnF5.Text);
            MatrizFinal[1, 2] = Convert.ToInt32(btnF6.Text);
            MatrizFinal[2, 0] = Convert.ToInt32(btnF7.Text);
            MatrizFinal[2, 1] = Convert.ToInt32(btnF8.Text);
            MatrizFinal[2, 2] = Convert.ToInt32(btnF0.Text);
        }

        private void btnEmbaralhar_Click(object sender, EventArgs e)
        {
            EmbaralharTudo();
        }

        private bool estadoUtilizado(int[,] matriz)
        {
            foreach (var usado in listaEstadosUsados)
            {
                if (usado == matriz) // Matriz já usada ?
                {
                    return true;
                }
            }
            return false;
        }

        private int calcularHeuristica()
        {
            int heuristica = 0;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    if (MatrizEmbaralhada[i, j] != MatrizFinal[i ,j])
                    {
                        heuristica++;
                    }
                    
                }
            return heuristica;
        }

        private void ResolverAStar()
        {
            //Declarações...
            int linha, coluna, aux, distHeuristica, custo = 0;

            // Calcular distância Heurística
            distHeuristica = calcularHeuristica();
            
            // Cria novo elemento matriz
            Elemento elemento = newNode(MatrizEmbaralhada, custo, distHeuristica);

            // Insere elemento matriz criado na fila
            elemento = push(elemento, MatrizEmbaralhada, custo, distHeuristica);

            while (!isEmpty(elemento)) // enquanto a fila não estiver vazia
            {
                // Procura o 0 nesse elemento matriz retirado da fila e atribui as coordenadas
                (linha, coluna) = procurarVazio(elemento.matriz);

                // Verifica as possíveis posições de movimentação do 0
                // ↓↓↓↓

                if (linha > 0) // Pode ir para cima ?
                {
                    // Faz uma cópia do elemento matriz
                    int[,] copiaMatriz = elemento.matriz;

                    // Trocar 0 para a posição permitida
                    aux = copiaMatriz[linha, coluna];
                    copiaMatriz[linha, coluna] = copiaMatriz[linha - 1, coluna];
                    copiaMatriz[linha - 1, coluna] = aux;

                    // Verificar se o estado da cópia gerada já foi usado
                    if (!estadoUtilizado(copiaMatriz)) // se houver, ignora...
                    {
                        // Insere na lista de usados
                        listaEstadosUsados.Add(copiaMatriz);

                        // Calcula distância
                        distHeuristica = calcularHeuristica();

                        // Criar novo elemento a partir do novo estado gerado
                        elemento = newNode(copiaMatriz, custo, distHeuristica);

                        // Insere o novo elemento matriz na fila de prioridade
                        elemento = push(elemento, copiaMatriz, custo, distHeuristica);
                    }
                }

                if (linha < 2) // Pode ir para baixo ?
                {
                    int[,] copiaMatriz = elemento.matriz;

                    aux = copiaMatriz[linha, coluna];
                    copiaMatriz[linha, coluna] = copiaMatriz[linha + 1, coluna];
                    copiaMatriz[linha + 1, coluna] = aux;

                    if (!estadoUtilizado(copiaMatriz)) // se não houver estado usado
                    {
                        //insere na lista de usados
                        listaEstadosUsados.Add(copiaMatriz);

                        //calcula distância
                        distHeuristica = calcularHeuristica();

                        //Criar novo elemento e inserir na fila de prioridade
                        elemento = newNode(copiaMatriz, custo, distHeuristica);
                        elemento = push(elemento, copiaMatriz, custo, distHeuristica);
                    }
                }

                if (coluna > 0) // Pode ir para esquerda ?
                {
                    int[,] copiaMatriz = elemento.matriz;

                    aux = copiaMatriz[linha, coluna];
                    copiaMatriz[linha, coluna] = copiaMatriz[linha, coluna - 1];
                    copiaMatriz[linha, coluna - 1] = aux;

                    if (!estadoUtilizado(copiaMatriz)) // se não houver estado usado
                    {
                        //insere na lista de usados
                        listaEstadosUsados.Add(copiaMatriz);

                        //calcula distância
                        distHeuristica = calcularHeuristica();

                        //Criar novo elemento e inserir na fila de prioridade
                        elemento = newNode(copiaMatriz, custo, distHeuristica);
                        elemento = push(elemento, copiaMatriz, custo, distHeuristica);
                    }
                }

                if (coluna < 2) // Pode ir para direita ?
                {
                    int[,] copiaMatriz = elemento.matriz;

                    aux = copiaMatriz[linha, coluna];
                    copiaMatriz[linha, coluna] = copiaMatriz[linha, coluna + 1];
                    copiaMatriz[linha, coluna + 1] = aux;

                    if (!estadoUtilizado(copiaMatriz)) // se não houver estado usado
                    {
                        //insere na lista de usados
                        listaEstadosUsados.Add(copiaMatriz);

                        //calcula distância
                        distHeuristica = calcularHeuristica();

                        //Criar novo elemento e inserir na fila de prioridade
                        elemento = newNode(copiaMatriz, custo, distHeuristica);
                        elemento = push(elemento, copiaMatriz, custo, distHeuristica);
                    }
                }
                // Retida elemento matriz
                elemento = pop(elemento);
                // Incremeta o custo acumulado
                custo++;
            }

            popularBotoes();
        }

        private void btnResolver_Click(object sender, EventArgs e)
        {
            if (cbMetodo.SelectedIndex == 1) // A* ou (A Star)
            {
                ResolverAStar();
            }
            else
            {

            }
        }
    }
}
