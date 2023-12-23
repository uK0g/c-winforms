using System.Numerics;

namespace TrabalhoAIGabriel
{
    public partial class InGame : Form
    {
        List<Cars> cars = new List<Cars>();
        public InGame()
        {
            InitializeComponent();
        }

        //int centerfrontx;
        //int centerfronty;
        //int centerbackx;
        //int centerbacky;
        //int centerx;
        //int centery;
        //Color maincolor;
        //Color sencondarycolor;
        //Color tyrecolor;
        Vector2 cbcf;
        Vector2 ucbcf;



        SolidBrush maincolorbrush = new SolidBrush(Color.FromArgb(200, 10, 12));
        SolidBrush secondarycolorbrush = new SolidBrush(Color.FromArgb(63, 63, 63));
        SolidBrush tyrecolorbrush = new SolidBrush(Color.FromArgb(0, 0, 0));





        Player player = new Player(new Point(400, 400), new Point(320, 400), Color.FromArgb(200, 10, 12), Color.FromArgb(63, 63, 63), Color.FromArgb(0, 0, 0));

        private void InGame_Load(object sender, EventArgs e)
        {
            //Draw();
        }
        //carro vroom vroom 
        public bool goright, goleft, gofront, goback;
        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                gofront = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                goback = true;
            }
        }
        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                gofront = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goback = false;
            }
        }
        private void keypress(object sender, KeyPressEventArgs e)
        {
            //right and left
        }
        private void updatePosition()
        {
            if (gofront == true)
            {
                //Vector2 Positionx2 = Vector2.Multiply(2, ucbcf);
                player.centerfrontx += (int)(2 * ucbcf.X);
                player.centerfronty += (int)(2 * ucbcf.Y);
                player.centerbackx += (int)(2 * ucbcf.X);
                player.centerbacky += (int)(2 * ucbcf.Y);
            }
            if (goback == true)
            {
                player.centerfrontx -= (int)(2 * ucbcf.X);
                player.centerfronty -= (int)(2 * ucbcf.Y);
                player.centerbackx -= (int)(2 * ucbcf.X);
                player.centerbacky -= (int)(2 * ucbcf.Y);
            }
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBox_canvas.Width, pictureBox_canvas.Height);
            Graphics g = Graphics.FromImage(bmp);

            cbcf = new Vector2(player.centerfrontx - player.centerbackx, player.centerfronty - player.centerbacky);
            ucbcf = Vector2.Normalize(cbcf);

            //front tyres right
            Point fronttyrerightfront1 = new Point(player.centerfrontx + (int)(30 * ucbcf.Y) + (int)(5 * ucbcf.X), player.centerfronty - (int)(30 * ucbcf.X) + (int)(5 * ucbcf.Y));
            Point fronttyrerightfront2 = new Point(player.centerfrontx - (int)(5 * ucbcf.Y) + (int)(5 * ucbcf.X), player.centerfronty + (int)(5 * ucbcf.X) + (int)(5 * ucbcf.Y));
            Point fronttyrerightback1 = new Point(player.centerfrontx - (int)(5 * ucbcf.Y) - (int)(5 * ucbcf.X), player.centerfronty + (int)(5 * ucbcf.X) - (int)(5 * ucbcf.Y));
            Point fronttyrerightback2 = new Point(player.centerfrontx + (int)(30 * ucbcf.Y) - (int)(5 * ucbcf.X), player.centerfronty - (int)(30 * ucbcf.X) - (int)(5 * ucbcf.Y));

            Point[] fronttyrerightPoints = { fronttyrerightfront1, fronttyrerightfront2, fronttyrerightback1, fronttyrerightback2 };

            //front tyres left
            Point fronttyreleftfront1 = new Point(player.centerfrontx + (int)(5 * ucbcf.Y) + (int)(5 * ucbcf.X), player.centerfronty - (int)(5 * ucbcf.X) + (int)(5 * ucbcf.Y));
            Point fronttyreleftfront2 = new Point(player.centerfrontx - (int)(30 * ucbcf.Y) + (int)(5 * ucbcf.X), player.centerfronty + (int)(30 * ucbcf.X) + (int)(5 * ucbcf.Y));
            Point fronttyreleftback1 = new Point(player.centerfrontx - (int)(30 * ucbcf.Y) - (int)(5 * ucbcf.X), player.centerfronty + (int)(30 * ucbcf.X) - (int)(5 * ucbcf.Y));
            Point fronttyreleftback2 = new Point(player.centerfrontx + (int)(5 * ucbcf.Y) - (int)(5 * ucbcf.X), player.centerfronty - (int)(5 * ucbcf.X) - (int)(5 * ucbcf.Y));

            Point[] fronttyreleftPoints = { fronttyreleftfront1, fronttyreleftfront2, fronttyreleftback1, fronttyreleftback2 };

            //back tyres
            Point backtyresfront1 = new Point(player.centerbackx + (int)(30 * ucbcf.Y) + (int)(5 * ucbcf.X), player.centerbacky - (int)(30 * ucbcf.X) + (int)(5 * ucbcf.Y));
            Point backtyresfront2 = new Point(player.centerbackx - (int)(30 * ucbcf.Y) + (int)(5 * ucbcf.X), player.centerbacky + (int)(30 * ucbcf.X) + (int)(5 * ucbcf.Y));
            Point backtyresback1 = new Point(player.centerbackx - (int)(30 * ucbcf.Y) - (int)(5 * ucbcf.X), player.centerbacky + (int)(30 * ucbcf.X) - (int)(5 * ucbcf.Y));
            Point backtyresback2 = new Point(player.centerbackx + (int)(30 * ucbcf.Y) - (int)(5 * ucbcf.X), player.centerbacky - (int)(30 * ucbcf.X) - (int)(5 * ucbcf.Y));

            Point[] backtyresPoints = { backtyresfront1, backtyresfront2, backtyresback1, backtyresback2 };

            Point rectanglefront1 = new Point(player.centerfrontx + (int)(25 * ucbcf.Y) + (int)(10 * ucbcf.X), player.centerfronty - (int)(25 * ucbcf.X) + (int)(10 * ucbcf.Y));
            Point rectanglefront2 = new Point(player.centerfrontx - (int)(25 * ucbcf.Y) + (int)(10 * ucbcf.X), player.centerfronty + (int)(25 * ucbcf.X) + (int)(10 * ucbcf.Y));
            Point rectangleback1 = new Point(player.centerfrontx - (int)(25 * ucbcf.Y) - (int)(90 * ucbcf.X), player.centerfronty + (int)(25 * ucbcf.X) - (int)(90 * ucbcf.Y));
            Point rectangleback2 = new Point(player.centerfrontx + (int)(25 * ucbcf.Y) - (int)(90 * ucbcf.X), player.centerfronty - (int)(25 * ucbcf.X) - (int)(90 * ucbcf.Y));

            Point[] rectanglePoints = { rectanglefront1, rectanglefront2, rectangleback1, rectangleback2 };

            foreach (Cars cars in cars)
            {
                cars.Draw(g);
            }
            //pictureBox_canvas.Image = bmp;

            g.FillPolygon(tyrecolorbrush, fronttyrerightPoints);
            g.FillPolygon(tyrecolorbrush, fronttyreleftPoints);
            g.FillPolygon(tyrecolorbrush, backtyresPoints);
            g.FillPolygon(maincolorbrush, rectanglePoints);

            Pen secondarycolorpen = new Pen(Color.FromArgb(63, 63, 63));
            Point Center_Back = new Point(player.centerbackx, player.centerbacky);
            Point Center_Front = new Point(player.centerfrontx, player.centerfronty);
            g.DrawLine(secondarycolorpen, Center_Back, Center_Front);
        }
        private void timerPosition_Tick(object sender, EventArgs e)
        {
            updatePosition();
            Draw();
        }





        //rotating 
        //https://www.youtube.com/watch?v=r28w6YdNQYQ&ab_channel=CreatorsEyeDev 
        //https://stackoverflow.com/questions/12024406/how-can-i-rotate-an-image-by-any-degree
        //steering
        //https://www.youtube.com/watch?v=Nd-qTMdgKVE&ab_channel=DubiousInsights
        //drawing
        //https://www.youtube.com/watch?v=ZW1tMRSuwnY&ab_channel=DarrenDoesEverything
    }


}

