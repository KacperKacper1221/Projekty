namespace Figury_geometryczne
{
    partial class KokpitNr2
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFormLab = new System.Windows.Forms.Button();
            this.FormularzIndywidualny = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFormLab
            // 
            this.btnFormLab.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFormLab.Location = new System.Drawing.Point(133, 203);
            this.btnFormLab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFormLab.Name = "btnFormLab";
            this.btnFormLab.Size = new System.Drawing.Size(191, 103);
            this.btnFormLab.TabIndex = 0;
            this.btnFormLab.Text = "Figury kreślone automatycznie";
            this.btnFormLab.UseVisualStyleBackColor = true;
            this.btnFormLab.Click += new System.EventHandler(this.btnFormInd_Click);
            // 
            // FormularzIndywidualny
            // 
            this.FormularzIndywidualny.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormularzIndywidualny.Location = new System.Drawing.Point(645, 203);
            this.FormularzIndywidualny.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FormularzIndywidualny.Name = "FormularzIndywidualny";
            this.FormularzIndywidualny.Size = new System.Drawing.Size(191, 103);
            this.FormularzIndywidualny.TabIndex = 1;
            this.FormularzIndywidualny.Text = "Figury kreślone ręcznie";
            this.FormularzIndywidualny.UseVisualStyleBackColor = true;
            this.FormularzIndywidualny.Click += new System.EventHandler(this.btnFormInd_Click_1);
            // 
            // KokpitNr2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 558);
            this.Controls.Add(this.FormularzIndywidualny);
            this.Controls.Add(this.btnFormLab);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "KokpitNr2";
            this.Text = "Formularz główny projektu nr 2 ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KokpitNr2_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFormLab;
        private System.Windows.Forms.Button FormularzIndywidualny;
    }
}

