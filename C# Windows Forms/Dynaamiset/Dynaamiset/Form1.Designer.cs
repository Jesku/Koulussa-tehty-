
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
            this.buttonLisaaKentta = new System.Windows.Forms.Button();
            this.textBoxSyote = new System.Windows.Forms.TextBox();
            this.buttonLaske = new System.Windows.Forms.Button();
            this.buttonLisaaAuto = new System.Windows.Forms.Button();
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 450);
            this.Controls.Add(this.buttonLisaaAuto);
            this.Controls.Add(this.buttonLaske);
            this.Controls.Add(this.textBoxSyote);
            this.Controls.Add(this.buttonLisaaKentta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLisaaKentta;
        private System.Windows.Forms.TextBox textBoxSyote;
        private System.Windows.Forms.Button buttonLaske;
        private System.Windows.Forms.Button buttonLisaaAuto;
    }
}

