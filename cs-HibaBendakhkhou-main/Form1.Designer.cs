
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
            this.txtAffichage = new System.Windows.Forms.TextBox();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn55 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btnMoins = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.decim = new System.Windows.Forms.Button();
            this.plusMoins = new System.Windows.Forms.Button();
            this.btlC = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnEql = new System.Windows.Forms.Button();
            this.btnBackSpace = new System.Windows.Forms.Button();
            this.history = new System.Windows.Forms.RichTextBox();
            this.Standars = new System.Windows.Forms.Label();
            this.trash = new System.Windows.Forms.Button();
            this.memory = new System.Windows.Forms.RichTextBox();
            this.shortHistory = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.trash2 = new System.Windows.Forms.Label();
            this.MC = new System.Windows.Forms.Label();
            this.MR = new System.Windows.Forms.Label();
            this.Mplus = new System.Windows.Forms.Label();
            this.Mmoins = new System.Windows.Forms.Label();
            this.MS = new System.Windows.Forms.Label();
            this.showMemory = new System.Windows.Forms.Label();
            this.trash3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAffichage
            // 
            this.txtAffichage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAffichage.Font = new System.Drawing.Font("Segoe UI Symbol", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAffichage.Location = new System.Drawing.Point(3, 129);
            this.txtAffichage.Margin = new System.Windows.Forms.Padding(2);
            this.txtAffichage.Multiline = true;
            this.txtAffichage.Name = "txtAffichage";
            this.txtAffichage.ReadOnly = true;
            this.txtAffichage.Size = new System.Drawing.Size(236, 57);
            this.txtAffichage.TabIndex = 0;
            this.txtAffichage.Text = "0";
            this.txtAffichage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAffichage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAffichage_KeyPress);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Segoe UI Emoji", 12.75F);
            this.btn7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btn7.Location = new System.Drawing.Point(3, 272);
            this.btn7.Margin = new System.Windows.Forms.Padding(1);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(56, 40);
            this.btn7.TabIndex = 2;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.num_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.Font = new System.Drawing.Font("Segoe UI Emoji", 12.75F);
            this.btnPlus.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnPlus.Location = new System.Drawing.Point(183, 360);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(56, 40);
            this.btnPlus.TabIndex = 4;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.Operations);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Segoe UI Emoji", 12.75F);
            this.btn4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btn4.Location = new System.Drawing.Point(3, 316);
            this.btn4.Margin = new System.Windows.Forms.Padding(2);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(56, 40);
            this.btn4.TabIndex = 6;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.num_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Segoe UI Emoji", 12.75F);
            this.btn1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btn1.Location = new System.Drawing.Point(3, 360);
            this.btn1.Margin = new System.Windows.Forms.Padding(2);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(56, 40);
            this.btn1.TabIndex = 7;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.num_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.Control;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Segoe UI Emoji", 12.75F);
            this.btn0.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn0.Location = new System.Drawing.Point(63, 404);
            this.btn0.Margin = new System.Windows.Forms.Padding(2);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(56, 40);
            this.btn0.TabIndex = 8;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.num_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Segoe UI Emoji", 12.75F);
            this.btn2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btn2.Location = new System.Drawing.Point(63, 360);
            this.btn2.Margin = new System.Windows.Forms.Padding(2);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(56, 40);
            this.btn2.TabIndex = 9;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.num_Click);
            // 
            // btn55
            // 
            this.btn55.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn55.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn55.Font = new System.Drawing.Font("Segoe UI Emoji", 12.75F);
            this.btn55.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btn55.Location = new System.Drawing.Point(63, 316);
            this.btn55.Margin = new System.Windows.Forms.Padding(2);
            this.btn55.Name = "btn55";
            this.btn55.Size = new System.Drawing.Size(56, 40);
            this.btn55.TabIndex = 10;
            this.btn55.Text = "5";
            this.btn55.UseVisualStyleBackColor = false;
            this.btn55.Click += new System.EventHandler(this.num_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Segoe UI Emoji", 12.75F);
            this.btn9.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btn9.Location = new System.Drawing.Point(123, 272);
            this.btn9.Margin = new System.Windows.Forms.Padding(2);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(56, 40);
            this.btn9.TabIndex = 11;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.num_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Segoe UI Emoji", 12.75F);
            this.btn3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btn3.Location = new System.Drawing.Point(123, 360);
            this.btn3.Margin = new System.Windows.Forms.Padding(2);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(56, 40);
            this.btn3.TabIndex = 12;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.num_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Segoe UI Emoji", 12.75F);
            this.btn6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btn6.Location = new System.Drawing.Point(123, 316);
            this.btn6.Margin = new System.Windows.Forms.Padding(2);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(56, 40);
            this.btn6.TabIndex = 13;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.num_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Segoe UI Emoji", 12.75F);
            this.btn8.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btn8.Location = new System.Drawing.Point(63, 272);
            this.btn8.Margin = new System.Windows.Forms.Padding(2);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(56, 40);
            this.btn8.TabIndex = 14;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.num_Click);
            // 
            // btnMoins
            // 
            this.btnMoins.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMoins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoins.Font = new System.Drawing.Font("Segoe UI Emoji", 12.75F);
            this.btnMoins.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnMoins.Location = new System.Drawing.Point(183, 316);
            this.btnMoins.Margin = new System.Windows.Forms.Padding(2);
            this.btnMoins.Name = "btnMoins";
            this.btnMoins.Size = new System.Drawing.Size(56, 40);
            this.btnMoins.TabIndex = 15;
            this.btnMoins.Text = "-";
            this.btnMoins.UseVisualStyleBackColor = false;
            this.btnMoins.Click += new System.EventHandler(this.Operations);
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.Font = new System.Drawing.Font("Segoe UI Emoji", 12.75F);
            this.btnX.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnX.Location = new System.Drawing.Point(183, 272);
            this.btnX.Margin = new System.Windows.Forms.Padding(2);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(56, 40);
            this.btnX.TabIndex = 16;
            this.btnX.Text = "x";
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.Operations);
            // 
            // btnDiv
            // 
            this.btnDiv.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiv.Font = new System.Drawing.Font("Segoe UI Emoji", 12.75F);
            this.btnDiv.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnDiv.Location = new System.Drawing.Point(183, 228);
            this.btnDiv.Margin = new System.Windows.Forms.Padding(2);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(56, 40);
            this.btnDiv.TabIndex = 17;
            this.btnDiv.Text = "÷";
            this.btnDiv.UseVisualStyleBackColor = false;
            this.btnDiv.Click += new System.EventHandler(this.Operations);
            // 
            // decim
            // 
            this.decim.BackColor = System.Drawing.SystemColors.Control;
            this.decim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decim.Font = new System.Drawing.Font("Segoe UI Emoji", 12.75F);
            this.decim.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.decim.Location = new System.Drawing.Point(123, 404);
            this.decim.Margin = new System.Windows.Forms.Padding(2);
            this.decim.Name = "decim";
            this.decim.Size = new System.Drawing.Size(56, 40);
            this.decim.TabIndex = 19;
            this.decim.Text = ",";
            this.decim.UseVisualStyleBackColor = false;
            this.decim.Click += new System.EventHandler(this.num_Click);
            // 
            // plusMoins
            // 
            this.plusMoins.BackColor = System.Drawing.SystemColors.Control;
            this.plusMoins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusMoins.Font = new System.Drawing.Font("Segoe UI Emoji", 12.75F);
            this.plusMoins.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.plusMoins.Location = new System.Drawing.Point(3, 404);
            this.plusMoins.Margin = new System.Windows.Forms.Padding(2);
            this.plusMoins.Name = "plusMoins";
            this.plusMoins.Size = new System.Drawing.Size(56, 40);
            this.plusMoins.TabIndex = 20;
            this.plusMoins.Text = "±";
            this.plusMoins.UseVisualStyleBackColor = false;
            // 
            // btlC
            // 
            this.btlC.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btlC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btlC.Font = new System.Drawing.Font("Segoe UI Emoji", 12.75F);
            this.btlC.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btlC.Location = new System.Drawing.Point(63, 228);
            this.btlC.Margin = new System.Windows.Forms.Padding(2);
            this.btlC.Name = "btlC";
            this.btlC.Size = new System.Drawing.Size(56, 40);
            this.btlC.TabIndex = 21;
            this.btlC.Text = "C";
            this.btlC.UseVisualStyleBackColor = false;
            this.btlC.Click += new System.EventHandler(this.btlC_Click);
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCE.Font = new System.Drawing.Font("Segoe UI Emoji", 12.75F);
            this.btnCE.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnCE.Location = new System.Drawing.Point(3, 229);
            this.btnCE.Margin = new System.Windows.Forms.Padding(2);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(56, 40);
            this.btnCE.TabIndex = 22;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnEql
            // 
            this.btnEql.BackColor = System.Drawing.SystemColors.Control;
            this.btnEql.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEql.Font = new System.Drawing.Font("Segoe UI Emoji", 12.75F);
            this.btnEql.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEql.Location = new System.Drawing.Point(183, 404);
            this.btnEql.Margin = new System.Windows.Forms.Padding(2);
            this.btnEql.Name = "btnEql";
            this.btnEql.Size = new System.Drawing.Size(56, 40);
            this.btnEql.TabIndex = 23;
            this.btnEql.Text = "=";
            this.btnEql.UseVisualStyleBackColor = false;
            this.btnEql.Click += new System.EventHandler(this.btnEql_Click);
            // 
            // btnBackSpace
            // 
            this.btnBackSpace.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBackSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackSpace.Font = new System.Drawing.Font("Segoe UI Emoji", 12.75F);
            this.btnBackSpace.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnBackSpace.Location = new System.Drawing.Point(123, 228);
            this.btnBackSpace.Margin = new System.Windows.Forms.Padding(2);
            this.btnBackSpace.Name = "btnBackSpace";
            this.btnBackSpace.Size = new System.Drawing.Size(56, 40);
            this.btnBackSpace.TabIndex = 24;
            this.btnBackSpace.Text = "⌫";
            this.btnBackSpace.UseVisualStyleBackColor = false;
            this.btnBackSpace.Click += new System.EventHandler(this.btnBackSpace_Click);
            // 
            // history
            // 
            this.history.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.history.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.history.Location = new System.Drawing.Point(320, 81);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(156, 319);
            this.history.TabIndex = 25;
            this.history.Text = "";
            // 
            // Standars
            // 
            this.Standars.AutoSize = true;
            this.Standars.Location = new System.Drawing.Point(144, 62);
            this.Standars.Name = "Standars";
            this.Standars.Size = new System.Drawing.Size(0, 13);
            this.Standars.TabIndex = 26;
            // 
            // trash
            // 
            this.trash.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.trash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trash.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.trash.ForeColor = System.Drawing.SystemColors.ControlText;
            this.trash.Location = new System.Drawing.Point(422, 404);
            this.trash.Name = "trash";
            this.trash.Size = new System.Drawing.Size(54, 39);
            this.trash.TabIndex = 29;
            this.trash.Text = " 🗑️";
            this.trash.UseMnemonic = false;
            this.trash.UseVisualStyleBackColor = false;
            this.trash.Click += new System.EventHandler(this.trash_Click);
            // 
            // memory
            // 
            this.memory.BackColor = System.Drawing.SystemColors.Menu;
            this.memory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.memory.Font = new System.Drawing.Font("Segoe UI Emoji", 12.75F);
            this.memory.Location = new System.Drawing.Point(3, 220);
            this.memory.Name = "memory";
            this.memory.Size = new System.Drawing.Size(236, 224);
            this.memory.TabIndex = 31;
            this.memory.Text = "";
            // 
            // shortHistory
            // 
            this.shortHistory.AutoSize = true;
            this.shortHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.shortHistory.Location = new System.Drawing.Point(177, 9);
            this.shortHistory.Name = "shortHistory";
            this.shortHistory.Size = new System.Drawing.Size(33, 31);
            this.shortHistory.TabIndex = 32;
            this.shortHistory.Text = "↻";
            this.shortHistory.Click += new System.EventHandler(this.shortHistory_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Segoe UI Emoji", 12.75F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(3, 48);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(236, 396);
            this.listBox1.TabIndex = 33;
            // 
            // trash2
            // 
            this.trash2.AutoSize = true;
            this.trash2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.trash2.Location = new System.Drawing.Point(175, 404);
            this.trash2.Name = "trash2";
            this.trash2.Size = new System.Drawing.Size(40, 25);
            this.trash2.TabIndex = 34;
            this.trash2.Text = " 🗑️";
            this.trash2.Click += new System.EventHandler(this.trash2_Click_1);
            // 
            // MC
            // 
            this.MC.AutoSize = true;
            this.MC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.MC.Location = new System.Drawing.Point(12, 200);
            this.MC.Name = "MC";
            this.MC.Size = new System.Drawing.Size(28, 17);
            this.MC.TabIndex = 35;
            this.MC.Text = "MC";
            this.MC.Click += new System.EventHandler(this.MC_Click);
            // 
            // MR
            // 
            this.MR.AutoSize = true;
            this.MR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.MR.Location = new System.Drawing.Point(60, 200);
            this.MR.Name = "MR";
            this.MR.Size = new System.Drawing.Size(29, 17);
            this.MR.TabIndex = 36;
            this.MR.Text = "MR";
            this.MR.Click += new System.EventHandler(this.MR_Click);
            // 
            // Mplus
            // 
            this.Mplus.AutoSize = true;
            this.Mplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Mplus.Location = new System.Drawing.Point(102, 200);
            this.Mplus.Name = "Mplus";
            this.Mplus.Size = new System.Drawing.Size(27, 17);
            this.Mplus.TabIndex = 37;
            this.Mplus.Text = "M+";
            this.Mplus.Click += new System.EventHandler(this.Mplus_Click_1);
            // 
            // Mmoins
            // 
            this.Mmoins.AutoSize = true;
            this.Mmoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Mmoins.Location = new System.Drawing.Point(144, 200);
            this.Mmoins.Name = "Mmoins";
            this.Mmoins.Size = new System.Drawing.Size(24, 17);
            this.Mmoins.TabIndex = 38;
            this.Mmoins.Text = "M-";
            this.Mmoins.Click += new System.EventHandler(this.Mmoins_Click);
            // 
            // MS
            // 
            this.MS.AutoSize = true;
            this.MS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.MS.Location = new System.Drawing.Point(177, 200);
            this.MS.Name = "MS";
            this.MS.Size = new System.Drawing.Size(28, 17);
            this.MS.TabIndex = 39;
            this.MS.Text = "MS";
            this.MS.Click += new System.EventHandler(this.MS_Click_1);
            // 
            // showMemory
            // 
            this.showMemory.AutoSize = true;
            this.showMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.showMemory.Location = new System.Drawing.Point(213, 200);
            this.showMemory.Name = "showMemory";
            this.showMemory.Size = new System.Drawing.Size(26, 17);
            this.showMemory.TabIndex = 40;
            this.showMemory.Text = "Mv";
            this.showMemory.Click += new System.EventHandler(this.showMemory_Click);
            // 
            // trash3
            // 
            this.trash3.AutoSize = true;
            this.trash3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.trash3.Location = new System.Drawing.Point(175, 404);
            this.trash3.Name = "trash3";
            this.trash3.Size = new System.Drawing.Size(40, 25);
            this.trash3.TabIndex = 41;
            this.trash3.Text = " 🗑️";
            this.trash3.Click += new System.EventHandler(this.trash3_Click);
            // 
            // frmCalculette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(499, 448);
            this.Controls.Add(this.trash3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.trash2);
            this.Controls.Add(this.memory);
            this.Controls.Add(this.showMemory);
            this.Controls.Add(this.MS);
            this.Controls.Add(this.Mmoins);
            this.Controls.Add(this.Mplus);
            this.Controls.Add(this.MR);
            this.Controls.Add(this.MC);
            this.Controls.Add(this.shortHistory);
            this.Controls.Add(this.trash);
            this.Controls.Add(this.Standars);
            this.Controls.Add(this.history);
            this.Controls.Add(this.btnBackSpace);
            this.Controls.Add(this.btnEql);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btlC);
            this.Controls.Add(this.plusMoins);
            this.Controls.Add(this.decim);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnMoins);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn55);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.txtAffichage);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCalculette";
            this.Text = "Ma calculette";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.num_Click);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmCalculette_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAffichage;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn55;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btnMoins;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button decim;
        private System.Windows.Forms.Button plusMoins;
        private System.Windows.Forms.Button btlC;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnEql;
        private System.Windows.Forms.Button btnBackSpace;
        private System.Windows.Forms.RichTextBox history;
        private System.Windows.Forms.Label Standars;
        private System.Windows.Forms.Button trash;
        private System.Windows.Forms.RichTextBox memory;
        private System.Windows.Forms.Label shortHistory;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label trash2;
        private System.Windows.Forms.Label MC;
        private System.Windows.Forms.Label MR;
        private System.Windows.Forms.Label Mplus;
        private System.Windows.Forms.Label Mmoins;
        private System.Windows.Forms.Label MS;
        private System.Windows.Forms.Label showMemory;
        private System.Windows.Forms.Label trash3;
    }
}

