﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDashApp.Model;

namespace BoulderDashApp.Process
{
    class LevelData
    {
        public static int Level_width = 40;
        public static int Level_height = 22;

        public static char[,] Level1 = new char[22, 40]
        {
        { 'S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S' },
        { 'S','M','M','M','M','M','M',' ','M','M','D','M','B','M','M','M','M','M','M','B','M','B','M','M','M','M','M','M','M',' ','M','M','M','M','B','M','M','M','M','S' },
        { 'S','M','B','R','B','M','M','H','M','M','M',' ','M','M','M','M','M','M','M','M','M','B','D','M','M','B','M','M','M','M',' ','M','M','M','M','M',' ','M','M','S' },
        { 'S','M','M','M','M','M','M','H','M','M','T',' ','M','M',' ','M','M','M','M','M','B','M','B','M','M','B','M','M','M','M','M','M','M','M','B','M','M','M','M','S' },
        { 'S','B','M',' ',' ','M','M','H','M','M','M','M','M','M','B','M','M','M','M','M','M','B','M','M','B','M','M','M','M','B','M','M','M','B','M','M','M','M','M','S' },
        { 'S','B','M','B','B','M','M','M','M','M','M','M','M','M','B','B','M','M','B','M','M','M','M','M','M','M','M','B','M','M','M','M','M','M','B','M','B',' ','M','S' },
        { 'S','M','M','M','B','M','M','B','M','M','M','M','M','M','M','M','B','M','M','M','M','M','B','M',' ','B','M','M','M','M','M','M','M','M','B','M','B','B','M','S' },
        { 'S','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','M','M','M','B','M','M','B','M','S' },
        { 'S','M',' ','M','M','M','B','M','M','D','M',' ','M','M','B','M','B','M','M','M','M','M','M','M','M','M','M','D','M','B',' ','M','M','M','M','M','M','B','M','S' },
        { 'S','M','M','D','M','M','M','M','M','B','M','M','M','M','M',' ','M','M','M','M','M','M','M','M','B',' ',' ','B','M','M','D','M','M','M','M','B','M','M','M','S' },
        { 'S','M','M','M','B','M','M','B','M','B','M','M','M','M','M','M','M','M','M','M','M','M','M','M','B','B','M','B','M','M','B','M','M','M','M','M','M','M','M','S' },
        { 'S','M',' ','M','M','M','M','M','B','M','M','T','M','M','M','M','M','B','B',' ','M','M','M','M','M','M','M','B','M','M','B','M','D','M','M','M','M',' ','M','S' },
        { 'S','M','B','M','M',' ','M','M','B','M','M','M','M','M','M','M','M','B','M','B','D','M','M','D','M','M','M','M','B','M','M','M','B','M','M','D','M','B','M','S' },
        { 'S','M','D','B','M','M','M','M','M','M','M','M','M','M','M','M','M','M','B','B','B','M','M','B','M','M','M','M','M','M','M','M','D','M','M','M','M','M','B','S' },
        { 'S','H','H','H','H','H','H','H','H','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','S' },
        { 'S',' ',' ','M','M','M','M','M','M','M','M','M',' ','M','M','M','D','M','M','M','M','B','M','M','M','M','M','B','M','M','M','B','M','M','M','M','M','M','M','S' },
        { 'S','B',' ','M','M','M','M','M','M','M','M','M','B','B','M','M','B','M','M','M','M','M','M','M','M','B','M','M','M','M','M','M','B','M','B',' ','M','M','E','S' },
        { 'S','M','B','M','M','B','M','M','M','M','M','M','M','M','B','M','M','M','M','M','B','M',' ',' ','M','M','M','M','D','M','M','M','B','M','B','B','M','M','M','S' },
        { 'S','M','M','M','M','B','D','M','M',' ','M','M','M','M','M','M','M','M','B','M','M','M','M','M','M','B','M','B','D','M','M','M','M','M','M','B','M','M','M','S' },
        { 'S','M','M','M',' ','M','M',' ','M','B','M','M','B','M','B','B','M','M','M','M','T','M','M','M','M','B','M','B','D','M','M','M','M','M','M','B','M','M','B','S' },
        { 'S','M','D','M','M','M','M','B','M','M','M','M','M',' ','M','M','M','M','M','M','M','M','M',' ','M','B','M','M','B','M','M','M','M','B','M','M','M','B','M','S' },
        { 'S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S' }
        };

        public static char[,] Level2 = new char[22, 40]
        {
        {'S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S' },
        {'S','M','B','M','M','B','M','M','W','M','B','M','M','M','D','M','W','M','M','M','T','M','B','M','W',' ','M','M','M','M','M','M','W','M','M','B','B','M','M','S' },
        {'S','M','M','M','M','M','M','M','W','M','M','M','M','M','M',' ','W','H',' ','M',' ','M','M','M','W',' ','M','M',' ','M','M','M','W','M','M','M','M',' ','M','S' },
        {'S',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','B',' ','B','B',' ',' ',' ',' ',' ',' ','B',' ',' ','D',' ',' ',' ',' ',' ',' ',' ',' ','B',' ','S' },
        {'S','D','M','M','M','M','M','M','W','M','B','M','M','M','M','B','W','M','B','M',' ','M','M',' ','W','M','M','B','M','M','D','M','W','M','M','B','H','B','M','S' },
        {'S','M','M','M','M','M','M','M','W','M','B','M','M','M','M','B','W','M','B','M',' ',' ','M','M','W','M','M','M','M','M','B','M','W','M','M','H','T','H','M','S' },
        {'S','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','B',' ','W','W','W','W','W','W','W','W','W','W','W','W','W','W','H','H','H','W','S' },
        {'S','M','M','M','M','B','B','M','W','M','M',' ','M','M','M','M','W','M','M','M',' ','M','M','B','W','M','M','M','M',' ','M','M','W','M','M','M','M','M',' ','S' },
        {'S','M','M','M','M','M','M','M','W','M','M',' ','M','M','M','M','W','M','M','B',' ','M','M','M','W','M','M','M','M','B','M',' ','W','M','M','M','M','M','B','S' },
        {'S',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','B',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','B',' ',' ',' ',' ',' ',' ',' ',' ','B','S' },
        {'S','B','M','M','B','M','M','M','W','M','M','M','M','B','M','M','W','M','M','B','S','M','M','M','W','M','M','M','M','M','M','D','W',' ','M','M','M','M','M','S' },
        {'S','B','M','M','M','M','B','M','W','M','M','B','M','M','B','M','W','M','M','M',' ','M',' ',' ','W','M','M','M','M','M','M','M','W','B','M','M','M','B','M','S' },
        {'S','M','B','M','M','M','M','M','W','M','M','M','B','M','M','M','W','M','M','M',' ','M','B','B','W','M','M','M','M','M','M','M','W','B','B','M','M','B','M','S' },
        {'S','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W',' ','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','S' },
        {'S','B','M',' ','F',' ','M','M','W','M','M','M','M','B','M','B','W','M','M','M',' ','M','M','M','W','M','B','D','M','M','B','M','W','M','M','M','M','M','M','S' },
        {'S','M','M','M','M','M',' ','M','W',' ','M','M','M','M','M','M','W','M','M',' ',' ','M','M','M','W',' ','M','M',' ','M','M','M','W','M',' ','M',' ',' ','M','S' },
        {'S','T',' ',' ',' ',' ',' ',' ',' ','B',' ',' ',' ',' ',' ',' ',' ',' ',' ','D',' ',' ',' ',' ',' ',' ',' ',' ','B',' ',' ',' ',' ',' ','B',' ','B','B',' ','S' },
        {'S','D','M','M',' ','M','B','M','W','B','M','M','M','M','B','M','W','M','B','M',' ','M','M','B','W','M','B','M','B','M','M','M','W','M','M','M','M','M','M','S' },
        {'S','M','M','M','M','M','B','M','W','B','M','M','D','M','M','M','W','M','M','M',' ',' ','M','M','W','M','M','B','M','M','M','M','W','M','M','M',' ',' ',' ','S' },
        {'S','M','D','M','M','M','B',' ','W','M','M',' ','M','M','M','M','W','M','R','D','B','B','M','M','W','M',' ','M','M','M','M','M','W','M','M','M','B','B','B','S' },
        {'S','M','B','M','M','M','M','B','W','M','M','B','M','M','B','M','W','M','S','M','B','M','M','M','W','M','M','M','M','B','M','B','W','M','M','M','M','B','M','S' },
        {'S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S' },
        };

        public static char[,] Level3 = new char[22, 40]
        {
        { 'S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S' },
        { 'S',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','S' },
        { 'S',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','S' },
        { 'S',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','S' },
        { 'S',' ',' ','B','B','T',' ',' ',' ','B','B','B',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','S' },
        { 'S',' ','M','M','M','M','M',' ','M','M','M','M','M','M','H','H','H','H','H','H','H','H','H','H','H','H',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','S' },
        { 'S',' ','M',' ',' ',' ','M',' ','M',' ','T',' ','M','M','H','H',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','S' },
        { 'S',' ','M',' ',' ',' ','M',' ','M',' ',' ',' ','M','M','H',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','S' },
        { 'S',' ','M','F',' ',' ','M',' ','M','F',' ','M','M','M','H',' ',' ',' ',' ',' ',' ',' ','R',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','S' },
        { 'S',' ','M',' ',' ',' ','M',' ','M',' ',' ',' ','M','M','H',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','S' },
        { 'S',' ','M',' ',' ',' ','M',' ','M',' ',' ',' ','M','M','H',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','S' },
        { 'S',' ','M','M','M','M','M',' ','M','M','M','M','M','M',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','S' },
        { 'S',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','S' },
        { 'S',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','S' },
        { 'S',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','S' },
        { 'S',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','S' },
        { 'S',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','S' },
        { 'S',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','S' },
        { 'S',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','S' },
        { 'S',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','S' },
        { 'S',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','S' },
        { 'S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S' }
        };
        public Model.Cave Cave { get; set; }

        public void PrintMaze()
        {
            int counter = 0;
            foreach (char c in Level1)
            {
                if (counter == 40)
                {
                    Console.WriteLine();
                    counter = 0;
                }
                Console.Write(c);
                counter++;
            }
            //Console.WriteLine(Level1.GetLength(0));
        }

        public void BuildMaze()
        {
            Cave = new Cave();
            Model.Tile[,] tiles = new Model.Tile[Level1.GetLength(0), Level1.GetLength(1)];
            for (int i = 0; i < Level1.GetLength(0); i++)
            {
                for (int j = 0; j < Level1.GetLength(1); j++)
                {
                    switch (Level1[i, j])
                    {
                        case 'S':
                            tiles[i, j] = new Steelwall();
                            break;
                        case 'M':
                            tiles[i, j] = new Mud();
                            break;
                        case 'B':
                            tiles[i, j] = new EmptyTIle();
                            tiles[i, j].Entity = new Boulder();
                            break;
                        case 'R':
                            tiles[i, j] = new EmptyTIle();
                            tiles[i, j].Entity = Cave.Rockford;
                            Cave.Rockford.Tile = tiles[i, j];
                            Cave.CurrentRockford = tiles[i, j];
                            break;
                        case 'D':
                            tiles[i, j] = new EmptyTIle();
                            tiles[i, j].Entity = new Diamond();
                            break;
                        case 'F':
                            tiles[i, j] = new EmptyTIle();
                            tiles[i, j].Entity = new Firefly();
                            break;
                        case ' ':
                            tiles[i, j] = new EmptyTIle();
                            break;
                        case 'W':
                            tiles[i, j] = new Wall();
                            break;
                        case 'H':
                            tiles[i, j] = new HardenedMud();
                            break;
                        case 'T':
                            tiles[i, j] = new EmptyTIle();
                            tiles[i, j].Entity = new TNT();
                            break;
                        case 'E':
                            tiles[i, j] = new Exit();
                            break;
                    }
                    if (Cave.First == null)
                    {
                        Cave.First = tiles[i, j];
                    }
                }
            }

            for (int i = 0; i < Level1.GetLength(0); i++)
            {
                for (int j = 0; j < Level1.GetLength(1); j++)
                {
                    if (i - 1 > -1)
                    {
                        tiles[i, j].Above = tiles[i - 1, j];
                    }
                    if (i + 1 < Level1.GetLength(0))
                    {
                        tiles[i, j].Below = tiles[i + 1, j];
                    }
                    if (j - 1 > -1)
                    {
                        tiles[i, j].Left = tiles[i, j - 1];
                    }
                    if (j + 1 < Level1.GetLength(1))
                    {
                        tiles[i, j].Right = tiles[i, j + 1];
                    }
                }
            }
        }
    }
}
