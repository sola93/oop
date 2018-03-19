namespace lab3.Dialogs
{
    partial class EllipseDialog
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.RadiusY = new System.Windows.Forms.TextBox();
            this.RadiusX = new System.Windows.Forms.TextBox();
            this.Y = new System.Windows.Forms.TextBox();
            this.X = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(105, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Center point";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Radius Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Radius X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "X";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(91, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RadiusY
            // 
            this.RadiusY.Location = new System.Drawing.Point(91, 142);
            this.RadiusY.Name = "RadiusY";
            this.RadiusY.Size = new System.Drawing.Size(99, 20);
            this.RadiusY.TabIndex = 13;
            // 
            // RadiusX
            // 
            this.RadiusX.Location = new System.Drawing.Point(91, 103);
            this.RadiusX.Name = "RadiusX";
            this.RadiusX.Size = new System.Drawing.Size(99, 20);
            this.RadiusX.TabIndex = 12;
            // 
            // Y
            // 
            this.Y.Location = new System.Drawing.Point(151, 61);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(39, 20);
            this.Y.TabIndex = 11;
            // 
            // X
            // 
            this.X.Location = new System.Drawing.Point(91, 61);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(39, 20);
            this.X.TabIndex = 10;
            // 
            // EllipseDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RadiusY);
            this.Controls.Add(this.RadiusX);
            this.Controls.Add(this.Y);
            this.Controls.Add(this.X);
            this.Name = "EllipseDialog";
            this.Text = "EllipseDialog";
            this.Activated += new System.EventHandler(this.Activate);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox RadiusY;
        public System.Windows.Forms.TextBox RadiusX;
        public System.Windows.Forms.TextBox Y;
        public System.Windows.Forms.TextBox X;
    }
}