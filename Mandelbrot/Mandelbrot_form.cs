using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Mandelbrot
{
    public partial class Mandelbrot : Form
    {
        // Declare global values
        public double middleX;
        public double middleY;
        public double detail;
        public double zoomScale;
        public string style = "Glow";
        public string preset = "User control";

        public List<double> result = new List<double>();
        public List<double> result_smooth = new List<double>();

        public bool initPlot = true;

        public Mandelbrot()
        {
            InitializeComponent();
            Init();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Init();
        }

        private void Canvas_Click(object sender, EventArgs e)
        {
            // Get position of cursor on form
            Point relativePos = this.PointToClient(Cursor.Position);

            // Scale relativePos
            double scale = (double)canvas.Width / 2 / 2.5;
            double n0 = (-canvas.Width / 2 + (relativePos.X - 204)) / scale * zoomScale + middleX;
            double n1 = (canvas.Height / 2 - (relativePos.Y - 12)) / scale * zoomScale + middleY;

            middle_xField.Text = Math.Round(n0, 7).ToString();
            middle_yField.Text = Math.Round(n1, 7).ToString();
            scaleField.Text = (zoomScale / 2).ToString();
            maxField.Text = (detail + 100).ToString();
        }

        private void Init()
        {
            // Initial values
            middleX = 0;
            middleY = 0;
            zoomScale = 1;
            detail = 100;
            styleDropdown.SelectedItem = style;
            locationDropdown.SelectedItem = "User control";

            middle_xField.Text = "0";
            middle_yField.Text = "0";
            maxField.Text = "100";
            scaleField.Text = "1";
            initPlot = true;

            statusIndicator.Text = "Plotting...";
            statusIndicator.Refresh();

            Draw();

            statusIndicator.Text = "Ready";
            statusIndicator.Refresh();
        }

        private double[] F(double x, double y)
        {
            // Initialise result array
            double[] result = new double[2];

            double a0 = 0;
            double b0 = 0;

            double t = 0;
            bool end = false;

            double dist = 0;
            double distMax = 2;

            while (end == false)
            {
                t++;

                double a = a0 * a0 - b0 * b0 + x;
                double b = 2 * a0 * b0 + y;

                dist = Math.Sqrt(a * a + b * b);

                if (t >= int.Parse(maxField.Text) || dist > distMax)
                    end = true;

                a0 = a;
                b0 = b;
            }

            // Return a normalised iteration count
            result[0] = t + (1 - Math.Log(Math.Log(dist, 2), 2));

            // Return the iterartion count
            result[1] = t;

            return result;
        }

        private void Plot(object sender, EventArgs e)
        {
            statusIndicator.Text = "Plotting...";
            statusIndicator.Refresh();

            Draw();

            statusIndicator.Text = "Ready";
            statusIndicator.Refresh();
        }

        private void Draw()
        {
            style = (string)styleDropdown.SelectedItem;
            preset = (string)locationDropdown.SelectedItem;

            // Preset locations
            if (preset == "Spiral")
            {
                middle_xField.Text = (-0.7695358).ToString();
                middle_yField.Text = 0.1151547.ToString();
                maxField.Text = 3000.ToString();
                scaleField.Text = 0.002.ToString();
            }
            if (preset == "Fracture")
            {
                middle_xField.Text = (-0.108625).ToString();
                middle_yField.Text = 0.9014428.ToString();
                maxField.Text = 3000.ToString();
                scaleField.Text = 3.8147E-6.ToString();
            }
            if (preset == "Mini Mandelbrot")
            {
                middle_xField.Text = (-1.7585714).ToString();
                middle_yField.Text = 0.ToString();
                maxField.Text = 600.ToString();
                scaleField.Text = 0.03125.ToString();
            }
            if (preset == "Diagonal Mandelbrot")
            {
                middle_xField.Text = (-1.0079296875).ToString();
                middle_yField.Text = 0.3112109375.ToString();
                maxField.Text = 3000.ToString();
                scaleField.Text = 1.953125E-3.ToString();
            }

            Bitmap fig = new Bitmap(canvas.Width, canvas.Height);

            Graphics figGraphics = Graphics.FromImage(fig);

            double scale = (double)canvas.Width / 2 / 2.5;

            // If no values have changed and it is not the initial plot, get the pre-calculated values from the arrays
            if (middle_xField.Text == middleX.ToString() && middle_yField.Text == middleY.ToString() && scaleField.Text == zoomScale.ToString() && maxField.Text == detail.ToString() && initPlot == false)
            {
                int i = 0;

                // Rows
                for (int y = 0; y <= canvas.Height; y++)
                {
                    // Cols
                    for (int x = 0; x <= canvas.Width; x++)
                    {
                        double t = result[i];
                        double tS = result_smooth[i];

                        i++;

                        // Color conditions
                        if (style == "Grayscale")
                        {
                            if (t < int.Parse(maxField.Text))
                            {
                                double factor = Math.Sqrt(tS / double.Parse(maxField.Text));
                                double g = 255 * factor;

                                Color grayscale = Color.FromArgb(255, (int)g, (int)g, (int)g);

                                using (Brush brush = new SolidBrush(grayscale))
                                    figGraphics.FillRectangle(brush, x, y, 1, 1);
                            }
                            else
                            {
                                using (Brush brush = new SolidBrush(Color.Black))
                                    figGraphics.FillRectangle(brush, x, y, 1, 1);
                            }
                        }

                        if (style == "Glow")
                        {
                            if (t < int.Parse(maxField.Text))
                            {
                                // ColorGradient1 class is inside ColorGradients.cs
                                int index = (int)(Math.Sqrt(tS) * 256) % ColorGradient1.r.Length;
                                Color color = Color.FromArgb(255, ColorGradient1.r[index], ColorGradient1.g[index], ColorGradient1.b[index]);
                                
                                using (Brush brush = new SolidBrush(color))
                                    figGraphics.FillRectangle(brush, x, y, 1, 1);
                            }
                            else
                            {
                                using (Brush brush = new SolidBrush(Color.Black))
                                    figGraphics.FillRectangle(brush, x, y, 1, 1);
                            }
                        }

                        if (style == "Rainbow")
                        {
                            if (t < int.Parse(maxField.Text))
                            {
                                int index = (int)(Math.Sqrt(tS) * 256) % ColorGradient2.r.Length;
                                Color color = Color.FromArgb(255, ColorGradient2.r[index], ColorGradient2.g[index], ColorGradient2.b[index]);

                                using (Brush brush = new SolidBrush(color))
                                {
                                    figGraphics.FillRectangle(brush, x, y, 1, 1);
                                }
                            }
                            else
                            {
                                using (Brush brush = new SolidBrush(Color.Black))
                                {
                                    figGraphics.FillRectangle(brush, x, y, 1, 1);
                                }
                            }
                        }

                        if (style == "Rainbow 2")
                        {
                            if (t < int.Parse(maxField.Text))
                            {
                                double hue = tS * 50.0;
                                while (hue > 360) hue -= 360;
                                while (hue < 0) hue += 360;

                                // HSVclass is inside HSV.cs
                                Color color = HSV.ColorFromHSV(hue, 0.8, 1);
                                using (Brush brush = new SolidBrush(color))
                                    figGraphics.FillRectangle(brush, x, y, 1, 1);
                            }
                            else
                            {
                                using (Brush brush = new SolidBrush(Color.Black))
                                {
                                    figGraphics.FillRectangle(brush, x, y, 1, 1);
                                }
                            }
                        }
                    }
                }
            }

            // If values have changed, re-calculate and plot
            else
            {
                result.Clear();
                result_smooth.Clear();

                middleX = double.Parse(middle_xField.Text);
                middleY = double.Parse(middle_yField.Text);
                zoomScale = double.Parse(scaleField.Text);
                detail = int.Parse(maxField.Text);

                // Rows
                for (int y = 0; y <= canvas.Height; y++)
                {
                    // Cols
                    for (int x = 0; x <= canvas.Width; x++)
                    {

                        // Scale x and y
                        double x0 = (-canvas.Width / 2 + x) / scale * zoomScale + middleX;
                        double y0 = (canvas.Height / 2 - y) / scale * zoomScale + middleY;

                        double[] res = F(x0, y0);

                        // Add results to arrays
                        result_smooth.Add(res[0]);
                        result.Add(res[1]);

                        double tS = res[0];
                        double t = res[1];


                        // Color conditions
                        if (style == "Grayscale")
                        {
                            if (t < int.Parse(maxField.Text))
                            {

                                // Create grayscale value based on ratio t / tMAX
                                double factor = Math.Sqrt(tS / double.Parse(maxField.Text));
                                double g = 255 * factor;

                                Color grayscale = Color.FromArgb(255, (int)g, (int)g, (int)g);

                                using (Brush brush = new SolidBrush(grayscale))
                                    figGraphics.FillRectangle(brush, x, y, 1, 1);
                            }
                            else
                            {
                                using (Brush brush = new SolidBrush(Color.Black))
                                    figGraphics.FillRectangle(brush, x, y, 1, 1);
                            }
                        }

                        if (style == "Glow")
                        {
                            if (t < int.Parse(maxField.Text))
                            {
                                // ColorGradient1 is inside ColorGradients.cs
                                int index = (int)(Math.Sqrt(tS) * 256) % ColorGradient1.r.Length;
                                Color color = Color.FromArgb(255, ColorGradient1.r[index], ColorGradient1.g[index], ColorGradient1.b[index]);

                                using (Brush brush = new SolidBrush(color))
                                    figGraphics.FillRectangle(brush, x, y, 1, 1);
                            }
                            else
                            {
                                using (Brush brush = new SolidBrush(Color.Black))
                                    figGraphics.FillRectangle(brush, x, y, 1, 1);
                            }
                        }

                        if (style == "Rainbow")
                        {
                            if (t < int.Parse(maxField.Text))
                            {
                                int index = (int)(Math.Sqrt(tS) * 256) % ColorGradient2.r.Length;
                                Color color = Color.FromArgb(255, ColorGradient2.r[index], ColorGradient2.g[index], ColorGradient2.b[index]);

                                using (Brush brush = new SolidBrush(color))
                                    figGraphics.FillRectangle(brush, x, y, 1, 1);
                            }
                            else
                            {
                                using (Brush brush = new SolidBrush(Color.Black))
                                    figGraphics.FillRectangle(brush, x, y, 1, 1);
                            }
                        }

                        if (style == "Rainbow 2")
                        {
                            if (t < int.Parse(maxField.Text))
                            {
                                double hue = tS * 50.0;
                                while (hue > 360) hue -= 360;
                                while (hue < 0) hue += 360;

                                // HSVclass is inside HSV.cs
                                Color color = HSV.ColorFromHSV(hue, 0.8, 1);
                                using (Brush brush = new SolidBrush(color))
                                    figGraphics.FillRectangle(brush, x, y, 1, 1);
                            }
                            else
                            {
                                using (Brush brush = new SolidBrush(Color.Black))
                                {
                                    figGraphics.FillRectangle(brush, x, y, 1, 1);
                                }
                            }
                        }
                    }
                }
            }
            initPlot = false;
            canvas.Image = fig;
            canvas.Refresh();
        }
    }
}
