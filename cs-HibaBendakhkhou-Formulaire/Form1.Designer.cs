
namespace TpCalculette
{
    partial class frmCalculette
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculette));
            this.Nom = new System.Windows.Forms.Label();
            this.Prenom = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.Créer = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            this.Supprimer = new System.Windows.Forms.Button();
            this.Annuler = new System.Windows.Forms.Button();
            this.Valider = new System.Windows.Forms.Button();
            this.labelError0 = new System.Windows.Forms.Label();
            this.labelError2 = new System.Windows.Forms.Label();
            this.labelError1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ageFiled = new System.Windows.Forms.NumericUpDown();
            this.closeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ageFiled)).BeginInit();
            this.SuspendLayout();
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.Nom.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.Nom.ForeColor = System.Drawing.Color.RosyBrown;
            this.Nom.Location = new System.Drawing.Point(34, 124);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(45, 21);
            this.Nom.TabIndex = 0;
            this.Nom.Text = "Nom";
            // 
            // Prenom
            // 
            this.Prenom.AutoSize = true;
            this.Prenom.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.Prenom.ForeColor = System.Drawing.Color.RosyBrown;
            this.Prenom.Location = new System.Drawing.Point(17, 169);
            this.Prenom.Name = "Prenom";
            this.Prenom.Size = new System.Drawing.Size(65, 21);
            this.Prenom.TabIndex = 1;
            this.Prenom.Text = "Prenom";
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.age.ForeColor = System.Drawing.Color.RosyBrown;
            this.age.Location = new System.Drawing.Point(34, 212);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(37, 21);
            this.age.TabIndex = 2;
            this.age.Text = "Age";
            // 
            // txtNom
            // 
            this.txtNom.BackColor = System.Drawing.SystemColors.Window;
            this.txtNom.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.txtNom.Location = new System.Drawing.Point(88, 116);
            this.txtNom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNom.Multiline = true;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(219, 42);
            this.txtNom.TabIndex = 3;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.txtPrenom.Location = new System.Drawing.Point(88, 166);
            this.txtPrenom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrenom.Multiline = true;
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(219, 36);
            this.txtPrenom.TabIndex = 4;
            // 
            // Créer
            // 
            this.Créer.BackColor = System.Drawing.Color.RosyBrown;
            this.Créer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Créer.Font = new System.Drawing.Font("Segoe UI Emoji", 8.75F, System.Drawing.FontStyle.Bold);
            this.Créer.ForeColor = System.Drawing.Color.Black;
            this.Créer.Location = new System.Drawing.Point(5, 299);
            this.Créer.Margin = new System.Windows.Forms.Padding(0);
            this.Créer.Name = "Créer";
            this.Créer.Size = new System.Drawing.Size(74, 38);
            this.Créer.TabIndex = 7;
            this.Créer.Text = "Créer";
            this.Créer.UseVisualStyleBackColor = false;
            this.Créer.Click += new System.EventHandler(this.Créer_Click);
            // 
            // Modifier
            // 
            this.Modifier.BackColor = System.Drawing.Color.RosyBrown;
            this.Modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Modifier.Font = new System.Drawing.Font("Segoe UI Emoji", 8.75F, System.Drawing.FontStyle.Bold);
            this.Modifier.ForeColor = System.Drawing.Color.Black;
            this.Modifier.Location = new System.Drawing.Point(85, 299);
            this.Modifier.Margin = new System.Windows.Forms.Padding(0);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(75, 38);
            this.Modifier.TabIndex = 8;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = false;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // Supprimer
            // 
            this.Supprimer.BackColor = System.Drawing.Color.RosyBrown;
            this.Supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Supprimer.Font = new System.Drawing.Font("Segoe UI Emoji", 8.75F, System.Drawing.FontStyle.Bold);
            this.Supprimer.ForeColor = System.Drawing.Color.Black;
            this.Supprimer.Location = new System.Drawing.Point(170, 299);
            this.Supprimer.Margin = new System.Windows.Forms.Padding(0);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(92, 38);
            this.Supprimer.TabIndex = 9;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseVisualStyleBackColor = false;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // Annuler
            // 
            this.Annuler.BackColor = System.Drawing.Color.RosyBrown;
            this.Annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Annuler.Font = new System.Drawing.Font("Segoe UI Emoji", 8.75F, System.Drawing.FontStyle.Bold);
            this.Annuler.ForeColor = System.Drawing.Color.Black;
            this.Annuler.Location = new System.Drawing.Point(271, 299);
            this.Annuler.Margin = new System.Windows.Forms.Padding(0);
            this.Annuler.Name = "Annuler";
            this.Annuler.Size = new System.Drawing.Size(68, 38);
            this.Annuler.TabIndex = 10;
            this.Annuler.Text = "Annuler";
            this.Annuler.UseVisualStyleBackColor = false;
            this.Annuler.Click += new System.EventHandler(this.Annuler_Click);
            // 
            // Valider
            // 
            this.Valider.BackColor = System.Drawing.Color.RosyBrown;
            this.Valider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Valider.Font = new System.Drawing.Font("Segoe UI Emoji", 8.75F, System.Drawing.FontStyle.Bold);
            this.Valider.ForeColor = System.Drawing.Color.Black;
            this.Valider.Location = new System.Drawing.Point(348, 299);
            this.Valider.Margin = new System.Windows.Forms.Padding(0);
            this.Valider.Name = "Valider";
            this.Valider.Size = new System.Drawing.Size(66, 38);
            this.Valider.TabIndex = 11;
            this.Valider.Text = "Valider";
            this.Valider.UseVisualStyleBackColor = false;
            this.Valider.Click += new System.EventHandler(this.Valider_Click);
            // 
            // labelError0
            // 
            this.labelError0.AutoSize = true;
            this.labelError0.Font = new System.Drawing.Font("Segoe UI Emoji", 10F);
            this.labelError0.ForeColor = System.Drawing.Color.Red;
            this.labelError0.Location = new System.Drawing.Point(313, 124);
            this.labelError0.Name = "labelError0";
            this.labelError0.Size = new System.Drawing.Size(47, 19);
            this.labelError0.TabIndex = 13;
            this.labelError0.Text = "error1";
            // 
            // labelError2
            // 
            this.labelError2.AutoSize = true;
            this.labelError2.Font = new System.Drawing.Font("Segoe UI Emoji", 10F);
            this.labelError2.ForeColor = System.Drawing.Color.Red;
            this.labelError2.Location = new System.Drawing.Point(313, 214);
            this.labelError2.Name = "labelError2";
            this.labelError2.Size = new System.Drawing.Size(47, 19);
            this.labelError2.TabIndex = 14;
            this.labelError2.Text = "error3";
            // 
            // labelError1
            // 
            this.labelError1.AutoSize = true;
            this.labelError1.Font = new System.Drawing.Font("Segoe UI Emoji", 10F);
            this.labelError1.ForeColor = System.Drawing.Color.Red;
            this.labelError1.Location = new System.Drawing.Point(313, 169);
            this.labelError1.Name = "labelError1";
            this.labelError1.Size = new System.Drawing.Size(47, 19);
            this.labelError1.TabIndex = 15;
            this.labelError1.Text = "error2";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.comboBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(88, 68);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(218, 29);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ageFiled
            // 
            this.ageFiled.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ageFiled.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.ageFiled.Location = new System.Drawing.Point(88, 214);
            this.ageFiled.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ageFiled.Name = "ageFiled";
            this.ageFiled.Size = new System.Drawing.Size(221, 25);
            this.ageFiled.TabIndex = 17;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.White;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.closeBtn.Location = new System.Drawing.Point(438, 30);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(28, 31);
            this.closeBtn.TabIndex = 18;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // frmCalculette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 418);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.ageFiled);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelError1);
            this.Controls.Add(this.labelError2);
            this.Controls.Add(this.labelError0);
            this.Controls.Add(this.Valider);
            this.Controls.Add(this.Annuler);
            this.Controls.Add(this.Supprimer);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.Créer);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.age);
            this.Controls.Add(this.Prenom);
            this.Controls.Add(this.Nom);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmCalculette";
            this.Text = "Formulaire";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ageFiled)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nom;
        private System.Windows.Forms.Label Prenom;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Button Créer;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.Button Supprimer;
        private System.Windows.Forms.Button Annuler;
        private System.Windows.Forms.Button Valider;
        private System.Windows.Forms.Label labelError0;
        private System.Windows.Forms.Label labelError1;
        private System.Windows.Forms.Label labelError2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown ageFiled;
        private System.Windows.Forms.Button closeBtn;
    }
}

