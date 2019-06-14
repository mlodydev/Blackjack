namespace Blackjack
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
            this.textBox1Krupier = new System.Windows.Forms.TextBox();
            this.textBox2Gracz = new System.Windows.Forms.TextBox();
            this.label1Krupier = new System.Windows.Forms.Label();
            this.label2Gracz = new System.Windows.Forms.Label();
            this.button1Dobieraj = new System.Windows.Forms.Button();
            this.button2Trzymaj = new System.Windows.Forms.Button();
            this.button3Start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1Krupier
            // 
            this.textBox1Krupier.Location = new System.Drawing.Point(177, 85);
            this.textBox1Krupier.Name = "textBox1Krupier";
            this.textBox1Krupier.Size = new System.Drawing.Size(203, 20);
            this.textBox1Krupier.TabIndex = 0;
            // 
            // textBox2Gracz
            // 
            this.textBox2Gracz.Location = new System.Drawing.Point(177, 308);
            this.textBox2Gracz.Name = "textBox2Gracz";
            this.textBox2Gracz.Size = new System.Drawing.Size(203, 20);
            this.textBox2Gracz.TabIndex = 1;
            // 
            // label1Krupier
            // 
            this.label1Krupier.AutoSize = true;
            this.label1Krupier.Location = new System.Drawing.Point(244, 108);
            this.label1Krupier.Name = "label1Krupier";
            this.label1Krupier.Size = new System.Drawing.Size(40, 13);
            this.label1Krupier.TabIndex = 2;
            this.label1Krupier.Text = "Krupier";
            // 
            // label2Gracz
            // 
            this.label2Gracz.AutoSize = true;
            this.label2Gracz.Location = new System.Drawing.Point(244, 335);
            this.label2Gracz.Name = "label2Gracz";
            this.label2Gracz.Size = new System.Drawing.Size(35, 13);
            this.label2Gracz.TabIndex = 3;
            this.label2Gracz.Text = "Gracz";
            // 
            // button1Dobieraj
            // 
            this.button1Dobieraj.Location = new System.Drawing.Point(416, 304);
            this.button1Dobieraj.Name = "button1Dobieraj";
            this.button1Dobieraj.Size = new System.Drawing.Size(75, 23);
            this.button1Dobieraj.TabIndex = 4;
            this.button1Dobieraj.Text = "Dobieraj";
            this.button1Dobieraj.UseVisualStyleBackColor = true;
            this.button1Dobieraj.Click += new System.EventHandler(this.button1Dobieraj_click);
            // 
            // button2Trzymaj
            // 
            this.button2Trzymaj.Location = new System.Drawing.Point(498, 304);
            this.button2Trzymaj.Name = "button2Trzymaj";
            this.button2Trzymaj.Size = new System.Drawing.Size(75, 23);
            this.button2Trzymaj.TabIndex = 5;
            this.button2Trzymaj.Text = "Trzymaj";
            this.button2Trzymaj.UseVisualStyleBackColor = true;
            this.button2Trzymaj.Click += new System.EventHandler(this.Button2Trzymaj_Click);
            // 
            // button3Start
            // 
            this.button3Start.Location = new System.Drawing.Point(639, 161);
            this.button3Start.Name = "button3Start";
            this.button3Start.Size = new System.Drawing.Size(75, 23);
            this.button3Start.TabIndex = 6;
            this.button3Start.Text = "Start";
            this.button3Start.UseVisualStyleBackColor = true;
            this.button3Start.Click += new System.EventHandler(this.Button3Start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3Start);
            this.Controls.Add(this.button2Trzymaj);
            this.Controls.Add(this.button1Dobieraj);
            this.Controls.Add(this.label2Gracz);
            this.Controls.Add(this.label1Krupier);
            this.Controls.Add(this.textBox2Gracz);
            this.Controls.Add(this.textBox1Krupier);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1Krupier;
        private System.Windows.Forms.TextBox textBox2Gracz;
        private System.Windows.Forms.Label label1Krupier;
        private System.Windows.Forms.Label label2Gracz;
        private System.Windows.Forms.Button button1Dobieraj;
        private System.Windows.Forms.Button button2Trzymaj;
        private System.Windows.Forms.Button button3Start;
    }
}

