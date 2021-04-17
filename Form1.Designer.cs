
namespace GradeCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.EtRes = new System.Windows.Forms.ListBox();
            this.CoRes = new System.Windows.Forms.ListBox();
            this.NoRes = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.RelevesDeNotes = new System.Windows.Forms.ListBox();
            this.CreerEtudiant = new System.Windows.Forms.Button();
            this.CreerCours = new System.Windows.Forms.Button();
            this.CreerNote = new System.Windows.Forms.Button();
            this.AfficherReleves = new System.Windows.Forms.Button();
            this.SaveToTxtFile = new System.Windows.Forms.Button();
            this.EtNumeroEtudiant = new System.Windows.Forms.TextBox();
            this.EtNom = new System.Windows.Forms.TextBox();
            this.EtPrenom = new System.Windows.Forms.TextBox();
            this.CoNumeroCours = new System.Windows.Forms.TextBox();
            this.CoCode = new System.Windows.Forms.TextBox();
            this.CoTitre = new System.Windows.Forms.TextBox();
            this.NoNumeroEtudiant = new System.Windows.Forms.TextBox();
            this.NoNumeroCours = new System.Windows.Forms.TextBox();
            this.NoNotes = new System.Windows.Forms.TextBox();
            this.NumeroEtudiant = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero Etudiant :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(389, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(729, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prenom :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Numero Du Cours";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(389, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Code";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(729, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Titre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Numero Etudiant";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(389, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Numero du Cours";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(729, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Note";
            // 
            // EtRes
            // 
            this.EtRes.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EtRes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EtRes.FormattingEnabled = true;
            this.EtRes.ItemHeight = 16;
            this.EtRes.Location = new System.Drawing.Point(53, 251);
            this.EtRes.Name = "EtRes";
            this.EtRes.Size = new System.Drawing.Size(329, 308);
            this.EtRes.TabIndex = 9;
            // 
            // CoRes
            // 
            this.CoRes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CoRes.FormattingEnabled = true;
            this.CoRes.ItemHeight = 16;
            this.CoRes.Location = new System.Drawing.Point(457, 251);
            this.CoRes.Name = "CoRes";
            this.CoRes.Size = new System.Drawing.Size(391, 308);
            this.CoRes.TabIndex = 10;
            // 
            // NoRes
            // 
            this.NoRes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NoRes.FormattingEnabled = true;
            this.NoRes.ItemHeight = 16;
            this.NoRes.Location = new System.Drawing.Point(930, 251);
            this.NoRes.Name = "NoRes";
            this.NoRes.Size = new System.Drawing.Size(573, 308);
            this.NoRes.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(64, 638);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "Numero Etudiant :";
            // 
            // RelevesDeNotes
            // 
            this.RelevesDeNotes.Font = new System.Drawing.Font("Yu Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RelevesDeNotes.ForeColor = System.Drawing.Color.Black;
            this.RelevesDeNotes.FormattingEnabled = true;
            this.RelevesDeNotes.ItemHeight = 17;
            this.RelevesDeNotes.Location = new System.Drawing.Point(852, 592);
            this.RelevesDeNotes.Name = "RelevesDeNotes";
            this.RelevesDeNotes.Size = new System.Drawing.Size(651, 327);
            this.RelevesDeNotes.TabIndex = 13;
            // 
            // CreerEtudiant
            // 
            this.CreerEtudiant.Location = new System.Drawing.Point(1035, 31);
            this.CreerEtudiant.Name = "CreerEtudiant";
            this.CreerEtudiant.Size = new System.Drawing.Size(96, 26);
            this.CreerEtudiant.TabIndex = 14;
            this.CreerEtudiant.Text = "CreerEtudiant";
            this.CreerEtudiant.UseVisualStyleBackColor = true;
            this.CreerEtudiant.Click += new System.EventHandler(this.CreerEtudiant_Click);
            // 
            // CreerCours
            // 
            this.CreerCours.Location = new System.Drawing.Point(1035, 81);
            this.CreerCours.Name = "CreerCours";
            this.CreerCours.Size = new System.Drawing.Size(96, 27);
            this.CreerCours.TabIndex = 15;
            this.CreerCours.Text = "CreerCours";
            this.CreerCours.UseVisualStyleBackColor = true;
            this.CreerCours.Click += new System.EventHandler(this.CreerCours_Click);
            // 
            // CreerNote
            // 
            this.CreerNote.Location = new System.Drawing.Point(1035, 140);
            this.CreerNote.Name = "CreerNote";
            this.CreerNote.Size = new System.Drawing.Size(96, 26);
            this.CreerNote.TabIndex = 16;
            this.CreerNote.Text = "CreerNote";
            this.CreerNote.UseVisualStyleBackColor = true;
            this.CreerNote.Click += new System.EventHandler(this.CreerNote_Click);
            // 
            // AfficherReleves
            // 
            this.AfficherReleves.Location = new System.Drawing.Point(495, 638);
            this.AfficherReleves.Name = "AfficherReleves";
            this.AfficherReleves.Size = new System.Drawing.Size(124, 31);
            this.AfficherReleves.TabIndex = 17;
            this.AfficherReleves.Text = "AfficherReleves";
            this.AfficherReleves.UseVisualStyleBackColor = true;
            this.AfficherReleves.Click += new System.EventHandler(this.AfficherReleves_Click);
            // 
            // SaveToTxtFile
            // 
            this.SaveToTxtFile.Location = new System.Drawing.Point(495, 717);
            this.SaveToTxtFile.Name = "SaveToTxtFile";
            this.SaveToTxtFile.Size = new System.Drawing.Size(124, 32);
            this.SaveToTxtFile.TabIndex = 18;
            this.SaveToTxtFile.Text = "SaveToTxtFile";
            this.SaveToTxtFile.UseVisualStyleBackColor = true;
            this.SaveToTxtFile.Click += new System.EventHandler(this.SaveToTxtFile_Click);
            // 
            // EtNumeroEtudiant
            // 
            this.EtNumeroEtudiant.Location = new System.Drawing.Point(181, 25);
            this.EtNumeroEtudiant.Name = "EtNumeroEtudiant";
            this.EtNumeroEtudiant.Size = new System.Drawing.Size(100, 23);
            this.EtNumeroEtudiant.TabIndex = 19;
            // 
            // EtNom
            // 
            this.EtNom.Location = new System.Drawing.Point(519, 30);
            this.EtNom.Name = "EtNom";
            this.EtNom.Size = new System.Drawing.Size(100, 23);
            this.EtNom.TabIndex = 20;
            // 
            // EtPrenom
            // 
            this.EtPrenom.Location = new System.Drawing.Point(831, 30);
            this.EtPrenom.Name = "EtPrenom";
            this.EtPrenom.Size = new System.Drawing.Size(100, 23);
            this.EtPrenom.TabIndex = 21;
            // 
            // CoNumeroCours
            // 
            this.CoNumeroCours.Location = new System.Drawing.Point(181, 81);
            this.CoNumeroCours.Name = "CoNumeroCours";
            this.CoNumeroCours.Size = new System.Drawing.Size(100, 23);
            this.CoNumeroCours.TabIndex = 22;
            // 
            // CoCode
            // 
            this.CoCode.Location = new System.Drawing.Point(519, 85);
            this.CoCode.Name = "CoCode";
            this.CoCode.Size = new System.Drawing.Size(100, 23);
            this.CoCode.TabIndex = 23;
            // 
            // CoTitre
            // 
            this.CoTitre.Location = new System.Drawing.Point(831, 83);
            this.CoTitre.Name = "CoTitre";
            this.CoTitre.Size = new System.Drawing.Size(100, 23);
            this.CoTitre.TabIndex = 24;
            // 
            // NoNumeroEtudiant
            // 
            this.NoNumeroEtudiant.Location = new System.Drawing.Point(181, 143);
            this.NoNumeroEtudiant.Name = "NoNumeroEtudiant";
            this.NoNumeroEtudiant.Size = new System.Drawing.Size(100, 23);
            this.NoNumeroEtudiant.TabIndex = 25;
            // 
            // NoNumeroCours
            // 
            this.NoNumeroCours.Location = new System.Drawing.Point(519, 143);
            this.NoNumeroCours.Name = "NoNumeroCours";
            this.NoNumeroCours.Size = new System.Drawing.Size(100, 23);
            this.NoNumeroCours.TabIndex = 26;
            // 
            // NoNotes
            // 
            this.NoNotes.Location = new System.Drawing.Point(831, 140);
            this.NoNotes.Name = "NoNotes";
            this.NoNotes.Size = new System.Drawing.Size(100, 23);
            this.NoNotes.TabIndex = 27;
            // 
            // NumeroEtudiant
            // 
            this.NumeroEtudiant.Location = new System.Drawing.Point(196, 630);
            this.NumeroEtudiant.Name = "NumeroEtudiant";
            this.NumeroEtudiant.Size = new System.Drawing.Size(100, 23);
            this.NumeroEtudiant.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1567, 943);
            this.Controls.Add(this.NumeroEtudiant);
            this.Controls.Add(this.NoNotes);
            this.Controls.Add(this.NoNumeroCours);
            this.Controls.Add(this.NoNumeroEtudiant);
            this.Controls.Add(this.CoTitre);
            this.Controls.Add(this.CoCode);
            this.Controls.Add(this.CoNumeroCours);
            this.Controls.Add(this.EtPrenom);
            this.Controls.Add(this.EtNom);
            this.Controls.Add(this.EtNumeroEtudiant);
            this.Controls.Add(this.SaveToTxtFile);
            this.Controls.Add(this.AfficherReleves);
            this.Controls.Add(this.CreerNote);
            this.Controls.Add(this.CreerCours);
            this.Controls.Add(this.CreerEtudiant);
            this.Controls.Add(this.RelevesDeNotes);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.NoRes);
            this.Controls.Add(this.CoRes);
            this.Controls.Add(this.EtRes);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Crimson;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox EtRes;
        private System.Windows.Forms.ListBox CoRes;
        private System.Windows.Forms.ListBox NoRes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox RelevesDeNotes;
        private System.Windows.Forms.Button CreerEtudiant;
        private System.Windows.Forms.Button CreerCours;
        private System.Windows.Forms.Button CreerNote;
        private System.Windows.Forms.Button AfficherReleves;
        private System.Windows.Forms.Button SaveToTxtFile;
        private System.Windows.Forms.TextBox EtNumeroEtudiant;
        private System.Windows.Forms.TextBox EtNom;
        private System.Windows.Forms.TextBox EtPrenom;
        private System.Windows.Forms.TextBox CoNumeroCours;
        private System.Windows.Forms.TextBox CoCode;
        private System.Windows.Forms.TextBox CoTitre;
        private System.Windows.Forms.TextBox NoNumeroEtudiant;
        private System.Windows.Forms.TextBox NoNumeroCours;
        private System.Windows.Forms.TextBox NoNotes;
        private System.Windows.Forms.TextBox NumeroEtudiant;
    }
}

