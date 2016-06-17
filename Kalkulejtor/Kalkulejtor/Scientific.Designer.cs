namespace Kalkulejtor
{
    partial class Scientific
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
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.tbResults = new System.Windows.Forms.TextBox();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnMnozhenje = new System.Windows.Forms.Button();
            this.btnDelenje = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnEdnakvo = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnTochka = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button29 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.lbPateka = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb1
            // 
            this.cb1.FormattingEnabled = true;
            this.cb1.Items.AddRange(new object[] {
            "Scientific",
            "Normal"});
            this.cb1.Location = new System.Drawing.Point(12, 25);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(121, 21);
            this.cb1.TabIndex = 21;
            this.cb1.Text = "Scientific";
            this.cb1.SelectedIndexChanged += new System.EventHandler(this.cb1_SelectedIndexChanged);
            // 
            // tbResults
            // 
            this.tbResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbResults.Location = new System.Drawing.Point(12, 52);
            this.tbResults.Multiline = true;
            this.tbResults.Name = "tbResults";
            this.tbResults.ReadOnly = true;
            this.tbResults.Size = new System.Drawing.Size(283, 96);
            this.tbResults.TabIndex = 20;
            this.tbResults.Text = "0";
            this.tbResults.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCE
            // 
            this.btnCE.Location = new System.Drawing.Point(41, 164);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(49, 38);
            this.btnCE.TabIndex = 16;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(96, 164);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(49, 38);
            this.btnC.TabIndex = 17;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(151, 164);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(49, 38);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "<<";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnMnozhenje
            // 
            this.btnMnozhenje.Location = new System.Drawing.Point(206, 164);
            this.btnMnozhenje.Name = "btnMnozhenje";
            this.btnMnozhenje.Size = new System.Drawing.Size(49, 38);
            this.btnMnozhenje.TabIndex = 15;
            this.btnMnozhenje.Text = "*";
            this.btnMnozhenje.UseVisualStyleBackColor = true;
            this.btnMnozhenje.Click += new System.EventHandler(this.se_najbolje);
            // 
            // btnDelenje
            // 
            this.btnDelenje.Location = new System.Drawing.Point(206, 208);
            this.btnDelenje.Name = "btnDelenje";
            this.btnDelenje.Size = new System.Drawing.Size(49, 38);
            this.btnDelenje.TabIndex = 14;
            this.btnDelenje.Text = "/";
            this.btnDelenje.UseVisualStyleBackColor = true;
            this.btnDelenje.Click += new System.EventHandler(this.se_najbolje);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(206, 252);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(49, 38);
            this.btnPlus.TabIndex = 13;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.se_najbolje);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(206, 296);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(49, 38);
            this.btnMinus.TabIndex = 12;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.se_najbolje);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(45, 208);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(45, 39);
            this.btn7.TabIndex = 8;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.button_click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(100, 208);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(45, 39);
            this.btn8.TabIndex = 9;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.button_click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(155, 208);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(45, 39);
            this.btn9.TabIndex = 10;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.button_click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(45, 253);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(45, 39);
            this.btn4.TabIndex = 5;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.button_click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(100, 253);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(45, 39);
            this.btn5.TabIndex = 6;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.button_click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(155, 253);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(45, 39);
            this.btn6.TabIndex = 7;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.button_click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(100, 295);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(45, 39);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.button_click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(155, 295);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(45, 39);
            this.btn3.TabIndex = 4;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.button_click);
            // 
            // btnEdnakvo
            // 
            this.btnEdnakvo.Location = new System.Drawing.Point(206, 340);
            this.btnEdnakvo.Name = "btnEdnakvo";
            this.btnEdnakvo.Size = new System.Drawing.Size(49, 38);
            this.btnEdnakvo.TabIndex = 0;
            this.btnEdnakvo.Text = "=";
            this.btnEdnakvo.UseVisualStyleBackColor = true;
            this.btnEdnakvo.Click += new System.EventHandler(this.btnEdnakvo_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(45, 295);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(45, 39);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.button_click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(100, 339);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(45, 39);
            this.btn0.TabIndex = 1;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.button_click);
            // 
            // btnTochka
            // 
            this.btnTochka.Location = new System.Drawing.Point(155, 340);
            this.btnTochka.Name = "btnTochka";
            this.btnTochka.Size = new System.Drawing.Size(45, 38);
            this.btnTochka.TabIndex = 11;
            this.btnTochka.Text = ",";
            this.btnTochka.UseVisualStyleBackColor = true;
            this.btnTochka.Click += new System.EventHandler(this.button_click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button29);
            this.groupBox1.Controls.Add(this.button28);
            this.groupBox1.Controls.Add(this.button27);
            this.groupBox1.Controls.Add(this.button26);
            this.groupBox1.Controls.Add(this.button25);
            this.groupBox1.Controls.Add(this.button24);
            this.groupBox1.Controls.Add(this.button23);
            this.groupBox1.Controls.Add(this.button22);
            this.groupBox1.Controls.Add(this.button21);
            this.groupBox1.Controls.Add(this.button20);
            this.groupBox1.Location = new System.Drawing.Point(12, 397);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 175);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // button29
            // 
            this.button29.Location = new System.Drawing.Point(215, 74);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(46, 34);
            this.button29.TabIndex = 9;
            this.button29.Text = "Mod";
            this.button29.UseVisualStyleBackColor = true;
            this.button29.Click += new System.EventHandler(this.se_najbolje);
            // 
            // button28
            // 
            this.button28.Location = new System.Drawing.Point(163, 74);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(46, 34);
            this.button28.TabIndex = 7;
            this.button28.Text = "Exp";
            this.button28.UseVisualStyleBackColor = true;
            this.button28.Click += new System.EventHandler(this.se_najbolje);
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(111, 74);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(46, 34);
            this.button27.TabIndex = 5;
            this.button27.Text = "log";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.se_najbolje);
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(59, 74);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(46, 34);
            this.button26.TabIndex = 3;
            this.button26.Text = "10^x";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.se_najbolje);
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(7, 74);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(46, 34);
            this.button25.TabIndex = 1;
            this.button25.Text = "√";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.se_najbolje);
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(215, 20);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(46, 34);
            this.button24.TabIndex = 8;
            this.button24.Text = "tan";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.se_najbolje);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(163, 20);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(46, 34);
            this.button23.TabIndex = 6;
            this.button23.Text = "cos";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.se_najbolje);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(111, 20);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(46, 34);
            this.button22.TabIndex = 4;
            this.button22.Text = "sin";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.se_najbolje);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(59, 20);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(46, 34);
            this.button21.TabIndex = 2;
            this.button21.Text = "x^y";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.se_najbolje);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(7, 20);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(46, 34);
            this.button20.TabIndex = 0;
            this.button20.Text = "x^2";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.se_najbolje);
            // 
            // lbPateka
            // 
            this.lbPateka.AutoSize = true;
            this.lbPateka.Location = new System.Drawing.Point(29, 112);
            this.lbPateka.Name = "lbPateka";
            this.lbPateka.Size = new System.Drawing.Size(0, 13);
            this.lbPateka.TabIndex = 19;

            // 
            // Scientific
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 584);
            this.Controls.Add(this.lbPateka);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnTochka);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnEdnakvo);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnDelenje);
            this.Controls.Add(this.btnMnozhenje);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.tbResults);
            this.Controls.Add(this.cb1);
            this.KeyPreview = true;
            this.Name = "Scientific";
            this.Text = "Scientific";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.kopchinja);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb1;
        private System.Windows.Forms.TextBox tbResults;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnMnozhenje;
        private System.Windows.Forms.Button btnDelenje;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnEdnakvo;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnTochka;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Label lbPateka;
    }
}