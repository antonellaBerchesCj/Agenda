namespace Agenda
{
    partial class Afisare
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
            this.agendaLbl = new System.Windows.Forms.Label();
            this.AfisareBtn = new System.Windows.Forms.Button();
            this.InapoiBtn = new System.Windows.Forms.Button();
            this.sortareLbl = new System.Windows.Forms.Label();
            this.SortareCmb = new System.Windows.Forms.ComboBox();
            this.StergereBtn = new System.Windows.Forms.Button();
            this.AfisareList = new System.Windows.Forms.ListBox();
            this.codPostalTxt = new System.Windows.Forms.TextBox();
            this.telefonTxt = new System.Windows.Forms.TextBox();
            this.prenumeTxt = new System.Windows.Forms.TextBox();
            this.numeTxt = new System.Windows.Forms.TextBox();
            this.codPostalLbl = new System.Windows.Forms.Label();
            this.prenumeLbl = new System.Windows.Forms.Label();
            this.telefonLbl = new System.Windows.Forms.Label();
            this.numeLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // agendaLbl
            // 
            this.agendaLbl.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.agendaLbl.AutoSize = true;
            this.agendaLbl.BackColor = System.Drawing.Color.Transparent;
            this.agendaLbl.Font = new System.Drawing.Font("Notram", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agendaLbl.ForeColor = System.Drawing.Color.Black;
            this.agendaLbl.Location = new System.Drawing.Point(215, 48);
            this.agendaLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.agendaLbl.Name = "agendaLbl";
            this.agendaLbl.Size = new System.Drawing.Size(270, 33);
            this.agendaLbl.TabIndex = 47;
            this.agendaLbl.Text = "Agenda telefonica";
            // 
            // AfisareBtn
            // 
            this.AfisareBtn.BackColor = System.Drawing.SystemColors.InfoText;
            this.AfisareBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AfisareBtn.FlatAppearance.BorderSize = 0;
            this.AfisareBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AfisareBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AfisareBtn.Location = new System.Drawing.Point(45, 341);
            this.AfisareBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AfisareBtn.Name = "AfisareBtn";
            this.AfisareBtn.Size = new System.Drawing.Size(158, 28);
            this.AfisareBtn.TabIndex = 46;
            this.AfisareBtn.Text = "Afisare";
            this.AfisareBtn.UseVisualStyleBackColor = false;
            this.AfisareBtn.Click += new System.EventHandler(this.AfisareBtn_Click);
            // 
            // InapoiBtn
            // 
            this.InapoiBtn.BackColor = System.Drawing.SystemColors.InfoText;
            this.InapoiBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InapoiBtn.FlatAppearance.BorderSize = 0;
            this.InapoiBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InapoiBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.InapoiBtn.Location = new System.Drawing.Point(404, 457);
            this.InapoiBtn.Margin = new System.Windows.Forms.Padding(4);
            this.InapoiBtn.Name = "InapoiBtn";
            this.InapoiBtn.Size = new System.Drawing.Size(240, 28);
            this.InapoiBtn.TabIndex = 45;
            this.InapoiBtn.Text = "Inapoi";
            this.InapoiBtn.UseVisualStyleBackColor = false;
            this.InapoiBtn.Click += new System.EventHandler(this.InapoiBtn_Click);
            // 
            // sortareLbl
            // 
            this.sortareLbl.AutoSize = true;
            this.sortareLbl.BackColor = System.Drawing.Color.Transparent;
            this.sortareLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sortareLbl.Location = new System.Drawing.Point(41, 285);
            this.sortareLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sortareLbl.Name = "sortareLbl";
            this.sortareLbl.Size = new System.Drawing.Size(71, 20);
            this.sortareLbl.TabIndex = 44;
            this.sortareLbl.Text = "Sortare";
            // 
            // SortareCmb
            // 
            this.SortareCmb.FormattingEnabled = true;
            this.SortareCmb.Location = new System.Drawing.Point(148, 280);
            this.SortareCmb.Margin = new System.Windows.Forms.Padding(4);
            this.SortareCmb.Name = "SortareCmb";
            this.SortareCmb.Size = new System.Drawing.Size(221, 24);
            this.SortareCmb.TabIndex = 43;
            this.SortareCmb.SelectedIndexChanged += new System.EventHandler(this.SortareCmb_SelectedIndexChanged);
            // 
            // StergereBtn
            // 
            this.StergereBtn.BackColor = System.Drawing.SystemColors.InfoText;
            this.StergereBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StergereBtn.FlatAppearance.BorderSize = 0;
            this.StergereBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StergereBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StergereBtn.Location = new System.Drawing.Point(211, 341);
            this.StergereBtn.Margin = new System.Windows.Forms.Padding(4);
            this.StergereBtn.Name = "StergereBtn";
            this.StergereBtn.Size = new System.Drawing.Size(158, 28);
            this.StergereBtn.TabIndex = 42;
            this.StergereBtn.Text = "Stergere";
            this.StergereBtn.UseVisualStyleBackColor = false;
            this.StergereBtn.Click += new System.EventHandler(this.StergereBtn_Click);
            // 
            // AfisareList
            // 
            this.AfisareList.FormattingEnabled = true;
            this.AfisareList.ItemHeight = 16;
            this.AfisareList.Location = new System.Drawing.Point(404, 122);
            this.AfisareList.Margin = new System.Windows.Forms.Padding(4);
            this.AfisareList.Name = "AfisareList";
            this.AfisareList.Size = new System.Drawing.Size(240, 308);
            this.AfisareList.TabIndex = 41;
            this.AfisareList.SelectedIndexChanged += new System.EventHandler(this.AfisareList_SelectedIndexChanged);
            // 
            // codPostalTxt
            // 
            this.codPostalTxt.BackColor = System.Drawing.Color.White;
            this.codPostalTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.codPostalTxt.Location = new System.Drawing.Point(148, 231);
            this.codPostalTxt.Margin = new System.Windows.Forms.Padding(4);
            this.codPostalTxt.Name = "codPostalTxt";
            this.codPostalTxt.ReadOnly = true;
            this.codPostalTxt.Size = new System.Drawing.Size(221, 24);
            this.codPostalTxt.TabIndex = 40;
            // 
            // telefonTxt
            // 
            this.telefonTxt.BackColor = System.Drawing.Color.White;
            this.telefonTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.telefonTxt.Location = new System.Drawing.Point(148, 199);
            this.telefonTxt.Margin = new System.Windows.Forms.Padding(4);
            this.telefonTxt.Name = "telefonTxt";
            this.telefonTxt.ReadOnly = true;
            this.telefonTxt.Size = new System.Drawing.Size(221, 24);
            this.telefonTxt.TabIndex = 39;
            // 
            // prenumeTxt
            // 
            this.prenumeTxt.BackColor = System.Drawing.Color.White;
            this.prenumeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prenumeTxt.Location = new System.Drawing.Point(148, 161);
            this.prenumeTxt.Margin = new System.Windows.Forms.Padding(4);
            this.prenumeTxt.Name = "prenumeTxt";
            this.prenumeTxt.ReadOnly = true;
            this.prenumeTxt.Size = new System.Drawing.Size(221, 24);
            this.prenumeTxt.TabIndex = 38;
            // 
            // numeTxt
            // 
            this.numeTxt.BackColor = System.Drawing.Color.White;
            this.numeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numeTxt.Location = new System.Drawing.Point(148, 122);
            this.numeTxt.Margin = new System.Windows.Forms.Padding(4);
            this.numeTxt.Name = "numeTxt";
            this.numeTxt.ReadOnly = true;
            this.numeTxt.Size = new System.Drawing.Size(221, 24);
            this.numeTxt.TabIndex = 37;
            // 
            // codPostalLbl
            // 
            this.codPostalLbl.AutoSize = true;
            this.codPostalLbl.BackColor = System.Drawing.Color.Transparent;
            this.codPostalLbl.Font = new System.Drawing.Font("Miramonte", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codPostalLbl.ForeColor = System.Drawing.Color.Black;
            this.codPostalLbl.Location = new System.Drawing.Point(37, 231);
            this.codPostalLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.codPostalLbl.Name = "codPostalLbl";
            this.codPostalLbl.Size = new System.Drawing.Size(88, 21);
            this.codPostalLbl.TabIndex = 36;
            this.codPostalLbl.Text = "Cod postal";
            // 
            // prenumeLbl
            // 
            this.prenumeLbl.AutoSize = true;
            this.prenumeLbl.BackColor = System.Drawing.Color.Transparent;
            this.prenumeLbl.Font = new System.Drawing.Font("Miramonte", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenumeLbl.ForeColor = System.Drawing.Color.Black;
            this.prenumeLbl.Location = new System.Drawing.Point(37, 159);
            this.prenumeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prenumeLbl.Name = "prenumeLbl";
            this.prenumeLbl.Size = new System.Drawing.Size(75, 21);
            this.prenumeLbl.TabIndex = 34;
            this.prenumeLbl.Text = "Prenume";
            // 
            // telefonLbl
            // 
            this.telefonLbl.AutoSize = true;
            this.telefonLbl.BackColor = System.Drawing.Color.Transparent;
            this.telefonLbl.Font = new System.Drawing.Font("Miramonte", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefonLbl.ForeColor = System.Drawing.Color.Black;
            this.telefonLbl.Location = new System.Drawing.Point(37, 197);
            this.telefonLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.telefonLbl.Name = "telefonLbl";
            this.telefonLbl.Size = new System.Drawing.Size(62, 21);
            this.telefonLbl.TabIndex = 35;
            this.telefonLbl.Text = "Telefon";
            // 
            // numeLbl
            // 
            this.numeLbl.AutoSize = true;
            this.numeLbl.BackColor = System.Drawing.Color.Transparent;
            this.numeLbl.Font = new System.Drawing.Font("Miramonte", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeLbl.ForeColor = System.Drawing.Color.Black;
            this.numeLbl.Location = new System.Drawing.Point(37, 124);
            this.numeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numeLbl.Name = "numeLbl";
            this.numeLbl.Size = new System.Drawing.Size(55, 21);
            this.numeLbl.TabIndex = 33;
            this.numeLbl.Text = "Nume";
            // 
            // Afisare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(689, 527);
            this.Controls.Add(this.agendaLbl);
            this.Controls.Add(this.AfisareBtn);
            this.Controls.Add(this.InapoiBtn);
            this.Controls.Add(this.sortareLbl);
            this.Controls.Add(this.SortareCmb);
            this.Controls.Add(this.StergereBtn);
            this.Controls.Add(this.AfisareList);
            this.Controls.Add(this.codPostalTxt);
            this.Controls.Add(this.telefonTxt);
            this.Controls.Add(this.prenumeTxt);
            this.Controls.Add(this.numeTxt);
            this.Controls.Add(this.codPostalLbl);
            this.Controls.Add(this.prenumeLbl);
            this.Controls.Add(this.telefonLbl);
            this.Controls.Add(this.numeLbl);
            this.Name = "Afisare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Afisare";
            this.Load += new System.EventHandler(this.Afisare_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label agendaLbl;
        private System.Windows.Forms.Button AfisareBtn;
        private System.Windows.Forms.Button InapoiBtn;
        private System.Windows.Forms.Label sortareLbl;
        private System.Windows.Forms.ComboBox SortareCmb;
        private System.Windows.Forms.Button StergereBtn;
        private System.Windows.Forms.ListBox AfisareList;
        private System.Windows.Forms.TextBox codPostalTxt;
        private System.Windows.Forms.TextBox telefonTxt;
        private System.Windows.Forms.TextBox prenumeTxt;
        private System.Windows.Forms.TextBox numeTxt;
        private System.Windows.Forms.Label codPostalLbl;
        private System.Windows.Forms.Label prenumeLbl;
        private System.Windows.Forms.Label telefonLbl;
        private System.Windows.Forms.Label numeLbl;
    }
}