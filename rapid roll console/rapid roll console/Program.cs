using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rapid_roll_console
{
    
   
    class Program
    {
        static int x = 20;
        static int y = 20;
        public class Ball
        {
           public int lives;
           public int ball_x;
           public int ball_y;
           public bool _isDead;
           public string logo;
           public int score;

            public Ball(int x , int y)
            {
                ball_x = x;
                ball_y = y;
                lives = 9;
                _isDead = false;
                logo = "☻";
                score = 0;
            }
            public string GetSym()
            {
                return logo;
            }
            public int X
            {
                get { return ball_x; }
                set { ball_x = value; }
            }
            public int Y
            {
                get { return ball_y; }
                set { ball_y = value; }
            }
        }
        public class Wall
        {
            public int wall_x;
            public int wall_y;
            public string sym;

            public Wall(int x, int y)
            {
                wall_x = x;
                wall_y = y;
                sym = "----";
            }
            public string GetSym()
            {
                return sym;
            }
            public int X
            {
                get { return wall_x; }
                set { wall_x = value; }
            }
            public int Y
            {
                get { return wall_y; }
                set { wall_y = value; }
            }
        }
         public class Field
        {
              
           public  Ball ball = new Ball(4 , 9);
           public List<Wall> wall = new List<Wall>();
             
           public string[ , ] f = new string [x, y];
           
            public Field(int x, int y)
            {
                //int x_b = ball.GetX();
               // wall[0] = new Wall(1, 3);
               // wall[1] = new Wall(5, 2);
               // wall[2] = new Wall(10, 10);
               wall.Add(new Wall(1 , 3));
                wall.Add(new Wall(5 , 2));
                wall.Add(new Wall(10 , 10));
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {
                        f[i, j] = " ";
                        f[0, j] = "♦";
                        f[19, j] = "♦";
                        f[j, 0] = "▌";
                        f[j, 19] = "▐";
                       f[ball.X, ball.Y] = ball.GetSym();
                       foreach (Wall w in wall)
                       {
                           f[w.X, w.Y] = w.GetSym();
                       }
                    }

                }
            }
           
            public void Show()
            {
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {

                        f[i, j] = " ";
                        f[0, j] = "♦";
                        f[19, j] = "♦";
                        f[j, 0] = "▌";
                        f[j, 19] = "▌";
                        f[ball.X, ball.Y] = ball.GetSym();
                        foreach (Wall w in wall)
                        {
                            f[w.X, w.Y] = w.GetSym();
                        }


                    }

                }
            
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {
                        Console.Write(f[i, j]);
                        
                    }
                    Console.WriteLine();
                    
                }
                Console.WriteLine("Lives: " + ball.lives);
                Console.WriteLine("Score: " + ball.score);
                //Console.Clear();
            }
            //public void Update()
            //{
            //    
            //
            //    //int x_b = ball.GetX();
            //    for (int i = 0; i < x; i++)
            //    {
            //        for (int j = 0; j < y; j++)
            //        {
            //            
            //                f[i, j] = " ";
            //                f[0, j] = "♦";
            //                f[19, j] = "♦";
            //                f[j, 0] = "▌";
            //                f[j, 19] = "▌";
            //                f[ball.X, ball.Y] = ball.GetSym();
            //                for (int k = 0; k <= 3; ++k)
            //                {
            //                    f[wall[k].X, wall[k].Y] = wall[k].GetSym();
            //                    //f[wall[0].X, wall[0].Y] = wall[0].GetSym();
            //                    //f[wall[1].X, wall[1].Y] = wall[1].GetSym();
            //                    //f[wall[2].X, wall[2].Y] = wall[2].GetSym();
            //                }
            //            
            //            
            //        }
            //
            //    }
            //
            //}
            public void MoveLeft()
            {
                if (ball.Y <= 1)
                {
                    ball.Y = 1;
                }
                else
                    if (ball.Y >= 18)
                    {
                        ball.Y = 18;
                    }
                else
                        if (ball.Y >= 1 || ball.Y <= 18)
                        {
                            f[ball.X, ball.Y] = " ";
                            ball.Y--;
                            //f[ball.X, ball.Y++] = " ";
                            f[ball.X, ball.Y] = ball.GetSym();
                        }
            }
            public void MoveRight()
            {
                 if (ball.Y <= 1)
                {
                    ball.Y = 1;
                }
                else
                    if (ball.Y >= 18)
                    {
                        ball.Y = 18;
                    }
                else
                        if (ball.Y >= 1 || ball.Y <= 18)
                        {
                            f[ball.X, ball.Y] = " ";
                            ball.Y++;
                            //f[ball.X, ball.Y++] = " ";
                            f[ball.X, ball.Y] = ball.GetSym();
                        }
            }
            //public int MoveUp_Down()
            //{
            //    if (ball.X <= 1)
            //    {
            //        ball.lives -= 1;
            //        ball.X = 4;
            //        ball.Y = 9;
            //        //return ball.lives;
            //    }
            //    else
            //        if (ball.X >= 18)
            //        {
            //            ball.lives -= 1;
            //            ball.X = 4;
            //            ball.Y = 9;
            //            //return ball.lives;
            //        }
            //    if (ball.X  != wall[0].X || ball.X  != wall[1].X || ball.X != wall[2].X)
            //    {
            //        ball.X++;
            //        ball.score += 2;
            //    }
            //    else
            //    {
            //        ball.X--;
            //    }
            //    return ball.lives;
            //}
            public int MoveWall()
            {
                foreach(Wall w in wall)
                {
                    if (w.X < 1)
                    {
                        Random rnd = new Random();

                        w.X = 18;
                        w.Y = rnd.Next(1, 15);

                      
                    }
                    else
                    {
                        w.X--;
                        
                    }
                }
                if (ball.X < 1)
                {
                    ball.lives--;
                    ball.X = 2;
                    ball.Y = 10;
                    //return ball.lives;
                }
                else
                    if (ball.X > 18)
                    {
                        ball.lives--;
                        ball.X = 2;
                        ball.Y = 10;
                        //return ball.lives;
                    }
                if (ball.X != wall[0].X || ball.X != wall[1].X || ball.X != wall[2].X || ball.X != wall[3].X)
                {
                    ball.X++;
                    ball.score += 2;
                }
                else
                {
                    ball.X--;
                }
                ball.X++;
                return ball.lives;    
            }
               
        }
        static void Main(string[] args)
        {
            try
            {
               // bool game_over = false;
                ConsoleKeyInfo cki = new ConsoleKeyInfo();
                cki = Console.ReadKey(true);

                
                    Field field = new Field(20, 20);
                    if (Console.KeyAvailable)
                    {
                        if (cki.Key == ConsoleKey.LeftArrow)
                        {
                            //field.MoveWall();
                            field.MoveLeft();
                           // field.Update();
                           // field.Show();

                        }
                        else
                            if (cki.Key == ConsoleKey.RightArrow)
                            {
                                //field.MoveWall();
                                field.MoveRight();
                                //field.Update();
                                //field.Show();


                            }
                    }

                    while (field.MoveWall() > 0)
                    {


                        //Console.SetCursorPosition(0, 0);
                        if (field.MoveWall() > 0)
                        {
                            field.MoveWall();
                            
                        }
                        else
                        {
                            Console.WriteLine("Game over your result: " + (field.ball.score).ToString());
                            break;

                        }
                        
                        //field.MoveWall();
                        
                        System.Threading.Thread.Sleep(300);
                        //field.Update();
                        field.Show();
                    }
                    
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
