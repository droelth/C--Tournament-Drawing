using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> teamlist = new List<string>();
        int takımsayısı = 0;
        string oyuncu1;
        string oyuncu2;
        string oyuncu3;
        string oyuncu4;
        int oyuncu1puan;
        int oyuncu2puan;
        int oyuncu3puan;
        int oyuncu4puan;
        int oyuncu1avr;
        int oyuncu2avr;
        int oyuncu3avr;
        int oyuncu4avr;

        int ikili12;
        int ikili13;
        int ikili14;
        int ikili23;
        int ikili24;
        int ikili34;
       
        //
        
        private void button1_Click(object sender, EventArgs e)
        {
            takımsecim();



            if (takımsayısı == 4)
            {
                
                button1.Enabled = true;
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
                checkBox5.Enabled = false;
                checkBox6.Enabled = false;
                checkBox7.Enabled = false;
                checkBox8.Enabled = false;
            }


            else
            {
                MessageBox.Show("4 takım seçin");
            }
        }
        private void ileriBtn_Click(object sender, EventArgs e)
        {

            textBox5.Text = teamlist[0].ToString();
            textBox6.Text = teamlist[1].ToString();
            textBox7.Text = teamlist[2].ToString();
            textBox8.Text = teamlist[3].ToString();
            button1.Enabled = false;
            ileriBtn.Enabled = false;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            oyuncuIsimleriBtn.Enabled = true;
        }
        private void btnFikstur_Click(object sender, EventArgs e)
        {
            puandurumuGBox.Visible = true;
            fiksturGBox.Visible = true;
            Random rnd = new Random();
            int x = rnd.Next(1, 4);

            if (x == 1)
            {
                fikstur1();
            }
            else if (x == 2)
            {
                fikstur2();
            }
            else if (x == 3)
            {
                fikstur3();
            }
            btnFikstur.Enabled = false;
            mtb1.Enabled = true;
            mtb2.Enabled = true;
            mtb3.Enabled = true;
            mtb4.Enabled = true;
            mtb5.Enabled = true;
            mtb6.Enabled = true;
            mtb7.Enabled = true;
            mtb8.Enabled = true;
            mtb9.Enabled = true;
            mtb10.Enabled = true;
            mtb11.Enabled = true;
            mtb12.Enabled = true;

            guncelle1Btn.Enabled = true;
        }

        private void ileri2Btn_Click(object sender, EventArgs e)
        {
            oyuncu1 = textBox1.Text;
            oyuncu2 = textBox2.Text;
            oyuncu3 = textBox3.Text;
            oyuncu4 = textBox4.Text;

            btnFikstur.Enabled = true;
            

            label9.Text = oyuncu1;
            label10.Text = oyuncu2;
            label11.Text = oyuncu3;
            label12.Text = oyuncu4;

            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;

            textBox5.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = true;
            
            btnFikstur.Visible = true;
            ileri2Btn.Enabled = false;
        }

        private void oyuncuIsimleriBtn_Click(object sender, EventArgs e)
        {
            oyuncuisimleri();
            
        }

        private void guncelle1Btn_Click(object sender, EventArgs e)
        {
            
            string x = ev1.Text;
            string y = dep1.Text;



            if (mtb1.Text != "" && mtb2.Text != "")
            {
                int a = Convert.ToInt32(mtb1.Text);
                int b = Convert.ToInt32(mtb2.Text);
                whowins(a, b, x, y);
                puanguncelle();
                skorukapa();
                guncelle1Btn.Enabled = false;
            }
            else
                MessageBox.Show("Skoru giriniz!");
            
        }

        private void guncelle2Btn_Click(object sender, EventArgs e)
        {
            
            string x = ev2.Text;
            string y = dep2.Text;

            if (mtb3.Text != "" && mtb4.Text != "")
            {
                int a = Convert.ToInt32(mtb3.Text);
                int b = Convert.ToInt32(mtb4.Text);
                whowins(a, b, x, y);
                puanguncelle();
                skorukapa();
                guncelle2Btn.Enabled = false;
            }
            else
                MessageBox.Show("Skoru giriniz!");
            
        }

        private void guncelle3Btn_Click(object sender, EventArgs e)
        {
            
            string x = ev3.Text;
            string y = dep3.Text;

            if (mtb5.Text != "" && mtb6.Text != "")
            {
                int a = Convert.ToInt32(mtb5.Text);
                int b = Convert.ToInt32(mtb6.Text);
                whowins(a, b, x, y);
                puanguncelle();
                skorukapa();
                guncelle3Btn.Enabled = false;
            }
            else
                MessageBox.Show("Skoru giriniz!");
        }

        private void guncelle4Btn_Click(object sender, EventArgs e)
        {
            
            string x = ev4.Text;
            string y = dep4.Text;

            if (mtb7.Text != "" && mtb8.Text != "")
            {
                int a = Convert.ToInt32(mtb7.Text);
                int b = Convert.ToInt32(mtb8.Text);
                whowins(a, b, x, y);
                puanguncelle();
                skorukapa();
                guncelle4Btn.Enabled = false;
            }
            else
                MessageBox.Show("Skoru giriniz!");
        }

        private void guncelle5Btn_Click(object sender, EventArgs e)
        {
            
            string x = ev5.Text;
            string y = dep5.Text;

            if (mtb9.Text != "" && mtb10.Text != "")
            {
                int a = Convert.ToInt32(mtb9.Text);
                int b = Convert.ToInt32(mtb10.Text);
                whowins(a, b, x, y);
                puanguncelle();
                skorukapa();
                guncelle5Btn.Enabled = false;
            }
            else
                MessageBox.Show("Skoru giriniz!");
        }

        private void guncelle6Btn_Click(object sender, EventArgs e)
        {
            
            string x = ev6.Text;
            string y = dep6.Text;

            if (mtb11.Text != "" && mtb12.Text != "")
            {
                int a = Convert.ToInt32(mtb11.Text);
                int b = Convert.ToInt32(mtb12.Text);
                whowins(a, b, x, y);
                puanguncelle();
                skorukapa();
                guncelle6Btn.Enabled = false;
                puansıralaması();
            }
            else
                MessageBox.Show("Skoru giriniz!");

            
        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // FONKSİYONLAR //
        public void takımsecim()
        {
            takımsayısı = 0;
            if (checkBox1.Checked)
            {
                takımsayısı++;
            }
            if (checkBox2.Checked)
            {
                takımsayısı++;
            }
            if (checkBox3.Checked)
            {
                takımsayısı++;
            }
            if (checkBox4.Checked)
            {
                takımsayısı++;
            }
            if (checkBox5.Checked)
            {
                takımsayısı++;
            }
            if (checkBox6.Checked)
            {
                takımsayısı++;
            }
            if (checkBox7.Checked)
            {
                takımsayısı++;
            }
            if (checkBox8.Checked)
            {                
                takımsayısı++;
            }

            if (takımsayısı == 4)
            {
                if (checkBox1.Checked)
                {
                    teamlist.Add(checkBox1.Text);                    
                }
                if (checkBox2.Checked)
                {
                    teamlist.Add(checkBox2.Text);                    
                }
                if (checkBox3.Checked)
                {
                    teamlist.Add(checkBox3.Text);                    
                }
                if (checkBox4.Checked)
                {
                    teamlist.Add(checkBox4.Text);                    
                }
                if (checkBox5.Checked)
                {
                    teamlist.Add(checkBox5.Text);                    
                }
                if (checkBox6.Checked)
                {
                    teamlist.Add(checkBox6.Text);                    
                }
                if (checkBox7.Checked)
                {
                    teamlist.Add(checkBox7.Text);                    
                }
                if (checkBox8.Checked)
                {
                    teamlist.Add(checkBox8.Text);                    
                }
            }
        }
        public void fikstur1()
        {
            ev1.Text = ev3.Text = dep5.Text = oyuncu1;
            dep1.Text = ev4.Text = dep6.Text = oyuncu2;
            ev2.Text = dep4.Text = ev5.Text = oyuncu3;
            dep2.Text = dep3.Text = ev6.Text = oyuncu4;
        }
        public void fikstur2()
        {
            dep1.Text = dep4.Text = ev5.Text = oyuncu1;
            ev2.Text = dep3.Text = dep5.Text = oyuncu2;
            ev1.Text = ev3.Text = dep6.Text = oyuncu3;
            dep2.Text = ev4.Text = ev6.Text = oyuncu4;
        }
        public void fikstur3()
        {
            ev1.Text = dep3.Text = ev6.Text = oyuncu1;
            dep2.Text = ev3.Text = ev5.Text = oyuncu2;
            ev2.Text = dep4.Text = dep6.Text = oyuncu3;
            dep1.Text = ev4.Text = dep5.Text = oyuncu4;
        }
        public void skorukapa()
        {
            if (mtb1.Text != "" && mtb2.Text != "")
            {
                mtb1.Enabled = false;
                mtb2.Enabled = false;
            }

            if (mtb3.Text != "" && mtb4.Text != "")
            {
                mtb3.Enabled = false;
                mtb4.Enabled = false;
            }

            if (mtb5.Text != "" && mtb6.Text != "")
            {
                mtb5.Enabled = false;
                mtb6.Enabled = false;
            }

            if (mtb7.Text != "" && mtb8.Text != "")
            {
                mtb7.Enabled = false;
                mtb8.Enabled = false;
            }

            if (mtb9.Text != "" && mtb10.Text != "")
            {
                mtb9.Enabled = false;
                mtb10.Enabled = false;
            }

            if (mtb11.Text != "" && mtb12.Text != "")
            {
                mtb11.Enabled = false;
                mtb12.Enabled = false;
            }


        }
        public void puanguncelle()
        {
            label5.Text = oyuncu1puan.ToString();
            label6.Text = oyuncu2puan.ToString();
            label7.Text = oyuncu3puan.ToString();
            label8.Text = oyuncu4puan.ToString();

        }
        public void whowins(int a, int b, string x, string y)
        {
            int avr = a - b;
            int ev = 0;
            int dep = 0;

            if (x == oyuncu1)
            {
                ev = 1;
            }
            else if (x == oyuncu2)
            {
                ev = 2;
            }
            else if (x == oyuncu3)
            {
                ev = 3;
            }
            else if (x == oyuncu4)
            {
                ev = 4;
            }

            if (y == oyuncu1)
            {
                dep = 1;
            }
            else if (y == oyuncu2)
            {
                dep = 2;
            }
            else if (y == oyuncu3)
            {
                dep = 3;
            }
            else if (y == oyuncu4)
            {
                dep = 4;
            }


            if (ev == 1 && dep == 2)
            {
                if (a > b)
                {
                    oyuncu1avr = oyuncu1avr + avr;
                    oyuncu1puan = oyuncu1puan + 3;
                    oyuncu2avr = oyuncu2avr - avr;
                    ikili12 = 1;
                }
                else if (a == b)
                {
                    oyuncu1puan++;
                    oyuncu2puan++;
                    ikili12 = 0;
                }
                else
                {
                    oyuncu1avr = oyuncu1avr + avr;
                    oyuncu2puan = oyuncu2puan + 3;
                    oyuncu2avr = oyuncu2avr - avr;
                    ikili12 = 2;
                }
            }
            if (ev == 1 && dep == 3)
            {
                if (a > b)
                {
                    oyuncu1avr = oyuncu1avr + avr;
                    oyuncu1puan = oyuncu1puan + 3;
                    oyuncu3avr = oyuncu3avr - avr;
                    ikili13 = 1;
                }
                else if (a == b)
                {
                    oyuncu1puan++;
                    oyuncu3puan++;
                    ikili13 = 0;
                }
                else
                {
                    oyuncu1avr = oyuncu1avr + avr;
                    oyuncu3puan = oyuncu3puan + 3;
                    oyuncu3avr = oyuncu3avr - avr;
                    ikili13 = 3;
                }
            }
            if (ev == 1 && dep == 4)
            {
                if (a > b)
                {
                    oyuncu1avr = oyuncu1avr + avr;
                    oyuncu1puan = oyuncu1puan + 3;
                    oyuncu4avr = oyuncu4avr - avr;
                    ikili14 = 1;
                }
                else if (a == b)
                {
                    oyuncu1puan++;
                    oyuncu4puan++;
                    ikili14 = 0;
                }
                else
                {
                    oyuncu1avr = oyuncu1avr + avr;
                    oyuncu4puan = oyuncu4puan + 3;
                    oyuncu4avr = oyuncu4avr - avr;
                    ikili14 = 4;
                }
            }
            if (ev == 2 && dep == 1)
            {
                if (a > b)
                {
                    oyuncu2avr = oyuncu2avr + avr;
                    oyuncu2puan = oyuncu2puan + 3;
                    oyuncu1avr = oyuncu1avr - avr;
                    ikili12 = 2;
                }
                else if (a == b)
                {
                    oyuncu2puan++;
                    oyuncu1puan++;
                    ikili12 = 0;
                }
                else
                {
                    oyuncu2avr = oyuncu2avr + avr;
                    oyuncu1puan = oyuncu1puan + 3;
                    oyuncu1avr = oyuncu1avr - avr;
                    ikili12 = 1;
                }
            }
            if (ev == 2 && dep == 3)
            {
                if (a > b)
                {
                    oyuncu2avr = oyuncu2avr + avr;
                    oyuncu2puan = oyuncu2puan + 3;
                    oyuncu3avr = oyuncu3avr - avr;
                    ikili23 = 2;
                }
                else if (a == b)
                {
                    oyuncu2puan++;
                    oyuncu3puan++;
                    ikili23 = 0;
                }
                else
                {
                    oyuncu2avr = oyuncu2avr + avr;
                    oyuncu3puan = oyuncu3puan + 3;
                    oyuncu3avr = oyuncu3avr - avr;
                    ikili23 = 3;
                }
            }
            if (ev == 2 && dep == 4)
            {
                if (a > b)
                {
                    oyuncu2avr = oyuncu2avr + avr;
                    oyuncu2puan = oyuncu2puan + 3;
                    oyuncu4avr = oyuncu4avr - avr;
                    ikili24 = 2;
                }
                else if (a == b)
                {
                    oyuncu2puan++;
                    oyuncu4puan++;
                    ikili24 = 0;
                }
                else
                {
                    oyuncu2avr = oyuncu2avr + avr;
                    oyuncu4puan = oyuncu4puan + 3;
                    oyuncu4avr = oyuncu4avr - avr;
                    ikili24 = 4;
                }
            }
            if (ev == 3 && dep == 1)
            {
                if (a > b)
                {
                    oyuncu3avr = oyuncu3avr + avr;
                    oyuncu3puan = oyuncu3puan + 3;
                    oyuncu1avr = oyuncu1avr - avr;
                    ikili13 = 3;
                }
                else if (a == b)
                {
                    oyuncu3puan++;
                    oyuncu1puan++;
                    ikili13 = 0;
                }
                else
                {
                    oyuncu3avr = oyuncu3avr + avr;
                    oyuncu1puan = oyuncu1puan + 3;
                    oyuncu1avr = oyuncu1avr - avr;
                    ikili13 = 1;
                }
            }
            if (ev == 3 && dep == 2)
            {
                if (a > b)
                {
                    oyuncu3avr = oyuncu3avr + avr;
                    oyuncu3puan = oyuncu3puan + 3;
                    oyuncu2avr = oyuncu2avr - avr;
                    ikili23 = 3;
                }
                else if (a == b)
                {
                    oyuncu3puan++;
                    oyuncu2puan++;
                    ikili23 = 0;
                }
                else
                {
                    oyuncu3avr = oyuncu3avr + avr;
                    oyuncu2puan = oyuncu2puan + 3;
                    oyuncu2avr = oyuncu2avr - avr;
                    ikili23 = 2;
                }
            }
            if (ev == 3 && dep == 4)
            {
                if (a > b)
                {
                    oyuncu3avr = oyuncu3avr + avr;
                    oyuncu3puan = oyuncu3puan + 3;
                    oyuncu4avr = oyuncu4avr - avr;
                    ikili34 = 3;
                }
                else if (a == b)
                {
                    oyuncu3puan++;
                    oyuncu4puan++;
                    ikili34 = 0;
                }
                else
                {
                    oyuncu3avr = oyuncu3avr + avr;
                    oyuncu4puan = oyuncu4puan + 3;
                    oyuncu4avr = oyuncu4avr - avr;
                    ikili34 = 4;
                }
            }
            if (ev == 4 && dep == 1)
            {
                if (a > b)
                {
                    oyuncu4avr = oyuncu4avr + avr;
                    oyuncu4puan = oyuncu4puan + 3;
                    oyuncu1avr = oyuncu1avr - avr;
                    ikili14 = 4;
                }
                else if (a == b)
                {
                    oyuncu4puan++;
                    oyuncu1puan++;
                    ikili14 = 0;
                }
                else
                {
                    oyuncu4avr = oyuncu4avr + avr;
                    oyuncu1puan = oyuncu1puan + 3;
                    oyuncu1avr = oyuncu1avr - avr;
                    ikili14 = 1;
                }
            }
            if (ev == 4 && dep == 2)
            {
                if (a > b)
                {
                    oyuncu4avr = oyuncu4avr + avr;
                    oyuncu4puan = oyuncu4puan + 3;
                    oyuncu2avr = oyuncu2avr - avr;
                    ikili24 = 4;
                }
                else if (a == b)
                {
                    oyuncu4puan++;
                    oyuncu2puan++;
                    ikili24 = 0;
                }
                else
                {
                    oyuncu4avr = oyuncu4avr + avr;
                    oyuncu2puan = oyuncu2puan + 3;
                    oyuncu2avr = oyuncu2avr - avr;
                    ikili24 = 2;
                }
            }
            if (ev == 4 && dep == 3)
            {
                if (a > b)
                {
                    oyuncu4avr = oyuncu4avr + avr;
                    oyuncu4puan = oyuncu4puan + 3;
                    oyuncu3avr = oyuncu3avr - avr;
                    ikili34 = 4;
                }
                else if (a == b)
                {
                    oyuncu4puan++;
                    oyuncu3puan++;
                    ikili34 = 0;
                }
                else
                {
                    oyuncu4avr = oyuncu4avr + avr;
                    oyuncu3puan = oyuncu3puan + 3;
                    oyuncu3avr = oyuncu3avr - avr;
                    ikili34 = 3;
                }
            }

            label1.Text = Convert.ToString(oyuncu1avr);
            label2.Text = Convert.ToString(oyuncu2avr);
            label3.Text = Convert.ToString(oyuncu3avr);
            label4.Text = Convert.ToString(oyuncu4avr);
        }
        public void oyuncuisimleri()
        {
            if (textBox1.Text != textBox2.Text && textBox1.Text != textBox3.Text && textBox1.Text != textBox4.Text &&
                textBox2.Text != textBox3.Text && textBox2.Text != textBox4.Text && textBox3.Text != textBox4.Text)
            {
                ileri2Btn.Enabled = true;
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                oyuncuIsimleriBtn.Enabled = false;

            }
            else
            {
                MessageBox.Show("Oyuncu isimleri birbirinden farklı olmalıdır!");
            }

        }
        public void puansıralaması()
        {
            if (oyuncu1puan>oyuncu2puan && oyuncu1puan > oyuncu3puan && oyuncu1puan > oyuncu4puan)
            {
                zaferTBox.Visible = true;
                zaferTBox.Text = oyuncu1 + " Kazandi ";
            }
            else if (oyuncu2puan > oyuncu1puan && oyuncu2puan > oyuncu3puan && oyuncu2puan > oyuncu4puan)
            {
                zaferTBox.Visible = true;
                zaferTBox.Text = oyuncu2 + " Kazandi ";
            }
            else if (oyuncu3puan > oyuncu1puan && oyuncu3puan > oyuncu2puan && oyuncu3puan > oyuncu4puan)
            {
                zaferTBox.Visible = true;
                zaferTBox.Text = oyuncu3 + " Kazandi ";
            }
            else if (oyuncu4puan > oyuncu1puan && oyuncu4puan > oyuncu2puan && oyuncu4puan > oyuncu3puan)
            {
                zaferTBox.Visible = true;
                zaferTBox.Text = oyuncu4 + " Kazandi ";
            }


            if (oyuncu1puan == oyuncu2puan || oyuncu1puan == oyuncu3puan || oyuncu1puan == oyuncu4puan ||
                oyuncu2puan == oyuncu3puan || oyuncu2puan == oyuncu4puan || oyuncu3puan == oyuncu4puan )

            {
                averajsıralaması();
            }
        }
        public void averajsıralaması()
        {
            if (oyuncu1avr > oyuncu2avr && oyuncu1avr > oyuncu3avr && oyuncu1avr > oyuncu4avr)
            {
                zaferTBox.Visible = true;
                zaferTBox.Text = oyuncu1 + " Kazandi ";
            }
            else if (oyuncu2avr > oyuncu1avr && oyuncu2avr > oyuncu3avr && oyuncu2avr > oyuncu4avr)
            {
                zaferTBox.Visible = true;
                zaferTBox.Text = oyuncu2 + " Kazandi ";
            }
            else if (oyuncu3avr > oyuncu1avr && oyuncu3avr > oyuncu2avr && oyuncu3avr > oyuncu4avr)
            {
                zaferTBox.Visible = true;
                zaferTBox.Text = oyuncu3 + " Kazandi ";
            }
            else if (oyuncu4avr > oyuncu1avr && oyuncu4avr > oyuncu2avr && oyuncu4avr > oyuncu3avr)
            {
                zaferTBox.Visible = true;
                zaferTBox.Text = oyuncu4 + " Kazandi ";
            }
        

            if (oyuncu1avr == oyuncu2avr || oyuncu1avr == oyuncu3avr || oyuncu1avr == oyuncu4avr ||
                oyuncu2avr == oyuncu3avr || oyuncu2avr == oyuncu4avr || oyuncu3avr == oyuncu4avr )

            {
                ikilisıralaması();
            }
        }
        public void ikilisıralaması()
        {
            if (oyuncu1avr == oyuncu2avr)
            {
                if (ikili12 == 1)
                {
                    zaferTBox.Visible = true;
                    zaferTBox.Text = oyuncu1 + " Kazandi ";
                    
                    label16.Text = "+";
                }
                else if (ikili12 == 2)
                {
                    zaferTBox.Visible = true;
                    zaferTBox.Text = oyuncu2 + " Kazandi ";
                    
                    label17.Text = "+";
                }
                else
                {
                    zaferTBox.Visible = true;
                    zaferTBox.Text = "Dostluk Kazandi ";
                }
            }
            else if (oyuncu1avr == oyuncu3avr)
            {
                if (ikili13 == 1)
                {
                    zaferTBox.Visible = true;
                    zaferTBox.Text = oyuncu1 + " Kazandi ";
                    label16.Text = "+";
                }
                else if (ikili13 == 3)
                {
                    zaferTBox.Visible = true;
                    zaferTBox.Text = oyuncu3 + " Kazandi ";
                    label18.Text = "+";
                }
                else
                {
                    zaferTBox.Visible = true;
                    zaferTBox.Text = "Dostluk Kazandi ";
                }
            }
            else if (oyuncu1avr == oyuncu4avr)
            {
                if (ikili14 == 1)
                {
                    zaferTBox.Visible = true;
                    zaferTBox.Text = oyuncu1 + " Kazandi ";
                    label16.Text = "+";
                }
                else if (ikili14 == 4)
                {
                    zaferTBox.Visible = true;
                    zaferTBox.Text = oyuncu4 + " Kazandi ";
                    label19.Text = "+";
                }
                else
                {
                    zaferTBox.Visible = true;
                    zaferTBox.Text = "Dostluk Kazandi ";
                }
            }
            else if (oyuncu2avr == oyuncu3avr)
            {
                if (ikili23 == 2)
                {
                    zaferTBox.Visible = true;
                    zaferTBox.Text = oyuncu2 + " Kazandi ";
                    label17.Text = "+";
                }
                else if (ikili23 == 3)
                {
                    zaferTBox.Visible = true;
                    zaferTBox.Text = oyuncu3 + " Kazandi ";
                    label18.Text = "+";
                }
                else
                {
                    zaferTBox.Visible = true;
                    zaferTBox.Text = "Dostluk Kazandi ";
                }
            }
            else if (oyuncu2avr == oyuncu4avr)
            {
                if (ikili24 == 2)
                {
                    zaferTBox.Visible = true;
                    zaferTBox.Text = oyuncu2 + " Kazandi ";
                    label17.Text = "+";
                }
                else if (ikili24 == 4)
                {
                    zaferTBox.Visible = true;
                    zaferTBox.Text = oyuncu4 + " Kazandi ";
                    label19.Text = "+";
                }
                else
                {
                    zaferTBox.Visible = true;
                    zaferTBox.Text = "Dostluk Kazandi ";
                }
            }
            else if (oyuncu3avr == oyuncu4avr)
            {
                if (ikili34 == 3)
                {
                    zaferTBox.Visible = true;
                    zaferTBox.Text = oyuncu3 + " Kazandi ";
                    label18.Text = "+";
                }
                else if (ikili34 == 4)
                {
                    zaferTBox.Visible = true;
                    zaferTBox.Text = oyuncu4 + " Kazandi ";
                    label19.Text = "+";
                }
                else
                {
                    zaferTBox.Visible = true;
                    zaferTBox.Text = "Dostluk Kazandi ";
                }
            }
        }

       
    }
}
