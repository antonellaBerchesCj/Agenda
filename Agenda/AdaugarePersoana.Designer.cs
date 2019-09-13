namespace Agenda
{
    partial class AdaugarePersoana
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
            this.prenumeCmb = new System.Windows.Forms.ComboBox();
            this.codPostalCmb = new System.Windows.Forms.ComboBox();
            this.telefonCmb = new System.Windows.Forms.ComboBox();
            this.numeCmb = new System.Windows.Forms.ComboBox();
            this.codPostalLbl = new System.Windows.Forms.Label();
            this.prenumeLbl = new System.Windows.Forms.Label();
            this.telefonLbl = new System.Windows.Forms.Label();
            this.numeLbl = new System.Windows.Forms.Label();
            this.AdaugareBtn = new System.Windows.Forms.Button();
            this.IesireBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // prenumeCmb
            // 
            this.prenumeCmb.FormattingEnabled = true;
            this.prenumeCmb.Items.AddRange(new object[] {
            "Popescu",
            "Ionescu",
            "Enescu",
            "Creanga"});
            this.prenumeCmb.Location = new System.Drawing.Point(169, 118);
            this.prenumeCmb.Name = "prenumeCmb";
            this.prenumeCmb.Size = new System.Drawing.Size(221, 24);
            this.prenumeCmb.TabIndex = 43;
            // 
            // codPostalCmb
            // 
            this.codPostalCmb.FormattingEnabled = true;
            this.codPostalCmb.Location = new System.Drawing.Point(169, 191);
            this.codPostalCmb.Name = "codPostalCmb";
            this.codPostalCmb.Size = new System.Drawing.Size(221, 24);
            this.codPostalCmb.TabIndex = 42;
            // 
            // telefonCmb
            // 
            this.telefonCmb.FormattingEnabled = true;
            this.telefonCmb.Location = new System.Drawing.Point(169, 156);
            this.telefonCmb.Name = "telefonCmb";
            this.telefonCmb.Size = new System.Drawing.Size(221, 24);
            this.telefonCmb.TabIndex = 41;
            // 
            // numeCmb
            // 
            this.numeCmb.FormattingEnabled = true;
            this.numeCmb.Items.AddRange(new object[] {
            "Popescu",
            "Ionescu",
            "Enescu",
            "Creanga"});
            this.numeCmb.Location = new System.Drawing.Point(169, 83);
            this.numeCmb.Name = "numeCmb";
            this.numeCmb.Size = new System.Drawing.Size(221, 24);
            this.numeCmb.TabIndex = 40;
            this.numeCmb.SelectedIndexChanged += new System.EventHandler(this.numeCmb_SelectedIndexChanged);
            // 
            // codPostalLbl
            // 
            this.codPostalLbl.AutoSize = true;
            this.codPostalLbl.BackColor = System.Drawing.Color.Transparent;
            this.codPostalLbl.Font = new System.Drawing.Font("Miramonte", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codPostalLbl.ForeColor = System.Drawing.Color.Black;
            this.codPostalLbl.Location = new System.Drawing.Point(58, 190);
            this.codPostalLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.codPostalLbl.Name = "codPostalLbl";
            this.codPostalLbl.Size = new System.Drawing.Size(88, 21);
            this.codPostalLbl.TabIndex = 39;
            this.codPostalLbl.Text = "Cod postal";
            // 
            // prenumeLbl
            // 
            this.prenumeLbl.AutoSize = true;
            this.prenumeLbl.BackColor = System.Drawing.Color.Transparent;
            this.prenumeLbl.Font = new System.Drawing.Font("Miramonte", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenumeLbl.ForeColor = System.Drawing.Color.Black;
            this.prenumeLbl.Location = new System.Drawing.Point(58, 118);
            this.prenumeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prenumeLbl.Name = "prenumeLbl";
            this.prenumeLbl.Size = new System.Drawing.Size(75, 21);
            this.prenumeLbl.TabIndex = 37;
            this.prenumeLbl.Text = "Prenume";
            // 
            // telefonLbl
            // 
            this.telefonLbl.AutoSize = true;
            this.telefonLbl.BackColor = System.Drawing.Color.Transparent;
            this.telefonLbl.Font = new System.Drawing.Font("Miramonte", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefonLbl.ForeColor = System.Drawing.Color.Black;
            this.telefonLbl.Location = new System.Drawing.Point(58, 156);
            this.telefonLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.telefonLbl.Name = "telefonLbl";
            this.telefonLbl.Size = new System.Drawing.Size(62, 21);
            this.telefonLbl.TabIndex = 38;
            this.telefonLbl.Text = "Telefon";
            // 
            // numeLbl
            // 
            this.numeLbl.AutoSize = true;
            this.numeLbl.BackColor = System.Drawing.Color.Transparent;
            this.numeLbl.Font = new System.Drawing.Font("Miramonte", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeLbl.ForeColor = System.Drawing.Color.Black;
            this.numeLbl.Location = new System.Drawing.Point(58, 83);
            this.numeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numeLbl.Name = "numeLbl";
            this.numeLbl.Size = new System.Drawing.Size(55, 21);
            this.numeLbl.TabIndex = 36;
            this.numeLbl.Text = "Nume";
            // 
            // AdaugareBtn
            // 
            this.AdaugareBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AdaugareBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdaugareBtn.FlatAppearance.BorderSize = 0;
            this.AdaugareBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AdaugareBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AdaugareBtn.Location = new System.Drawing.Point(62, 249);
            this.AdaugareBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AdaugareBtn.Name = "AdaugareBtn";
            this.AdaugareBtn.Size = new System.Drawing.Size(173, 28);
            this.AdaugareBtn.TabIndex = 35;
            this.AdaugareBtn.Text = "Adauga";
            this.AdaugareBtn.UseVisualStyleBackColor = false;
            this.AdaugareBtn.Click += new System.EventHandler(this.AdaugareBtn_Click);
            // 
            // IesireBtn
            // 
            this.IesireBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IesireBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IesireBtn.FlatAppearance.BorderSize = 0;
            this.IesireBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IesireBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IesireBtn.Location = new System.Drawing.Point(320, 249);
            this.IesireBtn.Margin = new System.Windows.Forms.Padding(4);
            this.IesireBtn.Name = "IesireBtn";
            this.IesireBtn.Size = new System.Drawing.Size(70, 28);
            this.IesireBtn.TabIndex = 34;
            this.IesireBtn.Text = "Iesire";
            this.IesireBtn.UseVisualStyleBackColor = false;
            this.IesireBtn.Click += new System.EventHandler(this.IesireBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Italianate", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 30);
            this.label1.TabIndex = 58;
            this.label1.Text = "Adaugare persoana in agenda";
            // 
            // AdaugarePersoana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(458, 333);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prenumeCmb);
            this.Controls.Add(this.codPostalCmb);
            this.Controls.Add(this.telefonCmb);
            this.Controls.Add(this.numeCmb);
            this.Controls.Add(this.codPostalLbl);
            this.Controls.Add(this.prenumeLbl);
            this.Controls.Add(this.telefonLbl);
            this.Controls.Add(this.numeLbl);
            this.Controls.Add(this.AdaugareBtn);
            this.Controls.Add(this.IesireBtn);
            this.Name = "AdaugarePersoana";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adaugare persoana";
            this.Load += new System.EventHandler(this.AdaugarePersoana_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox prenumeCmb;
        private System.Windows.Forms.ComboBox codPostalCmb;
        private System.Windows.Forms.ComboBox telefonCmb;
        private System.Windows.Forms.ComboBox numeCmb;
        private System.Windows.Forms.Label codPostalLbl;
        private System.Windows.Forms.Label prenumeLbl;
        private System.Windows.Forms.Label telefonLbl;
        private System.Windows.Forms.Label numeLbl;
        private System.Windows.Forms.Button AdaugareBtn;
        private System.Windows.Forms.Button IesireBtn;
        private System.Windows.Forms.Label label1;
    }
}