namespace Agenda
{
    partial class Modifica
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
            this.prenumeTxt = new System.Windows.Forms.TextBox();
            this.codPostalLbl = new System.Windows.Forms.Label();
            this.prenumeLbl = new System.Windows.Forms.Label();
            this.telefonLbl = new System.Windows.Forms.Label();
            this.numeLbl = new System.Windows.Forms.Label();
            this.IesireBtn = new System.Windows.Forms.Button();
            this.lstAfisare = new System.Windows.Forms.ListBox();
            this.SalvareBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Italianate", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 30);
            this.label1.TabIndex = 57;
            this.label1.Text = "Modificare agenda";
            // 
            // prenumeTxt
            // 
            this.prenumeTxt.BackColor = System.Drawing.Color.White;
            this.prenumeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prenumeTxt.Location = new System.Drawing.Point(143, 251);
            this.prenumeTxt.Margin = new System.Windows.Forms.Padding(4);
            this.prenumeTxt.Name = "prenumeTxt";
            this.prenumeTxt.ReadOnly = true;
            this.prenumeTxt.Size = new System.Drawing.Size(231, 24);
            this.prenumeTxt.TabIndex = 56;
            // 
            // codPostalLbl
            // 
            this.codPostalLbl.AutoSize = true;
            this.codPostalLbl.BackColor = System.Drawing.Color.Transparent;
            this.codPostalLbl.Font = new System.Drawing.Font("Miramonte", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codPostalLbl.ForeColor = System.Drawing.Color.Black;
            this.codPostalLbl.Location = new System.Drawing.Point(60, 378);
            this.codPostalLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.codPostalLbl.Name = "codPostalLbl";
            this.codPostalLbl.Size = new System.Drawing.Size(88, 21);
            this.codPostalLbl.TabIndex = 55;
            this.codPostalLbl.Text = "Cod postal";
            // 
            // prenumeLbl
            // 
            this.prenumeLbl.AutoSize = true;
            this.prenumeLbl.BackColor = System.Drawing.Color.Transparent;
            this.prenumeLbl.Font = new System.Drawing.Font("Miramonte", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenumeLbl.ForeColor = System.Drawing.Color.Black;
            this.prenumeLbl.Location = new System.Drawing.Point(60, 253);
            this.prenumeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prenumeLbl.Name = "prenumeLbl";
            this.prenumeLbl.Size = new System.Drawing.Size(75, 21);
            this.prenumeLbl.TabIndex = 53;
            this.prenumeLbl.Text = "Prenume";
            // 
            // telefonLbl
            // 
            this.telefonLbl.AutoSize = true;
            this.telefonLbl.BackColor = System.Drawing.Color.Transparent;
            this.telefonLbl.Font = new System.Drawing.Font("Miramonte", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefonLbl.ForeColor = System.Drawing.Color.Black;
            this.telefonLbl.Location = new System.Drawing.Point(60, 335);
            this.telefonLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.telefonLbl.Name = "telefonLbl";
            this.telefonLbl.Size = new System.Drawing.Size(62, 21);
            this.telefonLbl.TabIndex = 54;
            this.telefonLbl.Text = "Telefon";
            // 
            // numeLbl
            // 
            this.numeLbl.AutoSize = true;
            this.numeLbl.BackColor = System.Drawing.Color.Transparent;
            this.numeLbl.Font = new System.Drawing.Font("Miramonte", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeLbl.ForeColor = System.Drawing.Color.Black;
            this.numeLbl.Location = new System.Drawing.Point(60, 292);
            this.numeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numeLbl.Name = "numeLbl";
            this.numeLbl.Size = new System.Drawing.Size(55, 21);
            this.numeLbl.TabIndex = 52;
            this.numeLbl.Text = "Nume";
            // 
            // IesireBtn
            // 
            this.IesireBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IesireBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IesireBtn.FlatAppearance.BorderSize = 0;
            this.IesireBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IesireBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IesireBtn.Location = new System.Drawing.Point(274, 492);
            this.IesireBtn.Margin = new System.Windows.Forms.Padding(4);
            this.IesireBtn.Name = "IesireBtn";
            this.IesireBtn.Size = new System.Drawing.Size(100, 28);
            this.IesireBtn.TabIndex = 51;
            this.IesireBtn.Text = "Iesire";
            this.IesireBtn.UseVisualStyleBackColor = false;
            this.IesireBtn.Click += new System.EventHandler(this.IesireBtn_Click);
            // 
            // lstAfisare
            // 
            this.lstAfisare.FormattingEnabled = true;
            this.lstAfisare.ItemHeight = 16;
            this.lstAfisare.Location = new System.Drawing.Point(64, 82);
            this.lstAfisare.Margin = new System.Windows.Forms.Padding(4);
            this.lstAfisare.Name = "lstAfisare";
            this.lstAfisare.Size = new System.Drawing.Size(310, 148);
            this.lstAfisare.TabIndex = 50;
            this.lstAfisare.SelectedIndexChanged += new System.EventHandler(this.lstAfisare_SelectedIndexChanged);
            // 
            // SalvareBtn
            // 
            this.SalvareBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SalvareBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SalvareBtn.FlatAppearance.BorderSize = 0;
            this.SalvareBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SalvareBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SalvareBtn.Location = new System.Drawing.Point(64, 428);
            this.SalvareBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SalvareBtn.Name = "SalvareBtn";
            this.SalvareBtn.Size = new System.Drawing.Size(310, 28);
            this.SalvareBtn.TabIndex = 49;
            this.SalvareBtn.Text = "Salvare";
            this.SalvareBtn.UseVisualStyleBackColor = false;
            this.SalvareBtn.Click += new System.EventHandler(this.SalvareBtn_Click);
            // 
            // Modifica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(454, 545);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prenumeTxt);
            this.Controls.Add(this.codPostalLbl);
            this.Controls.Add(this.prenumeLbl);
            this.Controls.Add(this.telefonLbl);
            this.Controls.Add(this.numeLbl);
            this.Controls.Add(this.IesireBtn);
            this.Controls.Add(this.lstAfisare);
            this.Controls.Add(this.SalvareBtn);
            this.Name = "Modifica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modifica agenda";
            this.Load += new System.EventHandler(this.Modifica_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox prenumeTxt;
        private System.Windows.Forms.Label codPostalLbl;
        private System.Windows.Forms.Label prenumeLbl;
        private System.Windows.Forms.Label telefonLbl;
        private System.Windows.Forms.Label numeLbl;
        private System.Windows.Forms.Button IesireBtn;
        private System.Windows.Forms.ListBox lstAfisare;
        private System.Windows.Forms.Button SalvareBtn;
    }
}