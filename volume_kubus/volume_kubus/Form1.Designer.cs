namespace volume_kubus
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
            label1 = new Label();
            lblvolume = new Label();
            txtsisi = new TextBox();
            txtvolume = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 94);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Sisi Kubus";
            // 
            // lblvolume
            // 
            lblvolume.AutoSize = true;
            lblvolume.Location = new Point(78, 153);
            lblvolume.Name = "lblvolume";
            lblvolume.Size = new Size(103, 20);
            lblvolume.TabIndex = 1;
            lblvolume.Text = "Volume Kubus";
            // 
            // txtsisi
            // 
            txtsisi.Location = new Point(254, 91);
            txtsisi.Name = "txtsisi";
            txtsisi.Size = new Size(158, 27);
            txtsisi.TabIndex = 2;
            txtsisi.TextChanged += textBox1_TextChanged;
            // 
            // txtvolume
            // 
            txtvolume.Location = new Point(254, 153);
            txtvolume.Name = "txtvolume";
            txtvolume.Size = new Size(158, 27);
            txtvolume.TabIndex = 3;
            txtvolume.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(457, 89);
            button1.Name = "button1";
            button1.Size = new Size(109, 51);
            button1.TabIndex = 4;
            button1.Text = "Hitung";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(457, 163);
            button2.Name = "button2";
            button2.Size = new Size(109, 51);
            button2.TabIndex = 5;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtvolume);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtsisi);
            Controls.Add(lblvolume);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblvolume;
        private TextBox txtsisi;
        private TextBox txtvolume;
        private Button button1;
        private Button button2;
    }
}