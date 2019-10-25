namespace RegisztraciosAlkalmazas
{
    partial class RegisztraciosAlkalmazas
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
            this.lblNev = new System.Windows.Forms.Label();
            this.lblSzul = new System.Windows.Forms.Label();
            this.lblNem = new System.Windows.Forms.Label();
            this.txtboxNev = new System.Windows.Forms.TextBox();
            this.txtboxSzul = new System.Windows.Forms.TextBox();
            this.txtboxHobbi = new System.Windows.Forms.TextBox();
            this.listBoxHobbik = new System.Windows.Forms.ListBox();
            this.radioFerfi = new System.Windows.Forms.RadioButton();
            this.radioNo = new System.Windows.Forms.RadioButton();
            this.lblKedvencHobbi = new System.Windows.Forms.Label();
            this.lblUjHobbi = new System.Windows.Forms.Label();
            this.btnHozzaad = new System.Windows.Forms.Button();
            this.btnBetolt = new System.Windows.Forms.Button();
            this.btnMentes = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lblNev
            // 
            this.lblNev.AutoSize = true;
            this.lblNev.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNev.Location = new System.Drawing.Point(12, 9);
            this.lblNev.Name = "lblNev";
            this.lblNev.Size = new System.Drawing.Size(49, 24);
            this.lblNev.TabIndex = 0;
            this.lblNev.Text = "Név:";
            // 
            // lblSzul
            // 
            this.lblSzul.AutoSize = true;
            this.lblSzul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSzul.Location = new System.Drawing.Point(12, 44);
            this.lblSzul.Name = "lblSzul";
            this.lblSzul.Size = new System.Drawing.Size(113, 24);
            this.lblSzul.TabIndex = 1;
            this.lblSzul.Text = "Szül. dátum:";
            // 
            // lblNem
            // 
            this.lblNem.AutoSize = true;
            this.lblNem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNem.Location = new System.Drawing.Point(12, 86);
            this.lblNem.Name = "lblNem";
            this.lblNem.Size = new System.Drawing.Size(56, 24);
            this.lblNem.TabIndex = 2;
            this.lblNem.Text = "Nem:";
            // 
            // txtboxNev
            // 
            this.txtboxNev.Location = new System.Drawing.Point(131, 13);
            this.txtboxNev.Name = "txtboxNev";
            this.txtboxNev.Size = new System.Drawing.Size(140, 20);
            this.txtboxNev.TabIndex = 3;
            // 
            // txtboxSzul
            // 
            this.txtboxSzul.Location = new System.Drawing.Point(131, 48);
            this.txtboxSzul.Name = "txtboxSzul";
            this.txtboxSzul.Size = new System.Drawing.Size(140, 20);
            this.txtboxSzul.TabIndex = 4;
            // 
            // txtboxHobbi
            // 
            this.txtboxHobbi.Location = new System.Drawing.Point(299, 155);
            this.txtboxHobbi.Name = "txtboxHobbi";
            this.txtboxHobbi.Size = new System.Drawing.Size(135, 20);
            this.txtboxHobbi.TabIndex = 5;
            this.txtboxHobbi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtboxHobbi_KeyDown);
            // 
            // listBoxHobbik
            // 
            this.listBoxHobbik.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxHobbik.FormattingEnabled = true;
            this.listBoxHobbik.Location = new System.Drawing.Point(299, 35);
            this.listBoxHobbik.Name = "listBoxHobbik";
            this.listBoxHobbik.Size = new System.Drawing.Size(135, 106);
            this.listBoxHobbik.TabIndex = 6;
            // 
            // radioFerfi
            // 
            this.radioFerfi.AutoSize = true;
            this.radioFerfi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioFerfi.Location = new System.Drawing.Point(89, 86);
            this.radioFerfi.Name = "radioFerfi";
            this.radioFerfi.Size = new System.Drawing.Size(59, 24);
            this.radioFerfi.TabIndex = 9;
            this.radioFerfi.TabStop = true;
            this.radioFerfi.Text = "Férfi";
            this.radioFerfi.UseVisualStyleBackColor = true;
            // 
            // radioNo
            // 
            this.radioNo.AutoSize = true;
            this.radioNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioNo.Location = new System.Drawing.Point(89, 116);
            this.radioNo.Name = "radioNo";
            this.radioNo.Size = new System.Drawing.Size(47, 24);
            this.radioNo.TabIndex = 10;
            this.radioNo.TabStop = true;
            this.radioNo.Text = "Nő";
            this.radioNo.UseVisualStyleBackColor = true;
            // 
            // lblKedvencHobbi
            // 
            this.lblKedvencHobbi.AutoSize = true;
            this.lblKedvencHobbi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKedvencHobbi.Location = new System.Drawing.Point(295, 8);
            this.lblKedvencHobbi.Name = "lblKedvencHobbi";
            this.lblKedvencHobbi.Size = new System.Drawing.Size(155, 24);
            this.lblKedvencHobbi.TabIndex = 11;
            this.lblKedvencHobbi.Text = "Kedvenc Hobbik:";
            // 
            // lblUjHobbi
            // 
            this.lblUjHobbi.AutoSize = true;
            this.lblUjHobbi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUjHobbi.Location = new System.Drawing.Point(205, 151);
            this.lblUjHobbi.Name = "lblUjHobbi";
            this.lblUjHobbi.Size = new System.Drawing.Size(88, 24);
            this.lblUjHobbi.TabIndex = 12;
            this.lblUjHobbi.Text = "Új Hobbi:";
            // 
            // btnHozzaad
            // 
            this.btnHozzaad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHozzaad.Location = new System.Drawing.Point(334, 181);
            this.btnHozzaad.Name = "btnHozzaad";
            this.btnHozzaad.Size = new System.Drawing.Size(100, 23);
            this.btnHozzaad.TabIndex = 13;
            this.btnHozzaad.Text = "Hozzáadás";
            this.btnHozzaad.UseVisualStyleBackColor = true;
            this.btnHozzaad.Click += new System.EventHandler(this.btnHozzaad_Click);
            // 
            // btnBetolt
            // 
            this.btnBetolt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBetolt.Location = new System.Drawing.Point(108, 168);
            this.btnBetolt.Name = "btnBetolt";
            this.btnBetolt.Size = new System.Drawing.Size(72, 23);
            this.btnBetolt.TabIndex = 14;
            this.btnBetolt.Text = "Betöltés";
            this.btnBetolt.UseVisualStyleBackColor = true;
            this.btnBetolt.Click += new System.EventHandler(this.BtnBetolt_Click);
            // 
            // btnMentes
            // 
            this.btnMentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMentes.Location = new System.Drawing.Point(16, 168);
            this.btnMentes.Name = "btnMentes";
            this.btnMentes.Size = new System.Drawing.Size(72, 23);
            this.btnMentes.TabIndex = 15;
            this.btnMentes.Text = "Mentés";
            this.btnMentes.UseVisualStyleBackColor = true;
            this.btnMentes.Click += new System.EventHandler(this.BtnMentes_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "Szöveges fájl|*.txt";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // RegisztraciosAlkalmazas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(455, 223);
            this.Controls.Add(this.btnMentes);
            this.Controls.Add(this.btnBetolt);
            this.Controls.Add(this.btnHozzaad);
            this.Controls.Add(this.lblUjHobbi);
            this.Controls.Add(this.lblKedvencHobbi);
            this.Controls.Add(this.radioNo);
            this.Controls.Add(this.radioFerfi);
            this.Controls.Add(this.listBoxHobbik);
            this.Controls.Add(this.txtboxHobbi);
            this.Controls.Add(this.txtboxSzul);
            this.Controls.Add(this.txtboxNev);
            this.Controls.Add(this.lblNem);
            this.Controls.Add(this.lblSzul);
            this.Controls.Add(this.lblNev);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "RegisztraciosAlkalmazas";
            this.Text = "Regisztráció";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNev;
        private System.Windows.Forms.Label lblSzul;
        private System.Windows.Forms.Label lblNem;
        private System.Windows.Forms.TextBox txtboxNev;
        private System.Windows.Forms.TextBox txtboxSzul;
        private System.Windows.Forms.TextBox txtboxHobbi;
        private System.Windows.Forms.ListBox listBoxHobbik;
        private System.Windows.Forms.RadioButton radioFerfi;
        private System.Windows.Forms.RadioButton radioNo;
        private System.Windows.Forms.Label lblKedvencHobbi;
        private System.Windows.Forms.Label lblUjHobbi;
        private System.Windows.Forms.Button btnHozzaad;
        private System.Windows.Forms.Button btnBetolt;
        private System.Windows.Forms.Button btnMentes;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

