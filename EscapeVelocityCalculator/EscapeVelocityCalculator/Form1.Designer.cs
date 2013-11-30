namespace EscapeVelocityCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxMass = new System.Windows.Forms.TextBox();
            this.txtBoxRadius = new System.Windows.Forms.TextBox();
            this.txtBoxEscapeVe = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnEarth = new System.Windows.Forms.Button();
            this.btnMoon = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(614, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escape Velocity is the minimum velocity needed to escape the gravitational field " +
                "of a planet or other body. ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gravitational Constant(G) = 6.67300E-11";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(332, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Planet Mass (M)  = ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(331, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Planet Radius(R) =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Escape Velocity(ve)  =";
            // 
            // txtBoxMass
            // 
            this.txtBoxMass.Location = new System.Drawing.Point(461, 95);
            this.txtBoxMass.Name = "txtBoxMass";
            this.txtBoxMass.Size = new System.Drawing.Size(167, 20);
            this.txtBoxMass.TabIndex = 5;
            // 
            // txtBoxRadius
            // 
            this.txtBoxRadius.Location = new System.Drawing.Point(460, 128);
            this.txtBoxRadius.Name = "txtBoxRadius";
            this.txtBoxRadius.Size = new System.Drawing.Size(167, 20);
            this.txtBoxRadius.TabIndex = 6;
            // 
            // txtBoxEscapeVe
            // 
            this.txtBoxEscapeVe.Location = new System.Drawing.Point(460, 154);
            this.txtBoxEscapeVe.Name = "txtBoxEscapeVe";
            this.txtBoxEscapeVe.Size = new System.Drawing.Size(167, 20);
            this.txtBoxEscapeVe.TabIndex = 7;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(461, 190);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(166, 33);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnEarth
            // 
            this.btnEarth.Location = new System.Drawing.Point(647, 190);
            this.btnEarth.Name = "btnEarth";
            this.btnEarth.Size = new System.Drawing.Size(163, 33);
            this.btnEarth.TabIndex = 9;
            this.btnEarth.Text = "Earth";
            this.btnEarth.UseVisualStyleBackColor = true;
            this.btnEarth.Click += new System.EventHandler(this.btnEarth_Click);
            // 
            // btnMoon
            // 
            this.btnMoon.Location = new System.Drawing.Point(647, 229);
            this.btnMoon.Name = "btnMoon";
            this.btnMoon.Size = new System.Drawing.Size(163, 35);
            this.btnMoon.TabIndex = 10;
            this.btnMoon.Text = "Moon";
            this.btnMoon.UseVisualStyleBackColor = true;
            this.btnMoon.Click += new System.EventHandler(this.btnMoon_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(461, 229);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(166, 35);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear Fields";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(647, 270);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(163, 35);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit Program";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(635, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "kilograms";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(635, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "meters";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(635, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "meters / sec";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(53, 145);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 139);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 362);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnMoon);
            this.Controls.Add(this.btnEarth);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtBoxEscapeVe);
            this.Controls.Add(this.txtBoxRadius);
            this.Controls.Add(this.txtBoxMass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Escape Velocity Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxMass;
        private System.Windows.Forms.TextBox txtBoxRadius;
        private System.Windows.Forms.TextBox txtBoxEscapeVe;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnEarth;
        private System.Windows.Forms.Button btnMoon;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

