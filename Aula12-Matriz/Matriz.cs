﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12_Matriz
{
    internal class Matriz
    {
        private static int[,] _jogoDaVelha = new int[,]
     {
            { 7, 8, 9 },
            { 4, 5, 6 },
            { 1, 2, 3 }
     };
        public void ExibirMatriz()
        {
            for (int i = 0; i < _jogoDaVelha.GetLength(0); i++)
            {
                for (int j = 0; j < _jogoDaVelha.GetLength(1); j++)
                {
                    Console.Write(" | "+ _jogoDaVelha[i, j]);
                }
                Console.WriteLine("\n_____________");
            }
        }
                //Console.WriteLine($"{_jogoDaVelha[0, 0]} | {_jogoDaVelha[0, 1]} | {_jogoDaVelha[0, 2]}" + Environment.NewLine +
                //$"----------" + Environment.NewLine +
                //$"{_jogoDaVelha[1, 0]} | {_jogoDaVelha[1, 1]} | {_jogoDaVelha[1, 2]}" + Environment.NewLine +
                // $"----------" + Environment.NewLine +
                //$"{_jogoDaVelha[2, 0]} | {_jogoDaVelha[2, 1]} | {_jogoDaVelha[2, 2]}");

        }
}
