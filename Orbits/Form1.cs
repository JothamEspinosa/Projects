

namespace Orbits
{
    using System;
  using System.Collections.Generic;
  using System.ComponentModel;
  using System.Data;
  using System.Drawing;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;
  using System.Windows.Forms;

    public partial class Form1 : Form
    {
        Rectangle rect = new Rectangle(125, 125, 50, 50);
        Rectangle rect0 = new Rectangle(125, 125, 50, 50);

        public int spCountX = 0;
        public int spCountY = 0;
        public int AxisX = 0;//0,0
        public int AxisY = 0;
        public int AxisXx = 0;
        public int AxisYy = 0;
        public int Myvar = 0;

        Point coordinate ;
        double Angle = 0.0;
        private object displayText;

        public Form1()
        {
            InitializeComponent();

          
              
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Welcome to Space Travel Animation Software!!!";


            

        }
        public void redrawOribits()
        {
         AxisX = (pictureBox1.Width / 2);//0,0
        AxisY = (pictureBox1.Height / 2);
            // Create pen.(circle Orbit around Earth)
            Pen blackPen = new Pen(Color.Ivory, 3);

            // Create rectangle for ellipse(circle.



            Rectangle rect = new Rectangle(142 + 50, 360 + 30, 50, 50);

            pictureBox1.CreateGraphics().DrawEllipse(blackPen, rect);

            // Create pen.(Earth orbit around the sun)
            Pen bPen = new Pen(Color.Cyan, 3);

            // Create rectangle for ellipse.
            Rectangle rec = new Rectangle(215, 215, 400, 400);

            pictureBox1.CreateGraphics().DrawEllipse(bPen, rec);

            // Create pen.(Transfer Orbit to mars)
            Pen b2Pen = new Pen(Color.Green, 3);

            // Create rectangle for ellipse.
            Rectangle rec2 = new Rectangle(161 + 30, 150 + 30, 529, 470);

            pictureBox1.CreateGraphics().DrawEllipse(b2Pen, rec2);
            // Create pen.(Orbit around Mars)
            Pen b3Pen = new Pen(Color.Ivory, 3);

            // Create rectangle for ellipse(circle Orbit around mars).
            Rectangle rec3 = new Rectangle(723, 390, 50, 50);

            pictureBox1.CreateGraphics().DrawEllipse(b3Pen, rec3);

            // Create pen(Mars Orbit Around the sun).
            Pen b4Pen = new Pen(Color.Red, 3);

            // Create rectangle for ellipse.
            Rectangle rec4 = new Rectangle(100, 100, 650, 650);

            pictureBox1.CreateGraphics().DrawEllipse(b4Pen, rec4);

            // Create pen.(The Sun)
            Pen b5Pen = new Pen(Color.Yellow, 3);

            // Create rectangle for ellipse.
            Rectangle rec5 = new Rectangle(AxisX, AxisY, 40, 40);

            pictureBox1.CreateGraphics().DrawEllipse(b5Pen, rec5);

            // Create pen.(The Earth)
            Pen b6Pen = new Pen(Color.Aqua, 3);

            // Create rectangle for ellipse.
            Rectangle rec6 = new Rectangle(158 + 50, 378 + 30, 15, 15);

            pictureBox1.CreateGraphics().DrawEllipse(b6Pen, rec6);

            // Create pen.(Mars)
            Pen b7Pen = new Pen(Color.Red, 3);

            // Create rectangle for ellipse.
            Rectangle rec7 = new Rectangle(693 + 50, 378 + 30, 15, 15);

            pictureBox1.CreateGraphics().DrawEllipse(b7Pen, rec7);

        }

        //Solor system with all planets within the project
        private void label3_Click(object sender, EventArgs e)
        {
            AxisX = (pictureBox1.Width / 2);//0,0
            AxisY = (pictureBox1.Height / 2);

      

            // Create pen.(Earth orbit around the sun)
            Pen bPen = new Pen(Color.Cyan, 3);

            // Create rectangle for ellipse.
            Rectangle rec = new Rectangle(265,265, 300, 300);

            pictureBox1.CreateGraphics().DrawEllipse(bPen, rec);

            // Create pen.(The Sun)
            Pen b5Pen = new Pen(Color.Yellow, 3);

            // Create rectangle for ellipse.
            Rectangle rec5 = new Rectangle(AxisX, AxisY, 30, 30);

            pictureBox1.CreateGraphics().DrawEllipse(b5Pen, rec5);

            // Create pen.(The Earth)
            Pen b6Pen = new Pen(Color.Aqua, 3);

            // Create rectangle for ellipse.
            Rectangle rec6 = new Rectangle(208 + 50, 378 + 30, 15, 15);

            pictureBox1.CreateGraphics().DrawEllipse(b6Pen, rec6);

            // Create pen.(Mars)
            Pen b7Pen = new Pen(Color.Red, 3);

            // Create rectangle for ellipse.
            Rectangle rec7 = new Rectangle(542 + 50, 378 + 30, 15, 15);

            pictureBox1.CreateGraphics().DrawEllipse(b7Pen, rec7);
            

            // Create pen(Mars Orbit Around the sun).
            Pen b4Pen = new Pen(Color.Red, 3);
            // Create rectangle for ellipse.
            Rectangle rec4 = new Rectangle(225, 225, 375, 375);

            pictureBox1.CreateGraphics().DrawEllipse(b4Pen, rec4);

            

            // Create pen(Jupiter's Orbit Around the sun).
            Pen b4Pen4 = new Pen(Color.Orange, 3);

            // Create rectangle for ellipse.
            Rectangle rec40 = new Rectangle(187, 187, 450, 450);

            pictureBox1.CreateGraphics().DrawEllipse(b4Pen4, rec40);

            // Create pen.(Jupiter)
            Pen b7Pen7 = new Pen(Color.Orange, 3);

            // Create rectangle for ellipse.
            Rectangle rec70 = new Rectangle(580 + 50, 378 + 30, 15, 15);

            pictureBox1.CreateGraphics().DrawEllipse(b7Pen7, rec70);

            

            // Create pen(Venus Orbit Around the sun).
            Pen b4Pen44 = new Pen(Color.SandyBrown, 3);

            // Create rectangle for ellipse.
            Rectangle rec44 = new Rectangle(315, 315, 200, 200);

            pictureBox1.CreateGraphics().DrawEllipse(b4Pen44, rec44);
            // Create pen.(Venus)
            Pen b7Pen77 = new Pen(Color.SandyBrown, 3);

            // Create rectangle for ellipse.
            Rectangle rec77 = new Rectangle(458 + 50, 378 + 30, 15, 15);

            pictureBox1.CreateGraphics().DrawEllipse(b7Pen77, rec77);
            

            // Create pen(Mercury Orbit Around the sun).
            Pen b4Pen49 = new Pen(Color.BurlyWood, 3);

            // Create rectangle for ellipse.
            Rectangle rec49 = new Rectangle(360, 360, 115, 115);

            pictureBox1.CreateGraphics().DrawEllipse(b4Pen49, rec49);

            // Create pen.(Mercury)
            Pen b7Pen76 = new Pen(Color.BurlyWood, 3);

            // Create rectangle for ellipse.
            Rectangle rec76 = new Rectangle(417 + 50, 379 + 30, 15, 15);

            pictureBox1.CreateGraphics().DrawEllipse(b7Pen76, rec76);

            // Create pen(Saturns's Orbit Around the sun).
            Pen b4Pen40 = new Pen(Color.DarkOliveGreen, 3);

            // Create rectangle for ellipse.
            Rectangle rec400 = new Rectangle(150, 150, 530, 530);

            pictureBox1.CreateGraphics().DrawEllipse(b4Pen40, rec400);

            // Create pen.(Saturn)
            Pen b7Pen70 = new Pen(Color.DarkOliveGreen, 3);

            // Create rectangle for ellipse.
            Rectangle rec700 = new Rectangle(623 + 50, 378 + 30, 15, 15);

            pictureBox1.CreateGraphics().DrawEllipse(b7Pen70, rec700);

            // Create pen(Uranus' Orbit Around the sun).
            Pen b4Pen401 = new Pen(Color.LightBlue, 3);

            // Create rectangle for ellipse.
            Rectangle rec4001 = new Rectangle(108, 108, 615, 615);

            pictureBox1.CreateGraphics().DrawEllipse(b4Pen401, rec4001);

            // Create pen.(Uranus)
            Pen b7Pen701 = new Pen(Color.LightBlue, 3);

            // Create rectangle for ellipse.
            Rectangle rec7001 = new Rectangle(665 + 50, 378 + 30, 15, 15);

            pictureBox1.CreateGraphics().DrawEllipse(b7Pen701, rec7001);

            // Create pen(Neptune's Orbit Around the sun).
            Pen b4Pen4012 = new Pen(Color.Aquamarine, 3);

            // Create rectangle for ellipse.
            Rectangle rec40012 = new Rectangle(68, 68, 700, 700);

            pictureBox1.CreateGraphics().DrawEllipse(b4Pen4012, rec40012);

            // Create pen.(Neptune)
            Pen b7Pen7012 = new Pen(Color.Aquamarine, 3);

            // Create rectangle for ellipse.
            Rectangle rec70012 = new Rectangle(710 + 50, 378 + 30, 15, 15);

            pictureBox1.CreateGraphics().DrawEllipse(b7Pen7012, rec70012);






        }

        //Solor system for mars
        private void label1_Click(object sender, EventArgs e)
        {

            AxisX = (pictureBox1.Width / 2);//0,0
            AxisY = (pictureBox1.Height / 2); 

            // Create pen.(circle Orbit around Earth)
            Pen blackPen = new Pen(Color.Ivory, 3);

            // Create rectangle for ellipse.

            Rectangle rect = new Rectangle(142 + 50, 360 + 30, 50, 50);

            pictureBox1.CreateGraphics().DrawEllipse(blackPen, rect);

            // Create pen.(Earth orbit around the sun)
            Pen bPen = new Pen(Color.Cyan, 3);

            // Create rectangle for ellipse.
            Rectangle rec = new Rectangle(215,215, 400, 400);

            pictureBox1.CreateGraphics().DrawEllipse(bPen, rec);

            // Create pen.(Transfer Orbit to mars)
            Pen b2Pen = new Pen(Color.Green, 3);

            // Create rectangle for ellipse.
            Rectangle rec2 = new Rectangle(161 + 30, 150 + 30, 529, 470);

            pictureBox1.CreateGraphics().DrawEllipse(b2Pen, rec2);
            // Create pen.(Orbit around Mars)
            Pen b3Pen = new Pen(Color.Ivory, 3);

            // Create rectangle for ellipse(circle Orbit around mars).
            Rectangle rec3 = new Rectangle(723,390, 50, 50);

            pictureBox1.CreateGraphics().DrawEllipse(b3Pen, rec3);

            // Create pen(Mars Orbit Around the sun).
            Pen b4Pen = new Pen(Color.Red, 3);

            // Create rectangle for ellipse.
            Rectangle rec4 = new Rectangle(100, 100, 650, 650);

            pictureBox1.CreateGraphics().DrawEllipse(b4Pen, rec4);

            // Create pen.(The Sun)
            Pen b5Pen = new Pen(Color.Yellow, 3);

            // Create rectangle for ellipse.
            Rectangle rec5 = new Rectangle(AxisX, AxisY, 30, 30);

            pictureBox1.CreateGraphics().DrawEllipse(b5Pen, rec5);

            // Create pen.(The Earth)
            Pen b6Pen = new Pen(Color.Aqua, 3);

            // Create rectangle for ellipse.
            Rectangle rec6 = new Rectangle(158 + 50, 378 + 30, 15, 15);

            pictureBox1.CreateGraphics().DrawEllipse(b6Pen, rec6);

            // Create pen.(Mars)
            Pen b7Pen = new Pen(Color.Red, 3);

            // Create rectangle for ellipse.
            Rectangle rec7 = new Rectangle(693 + 50, 378 + 30, 15, 15);

            pictureBox1.CreateGraphics().DrawEllipse(b7Pen, rec7);






        }

        //Solor system for Jupiter
        private void label6_Click(object sender, EventArgs e)
        {

            AxisXx = (pictureBox1.Width / 2);//0,0
            AxisYy = (pictureBox1.Height / 2);

            // Create pen.(circle Orbit around Earth)
            Pen blackPen1 = new Pen(Color.Ivory, 3);

            // Create rectangle for ellipse(circle.)



            Rectangle rect0 = new Rectangle(142 + 50, 360 + 30, 50, 50);

            pictureBox1.CreateGraphics().DrawEllipse(blackPen1, rect0);

            // Create pen.(Earth orbit around the sun)
            Pen bPen1 = new Pen(Color.Cyan, 3);

            // Create rectangle for ellipse.
            Rectangle rec1 = new Rectangle(215, 215, 400, 400);

            pictureBox1.CreateGraphics().DrawEllipse(bPen1, rec1);

            // Create pen.(Transfer Orbit to Jupiter)
            Pen b2Pen2 = new Pen(Color.Green, 3);

            // Create rectangle for ellipse.
            Rectangle rec20 = new Rectangle(161 + 30, 150 + 30, 560, 470);

            pictureBox1.CreateGraphics().DrawEllipse(b2Pen2, rec20);
            // Create pen.(Orbit around Jupiter)
            Pen b3Pen3 = new Pen(Color.Ivory, 3);

            // Create rectangle for ellipse(circle Orbit around Jupiter).
            Rectangle rec30 = new Rectangle(750, 390, 50, 50);

            pictureBox1.CreateGraphics().DrawEllipse(b3Pen3, rec30);

            // Create pen(Jupiter's Orbit Around the sun).
            Pen b4Pen4 = new Pen(Color.Orange, 3);

            // Create rectangle for ellipse.
            Rectangle rec40 = new Rectangle(75, 80, 700, 700);

            pictureBox1.CreateGraphics().DrawEllipse(b4Pen4, rec40);

            // Create pen.(The Sun)
            Pen b5Pen5 = new Pen(Color.Yellow, 3);

            // Create rectangle for ellipse.
            Rectangle rec50 = new Rectangle(AxisXx, AxisYy, 30, 30);

            pictureBox1.CreateGraphics().DrawEllipse(b5Pen5, rec50);

            // Create pen.(The Earth)
            Pen b6Pen6 = new Pen(Color.Aqua, 3);

            // Create rectangle for ellipse.
            Rectangle rec60 = new Rectangle(158 + 50, 378 + 30, 15, 15);

            pictureBox1.CreateGraphics().DrawEllipse(b6Pen6, rec60);

            // Create pen.(Jupiter)
            Pen b7Pen7 = new Pen(Color.Orange, 3);

            // Create rectangle for ellipse.
            Rectangle rec70 = new Rectangle(717 + 50, 378 + 30, 15, 15);

            pictureBox1.CreateGraphics().DrawEllipse(b7Pen7, rec70);
        }

        //Solor system for Venus
        private void label5_Click(object sender, EventArgs e)
        {

            AxisX = (pictureBox1.Width / 2);//0,0
            AxisY = (pictureBox1.Height / 2);

            // Create pen.(circle Orbit around Earth)
            Pen blackPen = new Pen(Color.Ivory, 3);

            // Create rectangle for ellipse.

            Rectangle rect = new Rectangle(145 + 50, 330 + 30, 50, 50);

            pictureBox1.CreateGraphics().DrawEllipse(blackPen, rect);

            // Create pen.(Earth orbit around the sun)
            Pen bPen = new Pen(Color.Cyan, 3);

            // Create rectangle for ellipse.
            Rectangle rec = new Rectangle(220, 185, 400, 400);

            pictureBox1.CreateGraphics().DrawEllipse(bPen, rec);

            // Create pen.(Transfer Orbit to Venus)
            Pen b2Pen = new Pen(Color.Green, 3);

            // Create rectangle for ellipse.
            Rectangle rec2 = new Rectangle(216 + 30, 220 + 30, 314, 290);

            pictureBox1.CreateGraphics().DrawEllipse(b2Pen, rec2);
            // Create pen.(Orbit around Venus)
            Pen b3Pen = new Pen(Color.Ivory, 3);

            // Create rectangle for ellipse(circle Orbit around Venus).
            Rectangle rec3 = new Rectangle(509, 360, 50, 50);

            pictureBox1.CreateGraphics().DrawEllipse(b3Pen, rec3);

            // Create pen(Venus Orbit Around the sun).
            Pen b4Pen = new Pen(Color.SandyBrown, 3);

            // Create rectangle for ellipse.
            Rectangle rec4 = new Rectangle(290, 275, 250, 250);

            pictureBox1.CreateGraphics().DrawEllipse(b4Pen, rec4);

            // Create pen.(The Sun)
            Pen b5Pen = new Pen(Color.Yellow, 3);

            // Create rectangle for ellipse.
            Rectangle rec5 = new Rectangle(400, 375, 30, 30);

            pictureBox1.CreateGraphics().DrawEllipse(b5Pen, rec5);

            // Create pen.(The Earth)
            Pen b6Pen = new Pen(Color.Aqua, 3);

            // Create rectangle for ellipse.
            Rectangle rec6 = new Rectangle(163 + 50, 347 + 30, 15, 15);

            pictureBox1.CreateGraphics().DrawEllipse(b6Pen, rec6);

            // Create pen.(Venus)
            Pen b7Pen = new Pen(Color.SandyBrown, 3);

            // Create rectangle for ellipse.
            Rectangle rec7 = new Rectangle(481 + 50, 348 + 30, 15, 15);

            pictureBox1.CreateGraphics().DrawEllipse(b7Pen, rec7);


        }

        //Solor system for Mercury 
        private void label4_Click(object sender, EventArgs e)
        {
            AxisX = (pictureBox1.Width / 2);//0,0
            AxisY = (pictureBox1.Height / 2);

            // Create pen.(circle Orbit around Earth)
            Pen blackPen = new Pen(Color.Ivory, 3);

            // Create rectangle for ellipse.

            Rectangle rect = new Rectangle(145 + 50, 335 + 30, 50, 50);

            pictureBox1.CreateGraphics().DrawEllipse(blackPen, rect);

            // Create pen.(Earth orbit around the sun)
            Pen bPen = new Pen(Color.Cyan, 3);

            // Create rectangle for ellipse.
            Rectangle rec = new Rectangle(220, 190, 400, 400);

            pictureBox1.CreateGraphics().DrawEllipse(bPen, rec);

            // Create pen.(Transfer Orbit to Mercury )
            Pen b2Pen = new Pen(Color.Green, 3);

            // Create rectangle for ellipse.
            Rectangle rec2 = new Rectangle(216 + 30, 220 + 30, 314, 290);

            pictureBox1.CreateGraphics().DrawEllipse(b2Pen, rec2);
            // Create pen.(Orbit around Mercury)
            Pen b3Pen = new Pen(Color.Ivory, 3);

            // Create rectangle for ellipse(circle Orbit around Mercury).
            Rectangle rec3 = new Rectangle(508, 370, 50, 50);

            pictureBox1.CreateGraphics().DrawEllipse(b3Pen, rec3);

            // Create pen(Mercury Orbit Around the sun).
            Pen b4Pen = new Pen(Color.BurlyWood, 3);

            // Create rectangle for ellipse.
            Rectangle rec4 = new Rectangle(321, 290, 215, 215);

            pictureBox1.CreateGraphics().DrawEllipse(b4Pen, rec4);

            // Create pen.(The Sun)
            Pen b5Pen = new Pen(Color.Yellow, 3);

            // Create rectangle for ellipse.
            Rectangle rec5 = new Rectangle(400, 375, 30, 30);

            pictureBox1.CreateGraphics().DrawEllipse(b5Pen, rec5);

            // Create pen.(The Earth)
            Pen b6Pen = new Pen(Color.Aqua, 3);

            // Create rectangle for ellipse.
            Rectangle rec6 = new Rectangle(163 + 50, 352 + 30, 15, 15);

            pictureBox1.CreateGraphics().DrawEllipse(b6Pen, rec6);

            // Create pen.(Mercury)
            Pen b7Pen = new Pen(Color.BurlyWood, 3);

            // Create rectangle for ellipse.
            Rectangle rec7 = new Rectangle(479 + 50, 356 + 30, 15, 15);

            pictureBox1.CreateGraphics().DrawEllipse(b7Pen, rec7);
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

        }

               // mars button
        public void button4_Click(object sender, EventArgs e)
        {
            string newline = Environment.NewLine;
            textBox1.Text = "Mars Parameters:"+newline+"-Mass (10^24kg): 0.64169"+newline+"-Semimajor axis (106 km):	227.956" + newline + "-Surface Gravity(m/s^2): 3.71" + newline + "-Length of Day(hrs):24.6229" + newline+"-Mars' Semi Major axis is approximately 152% bigger than Earth’s Semi Major axis." + newline + " " + newline + "*Orbits are not up to scale.";
            textBox2.Text = "Earth Parameters:" + newline + "-Mass (10^24kg): 5.9722" + newline + "-Semimajor axis (106 km): 149.598" + newline + "-Surface Gravity(m/s^2): 9.798"+newline+"-Length of Day(hrs):24.0";





            pictureBox1.Refresh();

                        //redrawOribits();
            label1_Click(sender, e);
            // Create rectangle for ellipse(circle.
            int spTempX = 30 + spCountX;
            int spTempY = 30 - spCountY;
            if (Angle < 0 ){  //change < to >
                Angle = 360.00; 
            }
            Angle = Angle - 60.0; 

            coordinate = PoltoC(Angle, 215.00);
            if (coordinate.X > 0)
            {
                coordinate.X = coordinate.X + 100; 
            }
            if (coordinate.Y > 0)
            {
                coordinate.Y = coordinate.Y + 18;
            }


            if (coordinate.X > 0)
            {
                coordinate.X = coordinate.X + AxisX;
            }
            else
            {
                coordinate.X = (AxisX - Math.Abs(coordinate.X)) ;
            }

            if (coordinate.Y > 0)
            {
                coordinate.Y = coordinate.Y + AxisY;
            } else
            {
             
                coordinate.Y = coordinate.Y + AxisY;
            }
   
            Rectangle rect6 = new Rectangle( coordinate.X, coordinate.Y, 10, 10); 
            Pen b3Pen6 = new Pen(Color.DimGray, 5);
            pictureBox1.CreateGraphics().DrawEllipse(b3Pen6, rect6);    

        }

        public Point PoltoC(double angle, double radius)
        {

            double angleRad = -(Math.PI / 180.0) * (angle - 122); //change - before (Math.IP/180) 
            // angleRad = (Math.PI / angle);
            double x = radius * Math.Cos(angleRad);
            double y = radius * Math.Sin(angleRad);
            int newX = ((int)x);
            int newY = ((int)y);

            return new Point(newX, newY);

        }
        public Point PoltoCA(double angle, double radius)
        {

            double angleRad = -(Math.PI / 180.0) * (angle - 122); //change - before (Math.IP/180) 
            // angleRad = (Math.PI / angle);
            double x = radius * Math.Cos(angleRad);
            double y = radius * Math.Sin(angleRad);
            int newX = ((int)x);
            int newY = ((int)y);

            return new Point(newX, newY);

        }

        public Point PoltoCB(double angle, double radius)
        {

            double angleRad = -(Math.PI / 180.0) * (angle - 100); //change - before (Math.IP/180) 
            // angleRad = (Math.PI / angle);
            double x = radius * Math.Cos(angleRad);
            double y = radius * Math.Sin(angleRad);
            int newX = ((int)x);
            int newY = ((int)y);

            return new Point(newX, newY);

        }
        public Point PoltoCC(double angle, double radius)
        {

            double angleRad = -(Math.PI / 180.0) * (angle - 100); //change - before (Math.IP/180) 
            // angleRad = (Math.PI / angle);
            double x = radius * Math.Cos(angleRad);
            double y = radius * Math.Sin(angleRad);
            int newX = ((int)x);
            int newY = ((int)y);

            return new Point(newX, newY);

        }



        private void button5_Click(object sender, EventArgs e)
        {
            string newline = Environment.NewLine;
            textBox1.Text = "Jupiter Parameters:"+newline+"-Mass (10^24kg): 1,898.13"+newline+"-Semimajor axis (106 km): 778.479" + newline + "-Surface Gravity(m/s^2): 24.79" + newline + "-Length of Day(hrs):9.9259" + newline+"-Jupiter's Semi Major axis is approximately 520% bigger than Earth’s Semi Major axis." + newline + " " + newline + "*Orbits are not up to scale.";
            textBox2.Text = "Earth Parameters:" + newline + "-Mass (10^24kg): 5.9722" + newline + "-Semimajor axis (106 km): 149.598" + newline + "-Surface Gravity(m/s^2): 9.798" + newline + "-Length of Day(hrs):24.0";

            // for (int i = 0; i <4; i++){
            //   button5 =i;
            // }

            //for (int i = 0; i < 5; i++)    // Does a check for each button.
            //{
            //   button5.PerformClick()
            //}
            //int j = 1;

            //while (j <= 10)
            // {


            //j++;



            pictureBox1.Refresh();

            //redrawOribits();
            label6_Click(sender, e);
            // Create rectangle for ellipse(circle.
            int spTempX = 30 + spCountX;
            int spTempY = 30 - spCountY;
            if (Angle < 0)
            {
                Angle = 360.00;
            }
            Angle = Angle - 60.0;

            coordinate = PoltoCA(Angle, 215.00);
            if (coordinate.X > 0)
            {
                coordinate.X = coordinate.X + 130;
            }
            if (coordinate.Y > 0)
            {
                coordinate.Y = coordinate.Y + 18;
            }


            if (coordinate.X > 0)
            {
                coordinate.X = coordinate.X + AxisXx;
            }
            else
            {
                coordinate.X = (AxisXx - Math.Abs(coordinate.X));
            }

            if (coordinate.Y > 0)
            {
                coordinate.Y = coordinate.Y + AxisYy;
            }
            else
            {

                coordinate.Y = coordinate.Y + AxisYy;
            }

            Rectangle rect5 = new Rectangle(coordinate.X, coordinate.Y, 10, 10);
            Pen b3Pen5 = new Pen(Color.DimGray, 5);
            pictureBox1.CreateGraphics().DrawEllipse(b3Pen5, rect5);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = pictureBox1.InitialImage;
            Application.Restart();



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string newline = Environment.NewLine;
            textBox1.Text = "Venus Parameters:"+newline+"-Mass (10^24kg): 4.8673"+newline+"-Semimajor axis (106 km):	108.210" + newline + "-Surface Gravity(m/s^2): 8.87" + newline + "-Length of Day(hrs):2802.0" + newline+"-Venus' Semi Major axis is approximately 72.3% smaller than Earth’s Semi Major axis." + newline + " " + newline + "*Orbits are not up to scale.";
            textBox2.Text = "Earth Parameters:" + newline + "-Mass (10^24kg): 5.9722" + newline + "-Semimajor axis (106 km): 149.598" + newline + "-Surface Gravity(m/s^2): 9.798" + newline + "-Length of Day(hrs):24.0";





            pictureBox1.Refresh();

            //redrawOribits();
            label5_Click(sender, e);
            // Create rectangle for ellipse(circle.
            int spTempX = 30 + spCountX;
            int spTempY = 30 - spCountY;
            if (Angle < 0)
            {
                Angle = 360.00;
            }
            Angle = Angle - 83.0;

            coordinate = PoltoCB(Angle, 160.00);
            if (coordinate.X > 0)
            {
                coordinate.X = coordinate.X * (1);
            }
            if (coordinate.Y > 0)
            {
                coordinate.Y = coordinate.Y * (-1);
            }


            if (coordinate.X > 0)
            {
                coordinate.X = coordinate.X + AxisX;
            }
            else
            {
                coordinate.X = (AxisX - Math.Abs(coordinate.X));
            }

            if (coordinate.Y > 0)
            {
                coordinate.Y = coordinate.Y + AxisY;
            }
            else
            {

                coordinate.Y = coordinate.Y + AxisY;
            }

            Rectangle rect4 = new Rectangle(coordinate.X, coordinate.Y, 10, 10);
            Pen b3Pen4 = new Pen(Color.DimGray, 5);
            pictureBox1.CreateGraphics().DrawEllipse(b3Pen4, rect4);

        
    }

        private void button1_Click(object sender, EventArgs e)
        {
            string newline = Environment.NewLine;
            textBox1.Text = "Mercury Parameters:" +newline+ "-Mass (10^24kg): 0.33010" +newline+ "-Semimajor axis (106 km): 57.909" + newline + "-Surface Gravity(m/s^2): 3.70" + newline + "-Length of Day(hrs):4222.6" + newline+"-Mercury's Semi Major axis is approximately 38.7% smaller than Earth’s Semi Major axis." + newline + " " + newline + "*Orbits are not up to scale.";
            textBox2.Text = "Earth Parameters:" + newline + "-Mass (10^24kg): 5.9722" + newline + "-Semimajor axis (106 km): 149.598" + newline + "-Surface Gravity(m/s^2): 9.798" + newline + "-Length of Day(hrs):24.0";





            pictureBox1.Refresh();

            //redrawOribits();
            label4_Click(sender, e);
            // Create rectangle for ellipse(circle.
            int spTempX = 30 + spCountX;
            int spTempY = 30 - spCountY;
            if (Angle < 0)
            {
                Angle = 360.00;
            }
            Angle = Angle - 83.0;

            coordinate = PoltoCC(Angle, 160.00);
            if (coordinate.X > 0)
            {
                coordinate.X = coordinate.X * (1);
            }
            if (coordinate.Y > 0)
            {
                coordinate.Y = coordinate.Y * (-1);
            }


            if (coordinate.X > 0)
            {
                coordinate.X = coordinate.X + AxisX;
            }
            else
            {
                coordinate.X = (AxisX - Math.Abs(coordinate.X));
            }

            if (coordinate.Y > 0)
            {
                coordinate.Y = coordinate.Y + AxisY;
            }
            else
            {

                coordinate.Y = coordinate.Y + AxisY;
            }

            Rectangle rect3 = new Rectangle(coordinate.X, coordinate.Y, 10, 10);
            Pen b3Pen3 = new Pen(Color.DimGray, 5);
            pictureBox1.CreateGraphics().DrawEllipse(b3Pen3, rect3);


        }

        private void button6_Click(object sender, EventArgs e)
        {
            string newline = Environment.NewLine;
            textBox1.Text = "The Solar System"+newline+" "+newline+"-First Circle,Sun:Yellow."+newline+ "-Second Circle,Mercury:Burly Brown." + newline+ "-Third Circle, Venus:Sandy Brown." + newline+ "-Fourth Circle, Earth:Cyan." + newline+ "-Fifth Circle, Mars:Red." + newline+ "-Sixth Circle, Jupiter:Orange." + newline+ "-Seventh Circle, Saturn:Dark Olive Green." + newline+ "-Eigth Circle, Uranus:light Blue." + newline+ "-Ninth Circle, Neptune:Aquamarine." + newline+" "+newline+"*Orbits are not up to scale.";
            pictureBox1.Refresh();
            label3_Click(sender, e);
        }
    }
}



    
