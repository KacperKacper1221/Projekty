namespace Figury_geometryczne
    
{
    partial class RysowanieMyszą
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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pbRysownica = new System.Windows.Forms.PictureBox();
            this.btnPrzesuńFigury = new System.Windows.Forms.Button();
            this.btnWlacz = new System.Windows.Forms.Button();
            this.chAutomatyczny = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.kkStylLinii = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.chBoxFigury = new System.Windows.Forms.GroupBox();
            this.rdbFillSquare = new System.Windows.Forms.RadioButton();
            this.rdbLiniaKreślonaMyszą = new System.Windows.Forms.RadioButton();
            this.rdbKwadrat = new System.Windows.Forms.RadioButton();
            this.rdbProstokąt = new System.Windows.Forms.RadioButton();
            this.rdbOkrąg = new System.Windows.Forms.RadioButton();
            this.rdbElipsa = new System.Windows.Forms.RadioButton();
            this.rdbLinia = new System.Windows.Forms.RadioButton();
            this.rdbPunkt = new System.Windows.Forms.RadioButton();
            this.kkTextBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kkGrubośćLinii = new System.Windows.Forms.TrackBar();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnKolor = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtNumerFigury = new System.Windows.Forms.TextBox();
            this.btnNastępny = new System.Windows.Forms.Button();
            this.btnPoprzedni = new System.Windows.Forms.Button();
            this.btnWylacz = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.kkrdbLiniaPodwójna = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbRysownica)).BeginInit();
            this.chBoxFigury.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kkGrubośćLinii)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pbRysownica
            // 
            this.pbRysownica.Location = new System.Drawing.Point(18, 52);
            this.pbRysownica.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbRysownica.Name = "pbRysownica";
            this.pbRysownica.Size = new System.Drawing.Size(634, 418);
            this.pbRysownica.TabIndex = 0;
            this.pbRysownica.TabStop = false;
            this.pbRysownica.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbRysownica_MouseDown);
            this.pbRysownica.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbRysownica_MouseMove);
            this.pbRysownica.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbRysownica_MouseUp);
            // 
            // btnPrzesuńFigury
            // 
            this.btnPrzesuńFigury.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrzesuńFigury.Location = new System.Drawing.Point(454, 14);
            this.btnPrzesuńFigury.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrzesuńFigury.Name = "btnPrzesuńFigury";
            this.btnPrzesuńFigury.Size = new System.Drawing.Size(198, 25);
            this.btnPrzesuńFigury.TabIndex = 1;
            this.btnPrzesuńFigury.Text = "Przesuń figury do nowej lokalizacji";
            this.btnPrzesuńFigury.UseVisualStyleBackColor = true;
            this.btnPrzesuńFigury.Click += new System.EventHandler(this.btnPrzesuńFigury_Click_1);
            // 
            // btnWlacz
            // 
            this.btnWlacz.Location = new System.Drawing.Point(18, 514);
            this.btnWlacz.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnWlacz.Name = "btnWlacz";
            this.btnWlacz.Size = new System.Drawing.Size(94, 24);
            this.btnWlacz.TabIndex = 4;
            this.btnWlacz.Text = "Włącz pokaz figur";
            this.btnWlacz.UseVisualStyleBackColor = true;
            this.btnWlacz.Click += new System.EventHandler(this.button2_Click);
            // 
            // chAutomatyczny
            // 
            this.chAutomatyczny.AutoSize = true;
            this.chAutomatyczny.Location = new System.Drawing.Point(142, 488);
            this.chAutomatyczny.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chAutomatyczny.Name = "chAutomatyczny";
            this.chAutomatyczny.Size = new System.Drawing.Size(103, 19);
            this.chAutomatyczny.TabIndex = 5;
            this.chAutomatyczny.Text = "Automatyczny";
            this.chAutomatyczny.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(142, 514);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(83, 19);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "Manualny";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // kkStylLinii
            // 
            this.kkStylLinii.FormattingEnabled = true;
            this.kkStylLinii.Items.AddRange(new object[] {
            "Solid",
            "Dash",
            "Dash.Dot",
            "Dash.Dot.Dot",
            "Dot"});
            this.kkStylLinii.Location = new System.Drawing.Point(870, 332);
            this.kkStylLinii.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kkStylLinii.Name = "kkStylLinii";
            this.kkStylLinii.Size = new System.Drawing.Size(92, 21);
            this.kkStylLinii.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(902, 301);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Styl linii";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(715, 314);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kolor linii";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblInfo.Location = new System.Drawing.Point(16, 18);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(251, 20);
            this.lblInfo.TabIndex = 10;
            this.lblInfo.Text = "Współrzędne(x,y) położenia myszy";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblX.Location = new System.Drawing.Point(237, 18);
            this.lblX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(18, 18);
            this.lblX.TabIndex = 11;
            this.lblX.Text = "X";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblY.Location = new System.Drawing.Point(306, 18);
            this.lblY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(17, 18);
            this.lblY.TabIndex = 12;
            this.lblY.Text = "Y";
            this.lblY.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblY_MouseUp);
            // 
            // chBoxFigury
            // 
            this.chBoxFigury.Controls.Add(this.kkrdbLiniaPodwójna);
            this.chBoxFigury.Controls.Add(this.rdbFillSquare);
            this.chBoxFigury.Controls.Add(this.rdbLiniaKreślonaMyszą);
            this.chBoxFigury.Controls.Add(this.rdbKwadrat);
            this.chBoxFigury.Controls.Add(this.rdbProstokąt);
            this.chBoxFigury.Controls.Add(this.rdbOkrąg);
            this.chBoxFigury.Controls.Add(this.rdbElipsa);
            this.chBoxFigury.Controls.Add(this.rdbLinia);
            this.chBoxFigury.Controls.Add(this.rdbPunkt);
            this.chBoxFigury.Location = new System.Drawing.Point(699, 71);
            this.chBoxFigury.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chBoxFigury.Name = "chBoxFigury";
            this.chBoxFigury.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chBoxFigury.Size = new System.Drawing.Size(255, 214);
            this.chBoxFigury.TabIndex = 20;
            this.chBoxFigury.TabStop = false;
            this.chBoxFigury.Text = "Wybierz figurę do nakreślenia";
            // 
            // rdbFillSquare
            // 
            this.rdbFillSquare.AutoSize = true;
            this.rdbFillSquare.Location = new System.Drawing.Point(123, 54);
            this.rdbFillSquare.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbFillSquare.Name = "rdbFillSquare";
            this.rdbFillSquare.Size = new System.Drawing.Size(84, 19);
            this.rdbFillSquare.TabIndex = 27;
            this.rdbFillSquare.TabStop = true;
            this.rdbFillSquare.Text = "FillSquare";
            this.rdbFillSquare.UseVisualStyleBackColor = true;
            // 
            // rdbLiniaKreślonaMyszą
            // 
            this.rdbLiniaKreślonaMyszą.AutoSize = true;
            this.rdbLiniaKreślonaMyszą.Location = new System.Drawing.Point(123, 22);
            this.rdbLiniaKreślonaMyszą.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbLiniaKreślonaMyszą.Name = "rdbLiniaKreślonaMyszą";
            this.rdbLiniaKreślonaMyszą.Size = new System.Drawing.Size(143, 19);
            this.rdbLiniaKreślonaMyszą.TabIndex = 26;
            this.rdbLiniaKreślonaMyszą.TabStop = true;
            this.rdbLiniaKreślonaMyszą.Text = "Linia kreślona myszą";
            this.rdbLiniaKreślonaMyszą.UseVisualStyleBackColor = true;
            // 
            // rdbKwadrat
            // 
            this.rdbKwadrat.AutoSize = true;
            this.rdbKwadrat.Location = new System.Drawing.Point(18, 175);
            this.rdbKwadrat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbKwadrat.Name = "rdbKwadrat";
            this.rdbKwadrat.Size = new System.Drawing.Size(73, 19);
            this.rdbKwadrat.TabIndex = 25;
            this.rdbKwadrat.TabStop = true;
            this.rdbKwadrat.Text = "Kwadrat";
            this.rdbKwadrat.UseVisualStyleBackColor = true;
            // 
            // rdbProstokąt
            // 
            this.rdbProstokąt.AutoSize = true;
            this.rdbProstokąt.Location = new System.Drawing.Point(18, 145);
            this.rdbProstokąt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbProstokąt.Name = "rdbProstokąt";
            this.rdbProstokąt.Size = new System.Drawing.Size(79, 19);
            this.rdbProstokąt.TabIndex = 24;
            this.rdbProstokąt.TabStop = true;
            this.rdbProstokąt.Text = "Prostokąt";
            this.rdbProstokąt.UseVisualStyleBackColor = true;
            // 
            // rdbOkrąg
            // 
            this.rdbOkrąg.AutoSize = true;
            this.rdbOkrąg.Location = new System.Drawing.Point(18, 116);
            this.rdbOkrąg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbOkrąg.Name = "rdbOkrąg";
            this.rdbOkrąg.Size = new System.Drawing.Size(61, 19);
            this.rdbOkrąg.TabIndex = 23;
            this.rdbOkrąg.TabStop = true;
            this.rdbOkrąg.Text = "Okrąg";
            this.rdbOkrąg.UseVisualStyleBackColor = true;
            // 
            // rdbElipsa
            // 
            this.rdbElipsa.AutoSize = true;
            this.rdbElipsa.Location = new System.Drawing.Point(18, 85);
            this.rdbElipsa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbElipsa.Name = "rdbElipsa";
            this.rdbElipsa.Size = new System.Drawing.Size(62, 19);
            this.rdbElipsa.TabIndex = 22;
            this.rdbElipsa.TabStop = true;
            this.rdbElipsa.Text = "Elipsa";
            this.rdbElipsa.UseVisualStyleBackColor = true;
            // 
            // rdbLinia
            // 
            this.rdbLinia.AutoSize = true;
            this.rdbLinia.Location = new System.Drawing.Point(18, 54);
            this.rdbLinia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbLinia.Name = "rdbLinia";
            this.rdbLinia.Size = new System.Drawing.Size(55, 19);
            this.rdbLinia.TabIndex = 21;
            this.rdbLinia.TabStop = true;
            this.rdbLinia.Text = "Linia";
            this.rdbLinia.UseVisualStyleBackColor = true;
            // 
            // rdbPunkt
            // 
            this.rdbPunkt.AutoSize = true;
            this.rdbPunkt.Location = new System.Drawing.Point(18, 22);
            this.rdbPunkt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbPunkt.Name = "rdbPunkt";
            this.rdbPunkt.Size = new System.Drawing.Size(59, 19);
            this.rdbPunkt.TabIndex = 20;
            this.rdbPunkt.TabStop = true;
            this.rdbPunkt.Text = "Punkt";
            this.rdbPunkt.UseVisualStyleBackColor = true;
            // 
            // kkTextBox1
            // 
            this.kkTextBox1.Location = new System.Drawing.Point(699, 334);
            this.kkTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kkTextBox1.Name = "kkTextBox1";
            this.kkTextBox1.Size = new System.Drawing.Size(76, 20);
            this.kkTextBox1.TabIndex = 21;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // kkGrubośćLinii
            // 
            this.kkGrubośćLinii.Location = new System.Drawing.Point(870, 397);
            this.kkGrubośćLinii.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kkGrubośćLinii.Name = "kkGrubośćLinii";
            this.kkGrubośćLinii.Size = new System.Drawing.Size(91, 56);
            this.kkGrubośćLinii.TabIndex = 23;
            // 
            // btnKolor
            // 
            this.btnKolor.Location = new System.Drawing.Point(702, 383);
            this.btnKolor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnKolor.Name = "btnKolor";
            this.btnKolor.Size = new System.Drawing.Size(74, 24);
            this.btnKolor.TabIndex = 24;
            this.btnKolor.Text = "Wybierz kolor";
            this.btnKolor.UseVisualStyleBackColor = true;
            this.btnKolor.Click += new System.EventHandler(this.btnKolor_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtNumerFigury
            // 
            this.txtNumerFigury.Location = new System.Drawing.Point(19, 488);
            this.txtNumerFigury.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumerFigury.Name = "txtNumerFigury";
            this.txtNumerFigury.Size = new System.Drawing.Size(76, 20);
            this.txtNumerFigury.TabIndex = 25;
            this.txtNumerFigury.TextChanged += new System.EventHandler(this.txtNumerFigury_TextChanged);
            // 
            // btnNastępny
            // 
            this.btnNastępny.Location = new System.Drawing.Point(328, 488);
            this.btnNastępny.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNastępny.Name = "btnNastępny";
            this.btnNastępny.Size = new System.Drawing.Size(67, 19);
            this.btnNastępny.TabIndex = 26;
            this.btnNastępny.Text = "Następny";
            this.btnNastępny.UseVisualStyleBackColor = true;
            this.btnNastępny.Click += new System.EventHandler(this.btnNastępny_Click);
            // 
            // btnPoprzedni
            // 
            this.btnPoprzedni.Location = new System.Drawing.Point(239, 488);
            this.btnPoprzedni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPoprzedni.Name = "btnPoprzedni";
            this.btnPoprzedni.Size = new System.Drawing.Size(67, 19);
            this.btnPoprzedni.TabIndex = 27;
            this.btnPoprzedni.Text = "Poprzedni";
            this.btnPoprzedni.UseVisualStyleBackColor = true;
            this.btnPoprzedni.Click += new System.EventHandler(this.btnPoprzedni_Click);
            // 
            // btnWylacz
            // 
            this.btnWylacz.Location = new System.Drawing.Point(18, 552);
            this.btnWylacz.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnWylacz.Name = "btnWylacz";
            this.btnWylacz.Size = new System.Drawing.Size(94, 19);
            this.btnWylacz.TabIndex = 28;
            this.btnWylacz.Text = "Wyłącz pokaz figur";
            this.btnWylacz.UseVisualStyleBackColor = true;
            this.btnWylacz.Click += new System.EventHandler(this.btnWylacz_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(893, 371);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 29;
            this.label3.Text = "Grubość linii";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(702, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 39);
            this.button1.TabIndex = 30;
            this.button1.Text = "Powrót do formularza głównego";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kkrdbLiniaPodwójna
            // 
            this.kkrdbLiniaPodwójna.AutoSize = true;
            this.kkrdbLiniaPodwójna.Location = new System.Drawing.Point(123, 79);
            this.kkrdbLiniaPodwójna.Name = "kkrdbLiniaPodwójna";
            this.kkrdbLiniaPodwójna.Size = new System.Drawing.Size(112, 19);
            this.kkrdbLiniaPodwójna.TabIndex = 28;
            this.kkrdbLiniaPodwójna.TabStop = true;
            this.kkrdbLiniaPodwójna.Text = "Linia podwójna";
            this.kkrdbLiniaPodwójna.UseVisualStyleBackColor = true;
         
            // 
            // Indywidualne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 638);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnWylacz);
            this.Controls.Add(this.btnPoprzedni);
            this.Controls.Add(this.btnNastępny);
            this.Controls.Add(this.txtNumerFigury);
            this.Controls.Add(this.btnKolor);
            this.Controls.Add(this.kkGrubośćLinii);
            this.Controls.Add(this.kkTextBox1);
            this.Controls.Add(this.chBoxFigury);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kkStylLinii);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.chAutomatyczny);
            this.Controls.Add(this.btnWlacz);
            this.Controls.Add(this.btnPrzesuńFigury);
            this.Controls.Add(this.pbRysownica);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Indywidualne";
            this.Text = "Indywidualne";
            ((System.ComponentModel.ISupportInitialize)(this.pbRysownica)).EndInit();
            this.chBoxFigury.ResumeLayout(false);
            this.chBoxFigury.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kkGrubośćLinii)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pbRysownica;
        private System.Windows.Forms.Button btnPrzesuńFigury;
        private System.Windows.Forms.Button btnWlacz;
        private System.Windows.Forms.CheckBox chAutomatyczny;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ComboBox kkStylLinii;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.GroupBox chBoxFigury;
        private System.Windows.Forms.RadioButton rdbLiniaKreślonaMyszą;
        private System.Windows.Forms.RadioButton rdbKwadrat;
        private System.Windows.Forms.RadioButton rdbProstokąt;
        private System.Windows.Forms.RadioButton rdbOkrąg;
        private System.Windows.Forms.RadioButton rdbElipsa;
        private System.Windows.Forms.RadioButton rdbLinia;
        private System.Windows.Forms.RadioButton rdbPunkt;
        private System.Windows.Forms.TextBox kkTextBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TrackBar kkGrubośćLinii;
        private System.Windows.Forms.RadioButton rdbFillSquare;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnKolor;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtNumerFigury;
        private System.Windows.Forms.Button btnNastępny;
        private System.Windows.Forms.Button btnPoprzedni;
        private System.Windows.Forms.Button btnWylacz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton kkrdbLiniaPodwójna;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}