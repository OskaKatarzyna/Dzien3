namespace P02AplikacjaOkienkowa
{
    partial class Form1
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
            this.btmPowitanie = new System.Windows.Forms.Button();
            this.btmZamkniecie = new System.Windows.Forms.Button();
            this.txtWyswietlacz = new System.Windows.Forms.TextBox();
            this.btmWyswietlPowitanie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btmPowitanie
            // 
            this.btmPowitanie.Location = new System.Drawing.Point(12, 12);
            this.btmPowitanie.Name = "btmPowitanie";
            this.btmPowitanie.Size = new System.Drawing.Size(75, 23);
            this.btmPowitanie.TabIndex = 0;
            this.btmPowitanie.Text = "Powitanie";
            this.btmPowitanie.UseVisualStyleBackColor = true;
            this.btmPowitanie.Click += new System.EventHandler(this.btmPowitanie_Click);
            // 
            // btmZamkniecie
            // 
            this.btmZamkniecie.Location = new System.Drawing.Point(12, 41);
            this.btmZamkniecie.Name = "btmZamkniecie";
            this.btmZamkniecie.Size = new System.Drawing.Size(101, 23);
            this.btmZamkniecie.TabIndex = 1;
            this.btmZamkniecie.Text = "Zamkniecie";
            this.btmZamkniecie.UseVisualStyleBackColor = true;
            this.btmZamkniecie.Click += new System.EventHandler(this.btmZamkniecie_Click);
            // 
            // txtWyswietlacz
            // 
            this.txtWyswietlacz.Location = new System.Drawing.Point(293, 53);
            this.txtWyswietlacz.Name = "txtWyswietlacz";
            this.txtWyswietlacz.Size = new System.Drawing.Size(248, 22);
            this.txtWyswietlacz.TabIndex = 2;
            // 
            // btmWyswietlPowitanie
            // 
            this.btmWyswietlPowitanie.Location = new System.Drawing.Point(293, 1);
            this.btmWyswietlPowitanie.Name = "btmWyswietlPowitanie";
            this.btmWyswietlPowitanie.Size = new System.Drawing.Size(248, 23);
            this.btmWyswietlPowitanie.TabIndex = 3;
            this.btmWyswietlPowitanie.Text = "Powitanie na Wyświetlaczu";
            this.btmWyswietlPowitanie.UseVisualStyleBackColor = true;
            this.btmWyswietlPowitanie.Click += new System.EventHandler(this.btmWyswietlPowitanie_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btmWyswietlPowitanie);
            this.Controls.Add(this.txtWyswietlacz);
            this.Controls.Add(this.btmZamkniecie);
            this.Controls.Add(this.btmPowitanie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btmPowitanie;
        private System.Windows.Forms.Button btmZamkniecie;
        private System.Windows.Forms.TextBox txtWyswietlacz;
        private System.Windows.Forms.Button btmWyswietlPowitanie;
    }
}

