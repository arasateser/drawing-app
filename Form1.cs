using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace tatlibirdeneme
{
    public partial class ekran : Form
    {
        public ekran()
        {
            InitializeComponent();
        }
        Point[] Points = new Point[6];

        private void Form1_Load(object sender, EventArgs e)
        {
            sekilSec.Items.Add("Nokta");
            sekilSec.Items.Add("Cizgi");
            sekilSec.Items.Add("Poligon");
        }

        private void sekilSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sekilSec.Text == "Nokta")
            {
                turSec.Items.Clear();
                turSec.Items.Add("Kucuk");
                turSec.Items.Add("Orta");
                turSec.Items.Add("Buyuk");
            }
            else if (sekilSec.Text == "Cizgi")
            {
                turSec.Items.Clear();
                turSec.Items.Add("Ince");
                turSec.Items.Add("Orta");
                turSec.Items.Add("Kalin");
            }
            else if (sekilSec.Text == "Poligon")
            {
                turSec.Items.Clear();
                turSec.Items.Add("Bos");
                turSec.Items.Add("Tarali");
                turSec.Items.Add("Dolu");
            }
        }
        
        List<DrawAction> actions = new List<DrawAction>();

        public class DrawAction
        {
            public char type { get; set; }             // this should be an Enum!
            public Color color { get; set; }
            public float penWidth { get; set; }        // only one of many Pen properties!
            public List<Point> points { get; set; }    // use PointF for more precision

            public DrawAction(char type_, Color color_, float penwidth_)
            {
                type = type_; color = color_; penWidth = penwidth_;
                points = new List<Point>();
            }
        }

        private void buton2_Click(object sender, EventArgs e)
        {
            int en = Convert.ToInt32(Math.Round(numericUpDown3.Value, 0));
            int boy = Convert.ToInt32(Math.Round(numericUpDown4.Value, 0));
            Size size = new Size(en, boy);
            pictureBox1.Size = size;

            if (sekilSec.Text == "Nokta")
            {
                if (turSec.Text == "Kucuk")
                {
                    int noktaKalin = 5;
                    int count1ni = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
                    int count2ni = Convert.ToInt32(Math.Round(numericUpDown2.Value, 0));


                    actions.Add(new DrawAction('C', Color.Blue, 1));
                    actions[0].points.Add(new Point(count1ni, count2ni));


                    Bitmap pbk = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                    using (Graphics goruntuKalin = Graphics.FromImage(pbk))
                    {
                        goruntuKalin.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                        goruntuKalin.FillEllipse(System.Drawing.Brushes.Cyan, count1ni, count2ni, noktaKalin, noktaKalin); //koortinatlar kullanicidan gelecek sekilde degisecek
                    }
                    pictureBox1.Image = pbk;
                }
                else if (turSec.Text == "Orta")
                {
                    int noktaKalin = 10;
                    int count1no = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
                    int count2no = Convert.ToInt32(Math.Round(numericUpDown2.Value, 0));


                    actions.Add(new DrawAction('C', Color.Blue, 1));
                    actions[0].points.Add(new Point(count1no, count2no));


                    Bitmap pbk = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                    using (Graphics goruntuKalin = Graphics.FromImage(pbk))
                    {
                        goruntuKalin.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                        goruntuKalin.FillEllipse(System.Drawing.Brushes.Cyan, count1no, count2no, noktaKalin, noktaKalin); //koortinatlar kullanicidan gelecek sekilde degisecek
                    }
                    pictureBox1.Image = pbk;
                }
                else if (turSec.Text == "Buyuk")
                {
                    int noktaKalin = 20;
                    int count1nk = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
                    int count2nk = Convert.ToInt32(Math.Round(numericUpDown2.Value, 0));


                    actions.Add(new DrawAction('C', Color.Blue, 1));
                    actions[0].points.Add(new Point(count1nk, count2nk));


                    Bitmap pbk = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                    using (Graphics goruntuKalin = Graphics.FromImage(pbk))
                    {
                        goruntuKalin.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                        goruntuKalin.FillEllipse(System.Drawing.Brushes.Cyan, count1nk, count2nk, noktaKalin, noktaKalin); //koortinatlar kullanicidan gelecek sekilde degisecek
                    }
                    pictureBox1.Image = pbk;
                }
            }


            else if (sekilSec.Text == "Cizgi")
            {
                if (turSec.Text == "Ince")
                {
                    int count1ci = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
                    int count2ci = Convert.ToInt32(Math.Round(numericUpDown2.Value, 0));


                    actions.Add(new DrawAction('C', Color.Black, 1));
                    actions[0].points.Add(new Point(count1ci, count2ci));

                    Bitmap bmp = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
                    using (Graphics G = Graphics.FromImage(bmp)) Draw(G, actions);
                    pictureBox1.Image = bmp;

                }
                else if (turSec.Text == "Orta")
                {
                    int count1co = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
                    int count2co = Convert.ToInt32(Math.Round(numericUpDown2.Value, 0));

                    actions.Add(new DrawAction('C', Color.Black, 3));
                    actions[0].points.Add(new Point(count1co, count2co));

                    Bitmap bmp = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
                    using (Graphics G = Graphics.FromImage(bmp)) Draw(G, actions);
                    pictureBox1.Image = bmp;
                }
                else if (turSec.Text == "Kalin")
                {
                    int count1ck = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
                    int count2ck = Convert.ToInt32(Math.Round(numericUpDown2.Value, 0));

                    actions.Add(new DrawAction('C', Color.Black, 6));
                    actions[0].points.Add(new Point(count1ck, count2ck));

                    Bitmap bmp = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
                    using (Graphics G = Graphics.FromImage(bmp)) Draw(G, actions);
                    pictureBox1.Image = bmp;
                }
            }
            else if (sekilSec.Text == "Poligon")
            {
                if (turSec.Text == "Bos")
                {
                    int count1pb = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
                    int count2pb = Convert.ToInt32(Math.Round(numericUpDown2.Value, 0));

                    actions.Add(new DrawAction('P', Color.Red, 3));
                    actions[0].points.Add(new Point(count1pb, count2pb));

                    Bitmap bmp = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
                    using (Graphics G = Graphics.FromImage(bmp)) Draw(G, actions);
                    pictureBox1.Image = bmp;
                }
                else if (turSec.Text == "Tarali")
                {
                    int count1pb = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
                    int count2pb = Convert.ToInt32(Math.Round(numericUpDown2.Value, 0));

                    actions.Add(new DrawAction('P', Color.Red, 3));
                    actions[0].points.Add(new Point(count1pb, count2pb));


                    Bitmap bmp = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
                    using (Graphics G = Graphics.FromImage(bmp)) Draw(G, actions);
                    pictureBox1.Image = bmp;
                }
                else if (turSec.Text == "Dolu")
                {
                    int count1pb = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
                    int count2pb = Convert.ToInt32(Math.Round(numericUpDown2.Value, 0));

                    actions.Add(new DrawAction('P', Color.Red, 3));
                    actions[0].points.Add(new Point(count1pb, count2pb));
                    using (SolidBrush br = new SolidBrush(Color.FromArgb(100, Color.Yellow)))
                    {
                        e.Graphics.FillPolygon(br, polyPoints.ToArray());
                    }

                    Bitmap bmp = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
                    using (Graphics G = Graphics.FromImage(bmp)) Draw(G, actions);
                    pictureBox1.Image = bmp;
                }
            }
        }
        
        public void Draw(Graphics G, List<DrawAction> actions)
        {
            foreach (DrawAction da in actions)
                if (da.type == 'N' && da.points.Count > 1)
                    using (Pen pen = new Pen(da.color, da.penWidth))
                        G.DrawLine(pen, da.points[0], da.points[1]);

                else if (da.type == 'C' && da.points.Count > 1)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        using (Pen pen = new Pen(da.color, da.penWidth))
                            G.DrawLines(pen, da.points.ToArray());
                    }

                }

                else if (da.type == 'P' && da.points.Count > 1)
                    using (Pen pen = new Pen(da.color, da.penWidth))
                        G.DrawLines(pen, da.points.ToArray());
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int count1ni = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
            int count2ni = Convert.ToInt32(Math.Round(numericUpDown2.Value, 0));
        }
    }
}
