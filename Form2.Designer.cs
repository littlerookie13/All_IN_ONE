﻿
namespace All_IN_ONE
{
    partial class Form2
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
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.var1soma = new System.Windows.Forms.TextBox();
            this.var2soma = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblResSoma = new System.Windows.Forms.Label();
            this.resSomaBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.resSubBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.var1Sub = new System.Windows.Forms.TextBox();
            this.var2Sub = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.resMult = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.var1Mult = new System.Windows.Forms.TextBox();
            this.var2Mult = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.resDiv = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.var1Div = new System.Windows.Forms.TextBox();
            this.var2Div = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(201, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "Funções Aritméticas";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Window;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.button2.Location = new System.Drawing.Point(12, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 50);
            this.button2.TabIndex = 2;
            this.button2.Text = "Calcular";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "+";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 33);
            this.label3.TabIndex = 6;
            this.label3.Text = "Somar Dois Valores";
            // 
            // var1soma
            // 
            this.var1soma.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var1soma.Location = new System.Drawing.Point(12, 79);
            this.var1soma.Name = "var1soma";
            this.var1soma.Size = new System.Drawing.Size(100, 27);
            this.var1soma.TabIndex = 8;
            this.var1soma.Text = "0";
            this.var1soma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.var1soma_KeyPress_1);
            // 
            // var2soma
            // 
            this.var2soma.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var2soma.Location = new System.Drawing.Point(148, 79);
            this.var2soma.Name = "var2soma";
            this.var2soma.Size = new System.Drawing.Size(100, 27);
            this.var2soma.TabIndex = 9;
            this.var2soma.Text = "0";
            this.var2soma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.var2soma_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(254, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "=";
            // 
            // lblResSoma
            // 
            this.lblResSoma.AutoSize = true;
            this.lblResSoma.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblResSoma.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResSoma.Location = new System.Drawing.Point(300, 149);
            this.lblResSoma.Name = "lblResSoma";
            this.lblResSoma.Size = new System.Drawing.Size(0, 24);
            this.lblResSoma.TabIndex = 11;
            // 
            // resSomaBox
            // 
            this.resSomaBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.resSomaBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resSomaBox.Enabled = false;
            this.resSomaBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resSomaBox.Location = new System.Drawing.Point(286, 79);
            this.resSomaBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.resSomaBox.Name = "resSomaBox";
            this.resSomaBox.Size = new System.Drawing.Size(100, 27);
            this.resSomaBox.TabIndex = 12;
            this.resSomaBox.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.resSomaBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.var1soma);
            this.groupBox1.Controls.Add(this.var2soma);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 235);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.resSubBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.var1Sub);
            this.groupBox2.Controls.Add(this.var2Sub);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 346);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(412, 235);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Location = new System.Drawing.Point(12, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // resSubBox
            // 
            this.resSubBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.resSubBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resSubBox.Enabled = false;
            this.resSubBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resSubBox.Location = new System.Drawing.Point(286, 79);
            this.resSubBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.resSubBox.Name = "resSubBox";
            this.resSubBox.Size = new System.Drawing.Size(100, 27);
            this.resSubBox.TabIndex = 12;
            this.resSubBox.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(6, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(277, 33);
            this.label5.TabIndex = 6;
            this.label5.Text = "Subtrair Dois Valores";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(121, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(254, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "=";
            // 
            // var1Sub
            // 
            this.var1Sub.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var1Sub.Location = new System.Drawing.Point(12, 79);
            this.var1Sub.Name = "var1Sub";
            this.var1Sub.Size = new System.Drawing.Size(100, 27);
            this.var1Sub.TabIndex = 8;
            this.var1Sub.Text = "0";
            this.var1Sub.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.var1Sub_KeyPress);
            // 
            // var2Sub
            // 
            this.var2Sub.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var2Sub.Location = new System.Drawing.Point(148, 79);
            this.var2Sub.Name = "var2Sub";
            this.var2Sub.Size = new System.Drawing.Size(100, 27);
            this.var2Sub.TabIndex = 9;
            this.var2Sub.Text = "0";
            this.var2Sub.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.var2Sub_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.resMult);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.var1Mult);
            this.groupBox3.Controls.Add(this.var2Mult);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(460, 95);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(412, 235);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Window;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.button3.Location = new System.Drawing.Point(12, 135);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 50);
            this.button3.TabIndex = 2;
            this.button3.Text = "Calcular";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // resMult
            // 
            this.resMult.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.resMult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resMult.Enabled = false;
            this.resMult.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resMult.Location = new System.Drawing.Point(286, 79);
            this.resMult.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.resMult.Name = "resMult";
            this.resMult.Size = new System.Drawing.Size(100, 27);
            this.resMult.TabIndex = 12;
            this.resMult.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label8.Location = new System.Drawing.Point(6, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(316, 33);
            this.label8.TabIndex = 6;
            this.label8.Text = "Multiplicar Dois Valores";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(121, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 25);
            this.label9.TabIndex = 5;
            this.label9.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(254, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 25);
            this.label10.TabIndex = 10;
            this.label10.Text = "=";
            // 
            // var1Mult
            // 
            this.var1Mult.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var1Mult.Location = new System.Drawing.Point(12, 79);
            this.var1Mult.Name = "var1Mult";
            this.var1Mult.Size = new System.Drawing.Size(100, 27);
            this.var1Mult.TabIndex = 8;
            this.var1Mult.Text = "0";
            this.var1Mult.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.var1Mult_KeyPress);
            // 
            // var2Mult
            // 
            this.var2Mult.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var2Mult.Location = new System.Drawing.Point(148, 79);
            this.var2Mult.Name = "var2Mult";
            this.var2Mult.Size = new System.Drawing.Size(100, 27);
            this.var2Mult.TabIndex = 9;
            this.var2Mult.Text = "0";
            this.var2Mult.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.var2Mult_KeyPress);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.resDiv);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.var1Div);
            this.groupBox4.Controls.Add(this.var2Div);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(460, 346);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(412, 235);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Window;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.button4.Location = new System.Drawing.Point(12, 135);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(176, 50);
            this.button4.TabIndex = 2;
            this.button4.Text = "Calcular";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // resDiv
            // 
            this.resDiv.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.resDiv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resDiv.Enabled = false;
            this.resDiv.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resDiv.Location = new System.Drawing.Point(286, 79);
            this.resDiv.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.resDiv.Name = "resDiv";
            this.resDiv.Size = new System.Drawing.Size(100, 27);
            this.resDiv.TabIndex = 12;
            this.resDiv.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label11.Location = new System.Drawing.Point(6, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(262, 33);
            this.label11.TabIndex = 6;
            this.label11.Text = "Dividir Dois Valores";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(121, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 25);
            this.label12.TabIndex = 5;
            this.label12.Text = "/";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(254, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 25);
            this.label13.TabIndex = 10;
            this.label13.Text = "=";
            // 
            // var1Div
            // 
            this.var1Div.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var1Div.Location = new System.Drawing.Point(12, 79);
            this.var1Div.Name = "var1Div";
            this.var1Div.Size = new System.Drawing.Size(100, 27);
            this.var1Div.TabIndex = 8;
            this.var1Div.Text = "0";
            this.var1Div.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.var1Div_KeyPress);
            // 
            // var2Div
            // 
            this.var2Div.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var2Div.Location = new System.Drawing.Point(148, 79);
            this.var2Div.Name = "var2Div";
            this.var2Div.Size = new System.Drawing.Size(100, 27);
            this.var2Div.TabIndex = 9;
            this.var2Div.Text = "0";
            this.var2Div.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.var2Div_KeyPress);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 627);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblResSoma);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox var1soma;
        private System.Windows.Forms.TextBox var2soma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblResSoma;
        private System.Windows.Forms.TextBox resSomaBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox resSubBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox var1Sub;
        private System.Windows.Forms.TextBox var2Sub;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox resMult;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox var1Mult;
        private System.Windows.Forms.TextBox var2Mult;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox resDiv;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox var1Div;
        private System.Windows.Forms.TextBox var2Div;
    }
}