namespace lab2.Dialogs
{
    partial class RectangleDialog
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
            this.Height = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Width = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Point1Y = new System.Windows.Forms.TextBox();
            this.Point1X = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Height
            // 
            this.Height.Location = new System.Drawing.Point(84, 138);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(106, 20);
            this.Height.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 21);
            this.button1.TabIndex = 26;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(112, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Height";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(114, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Width";
            // 
            // Width
            // 
            this.Width.Location = new System.Drawing.Point(84, 95);
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(106, 20);
            this.Width.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(118, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Point";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "X";
            // 
            // Point1Y
            // 
            this.Point1Y.Location = new System.Drawing.Point(155, 52);
            this.Point1Y.Name = "Point1Y";
            this.Point1Y.Size = new System.Drawing.Size(35, 20);
            this.Point1Y.TabIndex = 17;
            // 
            // Point1X
            // 
            this.Point1X.Location = new System.Drawing.Point(84, 52);
            this.Point1X.Name = "Point1X";
            this.Point1X.Size = new System.Drawing.Size(35, 20);
            this.Point1X.TabIndex = 14;
            // 
            // RectangleDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Width);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Point1Y);
            this.Controls.Add(this.Point1X);
            this.Name = "RectangleDialog";
            this.Text = "RectangleDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public new System.Windows.Forms.TextBox Height;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public new System.Windows.Forms.TextBox Width;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox Point1Y;
        public System.Windows.Forms.TextBox Point1X;
    }
}