namespace Calculadora
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
            this.panelTitle = new System.Windows.Forms.Panel();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textDisplay2 = new System.Windows.Forms.TextBox();
            this.textDisplay1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonParentesisDer = new System.Windows.Forms.Button();
            this.buttonParentesisIqz = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonResta = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.buttonIgual = new System.Windows.Forms.Button();
            this.buttonSuma = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.buttonMultiplicar = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonDividir = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.textBox1);
            this.panelTitle.Controls.Add(this.buttonMinimize);
            this.panelTitle.Controls.Add(this.buttonExit);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(350, 40);
            this.panelTitle.TabIndex = 0;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_down);
            this.panelTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_move);
            this.panelTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouse_up);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Location = new System.Drawing.Point(200, 0);
            this.buttonMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(50, 40);
            this.buttonMinimize.TabIndex = 1;
            this.buttonMinimize.Text = "--";
            this.buttonMinimize.UseVisualStyleBackColor = true;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Location = new System.Drawing.Point(300, 0);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(50, 40);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 40);
            this.panel1.TabIndex = 2;
            // 
            // textDisplay2
            // 
            this.textDisplay2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.textDisplay2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDisplay2.Dock = System.Windows.Forms.DockStyle.Top;
            this.textDisplay2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDisplay2.ForeColor = System.Drawing.Color.White;
            this.textDisplay2.Location = new System.Drawing.Point(0, 80);
            this.textDisplay2.Margin = new System.Windows.Forms.Padding(0);
            this.textDisplay2.Multiline = true;
            this.textDisplay2.Name = "textDisplay2";
            this.textDisplay2.Size = new System.Drawing.Size(350, 30);
            this.textDisplay2.TabIndex = 3;
            this.textDisplay2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textDisplay1
            // 
            this.textDisplay1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.textDisplay1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDisplay1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textDisplay1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold);
            this.textDisplay1.ForeColor = System.Drawing.Color.White;
            this.textDisplay1.Location = new System.Drawing.Point(0, 110);
            this.textDisplay1.Margin = new System.Windows.Forms.Padding(0);
            this.textDisplay1.Multiline = true;
            this.textDisplay1.Name = "textDisplay1";
            this.textDisplay1.Size = new System.Drawing.Size(350, 45);
            this.textDisplay1.TabIndex = 4;
            this.textDisplay1.Text = "0";
            this.textDisplay1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 155);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 40);
            this.panel2.TabIndex = 5;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonBack.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonBack.Location = new System.Drawing.Point(261, 195);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(85, 55);
            this.buttonBack.TabIndex = 6;
            this.buttonBack.Text = "Borrar";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonClear.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonClear.Location = new System.Drawing.Point(176, 195);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(85, 55);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonParentesisDer
            // 
            this.buttonParentesisDer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.buttonParentesisDer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonParentesisDer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonParentesisDer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonParentesisDer.Location = new System.Drawing.Point(90, 195);
            this.buttonParentesisDer.Margin = new System.Windows.Forms.Padding(0);
            this.buttonParentesisDer.Name = "buttonParentesisDer";
            this.buttonParentesisDer.Size = new System.Drawing.Size(85, 55);
            this.buttonParentesisDer.TabIndex = 8;
            this.buttonParentesisDer.Text = ")";
            this.buttonParentesisDer.UseVisualStyleBackColor = false;
            this.buttonParentesisDer.Click += new System.EventHandler(this.buttonNumClick);
            // 
            // buttonParentesisIqz
            // 
            this.buttonParentesisIqz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.buttonParentesisIqz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonParentesisIqz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonParentesisIqz.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonParentesisIqz.Location = new System.Drawing.Point(5, 195);
            this.buttonParentesisIqz.Margin = new System.Windows.Forms.Padding(0);
            this.buttonParentesisIqz.Name = "buttonParentesisIqz";
            this.buttonParentesisIqz.Size = new System.Drawing.Size(85, 55);
            this.buttonParentesisIqz.TabIndex = 9;
            this.buttonParentesisIqz.Text = "(";
            this.buttonParentesisIqz.UseVisualStyleBackColor = false;
            this.buttonParentesisIqz.Click += new System.EventHandler(this.buttonNumClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(5, 360);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 55);
            this.button1.TabIndex = 13;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonNumClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(90, 360);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 55);
            this.button2.TabIndex = 12;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.buttonNumClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(176, 360);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 55);
            this.button3.TabIndex = 11;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.buttonNumClick);
            // 
            // buttonResta
            // 
            this.buttonResta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.buttonResta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonResta.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonResta.Location = new System.Drawing.Point(261, 360);
            this.buttonResta.Margin = new System.Windows.Forms.Padding(0);
            this.buttonResta.Name = "buttonResta";
            this.buttonResta.Size = new System.Drawing.Size(85, 55);
            this.buttonResta.TabIndex = 10;
            this.buttonResta.Text = "-";
            this.buttonResta.UseVisualStyleBackColor = false;
            this.buttonResta.Click += new System.EventHandler(this.buttonsMathOperators);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.button0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.Location = new System.Drawing.Point(5, 415);
            this.button0.Margin = new System.Windows.Forms.Padding(0);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(85, 55);
            this.button0.TabIndex = 17;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.buttonNumClick);
            // 
            // buttonDot
            // 
            this.buttonDot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.buttonDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonDot.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonDot.Location = new System.Drawing.Point(90, 415);
            this.buttonDot.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(85, 55);
            this.buttonDot.TabIndex = 16;
            this.buttonDot.Text = ".";
            this.buttonDot.UseVisualStyleBackColor = false;
            this.buttonDot.Click += new System.EventHandler(this.buttonNumClick);
            // 
            // buttonIgual
            // 
            this.buttonIgual.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonIgual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonIgual.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonIgual.Location = new System.Drawing.Point(176, 415);
            this.buttonIgual.Margin = new System.Windows.Forms.Padding(0);
            this.buttonIgual.Name = "buttonIgual";
            this.buttonIgual.Size = new System.Drawing.Size(85, 55);
            this.buttonIgual.TabIndex = 15;
            this.buttonIgual.Text = "=";
            this.buttonIgual.UseVisualStyleBackColor = false;
            this.buttonIgual.Click += new System.EventHandler(this.buttonIgual_Click);
            // 
            // buttonSuma
            // 
            this.buttonSuma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.buttonSuma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonSuma.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSuma.Location = new System.Drawing.Point(261, 415);
            this.buttonSuma.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSuma.Name = "buttonSuma";
            this.buttonSuma.Size = new System.Drawing.Size(85, 55);
            this.buttonSuma.TabIndex = 14;
            this.buttonSuma.Text = "+";
            this.buttonSuma.UseVisualStyleBackColor = false;
            this.buttonSuma.Click += new System.EventHandler(this.buttonsMathOperators);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(5, 305);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 55);
            this.button4.TabIndex = 21;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.buttonNumClick);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(90, 305);
            this.button5.Margin = new System.Windows.Forms.Padding(0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(85, 55);
            this.button5.TabIndex = 20;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.buttonNumClick);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(176, 305);
            this.button6.Margin = new System.Windows.Forms.Padding(0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(85, 55);
            this.button6.TabIndex = 19;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.buttonNumClick);
            // 
            // buttonMultiplicar
            // 
            this.buttonMultiplicar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.buttonMultiplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonMultiplicar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonMultiplicar.Location = new System.Drawing.Point(261, 305);
            this.buttonMultiplicar.Margin = new System.Windows.Forms.Padding(0);
            this.buttonMultiplicar.Name = "buttonMultiplicar";
            this.buttonMultiplicar.Size = new System.Drawing.Size(85, 55);
            this.buttonMultiplicar.TabIndex = 18;
            this.buttonMultiplicar.Text = "*";
            this.buttonMultiplicar.UseVisualStyleBackColor = false;
            this.buttonMultiplicar.Click += new System.EventHandler(this.buttonsMathOperators);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(5, 250);
            this.button7.Margin = new System.Windows.Forms.Padding(0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(85, 55);
            this.button7.TabIndex = 25;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.buttonNumClick);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(90, 250);
            this.button8.Margin = new System.Windows.Forms.Padding(0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(85, 55);
            this.button8.TabIndex = 24;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.buttonNumClick);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(176, 250);
            this.button9.Margin = new System.Windows.Forms.Padding(0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(85, 55);
            this.button9.TabIndex = 23;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.buttonNumClick);
            // 
            // buttonDividir
            // 
            this.buttonDividir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.buttonDividir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonDividir.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonDividir.Location = new System.Drawing.Point(261, 250);
            this.buttonDividir.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDividir.Name = "buttonDividir";
            this.buttonDividir.Size = new System.Drawing.Size(85, 55);
            this.buttonDividir.TabIndex = 22;
            this.buttonDividir.Text = "/";
            this.buttonDividir.UseVisualStyleBackColor = false;
            this.buttonDividir.Click += new System.EventHandler(this.buttonsMathOperators);
            // 
            // textBox1
            // 
            this.textBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 13);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Calculadora";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(350, 487);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.buttonDividir);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.buttonMultiplicar);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.buttonDot);
            this.Controls.Add(this.buttonIgual);
            this.Controls.Add(this.buttonSuma);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonResta);
            this.Controls.Add(this.buttonParentesisIqz);
            this.Controls.Add(this.buttonParentesisDer);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textDisplay1);
            this.Controls.Add(this.textDisplay2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTitle);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_down);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_move);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouse_up);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textDisplay2;
        private System.Windows.Forms.TextBox textDisplay1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonParentesisDer;
        private System.Windows.Forms.Button buttonParentesisIqz;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonResta;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.Button buttonIgual;
        private System.Windows.Forms.Button buttonSuma;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button buttonMultiplicar;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonDividir;
        private System.Windows.Forms.TextBox textBox1;
    }
}

