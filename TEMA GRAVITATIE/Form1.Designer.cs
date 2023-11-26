namespace TEMA_GRAVITATIE
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
            panel1 = new Panel();
            btn_baraSus = new Button();
            label1 = new Label();
            textBox_Nume = new TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            lbl_Rezultat1 = new Label();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            textBox_Greutate = new TextBox();
            btn_Calculeaza = new Button();
            pictureBox8 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox1 = new PictureBox();
            btn_Stergere = new Button();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(97, 75, 224);
            panel1.Controls.Add(btn_baraSus);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(871, 45);
            panel1.TabIndex = 0;
            // 
            // btn_baraSus
            // 
            btn_baraSus.BackgroundImage = (Image)resources.GetObject("btn_baraSus.BackgroundImage");
            btn_baraSus.Dock = DockStyle.Right;
            btn_baraSus.FlatStyle = FlatStyle.Flat;
            btn_baraSus.Location = new Point(822, 0);
            btn_baraSus.Name = "btn_baraSus";
            btn_baraSus.Size = new Size(49, 45);
            btn_baraSus.TabIndex = 8;
            btn_baraSus.UseVisualStyleBackColor = true;
            btn_baraSus.Click += btn_baraSus_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(169, 25);
            label1.TabIndex = 7;
            label1.Text = "CalculatorGravitatie ";
            // 
            // textBox_Nume
            // 
            textBox_Nume.Location = new Point(107, 195);
            textBox_Nume.Name = "textBox_Nume";
            textBox_Nume.Size = new Size(260, 31);
            textBox_Nume.TabIndex = 6;
            textBox_Nume.TextChanged += textBox_Nume_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(207, 200, 240);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(textBox_Greutate);
            panel2.Controls.Add(btn_Calculeaza);
            panel2.Controls.Add(pictureBox8);
            panel2.Controls.Add(pictureBox7);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btn_Stergere);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox_Nume);
            panel2.Location = new Point(0, 37);
            panel2.Name = "panel2";
            panel2.Size = new Size(871, 450);
            panel2.TabIndex = 8;
            panel2.Paint += panel2_Paint;
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Controls.Add(lbl_Rezultat1);
            panel3.Location = new Point(3, 375);
            panel3.Name = "panel3";
            panel3.Size = new Size(868, 75);
            panel3.TabIndex = 31;
            panel3.Paint += panel3_Paint;
            // 
            // lbl_Rezultat1
            // 
            lbl_Rezultat1.AutoSize = true;
            lbl_Rezultat1.Location = new Point(296, 30);
            lbl_Rezultat1.Name = "lbl_Rezultat1";
            lbl_Rezultat1.Size = new Size(0, 25);
            lbl_Rezultat1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(462, 177);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 48);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 30;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(516, 167);
            label4.Name = "label4";
            label4.Size = new Size(79, 25);
            label4.TabIndex = 29;
            label4.Text = "Greutate";
            // 
            // textBox_Greutate
            // 
            textBox_Greutate.Location = new Point(516, 194);
            textBox_Greutate.Name = "textBox_Greutate";
            textBox_Greutate.Size = new Size(260, 31);
            textBox_Greutate.TabIndex = 28;
            textBox_Greutate.TextChanged += textBox_Greutate_TextChanged;
            // 
            // btn_Calculeaza
            // 
            btn_Calculeaza.FlatStyle = FlatStyle.Flat;
            btn_Calculeaza.Location = new Point(462, 291);
            btn_Calculeaza.Name = "btn_Calculeaza";
            btn_Calculeaza.Size = new Size(248, 53);
            btn_Calculeaza.TabIndex = 27;
            btn_Calculeaza.Text = "Calculeaza";
            btn_Calculeaza.UseVisualStyleBackColor = true;
            btn_Calculeaza.Click += btn_Calculeaza_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(435, 25);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(92, 75);
            pictureBox8.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox8.TabIndex = 26;
            pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(342, 25);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(92, 75);
            pictureBox7.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox7.TabIndex = 25;
            pictureBox7.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = Properties.Resources.Contact_Details;
            pictureBox1.Image = Properties.Resources.Contact_Details;
            pictureBox1.Location = new Point(53, 188);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // btn_Stergere
            // 
            btn_Stergere.FlatStyle = FlatStyle.Flat;
            btn_Stergere.Location = new Point(119, 291);
            btn_Stergere.Name = "btn_Stergere";
            btn_Stergere.Size = new Size(248, 53);
            btn_Stergere.TabIndex = 18;
            btn_Stergere.Text = "Stergere";
            btn_Stergere.UseVisualStyleBackColor = true;
            btn_Stergere.Click += btn_Stergere_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(107, 167);
            label3.Name = "label3";
            label3.Size = new Size(60, 25);
            label3.TabIndex = 8;
            label3.Text = "Nume";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(351, 9);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(871, 487);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            ShowIcon = false;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox_Nume;
        private Label label1;
        private Panel panel2;
        private Label label3;
        private PictureBox pictureBox1;
        private Button btn_Stergere;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private Button btn_Calculeaza;
        private Button btn_baraSus;
        private PictureBox pictureBox2;
        private Label label4;
        private TextBox textBox_Greutate;
        private Panel panel3;
        private Label lbl_Rezultat1;
        private Label label2;
    }
}
