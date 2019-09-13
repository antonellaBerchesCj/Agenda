namespace Agenda
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.IesireBtn = new System.Windows.Forms.Button();
            this.ModificareBtn = new System.Windows.Forms.Button();
            this.AfisareBtn = new System.Windows.Forms.Button();
            this.AdaugareBtn = new System.Windows.Forms.Button();
            this.codPostalTxt = new System.Windows.Forms.TextBox();
            this.InfoCmb = new System.Windows.Forms.ComboBox();
            this.telefonTxt = new System.Windows.Forms.TextBox();
            this.numeTxt = new System.Windows.Forms.TextBox();
            this.codPostalLbl = new System.Windows.Forms.Label();
            this.numeLbl = new System.Windows.Forms.Label();
            this.telefonLbl = new System.Windows.Forms.Label();
            this.prenumeTxt = new System.Windows.Forms.TextBox();
            this.prenumeLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(71, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 25);
            this.label1.TabIndex = 48;
            this.label1.Text = "Selecteaza o persoana:";
            // 
            // IesireBtn
            // 
            this.IesireBtn.BackColor = System.Drawing.SystemColors.InfoText;
            this.IesireBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IesireBtn.FlatAppearance.BorderSize = 0;
            this.IesireBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IesireBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IesireBtn.Location = new System.Drawing.Point(387, 356);
            this.IesireBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IesireBtn.Name = "IesireBtn";
            this.IesireBtn.Size = new System.Drawing.Size(94, 35);
            this.IesireBtn.TabIndex = 47;
            this.IesireBtn.Text = "Iesire";
            this.IesireBtn.UseVisualStyleBackColor = false;
            this.IesireBtn.Click += new System.EventHandler(this.IesireBtn_Click);
            // 
            // ModificareBtn
            // 
            this.ModificareBtn.BackColor = System.Drawing.SystemColors.InfoText;
            this.ModificareBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ModificareBtn.FlatAppearance.BorderSize = 0;
            this.ModificareBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ModificareBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ModificareBtn.Location = new System.Drawing.Point(284, 294);
            this.ModificareBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ModificareBtn.Name = "ModificareBtn";
            this.ModificareBtn.Size = new System.Drawing.Size(94, 59);
            this.ModificareBtn.TabIndex = 46;
            this.ModificareBtn.Text = "Modificare agenda";
            this.ModificareBtn.UseVisualStyleBackColor = false;
            this.ModificareBtn.Click += new System.EventHandler(this.ModificareBtn_Click);
            // 
            // AfisareBtn
            // 
            this.AfisareBtn.BackColor = System.Drawing.SystemColors.InfoText;
            this.AfisareBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AfisareBtn.FlatAppearance.BorderSize = 0;
            this.AfisareBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AfisareBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AfisareBtn.Location = new System.Drawing.Point(76, 294);
            this.AfisareBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AfisareBtn.Name = "AfisareBtn";
            this.AfisareBtn.Size = new System.Drawing.Size(94, 59);
            this.AfisareBtn.TabIndex = 45;
            this.AfisareBtn.Text = "Afisare agenda";
            this.AfisareBtn.UseVisualStyleBackColor = false;
            this.AfisareBtn.Click += new System.EventHandler(this.AfisareBtn_Click);
            // 
            // AdaugareBtn
            // 
            this.AdaugareBtn.BackColor = System.Drawing.SystemColors.InfoText;
            this.AdaugareBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdaugareBtn.FlatAppearance.BorderSize = 0;
            this.AdaugareBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AdaugareBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AdaugareBtn.Location = new System.Drawing.Point(180, 294);
            this.AdaugareBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AdaugareBtn.Name = "AdaugareBtn";
            this.AdaugareBtn.Size = new System.Drawing.Size(94, 59);
            this.AdaugareBtn.TabIndex = 44;
            this.AdaugareBtn.Text = "Adaugare persoana";
            this.AdaugareBtn.UseVisualStyleBackColor = false;
            this.AdaugareBtn.Click += new System.EventHandler(this.AdaugareBtn_Click);
            // 
            // codPostalTxt
            // 
            this.codPostalTxt.BackColor = System.Drawing.Color.White;
            this.codPostalTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.codPostalTxt.Location = new System.Drawing.Point(197, 235);
            this.codPostalTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.codPostalTxt.Name = "codPostalTxt";
            this.codPostalTxt.ReadOnly = true;
            this.codPostalTxt.Size = new System.Drawing.Size(284, 28);
            this.codPostalTxt.TabIndex = 43;
            // 
            // InfoCmb
            // 
            this.InfoCmb.FormattingEnabled = true;
            this.InfoCmb.Location = new System.Drawing.Point(284, 65);
            this.InfoCmb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InfoCmb.Name = "InfoCmb";
            this.InfoCmb.Size = new System.Drawing.Size(198, 28);
            this.InfoCmb.TabIndex = 37;
            this.InfoCmb.SelectedIndexChanged += new System.EventHandler(this.InfoCmb_SelectedIndexChanged);
            // 
            // telefonTxt
            // 
            this.telefonTxt.BackColor = System.Drawing.Color.White;
            this.telefonTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.telefonTxt.Location = new System.Drawing.Point(197, 195);
            this.telefonTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.telefonTxt.Name = "telefonTxt";
            this.telefonTxt.ReadOnly = true;
            this.telefonTxt.Size = new System.Drawing.Size(284, 28);
            this.telefonTxt.TabIndex = 42;
            // 
            // numeTxt
            // 
            this.numeTxt.BackColor = System.Drawing.Color.White;
            this.numeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numeTxt.Location = new System.Drawing.Point(197, 104);
            this.numeTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numeTxt.Name = "numeTxt";
            this.numeTxt.ReadOnly = true;
            this.numeTxt.Size = new System.Drawing.Size(284, 28);
            this.numeTxt.TabIndex = 41;
            // 
            // codPostalLbl
            // 
            this.codPostalLbl.AutoSize = true;
            this.codPostalLbl.BackColor = System.Drawing.Color.Transparent;
            this.codPostalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codPostalLbl.ForeColor = System.Drawing.Color.Black;
            this.codPostalLbl.Location = new System.Drawing.Point(72, 235);
            this.codPostalLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.codPostalLbl.Name = "codPostalLbl";
            this.codPostalLbl.Size = new System.Drawing.Size(115, 25);
            this.codPostalLbl.TabIndex = 40;
            this.codPostalLbl.Text = "Cod postal";
            // 
            // numeLbl
            // 
            this.numeLbl.AutoSize = true;
            this.numeLbl.BackColor = System.Drawing.Color.Transparent;
            this.numeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeLbl.ForeColor = System.Drawing.Color.Black;
            this.numeLbl.Location = new System.Drawing.Point(72, 108);
            this.numeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numeLbl.Name = "numeLbl";
            this.numeLbl.Size = new System.Drawing.Size(68, 25);
            this.numeLbl.TabIndex = 38;
            this.numeLbl.Text = "Nume";
            // 
            // telefonLbl
            // 
            this.telefonLbl.AutoSize = true;
            this.telefonLbl.BackColor = System.Drawing.Color.Transparent;
            this.telefonLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefonLbl.ForeColor = System.Drawing.Color.Black;
            this.telefonLbl.Location = new System.Drawing.Point(72, 198);
            this.telefonLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.telefonLbl.Name = "telefonLbl";
            this.telefonLbl.Size = new System.Drawing.Size(84, 25);
            this.telefonLbl.TabIndex = 39;
            this.telefonLbl.Text = "Telefon";
            // 
            // prenumeTxt
            // 
            this.prenumeTxt.BackColor = System.Drawing.Color.White;
            this.prenumeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prenumeTxt.Location = new System.Drawing.Point(197, 149);
            this.prenumeTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.prenumeTxt.Name = "prenumeTxt";
            this.prenumeTxt.ReadOnly = true;
            this.prenumeTxt.Size = new System.Drawing.Size(284, 28);
            this.prenumeTxt.TabIndex = 50;
            // 
            // prenumeLbl
            // 
            this.prenumeLbl.AutoSize = true;
            this.prenumeLbl.BackColor = System.Drawing.Color.Transparent;
            this.prenumeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenumeLbl.ForeColor = System.Drawing.Color.Black;
            this.prenumeLbl.Location = new System.Drawing.Point(72, 149);
            this.prenumeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prenumeLbl.Name = "prenumeLbl";
            this.prenumeLbl.Size = new System.Drawing.Size(98, 25);
            this.prenumeLbl.TabIndex = 49;
            this.prenumeLbl.Text = "Prenume";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(547, 435);
            this.Controls.Add(this.prenumeTxt);
            this.Controls.Add(this.prenumeLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IesireBtn);
            this.Controls.Add(this.ModificareBtn);
            this.Controls.Add(this.AfisareBtn);
            this.Controls.Add(this.AdaugareBtn);
            this.Controls.Add(this.codPostalTxt);
            this.Controls.Add(this.InfoCmb);
            this.Controls.Add(this.telefonTxt);
            this.Controls.Add(this.numeTxt);
            this.Controls.Add(this.codPostalLbl);
            this.Controls.Add(this.numeLbl);
            this.Controls.Add(this.telefonLbl);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selectare persoana";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button IesireBtn;
        private System.Windows.Forms.Button ModificareBtn;
        private System.Windows.Forms.Button AfisareBtn;
        private System.Windows.Forms.Button AdaugareBtn;
        private System.Windows.Forms.TextBox codPostalTxt;
        private System.Windows.Forms.ComboBox InfoCmb;
        private System.Windows.Forms.TextBox telefonTxt;
        private System.Windows.Forms.TextBox numeTxt;
        private System.Windows.Forms.Label codPostalLbl;
        private System.Windows.Forms.Label numeLbl;
        private System.Windows.Forms.Label telefonLbl;
        private System.Windows.Forms.TextBox prenumeTxt;
        private System.Windows.Forms.Label prenumeLbl;
    }
}

