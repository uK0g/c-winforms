using System.Drawing;
using System.Numerics;

namespace TrabalhoAIGabriel
{
    public abstract class Cars
    {
        //points of refenrence
        public Point Center_Front { get; set; } //front axle
        public Point Center_Back { get; set; } //back axle
        public Point Center { get; set; } //center 

        //colors
        public Color MainColor { get; set; }
        public Color SecondaryColor { get; set; } //windows etc
        public Color TyreColor { get; set; }

        //points in x and y factor

        public int centerfrontx { get; set; }
        public int centerfronty { get; set; }
        public int centerbackx { get; set; }
        public int centerbacky { get; set; }
        public int centerx { get; set; }
        public int centery { get; set; }

        public const int width = 100;
        public const int height = 50;



        public Cars(Point center_front, Point center_back, Color maincolor, Color secondarycolor, Color tyrecolor)
        {
            Center_Front = new Point(centerfrontx, centerfronty);
            Center_Back = new Point(centerbackx, centerbacky);
            Center = new Point(centerx, centery);
            MainColor = maincolor;
            SecondaryColor = secondarycolor;
            TyreColor = tyrecolor;
        }
        public abstract void Draw(Graphics g);

    }

    public class Player : Cars
    {



        public bool goright, goleft, gofront, goback;

        public Vector2 cbcf { get; set; }
        public Vector2 ucbcf { get; set; }


        public Player(Point center_front, Point center_back, Color maincolor, Color secondarycolor, Color tyrecolor) : base(center_front, center_back, maincolor, secondarycolor, tyrecolor)
        {
            MainColor = Color.FromArgb(200, 10, 10);
            SecondaryColor = Color.FromArgb(63, 63, 63);
            TyreColor = Color.Black;
            centerfrontx = 400;
            centerfronty = 400;
            centerbackx = 320;
            centerbacky = 400;
        }

        public override void Draw(Graphics g)
        {
            //cores
            //SolidBrush maincolorbrush = new SolidBrush(MainColor);
            //Pen maincolorpen = new Pen(MainColor);
            //SolidBrush secondarycolorbrush = new SolidBrush(SecondaryColor);
            //Pen secondarycolorpen = new Pen(SecondaryColor);
            //SolidBrush tyrecolorbrush = new SolidBrush(TyreColor);
            //Pen tyrecolorpen = new Pen(TyreColor);

            //centerx = (centerbackx + centerfrontx) / 2;
            //centery = (centerbacky + centerfronty) / 2;

            //Point Center_Back = new Point(centerbackx, centerbacky);
            //Point Center_Front = new Point(centerfrontx, centerfronty);
            //Point Center = new Point(centerx, centery);


            //g.DrawLine(secondarycolorpen, Center_Back, Center_Front);




        }




        /*float inclinex = (centerx + centerfrontx) / 2;
        float incliney = (centery + centerfronty) / 2;

        float angle = (float)Math.Atan2(incliney, inclinex);

        float x1 = centerx + (float)(-width / 2 * Math.Cos(angle) - height / 2 * Math.Sin(angle));
        float y1 = centery + (float)(-width / 2 * Math.Sin(angle) + height / 2 * Math.Cos(angle));

        float x2 = centerx + (float)(width / 2 * Math.Cos(angle) - height / 2 * Math.Sin(angle));
        float y2 = centery + (float)(width / 2 * Math.Sin(angle) + height / 2 * Math.Cos(angle));

        float x3 = centerx + (float)(width / 2 * Math.Cos(angle) + height / 2 * Math.Sin(angle));
        float y3 = centery + (float)(width / 2 * Math.Sin(angle) - height / 2 * Math.Cos(angle));

        float x4 = centerx + (float)(-width / 2 * Math.Cos(angle) + height / 2 * Math.Sin(angle));
        float y4 = centery + (float)(-width / 2 * Math.Sin(angle) - height / 2 * Math.Cos(angle));*/



        /*PointF[] rectanglePoints =
        {
            new PointF(x1, y1),
            new PointF(x2, y2),
            new PointF(x3, y3),
            new PointF(x4, y4),    
        };*/







        /*if (centerfronty == centerbacky)
        {
            offsetx = (width / 2);
            offsety = (height / 2);

        }
        if (centerfrontx ==centerbackx)
        {
            offsetx += (width / 2);
            offsety += (height / 2);
        }
        else
        {
            offsetx = (width/2) * (float)(Math.Cos(angle) * radius);
            offsety = (height/2) * (float)(Math.Sin(angle) * radius);
        }
        */

        /*Point[] rectanglePoints =
        {
            new Point(centerx + (float)offsetx),centery + offsety),
            new Point(centerx - offsetx),centery + offsety),
            new Point(centerx - offsetx),centery - offsety),
            new Point(centerx + offsetx),centery - offsety),
        }; */




        /*Point[] rectanglePoints =
        {
            new Point((int)(centerx + (width/2)+(Math.Cos(angle)*100)),(int) (centery + (height/2)-(Math.Sin(angle) * 100))),
            new Point((int)(centerx - (width/2)-(Math.Cos(angle) * 100)),(int) (centery + (height/2)+(Math.Sin(angle) * 100))),
            new Point((int)(centerx - (width/2)+(Math.Cos(angle)*100)),(int) (centery - (height/2)-(Math.Sin(angle)*100))),
            new Point((int)(centerx + (width/2)-(Math.Cos(angle) * 100)),(int) (centery - (height/2)+(Math.Sin(angle)*100))),
        };*/








    }

}

    /*public class NPC : Cars
    {
        public NPC(Point center_front, Point center_back, Color maincolor, Color secondarycolor, Color tyrecolor);





        public override void Draw(Graphics g)
        {
            
        }
    }*/
    