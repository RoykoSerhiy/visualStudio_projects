using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
delegate void MenuCallBack();
namespace rapid_roll_double2
{
    
    class MenuItem
    {
        public MenuCallBack MC{set;get;}
        public string Text { set; get; }

        public MenuItem(string txt , MenuCallBack mc)
            {
               MC= mc;
               Text = txt;
            }

    }
    class Menu
    {
        ArrayList menu = new ArrayList();

        public void Add(string str, MenuCallBack mc)
        {
            menu.Add(new MenuItem(str, mc));
        }
        public void Show()
        {
            for (int i = 0; i < menu.Count; ++i)
            {
                MenuItem item = menu[i] as MenuItem;
                Console.WriteLine(item.Text);
            }
        }
        public void Run()
        {
            try
            {
                Console.Write("Please enter choise: ");
                int choise = Int32.Parse(Console.ReadLine());

                if (choise >= 1 && choise <= menu.Count)
                {
                    MenuItem mItem = menu[choise - 1] as MenuItem;
                    mItem.MC.Invoke();
                }
            }
            catch (Exception ex)
            {
                
                Console.WriteLine(ex.Message);
                
                Run();
            }
        }
    }


    class Program
    {
        static int lives = 9;
        static int sllep = 200;
        static bool is_pause;
        static bool is_exit = false;
        static string dif_status = "Easy";
        static int x = 20;
        static int y = 20;
        static string ball_custom = "☻";
        static string wall_custom = "-----";


        public class Ball
        {
            public int lives;
            public int ball_x;
            public int ball_y;
            public string logo;
            public int score;
            
            
            public Ball(int x, int y)
            {
                ball_x = x;
                ball_y = y;
                lives = 1;
                logo = "☻";
                score = 0;
            }
            public string GetSym
            {
                get { return logo; }
                set { logo = value; }
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
            public int Lives
            {
                get { return lives; }
                set { lives = value; }
            }
            public void MoveRight()
            {
                if (ball_y > 18)
                {
                    ball_y = 18;
                }
                else
                {
                    ball_y++;
                }
                
            }
            public void MoveLeft()
            {
                if (ball_y < 1)
                {
                    ball_y = 1;
                }
                else
                {
                    ball_y--;
                }
                
            }
            public void MoveUp()
            {
                if (ball_x < 1)
                {
                    ball_x = 5;
                    ball_y = 5;
                    lives--;
                }
                else
                {
                    ball_x--;
                }
                
            }
            public void MoveDown()
            {
                if (ball_x > 18)
                {
                    ball_x = 4;
                    ball_y = 8;
                    lives--;
                }
                else
                {
                    ball_x++;
                    
                    score += 2;
                }
                
            }
            
        }
        public class Wall
        {
            public int wall_x;
            public int wall_y;
            public string sym;
          
            public Wall()
            {
                wall_x = 10;
                wall_y = 10;
                sym = "-----";
            }
            public Wall(int x, int y)
            {
                wall_x = x;
                wall_y = y;
                sym = "-----";
                
            }
            public string GetSym
            {
                get { return sym; }
                set { sym = value; }
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
           
            public void MoveWall()
            {
                if (wall_x < 2)
                {
                    Random rnd = new Random();

                    wall_x = 18;
                    wall_y = rnd.Next(1, 15);


                }
                else
                {
                    wall_x--;

                }
                
            }
        }
        public class Field
        {

            public Ball ball = new Ball(4, 9);
            
            public List<Wall> wall = new List<Wall>();

            public string[,] f = new string[x, y];

            public Field(int x, int y)
            {
                
                wall.Add(new Wall(1, 3));
                wall.Add(new Wall(5, 2));
                wall.Add(new Wall(9, 9));
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {
                        f[ball.X, ball.Y] = ball.GetSym;
                        //foreach (Wall w in wall)
                        //{
                        //    f[w.X, w.Y] = w.GetSym();
                        //}
                        f[wall[0].X, wall[0].Y] = wall[0].GetSym;
                        f[wall[1].X, wall[1].Y] = wall[1].GetSym;
                        f[wall[2].X, wall[2].Y] = wall[2].GetSym;
                        f[0, j] = "♦";
                        f[19, j] = "♦";
                        f[j, 0] = "▌";
                        f[j, 19] = "▐";
                        f[i, j] = " ";
                        
                        
                    }

                }
            }
            //int l;
            public void Update()
            {

                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {
                        f[ball.X, ball.Y] = ball.GetSym;
                        f[wall[0].X, wall[0].Y] = wall[0].GetSym;
                        f[wall[1].X, wall[1].Y] = wall[1].GetSym;
                        f[wall[2].X, wall[2].Y] = wall[2].GetSym;
                        f[i, j] = " ";
                        f[0, j] = "♦";
                        f[19, j] = "♦";
                        f[j, 0] = "▌";
                        f[j, 19] = "▌";
                        


                    }

                }
                
            }
            public void Show()
            {
                
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
                Console.WriteLine("Dificulty: " + dif_status);
                Console.WriteLine("M - pause");
                //Console.WriteLine("lentgh = " + Convert.ToString(l));
                //Console.Clear();
            }
        }
        static void Main(string[] args)
        {
            Menu();
        }
        static void Game()
        {
            try
            {
                Console.Clear();
                is_pause = false;
                
                Field f = new Field(x, y);
                f.ball.Lives = lives;
                f.ball.GetSym = ball_custom;
                f.wall[0].GetSym = wall_custom;
                f.wall[1].GetSym = wall_custom;
                f.wall[2].GetSym = wall_custom;
               // int choise = 0;
                bool is_up = false;
                Menu menu = new Menu();
                Console.WriteLine("Press any key!!!");
                ConsoleKeyInfo cki = new ConsoleKeyInfo();
                cki = Console.ReadKey(true);
                do
                {
                    Console.SetCursorPosition(0, 0);

                    if (Console.KeyAvailable == true)
                    {

                        cki = Console.ReadKey(true);
                        if (cki.Key == ConsoleKey.LeftArrow)
                        {
                            f.ball.MoveLeft();
                        }
                        else
                            if (cki.Key == ConsoleKey.RightArrow)
                            {
                                f.ball.MoveRight();
                            }
                            else

                                if (cki.Key == ConsoleKey.M)
                                {
                                    
                                    is_pause = true;
                                    Menu();
                                    
                                }

                        if (is_exit == true)
                        {
                            break;
                        }   
                    }
                    // foreach(Wall w in f.wall)
                    // {
                    //if (f.ball.X + 1 == w.X && f.ball.Y > w.Y && f.ball.Y < w.Y + w.GetSym().Length)//&& f.ball.Y == w.Y)
                    if (f.ball.X + 1 == f.wall[0].X && f.ball.Y >= f.wall[0].Y && f.ball.Y <= f.wall[0].Y + f.wall[0].GetSym.Length
                        || f.ball.X + 1 == f.wall[1].X && f.ball.Y >= f.wall[1].Y && f.ball.Y <= f.wall[1].Y + f.wall[1].GetSym.Length
                        || f.ball.X + 1 == f.wall[2].X && f.ball.Y >= f.wall[2].Y && f.ball.Y <= f.wall[2].Y + f.wall[2].GetSym.Length)
                    {
                        is_up = true;
                    }
                    else
                    {
                        is_up = false;
                    }
                    // }
                    if (is_up == false)
                    {
                        f.ball.MoveDown();
                    }
                    else
                        if (is_up == true)
                        {
                            f.ball.MoveUp();
                        }


                    f.wall[0].MoveWall();
                    f.wall[1].MoveWall();
                    f.wall[2].MoveWall();


                    f.Update();
                    f.Show();
                    if (f.ball.lives == 0)
                    {
                        //Console.BackgroundColor = ConsoleColor.Red;
                        Console.Clear();
                        Console.WriteLine("Game Over \n your score: " + f.ball.score + "\n");
                        Console.WriteLine("Exit Game?");
                        menu.Add("1.Yes" , Exit);
                        menu.Add("2.No" , Menu);
                        menu.Show();
                        menu.Run();

                    }
                    System.Threading.Thread.Sleep(sllep);

                } while (f.ball.lives > 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Exit()
        {
           

            is_exit = true;
            
        }
        static void Continue()
        {
            if (is_pause)
            {
                Console.Clear();
            }
            else
            {
                Menu();
            }
        }
        static void About()
        {
            //int choise;
            Menu menu = new Menu();
            Console.Clear();
            Console.WriteLine("©Serhiy Roiiko Rapid Roll v1.0 beta release 14.10.2014 \n C# Engine");
            menu.Add("1.Back", Menu);
            menu.Show();
            menu.Run();
            //Console.WriteLine("1.Main Menu");
            //choise = Int32.Parse(Console.ReadLine());
            //switch (choise)
            //{
            //    
            //    case 1:
            //        {
            //            //Console.BackgroundColor = ConsoleColor.Black;
            //            Console.Clear();
            //            Menu();
            //        }
            //        break;
            //}
        }
        static void Menu()
        {
            Menu menu = new Menu();
            
            //Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            if (is_pause)
            {
                Console.WriteLine("Paused;");
            }

            
                menu.Add("[1] Start Game", Game);
                menu.Add("[2] Continue", Continue);
                menu.Add("[3] Reset", Reset);
                menu.Add("[4] Options", Options);
                menu.Add("[5] About", About);
                menu.Add("[6] Exit", Exit);
                menu.Show();
                menu.Run();
            
                
            
        }
        static void Options()
        {
            Menu menu = new Menu();
            Console.Clear();
            menu.Add("1.Dificulty", Dificulty);
            menu.Add("2.Ball Customisation" , BallCustom);
            menu.Add("3.Wall Customisation" , WallCustom);
            menu.Add("4.Background color" , BackColor);
            menu.Add("5.Foreground Color" , ForeColor);
            menu.Add("6.Back" , Menu);
            menu.Show();
            menu.Run();
        }
        static void BackColor()
        {
            try
            {
                Console.Clear();
                int choise;
                Console.WriteLine("1.Black\n2.Red\n3.Green\n4.Blue\n5.White\n0.Save and Back\n");
                choise = Convert.ToInt32(Console.ReadLine());
                switch (choise)
                {
                    case 1:
                        { Console.BackgroundColor = ConsoleColor.Black; Options(); }
                        break;
                    case 2:
                        { Console.BackgroundColor = ConsoleColor.Red; Options(); }
                        break;
                    case 3:
                        { Console.BackgroundColor = ConsoleColor.Green; Options(); }
                        break;
                    case 4:
                        { Console.BackgroundColor = ConsoleColor.Blue; Options(); }
                        break;
                    case 5:
                        { Console.BackgroundColor = ConsoleColor.White; Options(); }
                        break;
                    case 0:
                        { Options(); }
                        break;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void ForeColor()
        {
            try
            {
                Console.Clear();
                int choise;
                Console.WriteLine("1.Black\n2.Red\n3.Green\n4.Blue\n5.White\n0.Save and Back\n");
                choise = Convert.ToInt32(Console.ReadLine());
                switch (choise)
                {
                    case 1:
                        { Console.ForegroundColor = ConsoleColor.Black; Options(); }
                        break;    
                    case 2:       
                        { Console.ForegroundColor = ConsoleColor.Red; Options(); }
                        break;    
                    case 3:       
                        { Console.ForegroundColor = ConsoleColor.Green; Options(); }
                        break;    
                    case 4:       
                        { Console.ForegroundColor = ConsoleColor.Blue; Options(); }
                        break;    
                    case 5:       
                        { Console.ForegroundColor = ConsoleColor.White; Options(); }
                        break;
                    case 0:
                        { Options(); }
                        break;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Dificulty()
        {
            Menu menu = new Menu();
            Console.Clear();
            Console.WriteLine("Dificulty status: " + dif_status);
            menu.Add("1.Easy", Easy);
            menu.Add("2.Normal", Norm);
            menu.Add("3.Hard", Hard);
            menu.Add("4.Save and Back" , Options);
            menu.Show();
            menu.Run();
        }

        static void WallCustom()
        {
            try
            {
                Console.Clear();
                int choise;
                Console.WriteLine("1.-----\n2.=====\n3.─────\n4.▬▬▬▬▬\n5.♥♥♥♥♥\n0.Save and Back\n");
                choise = Convert.ToInt32(Console.ReadLine());
                switch (choise)
                {
                    case 1:
                        { wall_custom = "-----"; Options(); }
                        break;
                    case 2:
                        { wall_custom = "====="; Options(); }
                        break;
                    case 3:
                        { wall_custom = "─────"; Options(); }
                        break;
                    case 4:
                        { wall_custom = "▬▬▬▬▬"; Options(); }
                        break;
                    case 5:
                        { wall_custom = "♥♥♥♥♥"; Options(); }
                        break;
                    case 0:
                        { Options(); }
                        break;
                        
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void BallCustom()
        {
            Console.Clear();
            int choise;
            Console.WriteLine("1.☻\n2.☺\n3.©\n4.o\n5.☼\n0.Save and Back\n");
            try
            {
                choise = Convert.ToInt32(Console.ReadLine());
                switch (choise)
                {
                    case 1:
                        { ball_custom = "☻"; Options(); }
                        break;
                    case 2:
                        { ball_custom = "☺"; Options(); }
                        break;
                    case 3:
                        { ball_custom = "©"; Options(); }
                        break;
                    case 4:
                        { ball_custom = "o"; Options(); }
                        break;
                    case 5:
                        { ball_custom = "☼"; Options(); }
                        break;
                    case 0:
                        { Options();}
                        break;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Easy()
        { lives = 9; sllep = 200; dif_status = "Easy"; Console.Clear(); Dificulty(); }
        static void Norm()
        { lives = 5; sllep = 150; dif_status = "Normal"; Console.Clear(); Dificulty(); }
        static void Hard()
        { lives = 3; sllep = 100; dif_status = "Hard"; Console.Clear(); Dificulty(); }
        static void Reset()
        {
            is_pause = false;
            Console.Clear();
            Menu();
        }

    }
}
