namespace Wykres
{
    partial class wndWykres
    {
        public Model modelDanych;
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
            this.lbWzor = new System.Windows.Forms.Label();
            this.tbWzor = new System.Windows.Forms.TextBox();
            this.lbX1 = new System.Windows.Forms.Label();
            this.tbX1 = new System.Windows.Forms.TextBox();
            this.lbX2 = new System.Windows.Forms.Label();
            this.tbX2 = new System.Windows.Forms.TextBox();
            this.lbX = new System.Windows.Forms.Label();
            this.tbX = new System.Windows.Forms.TextBox();
            this.tbY = new System.Windows.Forms.TextBox();
            this.lbY = new System.Windows.Forms.Label();
            this.lbTytul = new System.Windows.Forms.Label();
            this.tbTytul = new System.Windows.Forms.TextBox();
            this.lbSiatka = new System.Windows.Forms.Label();
            this.chbVertical = new System.Windows.Forms.CheckBox();
            this.chbHorizontal = new System.Windows.Forms.CheckBox();
            this.pnWykres = new System.Windows.Forms.Panel();
            this.btRysuj = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbTemp2 = new System.Windows.Forms.Label();
            this.lbOY = new System.Windows.Forms.Label();
            this.lbOX = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbWzor
            // 
            this.lbWzor.AutoSize = true;
            this.lbWzor.Location = new System.Drawing.Point(13, 14);
            this.lbWzor.Name = "lbWzor";
            this.lbWzor.Size = new System.Drawing.Size(86, 16);
            this.lbWzor.TabIndex = 0;
            this.lbWzor.Text = "Wzór Funkcji:";
            // 
            // tbWzor
            // 
            this.tbWzor.Location = new System.Drawing.Point(16, 33);
            this.tbWzor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbWzor.Name = "tbWzor";
            this.tbWzor.Size = new System.Drawing.Size(191, 22);
            this.tbWzor.TabIndex = 1;
            this.tbWzor.Text = "cos(x)+0.2*x";
            this.tbWzor.TextChanged += new System.EventHandler(this.tbWzor_TextChanged);
            // 
            // lbX1
            // 
            this.lbX1.AutoSize = true;
            this.lbX1.Location = new System.Drawing.Point(13, 63);
            this.lbX1.Name = "lbX1";
            this.lbX1.Size = new System.Drawing.Size(25, 16);
            this.lbX1.TabIndex = 2;
            this.lbX1.Text = "X1:";
            // 
            // tbX1
            // 
            this.tbX1.Location = new System.Drawing.Point(16, 82);
            this.tbX1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbX1.Name = "tbX1";
            this.tbX1.Size = new System.Drawing.Size(100, 22);
            this.tbX1.TabIndex = 3;
            this.tbX1.Text = "0";
            // 
            // lbX2
            // 
            this.lbX2.AutoSize = true;
            this.lbX2.Location = new System.Drawing.Point(13, 107);
            this.lbX2.Name = "lbX2";
            this.lbX2.Size = new System.Drawing.Size(25, 16);
            this.lbX2.TabIndex = 4;
            this.lbX2.Text = "X2:";
            // 
            // tbX2
            // 
            this.tbX2.Location = new System.Drawing.Point(16, 126);
            this.tbX2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbX2.Name = "tbX2";
            this.tbX2.Size = new System.Drawing.Size(100, 22);
            this.tbX2.TabIndex = 5;
            this.tbX2.Text = "12";
            // 
            // lbX
            // 
            this.lbX.AutoSize = true;
            this.lbX.Location = new System.Drawing.Point(13, 151);
            this.lbX.Name = "lbX";
            this.lbX.Size = new System.Drawing.Size(38, 16);
            this.lbX.TabIndex = 6;
            this.lbX.Text = "Oś X:";
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(16, 170);
            this.tbX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(100, 22);
            this.tbX.TabIndex = 7;
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(16, 214);
            this.tbY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(100, 22);
            this.tbY.TabIndex = 9;
            // 
            // lbY
            // 
            this.lbY.AutoSize = true;
            this.lbY.Location = new System.Drawing.Point(13, 194);
            this.lbY.Name = "lbY";
            this.lbY.Size = new System.Drawing.Size(39, 16);
            this.lbY.TabIndex = 8;
            this.lbY.Text = "Oś Y:";
            // 
            // lbTytul
            // 
            this.lbTytul.AutoSize = true;
            this.lbTytul.Location = new System.Drawing.Point(13, 249);
            this.lbTytul.Name = "lbTytul";
            this.lbTytul.Size = new System.Drawing.Size(42, 16);
            this.lbTytul.TabIndex = 10;
            this.lbTytul.Text = "Tytuł:";
            // 
            // tbTytul
            // 
            this.tbTytul.Location = new System.Drawing.Point(16, 267);
            this.tbTytul.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTytul.Name = "tbTytul";
            this.tbTytul.Size = new System.Drawing.Size(191, 22);
            this.tbTytul.TabIndex = 11;
            // 
            // lbSiatka
            // 
            this.lbSiatka.AutoSize = true;
            this.lbSiatka.Location = new System.Drawing.Point(13, 295);
            this.lbSiatka.Name = "lbSiatka";
            this.lbSiatka.Size = new System.Drawing.Size(74, 16);
            this.lbSiatka.TabIndex = 12;
            this.lbSiatka.Text = "Linie Siatki:";
            // 
            // chbVertical
            // 
            this.chbVertical.AutoSize = true;
            this.chbVertical.Location = new System.Drawing.Point(16, 316);
            this.chbVertical.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbVertical.Name = "chbVertical";
            this.chbVertical.Size = new System.Drawing.Size(111, 20);
            this.chbVertical.TabIndex = 13;
            this.chbVertical.Text = "Linie pionowe";
            this.chbVertical.UseVisualStyleBackColor = true;
            // 
            // chbHorizontal
            // 
            this.chbHorizontal.AutoSize = true;
            this.chbHorizontal.Location = new System.Drawing.Point(16, 342);
            this.chbHorizontal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbHorizontal.Name = "chbHorizontal";
            this.chbHorizontal.Size = new System.Drawing.Size(112, 20);
            this.chbHorizontal.TabIndex = 14;
            this.chbHorizontal.Text = "Linie poziome";
            this.chbHorizontal.UseVisualStyleBackColor = true;
            // 
            // pnWykres
            // 
            this.pnWykres.BackColor = System.Drawing.Color.White;
            this.pnWykres.Location = new System.Drawing.Point(333, 62);
            this.pnWykres.Margin = new System.Windows.Forms.Padding(0);
            this.pnWykres.Name = "pnWykres";
            this.pnWykres.Size = new System.Drawing.Size(1000, 615);
            this.pnWykres.TabIndex = 15;
            this.pnWykres.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnWykres_MouseMove);
            // 
            // btRysuj
            // 
            this.btRysuj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btRysuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btRysuj.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btRysuj.Location = new System.Drawing.Point(16, 434);
            this.btRysuj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btRysuj.Name = "btRysuj";
            this.btRysuj.Size = new System.Drawing.Size(233, 71);
            this.btRysuj.TabIndex = 16;
            this.btRysuj.Text = "Rysuj";
            this.btRysuj.UseVisualStyleBackColor = false;
            this.btRysuj.Click += new System.EventHandler(this.btRysuj_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbTitle.Location = new System.Drawing.Point(809, 14);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(0, 29);
            this.lbTitle.TabIndex = 17;
            // 
            // lbTemp2
            // 
            this.lbTemp2.AutoSize = true;
            this.lbTemp2.Location = new System.Drawing.Point(93, 590);
            this.lbTemp2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTemp2.Name = "lbTemp2";
            this.lbTemp2.Size = new System.Drawing.Size(0, 16);
            this.lbTemp2.TabIndex = 19;
            // 
            // lbOY
            // 
            this.lbOY.AutoSize = true;
            this.lbOY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbOY.Location = new System.Drawing.Point(277, 305);
            this.lbOY.Name = "lbOY";
            this.lbOY.Size = new System.Drawing.Size(0, 20);
            this.lbOY.TabIndex = 20;
            // 
            // lbOX
            // 
            this.lbOX.AutoSize = true;
            this.lbOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbOX.Location = new System.Drawing.Point(832, 691);
            this.lbOX.Name = "lbOX";
            this.lbOX.Size = new System.Drawing.Size(0, 20);
            this.lbOX.TabIndex = 21;
            // 
            // wndWykres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1445, 752);
            this.Controls.Add(this.lbOX);
            this.Controls.Add(this.lbOY);
            this.Controls.Add(this.lbTemp2);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btRysuj);
            this.Controls.Add(this.pnWykres);
            this.Controls.Add(this.chbHorizontal);
            this.Controls.Add(this.chbVertical);
            this.Controls.Add(this.lbSiatka);
            this.Controls.Add(this.tbTytul);
            this.Controls.Add(this.lbTytul);
            this.Controls.Add(this.tbY);
            this.Controls.Add(this.lbY);
            this.Controls.Add(this.tbX);
            this.Controls.Add(this.lbX);
            this.Controls.Add(this.tbX2);
            this.Controls.Add(this.lbX2);
            this.Controls.Add(this.tbX1);
            this.Controls.Add(this.lbX1);
            this.Controls.Add(this.tbWzor);
            this.Controls.Add(this.lbWzor);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "wndWykres";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbWzor;
        private System.Windows.Forms.TextBox tbWzor;
        private System.Windows.Forms.Label lbX1;
        private System.Windows.Forms.TextBox tbX1;
        private System.Windows.Forms.Label lbX2;
        private System.Windows.Forms.TextBox tbX2;
        private System.Windows.Forms.Label lbX;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.Label lbY;
        private System.Windows.Forms.Label lbTytul;
        private System.Windows.Forms.TextBox tbTytul;
        private System.Windows.Forms.Label lbSiatka;
        private System.Windows.Forms.CheckBox chbVertical;
        private System.Windows.Forms.CheckBox chbHorizontal;
        private System.Windows.Forms.Panel pnWykres;
        private System.Windows.Forms.Button btRysuj;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbTemp2;
        private System.Windows.Forms.Label lbOY;
        private System.Windows.Forms.Label lbOX;
    }
}

