namespace lab4
{
    partial class AdapterDialog
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
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Point1Y = new System.Windows.Forms.TextBox();
            this.Point1X = new System.Windows.Forms.TextBox();
            this.Point2Y = new System.Windows.Forms.TextBox();
            this.Point2X = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 21);
            this.button1.TabIndex = 46;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(118, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 42;
            this.label3.Text = "Point";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "X";
            // 
            // Point1Y
            // 
            this.Point1Y.Location = new System.Drawing.Point(155, 72);
            this.Point1Y.Name = "Point1Y";
            this.Point1Y.Size = new System.Drawing.Size(35, 20);
            this.Point1Y.TabIndex = 39;
            // 
            // Point1X
            // 
            this.Point1X.Location = new System.Drawing.Point(84, 72);
            this.Point1X.Name = "Point1X";
            this.Point1X.Size = new System.Drawing.Size(35, 20);
            this.Point1X.TabIndex = 38;
            // 
            // Point2Y
            // 
            this.Point2Y.Location = new System.Drawing.Point(155, 98);
            this.Point2Y.Name = "Point2Y";
            this.Point2Y.Size = new System.Drawing.Size(35, 20);
            this.Point2Y.TabIndex = 48;
            // 
            // Point2X
            // 
            this.Point2X.Location = new System.Drawing.Point(84, 98);
            this.Point2X.Name = "Point2X";
            this.Point2X.Size = new System.Drawing.Size(35, 20);
            this.Point2X.TabIndex = 47;
            // 
            // AdapterDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Point2Y);
            this.Controls.Add(this.Point2X);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Point1Y);
            this.Controls.Add(this.Point1X);
            this.Name = "AdapterDialog";
            this.Text = "AdapterDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox Point1Y;
        public System.Windows.Forms.TextBox Point1X;
        public System.Windows.Forms.TextBox Point2Y;
        public System.Windows.Forms.TextBox Point2X;
    }
}