namespace RGB
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.moyLichniyTextBox1 = new RGB.MoyLichniyTextBox(this.components);
            this.moyLichniyTextBox2 = new RGB.MoyLichniyTextBox(this.components);
            this.moyLichniyTextBox3 = new RGB.MoyLichniyTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Desktop;
            this.pictureBox1.Location = new System.Drawing.Point(183, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 165);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(79, 150);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(56, 24);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Hex";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(14, 150);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(56, 24);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Dec";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Красный";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Зеленый";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Синий";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(79, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(98, 30);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(79, 55);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(98, 30);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "0";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(79, 94);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(98, 30);
            this.textBox3.TabIndex = 10;
            this.textBox3.Text = "0";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // moyLichniyTextBox1
            // 
            this.moyLichniyTextBox1.Location = new System.Drawing.Point(399, 19);
            this.moyLichniyTextBox1.Name = "moyLichniyTextBox1";
            this.moyLichniyTextBox1.ShortcutsEnabled = false;
            this.moyLichniyTextBox1.Size = new System.Drawing.Size(125, 27);
            this.moyLichniyTextBox1.TabIndex = 11;
            this.moyLichniyTextBox1.Text = "0";
            this.moyLichniyTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.moyLichniyTextBox1.TextChanged += new System.EventHandler(this.moyLichniyTextBox1_TextChanged);
            // 
            // moyLichniyTextBox2
            // 
            this.moyLichniyTextBox2.Location = new System.Drawing.Point(399, 58);
            this.moyLichniyTextBox2.Name = "moyLichniyTextBox2";
            this.moyLichniyTextBox2.Size = new System.Drawing.Size(125, 27);
            this.moyLichniyTextBox2.TabIndex = 12;
            this.moyLichniyTextBox2.Text = "0";
            this.moyLichniyTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.moyLichniyTextBox2.TextChanged += new System.EventHandler(this.moyLichniyTextBox2_TextChanged);
            // 
            // moyLichniyTextBox3
            // 
            this.moyLichniyTextBox3.Location = new System.Drawing.Point(397, 97);
            this.moyLichniyTextBox3.Name = "moyLichniyTextBox3";
            this.moyLichniyTextBox3.ShortcutsEnabled = false;
            this.moyLichniyTextBox3.Size = new System.Drawing.Size(125, 27);
            this.moyLichniyTextBox3.TabIndex = 13;
            this.moyLichniyTextBox3.Text = "0";
            this.moyLichniyTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.moyLichniyTextBox3.TextChanged += new System.EventHandler(this.moyLichniyTextBox3_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(534, 192);
            this.Controls.Add(this.moyLichniyTextBox3);
            this.Controls.Add(this.moyLichniyTextBox2);
            this.Controls.Add(this.moyLichniyTextBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private MoyLichniyTextBox moyLichniyTextBox1;
        private MoyLichniyTextBox moyLichniyTextBox2;
        private MoyLichniyTextBox moyLichniyTextBox3;
    }
}