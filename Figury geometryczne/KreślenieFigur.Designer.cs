namespace Figury_geometryczne
{
    partial class KreślenieFigur
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pbRysownica = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckedListBox();
            this.lblZaznaczFigury = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnWłączSlajder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnWyłączSlajder = new System.Windows.Forms.Button();
            this.btnNastępny = new System.Windows.Forms.Button();
            this.btnPoprzedni = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rdbAutomat = new System.Windows.Forms.RadioButton();
            this.btnWziernikKoloru = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbRysownica)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(57, 110);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Podaj liczbę figur geometrycznych";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "do losowej prezentacji";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pbRysownica
            // 
            this.pbRysownica.Location = new System.Drawing.Point(283, 25);
            this.pbRysownica.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbRysownica.Name = "pbRysownica";
            this.pbRysownica.Size = new System.Drawing.Size(760, 562);
            this.pbRysownica.TabIndex = 3;
            this.pbRysownica.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(57, 137);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(132, 44);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.FormattingEnabled = true;
            this.checkBox1.Items.AddRange(new object[] {
            "Punkt",
            "Linia",
            "Elipsa",
            "Okrąg",
            "Prostokąt",
            "Kwadrat",
            "Wielokąt"});
            this.checkBox1.Location = new System.Drawing.Point(1059, 63);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(215, 157);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.SelectedIndexChanged += new System.EventHandler(this.checkBox1_SelectedIndexChanged);
            // 
            // lblZaznaczFigury
            // 
            this.lblZaznaczFigury.AutoSize = true;
            this.lblZaznaczFigury.Location = new System.Drawing.Point(1056, 25);
            this.lblZaznaczFigury.Name = "lblZaznaczFigury";
            this.lblZaznaczFigury.Size = new System.Drawing.Size(179, 16);
            this.lblZaznaczFigury.TabIndex = 6;
            this.lblZaznaczFigury.Text = "Zaznacz figury do prezentacji";
            this.lblZaznaczFigury.Click += new System.EventHandler(this.lblZaznaczFigury_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 187);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 97);
            this.button1.TabIndex = 7;
            this.button1.Text = "Przeniesienie do nowego położenia bez zmiany atrybutów graficznych";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(57, 290);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 94);
            this.button2.TabIndex = 8;
            this.button2.Text = "Przeniesienie do nowego położenia wraz ze zmianą atrybutów graficznych";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(57, 594);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(132, 44);
            this.button5.TabIndex = 11;
            this.button5.Text = "Stop";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(356, 594);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(132, 44);
            this.button6.TabIndex = 12;
            this.button6.Text = "Zmień kolor linii";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnWłączSlajder
            // 
            this.btnWłączSlajder.Location = new System.Drawing.Point(1059, 299);
            this.btnWłączSlajder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWłączSlajder.Name = "btnWłączSlajder";
            this.btnWłączSlajder.Size = new System.Drawing.Size(213, 78);
            this.btnWłączSlajder.TabIndex = 13;
            this.btnWłączSlajder.Text = "Włącz prezentacje slajdów";
            this.btnWłączSlajder.UseVisualStyleBackColor = true;
            this.btnWłączSlajder.Click += new System.EventHandler(this.button7_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1117, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Index figury(slajdu)";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1120, 417);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 15;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnWyłączSlajder
            // 
            this.btnWyłączSlajder.Location = new System.Drawing.Point(1059, 511);
            this.btnWyłączSlajder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWyłączSlajder.Name = "btnWyłączSlajder";
            this.btnWyłączSlajder.Size = new System.Drawing.Size(213, 78);
            this.btnWyłączSlajder.TabIndex = 16;
            this.btnWyłączSlajder.Text = "Wyłącz prezentacje slajdów";
            this.btnWyłączSlajder.UseVisualStyleBackColor = true;
            this.btnWyłączSlajder.Click += new System.EventHandler(this.btnWyłączSlajder_Click);
            // 
            // btnNastępny
            // 
            this.btnNastępny.Location = new System.Drawing.Point(1192, 443);
            this.btnNastępny.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNastępny.Name = "btnNastępny";
            this.btnNastępny.Size = new System.Drawing.Size(80, 32);
            this.btnNastępny.TabIndex = 17;
            this.btnNastępny.Text = "Następny";
            this.btnNastępny.UseVisualStyleBackColor = true;
            this.btnNastępny.Click += new System.EventHandler(this.btnNastępny_Click);
            // 
            // btnPoprzedni
            // 
            this.btnPoprzedni.Location = new System.Drawing.Point(1058, 443);
            this.btnPoprzedni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPoprzedni.Name = "btnPoprzedni";
            this.btnPoprzedni.Size = new System.Drawing.Size(80, 32);
            this.btnPoprzedni.TabIndex = 18;
            this.btnPoprzedni.Text = "Poprzedni";
            this.btnPoprzedni.UseVisualStyleBackColor = true;
            this.btnPoprzedni.Click += new System.EventHandler(this.btnPoprzedni_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rdbAutomat
            // 
            this.rdbAutomat.AutoSize = true;
            this.rdbAutomat.Location = new System.Drawing.Point(1075, 263);
            this.rdbAutomat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbAutomat.Name = "rdbAutomat";
            this.rdbAutomat.Size = new System.Drawing.Size(63, 20);
            this.rdbAutomat.TabIndex = 19;
            this.rdbAutomat.TabStop = true;
            this.rdbAutomat.Text = "Timer";
            this.rdbAutomat.UseVisualStyleBackColor = true;
            // 
            // btnWziernikKoloru
            // 
            this.btnWziernikKoloru.Location = new System.Drawing.Point(539, 594);
            this.btnWziernikKoloru.Name = "btnWziernikKoloru";
            this.btnWziernikKoloru.Size = new System.Drawing.Size(103, 44);
            this.btnWziernikKoloru.TabIndex = 20;
            this.btnWziernikKoloru.Text = "Wziernik koloru";
            this.btnWziernikKoloru.UseVisualStyleBackColor = true;
            this.btnWziernikKoloru.Click += new System.EventHandler(this.btnWziernikKoloru_Click);
            // 
            // KreślenieFigur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 673);
            this.Controls.Add(this.btnWziernikKoloru);
            this.Controls.Add(this.rdbAutomat);
            this.Controls.Add(this.btnPoprzedni);
            this.Controls.Add(this.btnNastępny);
            this.Controls.Add(this.btnWyłączSlajder);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnWłączSlajder);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblZaznaczFigury);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pbRysownica);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "KreślenieFigur";
            this.Text = "Formularz laboratoryjny";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LaboratoriumNr2_FormClosing);
            this.Load += new System.EventHandler(this.LaboratoriumNr2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbRysownica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pbRysownica;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.CheckedListBox checkBox1;
        private System.Windows.Forms.Label lblZaznaczFigury;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnWłączSlajder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnWyłączSlajder;
        private System.Windows.Forms.Button btnNastępny;
        private System.Windows.Forms.Button btnPoprzedni;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton rdbAutomat;
        private System.Windows.Forms.Button btnWziernikKoloru;
    }
}