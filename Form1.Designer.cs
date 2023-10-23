namespace Practica_5
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(628, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(174, 205);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(32, -1);
            label1.Name = "label1";
            label1.Size = new Size(541, 36);
            label1.TabIndex = 1;
            label1.Text = "Introduce las dimensiones del cilindro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(39, 64);
            label2.Name = "label2";
            label2.Size = new Size(91, 33);
            label2.TabIndex = 2;
            label2.Text = "Radio";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(39, 129);
            label3.Name = "label3";
            label3.Size = new Size(91, 33);
            label3.TabIndex = 3;
            label3.Text = "Altura";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(225, 57);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 39);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(225, 123);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 39);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(39, 201);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 6;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Arial", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(211, 201);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 7;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Arial", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(386, 201);
            button3.Name = "button3";
            button3.Size = new Size(150, 46);
            button3.TabIndex = 8;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(39, 282);
            label4.Name = "label4";
            label4.Size = new Size(147, 33);
            label4.TabIndex = 9;
            label4.Text = "Base area";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(39, 371);
            label5.Name = "label5";
            label5.Size = new Size(170, 33);
            label5.TabIndex = 10;
            label5.Text = "Lateral area";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(386, 286);
            label6.Name = "label6";
            label6.Size = new Size(144, 33);
            label6.TabIndex = 11;
            label6.Text = "Total area";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(386, 373);
            label7.Name = "label7";
            label7.Size = new Size(128, 33);
            label7.TabIndex = 12;
            label7.Text = "Volumen";
            label7.Click += label7_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(211, 282);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(151, 39);
            textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(211, 371);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(146, 39);
            textBox4.TabIndex = 14;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(536, 284);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(164, 39);
            textBox5.TabIndex = 15;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(532, 365);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(168, 39);
            textBox6.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
    }
}