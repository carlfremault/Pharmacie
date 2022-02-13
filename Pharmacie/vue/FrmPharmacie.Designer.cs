
namespace Pharmacie.vue
{
    partial class FrmPharmacie
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSuppr = new System.Windows.Forms.Button();
            this.dgvMedicaments = new System.Windows.Forms.DataGridView();
            this.btnAjout = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboRecommandations = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtForme = new System.Windows.Forms.TextBox();
            this.txtLibelleATC3 = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicaments)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSuppr);
            this.groupBox1.Controls.Add(this.dgvMedicaments);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1151, 351);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "médicaments";
            // 
            // btnSuppr
            // 
            this.btnSuppr.Location = new System.Drawing.Point(6, 322);
            this.btnSuppr.Name = "btnSuppr";
            this.btnSuppr.Size = new System.Drawing.Size(113, 23);
            this.btnSuppr.TabIndex = 2;
            this.btnSuppr.Text = "supprimer";
            this.btnSuppr.UseVisualStyleBackColor = true;
            this.btnSuppr.Click += new System.EventHandler(this.BtnSuppr_Click);
            // 
            // dgvMedicaments
            // 
            this.dgvMedicaments.AllowUserToAddRows = false;
            this.dgvMedicaments.AllowUserToDeleteRows = false;
            this.dgvMedicaments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicaments.Location = new System.Drawing.Point(6, 22);
            this.dgvMedicaments.MultiSelect = false;
            this.dgvMedicaments.Name = "dgvMedicaments";
            this.dgvMedicaments.ReadOnly = true;
            this.dgvMedicaments.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvMedicaments.RowTemplate.Height = 25;
            this.dgvMedicaments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicaments.Size = new System.Drawing.Size(1139, 294);
            this.dgvMedicaments.TabIndex = 0;
            // 
            // btnAjout
            // 
            this.btnAjout.Location = new System.Drawing.Point(6, 135);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(113, 23);
            this.btnAjout.TabIndex = 1;
            this.btnAjout.Text = "ajouter";
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.BtnAjout_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cboRecommandations);
            this.groupBox2.Controls.Add(this.btnAjout);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtForme);
            this.groupBox2.Controls.Add(this.txtLibelleATC3);
            this.groupBox2.Controls.Add(this.txtNom);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 369);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1145, 164);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "nouveau médicament";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(698, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(213, 15);
            this.label11.TabIndex = 15;
            this.label11.Text = "E : écrasement possible des comprimés";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(698, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(185, 15);
            this.label10.TabIndex = 14;
            this.label10.Text = "NE : ne pas écraser les comprimés";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(698, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(183, 15);
            this.label9.TabIndex = 13;
            this.label9.Text = "O : ouverture possible des gélules";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(698, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "NO : ne pas ouvrir les gélules";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(698, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "NC : ne pas ouvrir les capsules";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(698, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "D : dissolution possible dans l\'eau";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(698, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "recommandations :";
            // 
            // cboRecommandations
            // 
            this.cboRecommandations.FormattingEnabled = true;
            this.cboRecommandations.Location = new System.Drawing.Point(119, 103);
            this.cboRecommandations.Name = "cboRecommandations";
            this.cboRecommandations.Size = new System.Drawing.Size(290, 23);
            this.cboRecommandations.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "recommandation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "forme galénique";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "libellé ATC3";
            // 
            // txtForme
            // 
            this.txtForme.Location = new System.Drawing.Point(119, 74);
            this.txtForme.Name = "txtForme";
            this.txtForme.Size = new System.Drawing.Size(514, 23);
            this.txtForme.TabIndex = 3;
            // 
            // txtLibelleATC3
            // 
            this.txtLibelleATC3.Location = new System.Drawing.Point(119, 45);
            this.txtLibelleATC3.Name = "txtLibelleATC3";
            this.txtLibelleATC3.Size = new System.Drawing.Size(514, 23);
            this.txtLibelleATC3.TabIndex = 2;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(119, 16);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(290, 23);
            this.txtNom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "nom";
            // 
            // FrmPharmacie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 545);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmPharmacie";
            this.Text = "Pharmacie";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicaments)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSuppr;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.DataGridView dgvMedicaments;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtForme;
        private System.Windows.Forms.TextBox txtLibelleATC3;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboRecommandations;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

