using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiikkuvaAuto;

namespace Dynaamiset
{
    public partial class Form1 : Form
    {
        List<TextBox> kentat = new List<TextBox>();
        private int tormaykset = 0;
        private int rikkinaiset = 0;
        private int negatives = 0;
        public Form1()
        {
            InitializeComponent();
            kentat.Add(textBoxSyote);
        }

        private void buttonLisaaKentta_Click(object sender, EventArgs e)
        {
            TextBox uusiboksi = new TextBox();
            int x = 20 + (kentat.Count) * 25;
            uusiboksi.Location = new Point(135, x);
            uusiboksi.Size = new Size(100, 20);
            kentat.Add(uusiboksi);
            uusiboksi.TabIndex = kentat.Count+1;
            uusiboksi.Text = (kentat.Count).ToString();
            Controls.Add(uusiboksi);
        }

        private void buttonLaske_Click(object sender, EventArgs e)
        {
            foreach (TextBox item in kentat)
            {
                item.Text = (Convert.ToInt16(item.Text) + 1).ToString();
            }
        }

        private void buttonLisaaAuto_Click(object sender, EventArgs e)
        {
            LiikkuvaAuto.LiikkuvaAuto auto = new LiikkuvaAuto.LiikkuvaAuto();
            //auto.tormays = new Tormays(osui);
            auto.random_sijainti = true;
            auto.rikki += new LiikkuvaAuto.Rikki(rikki);
            this.Controls.Add(auto);
        }
        private void osui(int kunto, int tormayksia)
        {
            this.Text = kunto.ToString();
            tormaykset++;
            labelTormays.Text = tormaykset.ToString();
        }
        private void rikki(object sender, AutoEventArgs e)
        {
            rikkinaiset++;
            tormaykset += e.tormayksia;
            labelRikki.Text = rikkinaiset.ToString();
            labelTormays.Text = tormaykset.ToString();
        }

        private void positiveNumberTextBox1_OnNegativeNumber()
        {
            negatives++;
            this.Text = negatives.ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.ValidateChildren())
            {

            }
            else
            {
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public delegate void Tormays(int kunto, int tormayksia);
    public delegate void Rikki(object sender, AutoEventArgs e);

    
}
