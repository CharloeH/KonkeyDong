using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Drawing;

namespace DonkeyKong
{
    class Player
    {
        DispatcherTimer GameTimer = new DispatcherTimer();

        int y_vel = 0;
        Window window;
        Canvas canvas;

        Point point = new Point(0, 0);

        public Player(Window w, Canvas c)
        {
            window = w;
            canvas = c;
        }
        public void move()
        {
            if (Keyboard.IsKeyDown(Key.D) || Keyboard.IsKeyDown(Key.Right) & point.X < 760)
            {
                point.X += 10;
            }
            if (Keyboard.IsKeyDown(Key.A) || Keyboard.IsKeyDown(Key.Left) & point.X > 0)
            {
                point.X -= 10;
            }
        }
        public void jump()
        {
            if (Keyboard.IsKeyDown(Key.Space) || Keyboard.IsKeyDown(Key.Up) & y_vel == 0)
            {

                point.Y -= 20;
                point.Y += y_vel;


                Console.WriteLine("postion: " + point.Y);

            }
        }
        public void fall()
        {

           


            
            if (point.X <= 800 & point.X >= 650)
            {
                Console.WriteLine(point.Y);
                if (point.Y < 100)
                {
                    y_vel += 3;
                    Console.WriteLine("sector 1");

                }
                if (point.Y > 100 & point.Y < 150)
                {
                    point.Y = 100;
                    y_vel = 0;
                }
            }
            if (point.X <= 150 & point.X >= 0 & point.Y >= 100 & point.Y <= 300)
            {
                Console.WriteLine(point.Y);
                if (point.Y < 200)
                {
                    
                    y_vel += 3;
                    Console.WriteLine("sector 2");
                }

                if (point.Y > 200)
                {
                    point.Y = 200;
                    y_vel = 0;
                }
            }
            if (point.X <= 800 & point.X >= 650 & point.Y >= 170 & point.Y <= 400 )
            {
                Console.WriteLine(point.Y);
                if (point.Y < 350)
                {
                    Console.WriteLine("sector 3");
                    y_vel += 3;
                }
                if (point.Y > 350)
                {
                    point.Y = 350;
                    y_vel = 0;
                }
            }
            if (point.X <= 150 & point.X >= 0 & point.Y >= 350 & point.Y <= 500)
            {
                Console.WriteLine(point.Y);
                if (point.Y < 450)
                {
                    Console.WriteLine("sector 3");
                    y_vel += 3;
                }

                if (point.Y > 450)
                {
                    point.Y = 450;
                    y_vel = 0;
                }

            }
            if(point.X <= 800 & point.X >= 650 & point.Y >= 400)
            {
                if(point.Y < 600)
                {
                    y_vel += 3;
                }
                if(point.Y > 600)
                {
                    point.Y = 600;
                    y_vel = 0;
                }
            }
            point.Y += y_vel;
        }



        




        public void climb()
        {

        }
        public void collide()
        {

        }
        public void update(Rectangle player_sprite)
        //moves player sprite to current position
        {
            Canvas.SetLeft(player_sprite, point.X);
            Canvas.SetTop(player_sprite, point.Y);
        }
        public void generate(Rectangle player_sprite)
        {
            //generates player sprite.
            player_sprite.Width = 25;
            player_sprite.Height = 50;
            player_sprite.Fill = Brushes.White;
            //player_sprite.Fill = image;
            Canvas.SetLeft(player_sprite, point.X);
            Canvas.SetTop(player_sprite, point.Y);
        }


    }
}

