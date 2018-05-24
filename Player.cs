﻿using System;
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
        int y_vel = 0;
        Window window;
        Canvas canvas;
        bool playerisgenerated = false;

        Point point = new Point(700, 80);

        public Player(Window w, Canvas c)
        {
            window = w;
            canvas = c;
        }
        public void move()
        {
            if (point.X > 25 && point.X < 730)
            {
                Console.WriteLine(point.X + ", " + point.Y);
                if (point.Y > 525)
                {
                    if (Keyboard.IsKeyDown(Key.Left))
                    {
                        point.X -= 5;
                    }
                    if (Keyboard.IsKeyDown(Key.Right))
                    {
                        point.X += 5;
                    }
                }
                else if (point.X <= 750 && point.X >= 149 && point.Y + 50 <= 193 && point.Y + 50 >= 139)
                {
                    if (point.Y + 50 >= -0.05 * (point.X) + 172 && point.Y + 50 <= point.X + 176)
                    {
                        if (Keyboard.IsKeyDown(Key.Left))
                        {
                            point.X -= 4.75;
                            point.Y += 0.25;
                        }
                        if (Keyboard.IsKeyDown(Key.Right))
                        {
                            point.X += 4.75;
                            point.Y -= 0.25;
                        }
                    }
                }
                else if (point.X <= 624 && point.X >= 22 && point.Y + 50 <= 301 && point.Y + 50 >= 245)
                {
                    if (point.Y + 50 >= 0.05 * (point.X) + 245 && point.Y + 50 <= 0.05 * (point.X) + 249)
                    {
                        if (Keyboard.IsKeyDown(Key.Left))
                        {
                            point.X -= 4.75;
                            point.Y -= 0.25;
                        }
                        if (Keyboard.IsKeyDown(Key.Right))
                        {
                            point.X += 4.75;
                            point.Y += 0.25;
                        }
                    }
                }
                else if (point.X <= 750 && point.X >= 149 && point.Y + 50 <= 421 && point.Y + 50 >= 367)
                {
                    if (point.Y + 50 >= -0.05 * (point.X) + 398 && point.Y + 50 <= 0.05 * (point.X) + 402)
                    {
                        if (Keyboard.IsKeyDown(Key.Left))
                        {
                            point.X -= 4.75;
                            point.Y += 0.25;
                        }
                        if (Keyboard.IsKeyDown(Key.Right))
                        {
                            point.X += 4.75;
                            point.Y -= 0.25;
                        }
                    }
                }
                else if (point.X <= 624 && point.X >= 22 && point.Y + 50 <= 551 && point.Y + 50 >= 496)
                {
                    if (point.Y + 50 >= 0.05 * (point.X) + 496 && point.Y + 50 <= 0.05 * (point.X) + 500)
                    {
                        if (Keyboard.IsKeyDown(Key.Left))
                        {
                            point.X -= 4.75;
                            point.Y -= 0.25;
                        }
                        if (Keyboard.IsKeyDown(Key.Right))
                        {
                            point.X += 4.75;
                            point.Y += 0.25;
                        }
                    }
                }
               
                else
                {
                    if (Keyboard.IsKeyDown(Key.Left))
                    {
                        point.X -= 1;
                    }
                    if (Keyboard.IsKeyDown(Key.Right))
                    {
                        point.X += 1;

                    }
                }

                
            }
        }
        public void jump()
        {
            //checks if up arrow is pressed, and if player is not currently falling
            if (Keyboard.IsKeyDown(Key.Up) && y_vel == 0)
            {
                y_vel -= 10;
                point.Y += y_vel;
                Console.WriteLine(y_vel);

            }
        }
        public void fall()
        {

            if (point.Y == 590)
            {
                y_vel = 0;
                Console.WriteLine("in sector 0");
            }
            else if (point.Y > 590)
            {
                point.Y = 590;
                y_vel = 0;
                Console.WriteLine("in sector 0");
            }
            else if (point.X <= 750 && point.X >= 149 && point.Y + 50 <= 193 && point.Y + 50 >= 139)
            {
                if (point.Y + 50 >= -0.05 * (point.X) + 172 && point.Y + 50 <= point.X + 176)
                {
                    y_vel = 0;
                    Console.WriteLine("in sector 1");
                }
                else
                {
                    y_vel += 3;
                    Console.WriteLine("falling");
                }
            }
            //second from top
            else if (point.X <= 624 && point.X >= 22 && point.Y + 50 <= 301 && point.Y + 50 >= 245)
            {
                if (point.Y + 50 >= 0.05 * (point.X) + 245 && point.Y + 50 <= 0.05 * (point.X) + 249)
                {
                    y_vel = 0;

                    Console.WriteLine("in sector 2");
                }
                else
                {
                    y_vel += 3;
                    Console.WriteLine("falling");
                }
            }
            //second from bottom
            else if (point.X <= 750 && point.X >= 149 && point.Y + 50 <= 421 && point.X + 50 >= 365)
            {
                if (point.Y + 50 >= -0.05 * (point.X) + 398 && point.Y + 50 <= 0.05 * (point.X) + 402)
                {
                    y_vel = 0;
                    Console.WriteLine("in sector 3");
                }
                else
                {
                    y_vel += 3;
                    Console.WriteLine("falling");
                }
            }
            //lowest angled bar
            else if (point.X <= 624 && point.X >= 22 && point.Y + 50 <= 551 && point.Y + 50 >= 496)
            {
                if (point.Y + 50 >= 0.05 * (point.X) + 496 && point.Y + 50 <= 0.05 * (point.X) + 500)
                {
                    y_vel = 0;
                    Console.WriteLine("in sector 4");
                }
                else
                {
                    y_vel += 3;
                    Console.WriteLine("falling");
                }
            }
            else
            {
                y_vel = 3;
                Console.WriteLine("falling");
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
