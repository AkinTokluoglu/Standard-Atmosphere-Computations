namespace calculator
{

    public partial class Form1 : Form
    {

        double R = 287.0; // fixed number
        double lamda = 1.4; // number of lamda
        double t0 = 288.15; //base temp
        double eu = 2.718; // number of euler
        double g = 9.81; //gravity
        double a, h0, p0, Ro;
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {

            double h1 = Convert.ToDouble(textBox1.Text); //altitude
            double v = Convert.ToDouble(textBox2.Text); //speed
            double D = Convert.ToDouble(textBox3.Text); //reference lenght

            if (h1 <= 11000) //h1= altitude 0-11000
            {

                h0 = 0;
                a = -6.5;
                p0 = 101325; //base pressure

                double temp = t0 + a * (h1 / 1000); //Temputere
                textBox4.Text = Convert.ToString(temp);

                double p1 = p0 * Math.Pow((temp / t0), -g / (-0.0065 * R));//calculete p1
                textBox6.Text = Convert.ToString(p1);

                double Ro = p1 / (R * temp);
                textBox5.Text = Convert.ToString(Ro);

                double c = Math.Sqrt(lamda * R * temp); // speed of sound
                textBox7.Text = Convert.ToString(c);


                double M = ((0.000001458) * Math.Sqrt(temp)) / ((110.4 / temp) + 1); // Viskosity

                textBox8.Text = Convert.ToString(M);

                double ReyNum = (Ro * v * D) / M; //reynold numbers
                textBox13.Text = Convert.ToString(ReyNum);

                double dynmc = (Ro * v * v) / 2.0; //dynamic pressure
                textBox10.Text = Convert.ToString(dynmc);

                double MacNum = v / c;
                textBox9.Text = Convert.ToString(MacNum); //Mach Number




            }

            else if (h1 > 11000 && h1 <= 20000)
            {
                t0 = 273.15 - 56.5;
                h0 = 11000;
                a = 0.0;// a value is 0. 
                p0 = 22632; //base pressure

                double temp = t0; //Temputere
                textBox4.Text = Convert.ToString(temp);

                double p1 = p0 * Math.Pow(eu, (-g * ((h1 - h0)) / (R * temp)));//different formula is used because it has different a 									//value when calculating p1
                textBox6.Text = Convert.ToString(p1);

                double c = Math.Sqrt(lamda * R * temp); // speed of sound
                textBox7.Text = Convert.ToString(c);

                double Ro = p1 / (R * temp);
                textBox5.Text = Convert.ToString(Ro);

                double M = ((0.000001458) * Math.Sqrt(temp)) / ((110.4 / temp) + 1); // Viskosity
                textBox8.Text = Convert.ToString(M);

                double ReyNum = (Ro * v * D) / M; //reynold numbers
                textBox13.Text = Convert.ToString(ReyNum);

                double dynmc = (Ro * v * v) / 2.0; //dynamic pressure
                textBox10.Text = Convert.ToString(dynmc);

                double MacNum = v / c;
                textBox9.Text = Convert.ToString(MacNum); //Mach Number





            }

            else if (h1 > 20000 && h1 <= 32000)
            {
                t0 = 273.15 - 56.5;
                h0 = 20000;
                a = 1.0;
                p0 = 5474.9; //base pressure

                double temp = t0 + a * ((h1 - h0) / 1000); //Temputere
                textBox4.Text = Convert.ToString(temp);

                double p1 = p0 * Math.Pow((temp / t0), -g / (0.001 * R));//calculete p1
                textBox6.Text = Convert.ToString(p1);

                double Ro = p1 / (R * temp);
                textBox5.Text = Convert.ToString(Ro);

                double c = Math.Sqrt(lamda * R * temp); // speed of sound
                textBox7.Text = Convert.ToString(c);


                double M = ((0.000001458) * Math.Sqrt(temp)) / ((110.4 / temp) + 1); // Viskosity

                textBox8.Text = Convert.ToString(M);

                double ReyNum = (Ro * v * D) / M; //reynold numbers
                textBox13.Text = Convert.ToString(ReyNum);

                double dynmc = (Ro * v * v) / 2.0; //dynamic pressure
                textBox10.Text = Convert.ToString(dynmc);

                double MacNum = v / c;
                textBox9.Text = Convert.ToString(MacNum); //Mach Number





            }

            else if (h1 > 32000 && h1 <= 47000)
            {
                t0 = 273.15 - 44.5;
                h0 = 32000;
                a = 2.8;
                p0 = 868.02; //base pressure

                double temp = t0 + a * ((h1 - h0) / 1000); //Temputere
                textBox4.Text = Convert.ToString(temp);

                double p1 = p0 * Math.Pow((temp / t0), -g / (0.0028 * R));//calculete p1
                textBox6.Text = Convert.ToString(p1);

                double Ro = p1 / (R * temp);
                textBox5.Text = Convert.ToString(Ro);

                double c = Math.Sqrt(lamda * R * temp); // speed of sound
                textBox7.Text = Convert.ToString(c);


                double M = ((0.000001458) * Math.Sqrt(temp)) / ((110.4 / temp) + 1); // Viskosity

                textBox8.Text = Convert.ToString(M);

                double ReyNum = (Ro * v * D) / M; //reynold numbers
                textBox13.Text = Convert.ToString(ReyNum);

                double dynmc = (Ro * v * v) / 2.0; //dynamic pressure
                textBox10.Text = Convert.ToString(dynmc);

                double MacNum = v / c;
                textBox9.Text = Convert.ToString(MacNum); //Mach Number



            }

            else if (h1 > 47000 && h1 <= 51000)
            {
                t0 = 273.15 - 2.5;
                h0 = 47000;
                a = 0.0;
                p0 = 110.91; //base pressure

                double temp = t0; //Temputere
                textBox4.Text = Convert.ToString(temp);

                double p1 = p0 * Math.Pow(eu, (-g * ((h1 - h0)) / (R * temp)));//calculete p1 
                textBox6.Text = Convert.ToString(p1);

                double c = Math.Sqrt(lamda * R * temp); // speed of sound
                textBox7.Text = Convert.ToString(c);

                double Ro = p1 / (R * temp);
                textBox5.Text = Convert.ToString(Ro);

                double M = ((0.000001458) * Math.Sqrt(temp)) / ((110.4 / temp) + 1); // Viskosity
                textBox8.Text = Convert.ToString(M);

                double ReyNum = (Ro * v * D) / M; //reynold numbers
                textBox13.Text = Convert.ToString(ReyNum);

                double dynmc = (Ro * v * v) / 2.0; //dynamic pressure
                textBox10.Text = Convert.ToString(dynmc);

                double MacNum = v / c;
                textBox9.Text = Convert.ToString(MacNum); //Mach Number


            }

            else if (h1 > 51000 && h1 <= 71000)
            {
                t0 = 273.15 - 2.5;
                h0 = 51000;
                a = -2.8;
                p0 = 66.939; //base pressure

                double temp = t0 + a * ((h1 - h0) / 1000); //Temputere
                textBox4.Text = Convert.ToString(temp);

                double p1 = p0 * Math.Pow((temp / t0), -g / (-0.0028 * R));//calculete p1
                textBox6.Text = Convert.ToString(p1);

                double Ro = p1 / (R * temp);//density
                textBox5.Text = Convert.ToString(Ro);

                double c = Math.Sqrt(lamda * R * temp); // speed of sound
                textBox7.Text = Convert.ToString(c);


                double M = ((0.000001458) * Math.Sqrt(temp)) / ((110.4 / temp) + 1); // Viskosity

                textBox8.Text = Convert.ToString(M);

                double ReyNum = (Ro * v * D) / M; //reynold numbers
                textBox13.Text = Convert.ToString(ReyNum);

                double dynmc = (Ro * v * v) / 2.0; //dynamic pressure
                textBox10.Text = Convert.ToString(dynmc);

                double MacNum = v / c;
                textBox9.Text = Convert.ToString(MacNum); //Mach Number


            }

            else if (h1 > 71000 && h1 <= 84852)
            {
                t0 = 273.15 - 58.5;
                h0 = 51000;
                a = -2.0;
                p0 = 3.9564; //base pressure

                double temp = t0 + a * ((h1 - h0) / 1000); //Temputere
                textBox4.Text = Convert.ToString(temp);

                double p1 = p0 * Math.Pow((temp / t0), -g / (-0.002 * R));//calculete p1
                textBox6.Text = Convert.ToString(p1);

                double Ro = p1 / (R * temp);
                textBox5.Text = Convert.ToString(Ro);

                double c = Math.Sqrt(lamda * R * temp); // speed of sound
                textBox7.Text = Convert.ToString(c);


                double M = ((0.000001458) * Math.Sqrt(temp)) / ((110.4 / temp) + 1); // Viskosity

                textBox8.Text = Convert.ToString(M);

                double ReyNum = (Ro * v * D) / M; //reynold numbers
                textBox13.Text = Convert.ToString(ReyNum);

                double dynmc = (Ro * v * v) / 2.0; //dynamic pressure
                textBox10.Text = Convert.ToString(dynmc);

                double MacNum = v / c;
                textBox9.Text = Convert.ToString(MacNum); //Mach Number


            }

        }
    }
}