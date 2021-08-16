
namespace Dynaamiset
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonLisaaKentta = new System.Windows.Forms.Button();
            this.textBoxSyote = new System.Windows.Forms.TextBox();
            this.buttonLaske = new System.Windows.Forms.Button();
            this.buttonLisaaAuto = new System.Windows.Forms.Button();
            this.labelTormays = new System.Windows.Forms.Label();
            this.labelRikki = new System.Windows.Forms.Label();
            this.liikkuvaAuto1 = new LiikkuvaAuto.LiikkuvaAuto();
            this.button1 = new System.Windows.Forms.Button();
            this.positiveNumberTextBox1 = new PositiveNumberTextBox.PositiveNumberTextBox();
            this.positiveNumberTextBox2 = new PositiveNumberTextBox.PositiveNumberTextBox();
            this.positiveNumberTextBox3 = new PositiveNumberTextBox.PositiveNumberTextBox();
            this.positiveNumberTextBox4 = new PositiveNumberTextBox.PositiveNumberTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.liikkuvaAuto1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLisaaKentta
            // 
            this.buttonLisaaKentta.AutoSize = true;
            this.buttonLisaaKentta.Location = new System.Drawing.Point(12, 12);
            this.buttonLisaaKentta.Name = "buttonLisaaKentta";
            this.buttonLisaaKentta.Size = new System.Drawing.Size(117, 23);
            this.buttonLisaaKentta.TabIndex = 0;
            this.buttonLisaaKentta.Text = "&Lisää tekstikenttä";
            this.buttonLisaaKentta.UseVisualStyleBackColor = true;
            this.buttonLisaaKentta.Click += new System.EventHandler(this.buttonLisaaKentta_Click);
            // 
            // textBoxSyote
            // 
            this.textBoxSyote.Location = new System.Drawing.Point(135, 12);
            this.textBoxSyote.Name = "textBoxSyote";
            this.textBoxSyote.Size = new System.Drawing.Size(100, 20);
            this.textBoxSyote.TabIndex = 1;
            this.textBoxSyote.Text = "1";
            // 
            // buttonLaske
            // 
            this.buttonLaske.AutoSize = true;
            this.buttonLaske.Location = new System.Drawing.Point(12, 63);
            this.buttonLaske.Name = "buttonLaske";
            this.buttonLaske.Size = new System.Drawing.Size(100, 23);
            this.buttonLaske.TabIndex = 2;
            this.buttonLaske.Text = "Kasvata numeroa";
            this.buttonLaske.UseVisualStyleBackColor = true;
            this.buttonLaske.Click += new System.EventHandler(this.buttonLaske_Click);
            // 
            // buttonLisaaAuto
            // 
            this.buttonLisaaAuto.Location = new System.Drawing.Point(12, 113);
            this.buttonLisaaAuto.Name = "buttonLisaaAuto";
            this.buttonLisaaAuto.Size = new System.Drawing.Size(75, 23);
            this.buttonLisaaAuto.TabIndex = 4;
            this.buttonLisaaAuto.Text = "Lisää &auto";
            this.buttonLisaaAuto.UseVisualStyleBackColor = true;
            this.buttonLisaaAuto.Click += new System.EventHandler(this.buttonLisaaAuto_Click);
            // 
            // labelTormays
            // 
            this.labelTormays.Location = new System.Drawing.Point(13, 161);
            this.labelTormays.Name = "labelTormays";
            this.labelTormays.Size = new System.Drawing.Size(100, 23);
            this.labelTormays.TabIndex = 5;
            this.labelTormays.Text = "0";
            this.labelTormays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRikki
            // 
            this.labelRikki.Location = new System.Drawing.Point(13, 208);
            this.labelRikki.Name = "labelRikki";
            this.labelRikki.Size = new System.Drawing.Size(100, 23);
            this.labelRikki.TabIndex = 6;
            this.labelRikki.Text = "0";
            this.labelRikki.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // liikkuvaAuto1
            // 
            this.liikkuvaAuto1.Image = ((System.Drawing.Image)(resources.GetObject("liikkuvaAuto1.Image")));
            this.liikkuvaAuto1.kunto = 4;
            this.liikkuvaAuto1.Location = new System.Drawing.Point(274, 313);
            this.liikkuvaAuto1.Name = "liikkuvaAuto1";
            this.liikkuvaAuto1.nopeus = 40;
            this.liikkuvaAuto1.Size = new System.Drawing.Size(75, 30);
            this.liikkuvaAuto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.liikkuvaAuto1.TabIndex = 7;
            this.liikkuvaAuto1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "&Sulje";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // positiveNumberTextBox1
            // 
            this.positiveNumberTextBox1.Location = new System.Drawing.Point(336, 66);
            this.positiveNumberTextBox1.Name = "positiveNumberTextBox1";
            this.positiveNumberTextBox1.Size = new System.Drawing.Size(100, 20);
            this.positiveNumberTextBox1.TabIndex = 8;
            this.positiveNumberTextBox1.OnNegativeNumber += new PositiveNumberTextBox.PositiveNumberTextBox.NegativeNumberHandler(this.positiveNumberTextBox1_OnNegativeNumber);
            // 
            // positiveNumberTextBox2
            // 
            this.positiveNumberTextBox2.Location = new System.Drawing.Point(336, 92);
            this.positiveNumberTextBox2.Name = "positiveNumberTextBox2";
            this.positiveNumberTextBox2.Size = new System.Drawing.Size(100, 20);
            this.positiveNumberTextBox2.TabIndex = 10;
            // 
            // positiveNumberTextBox3
            // 
            this.positiveNumberTextBox3.Location = new System.Drawing.Point(336, 118);
            this.positiveNumberTextBox3.Name = "positiveNumberTextBox3";
            this.positiveNumberTextBox3.Size = new System.Drawing.Size(100, 20);
            this.positiveNumberTextBox3.TabIndex = 11;
            // 
            // positiveNumberTextBox4
            // 
            this.positiveNumberTextBox4.Location = new System.Drawing.Point(336, 144);
            this.positiveNumberTextBox4.Name = "positiveNumberTextBox4";
            this.positiveNumberTextBox4.Size = new System.Drawing.Size(100, 20);
            this.positiveNumberTextBox4.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(448, 450);
            this.Controls.Add(this.positiveNumberTextBox4);
            this.Controls.Add(this.positiveNumberTextBox3);
            this.Controls.Add(this.positiveNumberTextBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.positiveNumberTextBox1);
            this.Controls.Add(this.liikkuvaAuto1);
            this.Controls.Add(this.labelRikki);
            this.Controls.Add(this.labelTormays);
            this.Controls.Add(this.buttonLisaaAuto);
            this.Controls.Add(this.buttonLaske);
            this.Controls.Add(this.textBoxSyote);
            this.Controls.Add(this.buttonLisaaKentta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.liikkuvaAuto1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLisaaKentta;
        private System.Windows.Forms.TextBox textBoxSyote;
        private System.Windows.Forms.Button buttonLaske;
        private System.Windows.Forms.Button buttonLisaaAuto;
        private System.Windows.Forms.Label labelTormays;
        private System.Windows.Forms.Label labelRikki;
        private LiikkuvaAuto.LiikkuvaAuto liikkuvaAuto1;
        private PositiveNumberTextBox.PositiveNumberTextBox positiveNumberTextBox1;
        private System.Windows.Forms.Button button1;
        private PositiveNumberTextBox.PositiveNumberTextBox positiveNumberTextBox2;
        private PositiveNumberTextBox.PositiveNumberTextBox positiveNumberTextBox3;
        private PositiveNumberTextBox.PositiveNumberTextBox positiveNumberTextBox4;
    }
}

