﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace DonkeyKong
{
    class Map
    {
        Canvas canvas;
        Window mainWindow;
        public Map()
        {
            canvas = new Canvas();
            mainWindow = new Window();
            drawMap();
        }
        public void drawMap()
        {
            darwLadders();
            drawBars();

        }
        public Map(Canvas c, Window w)
        {
            canvas = c;
            mainWindow = w;
        }
        public void drawBars()
        {
            Rectangle topBar = new Rectangle();
            topBar.Width = 650;
            topBar.Height = 20;
            topBar.Fill = Brushes.Red;

            Canvas.SetTop(topBar, 75);
            Canvas.SetLeft(topBar, 0);
            canvas.Children.Add(topBar);
            //counting up from top
            Rectangle bar1 = new Rectangle();
            bar1.Width = 650;
            bar1.Height = 20;
            bar1.Fill = Brushes.Red;
            //bar1.RenderTransform = new RotateTransform(-3);
            Canvas.SetTop(bar1, 150);
            Canvas.SetLeft(bar1, 150);
            canvas.Children.Add(bar1);

            Rectangle bar2 = new Rectangle();
            bar2.Width = 650;
            bar2.Height = 20;
            bar2.Fill = Brushes.Red;
            //bar2.RenderTransform = new RotateTransform(3);
            Canvas.SetTop(bar2, 250);
           // Canvas.SetLeft(bar2, 25);
            canvas.Children.Add(bar2);

            Rectangle bar3 = new Rectangle();
            bar3.Width = 650;
            bar3.Height = 20;
            bar3.Fill = Brushes.Red;
            //bar3.RenderTransform = new RotateTransform(-3);
            Canvas.SetTop(bar3, 400);
            Canvas.SetLeft(bar3, 150);
            canvas.Children.Add(bar3);

            Rectangle bar4 = new Rectangle();
            bar4.Width = 650;
            bar4.Height = 20;
            bar4.Fill = Brushes.Red;
            //bar4.RenderTransform = new RotateTransform(3);
            Canvas.SetTop(bar4, 500);
            
            canvas.Children.Add(bar4);

            Rectangle bottomBar = new Rectangle();
            bottomBar.Width = 800;
            bottomBar.Height = 20;
            bottomBar.Fill = Brushes.Red;
            Canvas.SetTop(bottomBar, 640);
            Canvas.SetLeft(bottomBar, 0);
            canvas.Children.Add(bottomBar);
        }
        public void darwLadders()
        {
            Rectangle ladder1 = new Rectangle();
            ladder1.Width = 40;
            ladder1.Height = 150;
            ladder1.Fill = Brushes.Salmon;
            Canvas.SetTop(ladder1, 500);
            Canvas.SetLeft(ladder1, 585);
            canvas.Children.Add(ladder1);

            Rectangle ladder2 = new Rectangle();
            ladder2.Width = 40;
            ladder2.Height = 120;
            ladder2.Fill = Brushes.Salmon;
            Canvas.SetTop(ladder2, 400);
            Canvas.SetLeft(ladder2, 275);
            canvas.Children.Add(ladder2);

            Rectangle ladder3 = new Rectangle();
            ladder3.Width = 40;
            ladder3.Height = 150;
            ladder3.Fill = Brushes.Salmon;
            Canvas.SetTop(ladder3, 250);
            Canvas.SetLeft(ladder3, 410);
            canvas.Children.Add(ladder3);

            Rectangle ladder4 = new Rectangle();
            ladder4.Width = 40;
            ladder4.Height = 150;
            ladder4.Fill = Brushes.Salmon;
            Canvas.SetTop(ladder4, 250);
            Canvas.SetLeft(ladder4, 610);
            canvas.Children.Add(ladder4);

            Rectangle ladder5 = new Rectangle();
            ladder5.Width = 40;
            ladder5.Height = 100;
            ladder5.Fill = Brushes.Salmon;
            Canvas.SetTop(ladder5, 150);
            Canvas.SetLeft(ladder5, 450);
            canvas.Children.Add(ladder5);

            Rectangle ladder6 = new Rectangle();
            ladder6.Width = 40;
            ladder6.Height = 100;
            ladder6.Fill = Brushes.Salmon;
            Canvas.SetTop(ladder6, 150);
            Canvas.SetLeft(ladder6, 150);
            canvas.Children.Add(ladder6);

            Rectangle ladder7 = new Rectangle();
            ladder7.Width = 40;
            ladder7.Height = 77;
            ladder7.Fill = Brushes.Salmon;
            Canvas.SetTop(ladder7, 75);
            Canvas.SetLeft(ladder7, 610);
            canvas.Children.Add(ladder7);
        }
    }
}
