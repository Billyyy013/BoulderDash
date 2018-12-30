using System;
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

        public bool ExitOpen { get; set; }

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

        public void BuildMaze1()
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
                            Boulder boulder = new Boulder();
                            tiles[i, j].Entity = boulder;
                            Cave.Boulders.Add(boulder);
                            boulder.Tile = tiles[i, j];
                            break;
                        case 'R':
                            tiles[i, j] = new EmptyTIle();
                            tiles[i, j].Entity = Cave.Rockford;
                            Cave.Rockford.Tile = tiles[i, j];
                            break;
                        case 'D':
                            tiles[i, j] = new EmptyTIle();
                            Diamond diamond = new Diamond();
                            tiles[i, j].Entity = diamond;
                            Cave.Diamonds.Add(diamond);
                            diamond.Tile = tiles[i, j];
                            break;
                        case 'F':
                            tiles[i, j] = new EmptyTIle();
                            Firefly firefly = new Firefly();
                            tiles[i, j].Entity = firefly;
                            Cave.Fireflys.Add(firefly);
                            firefly.Tile = tiles[i,j];
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
                            TNT t = new TNT();
                            tiles[i, j].Entity = t;
                            t.Tile = tiles[i, j];
                            break;
                        case 'E':
                            Exit exit = new Exit();
                            tiles[i, j] = exit;
                            this.ExitOpen = exit.IsOpen;
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

        public void BuildMaze2()
        {
            Cave = new Cave();
            Tile[,] tiles2 = new Tile[Level2.GetLength(0), Level2.GetLength(1)];

            for (int i = 0; i < Level2.GetLength(0); i++)
            {
                for (int j = 0; j < Level2.GetLength(1); j++)
                {
                    switch (Level2[i, j])
                    {
                        case 'S':
                            tiles2[i, j] = new Steelwall();
                            break;
                        case 'M':
                            tiles2[i, j] = new Mud();
                            break;
                        case 'B':
                            tiles2[i, j] = new EmptyTIle();
                            Boulder boulder = new Boulder();
                            tiles2[i, j].Entity = boulder;
                            Cave.Boulders.Add(boulder);
                            boulder.Tile = tiles2[i, j];
                            break;
                        case 'R':
                            tiles2[i, j] = new EmptyTIle();
                            tiles2[i, j].Entity = Cave.Rockford;
                            Cave.Rockford.Tile = tiles2[i, j];
                            break;
                        case 'D':
                            tiles2[i, j] = new EmptyTIle();
                            Diamond diamond = new Diamond();
                            tiles2[i, j].Entity = diamond;
                            Cave.Diamonds.Add(diamond);
                            diamond.Tile = tiles2[i, j];
                            break;
                        case 'F':
                            tiles2[i, j] = new EmptyTIle();
                            Firefly firefly = new Firefly();
                            tiles2[i, j].Entity = firefly;
                            Cave.Fireflys.Add(firefly);
                            firefly.Tile = tiles2[i, j];
                            break;
                        case ' ':
                            tiles2[i, j] = new EmptyTIle();
                            break;
                        case 'W':
                            tiles2[i, j] = new Wall();
                            break;
                        case 'H':
                            tiles2[i, j] = new HardenedMud();
                            break;
                        case 'T':
                            tiles2[i, j] = new EmptyTIle();
                            TNT t = new TNT();
                            tiles2[i, j].Entity = t;
                            t.Tile = tiles2[i, j];
                            break;
                        case 'E':
                            Exit exit = new Exit();
                            tiles2[i, j] = exit;
                            this.ExitOpen = exit.IsOpen;
                            break;
                    }
                    if (Cave.First == null)
                    {
                        Cave.First = tiles2[i, j];
                    }
                }
            }

            for (int i = 0; i < Level2.GetLength(0); i++)
            {
                for (int j = 0; j < Level2.GetLength(1); j++)
                {
                    if (i - 1 > -1)
                    {
                        tiles2[i, j].Above = tiles2[i - 1, j];
                    }
                    if (i + 1 < Level1.GetLength(0))
                    {
                        tiles2[i, j].Below = tiles2[i + 1, j];
                    }
                    if (j - 1 > -1)
                    {
                        tiles2[i, j].Left = tiles2[i, j - 1];
                    }
                    if (j + 1 < Level1.GetLength(1))
                    {
                        tiles2[i, j].Right = tiles2[i, j + 1];
                    }
                }
            }
        }

        public void BuildMaze3()
        {
            Cave = new Cave();
            Tile[,] tiles3 = new Tile[Level3.GetLength(0), Level3.GetLength(1)];

            for (int i = 0; i < Level3.GetLength(0); i++)
            {
                for (int j = 0; j < Level3.GetLength(1); j++)
                {
                    switch (Level3[i, j])
                    {
                        case 'S':
                            tiles3[i, j] = new Steelwall();
                            break;
                        case 'M':
                            tiles3[i, j] = new Mud();
                            break;
                        case 'B':
                            tiles3[i, j] = new EmptyTIle();
                            Boulder boulder = new Boulder();
                            tiles3[i, j].Entity = boulder;
                            Cave.Boulders.Add(boulder);
                            boulder.Tile = tiles3[i, j];
                            break;
                        case 'R':
                            tiles3[i, j] = new EmptyTIle();
                            tiles3[i, j].Entity = Cave.Rockford;
                            Cave.Rockford.Tile = tiles3[i, j];
                            break;
                        case 'D':
                            tiles3[i, j] = new EmptyTIle();
                            Diamond diamond = new Diamond();
                            tiles3[i, j].Entity = diamond;
                            Cave.Diamonds.Add(diamond);
                            diamond.Tile = tiles3[i, j];
                            break;
                        case 'F':
                            tiles3[i, j] = new EmptyTIle();
                            Firefly firefly = new Firefly();
                            tiles3[i, j].Entity = firefly;
                            Cave.Fireflys.Add(firefly);
                            firefly.Tile = tiles3[i, j];
                            break;
                        case ' ':
                            tiles3[i, j] = new EmptyTIle();
                            break;
                        case 'W':
                            tiles3[i, j] = new Wall();
                            break;
                        case 'H':
                            tiles3[i, j] = new HardenedMud();
                            break;
                        case 'T':
                            tiles3[i, j] = new EmptyTIle();
                            TNT t = new TNT();
                            tiles3[i, j].Entity = t;
                            t.Tile = tiles3[i, j];
                            break;
                        case 'E':
                            Exit exit = new Exit();
                            tiles3[i, j] = exit;
                            this.ExitOpen = exit.IsOpen;
                            break;
                    }
                    if (Cave.First == null)
                    {
                        Cave.First = tiles3[i, j];
                    }
                }
            }

            for (int i = 0; i < Level3.GetLength(0); i++)
            {
                for (int j = 0; j < Level3.GetLength(1); j++)
                {
                    if (i - 1 > -1)
                    {
                        tiles3[i, j].Above = tiles3[i - 1, j];
                    }
                    if (i + 1 < Level1.GetLength(0))
                    {
                        tiles3[i, j].Below = tiles3[i + 1, j];
                    }
                    if (j - 1 > -1)
                    {
                        tiles3[i, j].Left = tiles3[i, j - 1];
                    }
                    if (j + 1 < Level1.GetLength(1))
                    {
                        tiles3[i, j].Right = tiles3[i, j + 1];
                    }
                }
            }
        }
    }
}
