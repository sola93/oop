namespace lab4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loadAnglePluginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.angleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xmlJsonConverterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rhombToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(659, 375);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.Paint);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Circle",
            "Ellipse",
            "Square",
            "Rectangle",
            "Segment",
            "Triangle"});
            this.listBox1.Location = new System.Drawing.Point(695, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(160, 180);
            this.listBox1.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(695, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 76);
            this.button2.TabIndex = 5;
            this.button2.Text = "Добавить выбранную фигуру";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(695, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 73);
            this.button1.TabIndex = 4;
            this.button1.Text = "Отрисовать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(695, 359);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 43);
            this.button3.TabIndex = 8;
            this.button3.Text = "Serialize";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(776, 359);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 43);
            this.button4.TabIndex = 9;
            this.button4.Text = "Deserialize";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadAnglePluginToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(894, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loadAnglePluginToolStripMenuItem
            // 
            this.loadAnglePluginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.angleToolStripMenuItem,
            this.xmlJsonConverterToolStripMenuItem,
            this.rhombToolStripMenuItem,
            this.loadAllToolStripMenuItem});
            this.loadAnglePluginToolStripMenuItem.Name = "loadAnglePluginToolStripMenuItem";
            this.loadAnglePluginToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.loadAnglePluginToolStripMenuItem.Text = "Plugins";
            // 
            // angleToolStripMenuItem
            // 
            this.angleToolStripMenuItem.Name = "angleToolStripMenuItem";
            this.angleToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.angleToolStripMenuItem.Text = "Angle";
            this.angleToolStripMenuItem.Click += new System.EventHandler(this.angleToolStripMenuItem_Click);
            // 
            // xmlJsonConverterToolStripMenuItem
            // 
            this.xmlJsonConverterToolStripMenuItem.Name = "xmlJsonConverterToolStripMenuItem";
            this.xmlJsonConverterToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.xmlJsonConverterToolStripMenuItem.Text = "Xml <-> Json Converter";
            this.xmlJsonConverterToolStripMenuItem.Click += new System.EventHandler(this.xmlJsonConverterToolStripMenuItem_Click);
            // 
            // loadAllToolStripMenuItem
            // 
            this.loadAllToolStripMenuItem.Name = "loadAllToolStripMenuItem";
            this.loadAllToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.loadAllToolStripMenuItem.Text = "Load All";
            this.loadAllToolStripMenuItem.Click += new System.EventHandler(this.loadAllToolStripMenuItem_Click);
            // 
            // rhombToolStripMenuItem
            // 
            this.rhombToolStripMenuItem.Name = "rhombToolStripMenuItem";
            this.rhombToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.rhombToolStripMenuItem.Text = "Rhomb";
            this.rhombToolStripMenuItem.Click += new System.EventHandler(this.rhombToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 417);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loadAnglePluginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem angleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xmlJsonConverterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rhombToolStripMenuItem;
    }
}

