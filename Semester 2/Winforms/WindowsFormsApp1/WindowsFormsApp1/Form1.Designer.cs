namespace WindowsFormsApp1
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
            this.DoxSomeone = new System.Windows.Forms.Button();
            this.FailSafe = new System.Windows.Forms.CheckBox();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DoxSomeone
            // 
            this.DoxSomeone.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoxSomeone.Location = new System.Drawing.Point(12, 12);
            this.DoxSomeone.Name = "DoxSomeone";
            this.DoxSomeone.Size = new System.Drawing.Size(463, 255);
            this.DoxSomeone.TabIndex = 0;
            this.DoxSomeone.Text = "DOX";
            this.DoxSomeone.UseVisualStyleBackColor = true;
            this.DoxSomeone.Click += new System.EventHandler(this.DoxSomeone_Click);
            // 
            // FailSafe
            // 
            this.FailSafe.AutoSize = true;
            this.FailSafe.Location = new System.Drawing.Point(481, 27);
            this.FailSafe.Name = "FailSafe";
            this.FailSafe.Size = new System.Drawing.Size(67, 17);
            this.FailSafe.TabIndex = 1;
            this.FailSafe.Text = "Fail Safe";
            this.FailSafe.UseVisualStyleBackColor = true;
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Location = new System.Drawing.Point(481, 50);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.DateTimePicker.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "This button DOXES someone.";
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(482, 77);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(199, 190);
            this.PictureBox.TabIndex = 4;
            this.PictureBox.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 309);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 669);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.FailSafe);
            this.Controls.Add(this.DoxSomeone);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DoxSomeone;
        private System.Windows.Forms.CheckBox FailSafe;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.TextBox textBox1;
    }
}

