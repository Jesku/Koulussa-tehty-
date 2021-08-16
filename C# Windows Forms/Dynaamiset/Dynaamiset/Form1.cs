using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dynaamiset
{
    public partial class Form1 : Form
    {
        List<TextBox> kentat = new List<TextBox>();
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
            Auto auto = new Auto();
            this.Controls.Add(auto);
        }
    }

    public class Auto : PictureBox {
        private int nopeus = 10;
        private System.Windows.Forms.Timer ajastin = new System.Windows.Forms.Timer();
        
        public Auto()
        {
            this.Image = global::Dynaamiset.Properties.Resources.car;
            this.ParentChanged += new System.EventHandler(this.OnParentChanged);
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.TabStop = false;

            ajastin.Enabled = true;
            ajastin.Tick += new System.EventHandler(this.ajastin_Tick);
        }
        private void OnParentChanged(object sender, EventArgs e)
        {
            Random r = new Random();
            this.Location = new Point(r.Next(0, Parent.ClientSize.Width-ClientSize.Width), r.Next(0, Parent.ClientSize.Height-ClientSize.Height));
        }
        private void ajastin_Tick(object sender, EventArgs e)
        {
                if (Left <= 0) nopeus = -nopeus;
                if (Right >= Parent.ClientSize.Width) nopeus = -nopeus;
                Left = Left + nopeus;
        }    
    }
}
