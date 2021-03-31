
namespace Calculator
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
            this.button1 = new System.Windows.Forms.Button();
            this.Display = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.divisionButton = new System.Windows.Forms.Button();
            this.multiplicationButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.decimalPointButton = new System.Windows.Forms.Button();
            this.NumberSignButton = new System.Windows.Forms.Button();
            this.CEButton = new System.Windows.Forms.Button();
            this.CButton = new System.Windows.Forms.Button();
            this.backspaceButton = new System.Windows.Forms.Button();
            this.solveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AccessibleName = "";
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(12, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // Display
            // 
            this.Display.BackColor = System.Drawing.Color.White;
            this.Display.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Display.Enabled = false;
            this.Display.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Display.ForeColor = System.Drawing.SystemColors.Window;
            this.Display.Location = new System.Drawing.Point(12, 12);
            this.Display.Name = "Display";
            this.Display.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Display.Size = new System.Drawing.Size(298, 20);
            this.Display.TabIndex = 1;
            this.Display.Text = "0";
            this.Display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button2
            // 
            this.button2.AccessibleName = "";
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(88, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 45);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // button3
            // 
            this.button3.AccessibleName = "";
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(164, 195);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 45);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // button4
            // 
            this.button4.AccessibleName = "";
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(12, 144);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 45);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // button5
            // 
            this.button5.AccessibleName = "";
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Location = new System.Drawing.Point(88, 144);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(70, 45);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // button6
            // 
            this.button6.AccessibleName = "";
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button6.Location = new System.Drawing.Point(164, 144);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(70, 45);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // button7
            // 
            this.button7.AccessibleName = "";
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button7.Location = new System.Drawing.Point(12, 93);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(70, 45);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // button8
            // 
            this.button8.AccessibleName = "";
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button8.Location = new System.Drawing.Point(88, 93);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(70, 45);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // button9
            // 
            this.button9.AccessibleName = "";
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button9.Location = new System.Drawing.Point(164, 93);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(70, 45);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // button0
            // 
            this.button0.AccessibleName = "";
            this.button0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.button0.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            this.button0.FlatAppearance.BorderSize = 0;
            this.button0.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button0.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button0.Location = new System.Drawing.Point(88, 246);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(70, 45);
            this.button0.TabIndex = 10;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // divisionButton
            // 
            this.divisionButton.AccessibleName = "";
            this.divisionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            this.divisionButton.FlatAppearance.BorderSize = 0;
            this.divisionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.divisionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.divisionButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.divisionButton.Location = new System.Drawing.Point(240, 42);
            this.divisionButton.Name = "divisionButton";
            this.divisionButton.Size = new System.Drawing.Size(70, 45);
            this.divisionButton.TabIndex = 11;
            this.divisionButton.Text = "÷";
            this.divisionButton.UseVisualStyleBackColor = false;
            this.divisionButton.Click += new System.EventHandler(this.ActButton_Click);
            // 
            // multiplicationButton
            // 
            this.multiplicationButton.AccessibleName = "";
            this.multiplicationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            this.multiplicationButton.FlatAppearance.BorderSize = 0;
            this.multiplicationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiplicationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multiplicationButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.multiplicationButton.Location = new System.Drawing.Point(240, 93);
            this.multiplicationButton.Name = "multiplicationButton";
            this.multiplicationButton.Size = new System.Drawing.Size(70, 45);
            this.multiplicationButton.TabIndex = 12;
            this.multiplicationButton.Text = "×";
            this.multiplicationButton.UseVisualStyleBackColor = false;
            this.multiplicationButton.Click += new System.EventHandler(this.ActButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.AccessibleName = "";
            this.minusButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            this.minusButton.FlatAppearance.BorderSize = 0;
            this.minusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minusButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.minusButton.Location = new System.Drawing.Point(240, 144);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(70, 45);
            this.minusButton.TabIndex = 13;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = false;
            this.minusButton.Click += new System.EventHandler(this.ActButton_Click);
            // 
            // plusButton
            // 
            this.plusButton.AccessibleName = "";
            this.plusButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            this.plusButton.FlatAppearance.BorderSize = 0;
            this.plusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plusButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.plusButton.Location = new System.Drawing.Point(240, 195);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(70, 45);
            this.plusButton.TabIndex = 14;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = false;
            this.plusButton.Click += new System.EventHandler(this.ActButton_Click);
            // 
            // decimalPointButton
            // 
            this.decimalPointButton.AccessibleName = "";
            this.decimalPointButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            this.decimalPointButton.FlatAppearance.BorderSize = 0;
            this.decimalPointButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decimalPointButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decimalPointButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.decimalPointButton.Location = new System.Drawing.Point(164, 246);
            this.decimalPointButton.Name = "decimalPointButton";
            this.decimalPointButton.Size = new System.Drawing.Size(70, 45);
            this.decimalPointButton.TabIndex = 15;
            this.decimalPointButton.Text = ",";
            this.decimalPointButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.decimalPointButton.UseVisualStyleBackColor = false;
            this.decimalPointButton.Click += new System.EventHandler(this.decimalPointButton_Click);
            // 
            // NumberSignButton
            // 
            this.NumberSignButton.AccessibleName = "";
            this.NumberSignButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            this.NumberSignButton.FlatAppearance.BorderSize = 0;
            this.NumberSignButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NumberSignButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberSignButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NumberSignButton.Location = new System.Drawing.Point(12, 246);
            this.NumberSignButton.Name = "NumberSignButton";
            this.NumberSignButton.Size = new System.Drawing.Size(70, 45);
            this.NumberSignButton.TabIndex = 16;
            this.NumberSignButton.Text = "±";
            this.NumberSignButton.UseVisualStyleBackColor = false;
            this.NumberSignButton.Click += new System.EventHandler(this.NumberSignButton_Click);
            // 
            // CEButton
            // 
            this.CEButton.AccessibleName = "";
            this.CEButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            this.CEButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.CEButton.FlatAppearance.BorderSize = 0;
            this.CEButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CEButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CEButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CEButton.Location = new System.Drawing.Point(12, 42);
            this.CEButton.Name = "CEButton";
            this.CEButton.Size = new System.Drawing.Size(70, 45);
            this.CEButton.TabIndex = 17;
            this.CEButton.Text = "CE";
            this.CEButton.UseVisualStyleBackColor = false;
            this.CEButton.Click += new System.EventHandler(this.CEButton_Click);
            // 
            // CButton
            // 
            this.CButton.AccessibleName = "";
            this.CButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            this.CButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.CButton.FlatAppearance.BorderSize = 0;
            this.CButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CButton.Location = new System.Drawing.Point(88, 42);
            this.CButton.Name = "CButton";
            this.CButton.Size = new System.Drawing.Size(70, 45);
            this.CButton.TabIndex = 18;
            this.CButton.Text = "C";
            this.CButton.UseVisualStyleBackColor = false;
            this.CButton.Click += new System.EventHandler(this.CButton_Click);
            // 
            // backspaceButton
            // 
            this.backspaceButton.AccessibleName = "";
            this.backspaceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            this.backspaceButton.FlatAppearance.BorderSize = 0;
            this.backspaceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backspaceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backspaceButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.backspaceButton.Location = new System.Drawing.Point(164, 42);
            this.backspaceButton.Name = "backspaceButton";
            this.backspaceButton.Size = new System.Drawing.Size(70, 45);
            this.backspaceButton.TabIndex = 19;
            this.backspaceButton.Text = "⌫";
            this.backspaceButton.UseVisualStyleBackColor = false;
            this.backspaceButton.Click += new System.EventHandler(this.backspaceButton_Click);
            // 
            // solveButton
            // 
            this.solveButton.AccessibleName = "";
            this.solveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            this.solveButton.FlatAppearance.BorderSize = 0;
            this.solveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.solveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.solveButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.solveButton.Location = new System.Drawing.Point(240, 246);
            this.solveButton.Name = "solveButton";
            this.solveButton.Size = new System.Drawing.Size(70, 45);
            this.solveButton.TabIndex = 20;
            this.solveButton.Text = "=";
            this.solveButton.UseVisualStyleBackColor = false;
            this.solveButton.Click += new System.EventHandler(this.SolveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(100)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(322, 302);
            this.Controls.Add(this.solveButton);
            this.Controls.Add(this.backspaceButton);
            this.Controls.Add(this.CButton);
            this.Controls.Add(this.CEButton);
            this.Controls.Add(this.NumberSignButton);
            this.Controls.Add(this.decimalPointButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.multiplicationButton);
            this.Controls.Add(this.divisionButton);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "Form1";
            this.Text = "The best calculator ever";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox Display;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button divisionButton;
        private System.Windows.Forms.Button multiplicationButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button decimalPointButton;
        private System.Windows.Forms.Button NumberSignButton;
        private System.Windows.Forms.Button CEButton;
        private System.Windows.Forms.Button CButton;
        private System.Windows.Forms.Button backspaceButton;
        private System.Windows.Forms.Button solveButton;
    }
}

