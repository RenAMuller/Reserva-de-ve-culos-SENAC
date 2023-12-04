namespace Reserva_de_veiculos_SENAC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox2 = new GroupBox();
            button1 = new Button();
            textBox4 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label4 = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.AutoSize = true;
            groupBox2.BackColor = SystemColors.ActiveCaptionText;
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(-3, -9);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(233, 463);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(126, 416);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 15;
            button1.Text = "Confirmar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.Black;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("HelveticaNeueLT Pro 107 XBlkCn", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            textBox4.ForeColor = Color.White;
            textBox4.Location = new Point(10, 194);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(191, 30);
            textBox4.TabIndex = 14;
            textBox4.Text = "       do SENAC";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Black;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(13, 362);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "DIgite sua senha";
            textBox2.Size = new Size(188, 23);
            textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Black;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("HelveticaNeueLT Pro 107 XBlkCn", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.ForeColor = Color.White;
            textBox3.Location = new Point(10, 159);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(217, 30);
            textBox3.TabIndex = 13;
            textBox3.Text = "Reserva de veículos";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Black;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(13, 276);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "DIgite seu usuario";
            textBox1.Size = new Size(188, 23);
            textBox1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(188, 112);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("HelveticaNeueLT Pro 107 XBlkCn", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(9, 243);
            label2.Name = "label2";
            label2.Size = new Size(88, 30);
            label2.TabIndex = 5;
            label2.Text = "Usuario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.Font = new Font("HelveticaNeueLT Pro 107 XBlkCn", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(11, 329);
            label4.Name = "label4";
            label4.Size = new Size(74, 30);
            label4.TabIndex = 11;
            label4.Text = "Senha";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(932, 559);
            Controls.Add(groupBox2);
            ForeColor = Color.White;
            Name = "Form1";
            Text = "Usuario";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
    }
}