using System;
using System.Drawing;
using System.Windows;
using System.Windows.Forms;
using System.Threading;


namespace Animator.Utils
{
    internal class AnimatorModule
    {
        public enum AnimationStyle
        {
            FadeIn = 0,
            FadeOut = 1,
            SlideLeft = 2,
            SlideRight = 3,
            SlideTop = 4,
            SlideBottom = 5,
        }

        /// <summary>
        /// Displays the specificed form with the specificed animation style.
        /// </summary>
        /// <example>
        /// <code>
        /// AnimatorModule animator = new AnimatorModule();
        /// animator.ShowAnimation(new Form1(), AnimatorModule.AnimationStyle.FadeOut);
        /// </code>
        /// </example>
        /// <param name="style"> Animation style used to display current form.</param>
        /// <param name="form"> Form wanted to be displayed with animation.</param>
        public void ShowAnimation(Form form, AnimationStyle style)
        {
            if (style == AnimationStyle.FadeIn)
            {
                form.Opacity = 0.5;
                form.Show();
                form.Refresh();
                for (double i = 0.5; i <= 1; i += 0.1)
                {
                    form.Opacity = i;
                    Thread.Sleep(10);
                }
            }
            else if (style == AnimationStyle.FadeOut)
            {
                form.Opacity = 1;
                form.Refresh();
                for (double i = 1; i >= 0; i -= 0.1)
                {
                    form.Opacity = i;
                    Thread.Sleep(10);
                }
                form.Hide();
            }
            else if (style == AnimationStyle.SlideLeft)
            {
                form.Show();
                form.Refresh();
                Point oldlocation = form.Location;
                int x = oldlocation.X;
                int y = oldlocation.Y;
                for (int nx = x + 15; nx >= x; nx -= 1)
                {
                    form.Location = new Point(nx, y);
                    Thread.Sleep(10);
                }
            }
            else if (style == AnimationStyle.SlideRight)
            {
                form.Show();
                form.Refresh();
                Point oldlocation = form.Location;
                int x = oldlocation.X;
                int y = oldlocation.Y;
                for (int nx = x - 15; nx <= x; nx += 1)
                {
                    form.Location = new Point(nx, y);
                    Thread.Sleep(10);
                }
            }
            else if (style == AnimationStyle.SlideTop)
            {
                form.Show();
                form.Refresh();
                Point oldlocation = form.Location;
                int x = oldlocation.X;
                int y = oldlocation.Y;
                for (int ny = y + 15; ny >= y; ny -= 1)
                {
                    form.Location = new Point(x, ny);
                    Thread.Sleep(10);
                }
            }
            else if (style == AnimationStyle.SlideBottom)
            {
                form.Show();
                form.Refresh();
                Point oldlocation = form.Location;
                int x = oldlocation.X;
                int y = oldlocation.Y;
                for (int ny = y - 15; ny <= y; ny += 1)
                {
                    form.Location = new Point(x, ny);
                    Thread.Sleep(10);
                }
            }
        }


        /// <summary>
        /// Displays the specificed form with the specificed animation style.
        /// </summary>
        /// <example>
        /// <code>
        /// AnimatorModule animator = new AnimatorModule();
        /// animator.ShowAnimation(new Form1(), AnimatorModule.AnimationStyle.FadeOut);
        /// </code>
        /// </example>
        /// <param name="style"> Animation style used to display current form.</param>
        /// <param name="form"> Form wanted to be displayed with animation.</param>
        /// <param name="speed_ms"> Speed of the animation display (ms).</param>
        public void ShowAnimation(Form form, AnimationStyle style, int speed_ms)
        {
            if (style == AnimationStyle.FadeIn)
            {
                form.Opacity = 0.5;
                form.Show();
                form.Refresh();
                for (double i = 0.5; i <= 1; i += 0.1)
                {
                    form.Opacity = i;
                    Thread.Sleep(speed_ms);
                }
            }
            else if (style == AnimationStyle.FadeOut)
            {
                form.Opacity = 1;
                form.Refresh();
                for (double i = 1; i >= 0; i -= 0.1)
                {
                    form.Opacity = i;
                    Thread.Sleep(speed_ms);
                }
                form.Hide();
            }
            else if (style == AnimationStyle.SlideLeft)
            {
                form.Show();
                form.Refresh();
                Point oldlocation = form.Location;
                int x = oldlocation.X;
                int y = oldlocation.Y;
                for (int nx = x + 15; nx >= x; nx -= 1)
                {
                    form.Location = new Point(nx, y);
                    Thread.Sleep(speed_ms);
                }
            }
            else if (style == AnimationStyle.SlideRight)
            {
                form.Show();
                form.Refresh();
                Point oldlocation = form.Location;
                int x = oldlocation.X;
                int y = oldlocation.Y;
                for (int nx = x - 15; nx <= x; nx += 1)
                {
                    form.Location = new Point(nx, y);
                    Thread.Sleep(speed_ms);
                }
            }
            else if (style == AnimationStyle.SlideTop)
            {
                form.Show();
                form.Refresh();
                Point oldlocation = form.Location;
                int x = oldlocation.X;
                int y = oldlocation.Y;
                for (int ny = y + 15; ny >= y; ny -= 1)
                {
                    form.Location = new Point(x, ny);
                    Thread.Sleep(speed_ms);
                }
            }
            else if (style == AnimationStyle.SlideBottom)
            {
                form.Show();
                form.Refresh();
                Point oldlocation = form.Location;
                int x = oldlocation.X;
                int y = oldlocation.Y;
                for (int ny = y - 15; ny <= y; ny += 1)
                {
                    form.Location = new Point(x, ny);
                    Thread.Sleep(speed_ms);
                }
            }
        }
    }
}
