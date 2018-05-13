using GlobalShop.Controllers.Products;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GlobalShop
{
    partial class Magazin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Magazin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button21 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button20 = new System.Windows.Forms.Button();
            this.pret = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.button19 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buc7 = new System.Windows.Forms.Label();
            this.combo7 = new System.Windows.Forms.ComboBox();
            this.b7 = new System.Windows.Forms.Button();
            this.pret7 = new System.Windows.Forms.Label();
            this.stoc7 = new System.Windows.Forms.Label();
            this.nume7 = new System.Windows.Forms.Label();
            this.buc6 = new System.Windows.Forms.Label();
            this.combo6 = new System.Windows.Forms.ComboBox();
            this.b6 = new System.Windows.Forms.Button();
            this.pret6 = new System.Windows.Forms.Label();
            this.stoc6 = new System.Windows.Forms.Label();
            this.nume6 = new System.Windows.Forms.Label();
            this.buc8 = new System.Windows.Forms.Label();
            this.combo8 = new System.Windows.Forms.ComboBox();
            this.b8 = new System.Windows.Forms.Button();
            this.pret8 = new System.Windows.Forms.Label();
            this.stoc8 = new System.Windows.Forms.Label();
            this.nume8 = new System.Windows.Forms.Label();
            this.button28 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.buc5 = new System.Windows.Forms.Label();
            this.combo5 = new System.Windows.Forms.ComboBox();
            this.b5 = new System.Windows.Forms.Button();
            this.pret5 = new System.Windows.Forms.Label();
            this.stoc5 = new System.Windows.Forms.Label();
            this.nume5 = new System.Windows.Forms.Label();
            this.buc4 = new System.Windows.Forms.Label();
            this.combo4 = new System.Windows.Forms.ComboBox();
            this.b4 = new System.Windows.Forms.Button();
            this.pret4 = new System.Windows.Forms.Label();
            this.stoc4 = new System.Windows.Forms.Label();
            this.nume4 = new System.Windows.Forms.Label();
            this.buc3 = new System.Windows.Forms.Label();
            this.combo3 = new System.Windows.Forms.ComboBox();
            this.b3 = new System.Windows.Forms.Button();
            this.pret3 = new System.Windows.Forms.Label();
            this.stoc3 = new System.Windows.Forms.Label();
            this.nume3 = new System.Windows.Forms.Label();
            this.buc2 = new System.Windows.Forms.Label();
            this.combo2 = new System.Windows.Forms.ComboBox();
            this.b2 = new System.Windows.Forms.Button();
            this.pret2 = new System.Windows.Forms.Label();
            this.stoc2 = new System.Windows.Forms.Label();
            this.nume2 = new System.Windows.Forms.Label();
            this.buc1 = new System.Windows.Forms.Label();
            this.combo1 = new System.Windows.Forms.ComboBox();
            this.b1 = new System.Windows.Forms.Button();
            this.pret1 = new System.Windows.Forms.Label();
            this.stoc1 = new System.Windows.Forms.Label();
            this.nume1 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(23, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 658);
            this.panel1.TabIndex = 0;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.Highlight;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Champagne & Limousines", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Snow;
            this.button7.Location = new System.Drawing.Point(-1, 511);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(241, 33);
            this.button7.TabIndex = 9;
            this.button7.Text = "Auto & Moto";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button1_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.Highlight;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Champagne & Limousines", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Snow;
            this.button8.Location = new System.Drawing.Point(-1, 472);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(241, 33);
            this.button8.TabIndex = 8;
            this.button8.Text = "Carti";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button1_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.Highlight;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Champagne & Limousines", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.Snow;
            this.button9.Location = new System.Drawing.Point(-1, 433);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(241, 33);
            this.button9.TabIndex = 7;
            this.button9.Text = "Haine";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Highlight;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Champagne & Limousines", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Snow;
            this.button4.Location = new System.Drawing.Point(-1, 394);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(241, 33);
            this.button4.TabIndex = 6;
            this.button4.Text = "Gaming";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Highlight;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Champagne & Limousines", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Snow;
            this.button5.Location = new System.Drawing.Point(-1, 355);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(241, 33);
            this.button5.TabIndex = 5;
            this.button5.Text = "TV, Audio-Video & Foto";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Highlight;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Champagne & Limousines", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Snow;
            this.button6.Location = new System.Drawing.Point(-1, 316);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(241, 33);
            this.button6.TabIndex = 4;
            this.button6.Text = "PC & Periferice";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Highlight;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Champagne & Limousines", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Snow;
            this.button3.Location = new System.Drawing.Point(-1, 277);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(241, 33);
            this.button3.TabIndex = 3;
            this.button3.Text = "Telefoane";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Champagne & Limousines", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Snow;
            this.button2.Location = new System.Drawing.Point(-1, 238);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(241, 33);
            this.button2.TabIndex = 2;
            this.button2.Text = "Tablete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Champagne & Limousines", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(-1, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Laptopuri";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Champagne & Limousines", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(13, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Produse";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.button15);
            this.panel2.Controls.Add(this.button16);
            this.panel2.Controls.Add(this.button17);
            this.panel2.Controls.Add(this.button18);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Controls.Add(this.pictureBox7);
            this.panel2.Controls.Add(this.pictureBox8);
            this.panel2.Controls.Add(this.button14);
            this.panel2.Controls.Add(this.button13);
            this.panel2.Controls.Add(this.button12);
            this.panel2.Controls.Add(this.button11);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(286, 183);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1051, 551);
            this.panel2.TabIndex = 2;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Champagne & Limousines", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(789, 542);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(89, 26);
            this.label20.TabIndex = 47;
            this.label20.Text = "label13";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Champagne & Limousines", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(560, 542);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(89, 26);
            this.label19.TabIndex = 46;
            this.label19.Text = "label13";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Champagne & Limousines", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(325, 542);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(89, 26);
            this.label18.TabIndex = 45;
            this.label18.Text = "label13";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Champagne & Limousines", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(93, 542);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(89, 26);
            this.label17.TabIndex = 44;
            this.label17.Text = "label13";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Champagne & Limousines", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(790, 250);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(89, 26);
            this.label16.TabIndex = 43;
            this.label16.Text = "label13";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Champagne & Limousines", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(559, 250);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 26);
            this.label15.TabIndex = 42;
            this.label15.Text = "label13";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Champagne & Limousines", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(324, 250);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 26);
            this.label14.TabIndex = 41;
            this.label14.Text = "label13";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Champagne & Limousines", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(93, 250);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 26);
            this.label13.TabIndex = 40;
            this.label13.Text = "label13";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Champagne & Limousines", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(792, 507);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 16);
            this.label10.TabIndex = 39;
            this.label10.Text = "label10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Champagne & Limousines", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(562, 507);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 16);
            this.label9.TabIndex = 38;
            this.label9.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Champagne & Limousines", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(327, 507);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 16);
            this.label8.TabIndex = 37;
            this.label8.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Champagne & Limousines", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(95, 507);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 36;
            this.label7.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Champagne & Limousines", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(791, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 35;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Champagne & Limousines", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(562, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Champagne & Limousines", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(327, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "label4";
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button15.Font = new System.Drawing.Font("Champagne & Limousines", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button15.Location = new System.Drawing.Point(97, 571);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(150, 23);
            this.button15.TabIndex = 32;
            this.button15.Text = "Vezi detalii";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button11_Click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button16.Font = new System.Drawing.Font("Champagne & Limousines", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button16.Location = new System.Drawing.Point(330, 572);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(150, 23);
            this.button16.TabIndex = 31;
            this.button16.Text = "Vezi detalii";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button11_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button17.Font = new System.Drawing.Font("Champagne & Limousines", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button17.Location = new System.Drawing.Point(564, 569);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(150, 23);
            this.button17.TabIndex = 30;
            this.button17.Text = "Vezi detalii";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button11_Click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button18.Font = new System.Drawing.Font("Champagne & Limousines", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button18.Location = new System.Drawing.Point(794, 572);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(150, 23);
            this.button18.TabIndex = 29;
            this.button18.Text = "Vezi detalii";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.button11_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(795, 341);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(151, 155);
            this.pictureBox5.TabIndex = 20;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(565, 341);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(151, 155);
            this.pictureBox6.TabIndex = 19;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Location = new System.Drawing.Point(330, 341);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(151, 155);
            this.pictureBox7.TabIndex = 18;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Location = new System.Drawing.Point(97, 341);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(151, 155);
            this.pictureBox8.TabIndex = 17;
            this.pictureBox8.TabStop = false;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button14.Font = new System.Drawing.Font("Champagne & Limousines", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button14.Location = new System.Drawing.Point(794, 279);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(150, 23);
            this.button14.TabIndex = 16;
            this.button14.Text = "Vezi detalii";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button11_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button13.Font = new System.Drawing.Font("Champagne & Limousines", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button13.Location = new System.Drawing.Point(564, 279);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(150, 23);
            this.button13.TabIndex = 15;
            this.button13.Text = "Vezi detalii";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button12.Font = new System.Drawing.Font("Champagne & Limousines", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button12.Location = new System.Drawing.Point(329, 279);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(150, 23);
            this.button12.TabIndex = 14;
            this.button12.Text = "Vezi detalii";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button11_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button11.Font = new System.Drawing.Font("Champagne & Limousines", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button11.Location = new System.Drawing.Point(97, 279);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(150, 23);
            this.button11.TabIndex = 13;
            this.button11.Text = "Vezi detalii";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Champagne & Limousines", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(794, 49);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(151, 155);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(564, 49);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(151, 155);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(329, 49);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(151, 155);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(96, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 155);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox2.DropDownHeight = 500;
            this.comboBox2.Font = new System.Drawing.Font("Champagne & Limousines", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.IntegralHeight = false;
            this.comboBox2.Location = new System.Drawing.Point(41, 45);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(555, 37);
            this.comboBox2.TabIndex = 48;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Controls.Add(this.button21);
            this.panel3.Controls.Add(this.comboBox2);
            this.panel3.Controls.Add(this.button10);
            this.panel3.Controls.Add(this.metroButton1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(270, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1051, 101);
            this.panel3.TabIndex = 3;
            // 
            // button21
            // 
            this.button21.Font = new System.Drawing.Font("Champagne & Limousines", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.Location = new System.Drawing.Point(691, 43);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(147, 40);
            this.button21.TabIndex = 49;
            this.button21.Text = "Cosul meu";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Champagne & Limousines", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(862, 43);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(147, 40);
            this.button10.TabIndex = 3;
            this.button10.Text = "Contul meu";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.SystemColors.Window;
            this.metroButton1.BackgroundImage = global::GlobalShop.Properties.Resources.icons8_search_50;
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton1.Location = new System.Drawing.Point(604, 42);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(55, 41);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.UseSelectable = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Champagne & Limousines", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(37, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cauta produsul dorit";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label24);
            this.panel4.Controls.Add(this.label23);
            this.panel4.Controls.Add(this.label22);
            this.panel4.Controls.Add(this.label21);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.button20);
            this.panel4.Controls.Add(this.pret);
            this.panel4.Controls.Add(this.pictureBox9);
            this.panel4.Controls.Add(this.button19);
            this.panel4.Location = new System.Drawing.Point(286, 183);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1026, 533);
            this.panel4.TabIndex = 4;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Champagne & Limousines", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(158, 27);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(124, 37);
            this.label24.TabIndex = 9;
            this.label24.Text = "label24";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Champagne & Limousines", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Green;
            this.label23.Location = new System.Drawing.Point(482, 342);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(443, 24);
            this.label23.TabIndex = 8;
            this.label23.Text = "Livrare standard: Ajunge in data de 26.04.2018";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Champagne & Limousines", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(482, 290);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(157, 24);
            this.label22.TabIndex = 7;
            this.label22.Text = "Vandut de: Altex";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Champagne & Limousines", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(482, 397);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(130, 24);
            this.label21.TabIndex = 6;
            this.label21.Text = "Caracteristici";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Maroon;
            this.label12.Font = new System.Drawing.Font("Champagne & Limousines", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(486, 186);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 26);
            this.label12.TabIndex = 5;
            this.label12.Text = "In Stoc";
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.SystemColors.Highlight;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.Font = new System.Drawing.Font("Champagne & Limousines", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button20.Location = new System.Drawing.Point(486, 227);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(215, 33);
            this.button20.TabIndex = 4;
            this.button20.Text = "Adauga in cos";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // pret
            // 
            this.pret.AutoSize = true;
            this.pret.Font = new System.Drawing.Font("Champagne & Limousines", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pret.ForeColor = System.Drawing.Color.Red;
            this.pret.Location = new System.Drawing.Point(480, 141);
            this.pret.Name = "pret";
            this.pret.Size = new System.Drawing.Size(123, 36);
            this.pret.TabIndex = 3;
            this.pret.Text = "700 Lei";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Location = new System.Drawing.Point(58, 90);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(348, 385);
            this.pictureBox9.TabIndex = 1;
            this.pictureBox9.TabStop = false;
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.SystemColors.Highlight;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button19.Font = new System.Drawing.Font("Champagne & Limousines", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.ForeColor = System.Drawing.Color.Red;
            this.button19.Location = new System.Drawing.Point(55, 504);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(104, 25);
            this.button19.TabIndex = 0;
            this.button19.Text = "Intoarce-te";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.Controls.Add(this.buc7);
            this.panel5.Controls.Add(this.combo7);
            this.panel5.Controls.Add(this.b7);
            this.panel5.Controls.Add(this.pret7);
            this.panel5.Controls.Add(this.stoc7);
            this.panel5.Controls.Add(this.nume7);
            this.panel5.Controls.Add(this.buc6);
            this.panel5.Controls.Add(this.combo6);
            this.panel5.Controls.Add(this.b6);
            this.panel5.Controls.Add(this.pret6);
            this.panel5.Controls.Add(this.stoc6);
            this.panel5.Controls.Add(this.nume6);
            this.panel5.Controls.Add(this.buc8);
            this.panel5.Controls.Add(this.combo8);
            this.panel5.Controls.Add(this.b8);
            this.panel5.Controls.Add(this.pret8);
            this.panel5.Controls.Add(this.stoc8);
            this.panel5.Controls.Add(this.nume8);
            this.panel5.Controls.Add(this.button28);
            this.panel5.Controls.Add(this.button27);
            this.panel5.Controls.Add(this.buc5);
            this.panel5.Controls.Add(this.combo5);
            this.panel5.Controls.Add(this.b5);
            this.panel5.Controls.Add(this.pret5);
            this.panel5.Controls.Add(this.stoc5);
            this.panel5.Controls.Add(this.nume5);
            this.panel5.Controls.Add(this.buc4);
            this.panel5.Controls.Add(this.combo4);
            this.panel5.Controls.Add(this.b4);
            this.panel5.Controls.Add(this.pret4);
            this.panel5.Controls.Add(this.stoc4);
            this.panel5.Controls.Add(this.nume4);
            this.panel5.Controls.Add(this.buc3);
            this.panel5.Controls.Add(this.combo3);
            this.panel5.Controls.Add(this.b3);
            this.panel5.Controls.Add(this.pret3);
            this.panel5.Controls.Add(this.stoc3);
            this.panel5.Controls.Add(this.nume3);
            this.panel5.Controls.Add(this.buc2);
            this.panel5.Controls.Add(this.combo2);
            this.panel5.Controls.Add(this.b2);
            this.panel5.Controls.Add(this.pret2);
            this.panel5.Controls.Add(this.stoc2);
            this.panel5.Controls.Add(this.nume2);
            this.panel5.Controls.Add(this.buc1);
            this.panel5.Controls.Add(this.combo1);
            this.panel5.Controls.Add(this.b1);
            this.panel5.Controls.Add(this.pret1);
            this.panel5.Controls.Add(this.stoc1);
            this.panel5.Controls.Add(this.nume1);
            this.panel5.Controls.Add(this.label25);
            this.panel5.Font = new System.Drawing.Font("Champagne & Limousines", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(286, 183);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1051, 551);
            this.panel5.TabIndex = 48;
            // 
            // buc7
            // 
            this.buc7.AutoSize = true;
            this.buc7.Location = new System.Drawing.Point(671, 525);
            this.buc7.Name = "buc7";
            this.buc7.Size = new System.Drawing.Size(40, 20);
            this.buc7.TabIndex = 50;
            this.buc7.Text = "buc";
            // 
            // combo7
            // 
            this.combo7.FormattingEnabled = true;
            this.combo7.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.combo7.Location = new System.Drawing.Point(621, 522);
            this.combo7.Name = "combo7";
            this.combo7.Size = new System.Drawing.Size(44, 28);
            this.combo7.TabIndex = 49;
            this.combo7.Text = "1";
            // 
            // b7
            // 
            this.b7.BackColor = System.Drawing.Color.DarkRed;
            this.b7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b7.Font = new System.Drawing.Font("Champagne & Limousines", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.b7.Location = new System.Drawing.Point(763, 528);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(59, 30);
            this.b7.TabIndex = 48;
            this.b7.Text = "Sterge";
            this.b7.UseVisualStyleBackColor = false;
            this.b7.Click += new System.EventHandler(this.b1_Click);
            // 
            // pret7
            // 
            this.pret7.AutoSize = true;
            this.pret7.Font = new System.Drawing.Font("Champagne & Limousines", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pret7.Location = new System.Drawing.Point(759, 503);
            this.pret7.Name = "pret7";
            this.pret7.Size = new System.Drawing.Size(63, 22);
            this.pret7.TabIndex = 47;
            this.pret7.Text = "31 Lei";
            // 
            // stoc7
            // 
            this.stoc7.AutoSize = true;
            this.stoc7.BackColor = System.Drawing.Color.Lime;
            this.stoc7.Font = new System.Drawing.Font("Champagne & Limousines", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stoc7.Location = new System.Drawing.Point(126, 534);
            this.stoc7.Name = "stoc7";
            this.stoc7.Size = new System.Drawing.Size(137, 16);
            this.stoc7.TabIndex = 46;
            this.stoc7.Text = "Disponibilitate: In stoc";
            // 
            // nume7
            // 
            this.nume7.AutoSize = true;
            this.nume7.Font = new System.Drawing.Font("Champagne & Limousines", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nume7.Location = new System.Drawing.Point(125, 503);
            this.nume7.Name = "nume7";
            this.nume7.Size = new System.Drawing.Size(209, 22);
            this.nume7.TabIndex = 45;
            this.nume7.Text = "Casti Zalman ZM-HP200";
            // 
            // buc6
            // 
            this.buc6.AutoSize = true;
            this.buc6.Location = new System.Drawing.Point(671, 459);
            this.buc6.Name = "buc6";
            this.buc6.Size = new System.Drawing.Size(40, 20);
            this.buc6.TabIndex = 44;
            this.buc6.Text = "buc";
            // 
            // combo6
            // 
            this.combo6.FormattingEnabled = true;
            this.combo6.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.combo6.Location = new System.Drawing.Point(621, 456);
            this.combo6.Name = "combo6";
            this.combo6.Size = new System.Drawing.Size(44, 28);
            this.combo6.TabIndex = 43;
            this.combo6.Text = "1";
            // 
            // b6
            // 
            this.b6.BackColor = System.Drawing.Color.DarkRed;
            this.b6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b6.Font = new System.Drawing.Font("Champagne & Limousines", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.b6.Location = new System.Drawing.Point(763, 462);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(59, 30);
            this.b6.TabIndex = 42;
            this.b6.Text = "Sterge";
            this.b6.UseVisualStyleBackColor = false;
            this.b6.Click += new System.EventHandler(this.b1_Click);
            // 
            // pret6
            // 
            this.pret6.AutoSize = true;
            this.pret6.Font = new System.Drawing.Font("Champagne & Limousines", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pret6.Location = new System.Drawing.Point(759, 437);
            this.pret6.Name = "pret6";
            this.pret6.Size = new System.Drawing.Size(63, 22);
            this.pret6.TabIndex = 41;
            this.pret6.Text = "31 Lei";
            // 
            // stoc6
            // 
            this.stoc6.AutoSize = true;
            this.stoc6.BackColor = System.Drawing.Color.Lime;
            this.stoc6.Font = new System.Drawing.Font("Champagne & Limousines", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stoc6.Location = new System.Drawing.Point(126, 468);
            this.stoc6.Name = "stoc6";
            this.stoc6.Size = new System.Drawing.Size(137, 16);
            this.stoc6.TabIndex = 40;
            this.stoc6.Text = "Disponibilitate: In stoc";
            // 
            // nume6
            // 
            this.nume6.AutoSize = true;
            this.nume6.Font = new System.Drawing.Font("Champagne & Limousines", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nume6.Location = new System.Drawing.Point(125, 437);
            this.nume6.Name = "nume6";
            this.nume6.Size = new System.Drawing.Size(209, 22);
            this.nume6.TabIndex = 39;
            this.nume6.Text = "Casti Zalman ZM-HP200";
            // 
            // buc8
            // 
            this.buc8.AutoSize = true;
            this.buc8.Location = new System.Drawing.Point(671, 591);
            this.buc8.Name = "buc8";
            this.buc8.Size = new System.Drawing.Size(40, 20);
            this.buc8.TabIndex = 38;
            this.buc8.Text = "buc";
            // 
            // combo8
            // 
            this.combo8.FormattingEnabled = true;
            this.combo8.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.combo8.Location = new System.Drawing.Point(621, 588);
            this.combo8.Name = "combo8";
            this.combo8.Size = new System.Drawing.Size(44, 28);
            this.combo8.TabIndex = 37;
            this.combo8.Text = "1";
            // 
            // b8
            // 
            this.b8.BackColor = System.Drawing.Color.DarkRed;
            this.b8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b8.Font = new System.Drawing.Font("Champagne & Limousines", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.b8.Location = new System.Drawing.Point(763, 594);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(59, 30);
            this.b8.TabIndex = 36;
            this.b8.Text = "Sterge";
            this.b8.UseVisualStyleBackColor = false;
            this.b8.Click += new System.EventHandler(this.b1_Click);
            // 
            // pret8
            // 
            this.pret8.AutoSize = true;
            this.pret8.Font = new System.Drawing.Font("Champagne & Limousines", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pret8.Location = new System.Drawing.Point(759, 569);
            this.pret8.Name = "pret8";
            this.pret8.Size = new System.Drawing.Size(63, 22);
            this.pret8.TabIndex = 35;
            this.pret8.Text = "31 Lei";
            // 
            // stoc8
            // 
            this.stoc8.AutoSize = true;
            this.stoc8.BackColor = System.Drawing.Color.Lime;
            this.stoc8.Font = new System.Drawing.Font("Champagne & Limousines", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stoc8.Location = new System.Drawing.Point(126, 600);
            this.stoc8.Name = "stoc8";
            this.stoc8.Size = new System.Drawing.Size(137, 16);
            this.stoc8.TabIndex = 34;
            this.stoc8.Text = "Disponibilitate: In stoc";
            // 
            // nume8
            // 
            this.nume8.AutoSize = true;
            this.nume8.Font = new System.Drawing.Font("Champagne & Limousines", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nume8.Location = new System.Drawing.Point(125, 569);
            this.nume8.Name = "nume8";
            this.nume8.Size = new System.Drawing.Size(209, 22);
            this.nume8.TabIndex = 33;
            this.nume8.Text = "Casti Zalman ZM-HP200";
            // 
            // button28
            // 
            this.button28.Location = new System.Drawing.Point(846, 231);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(173, 150);
            this.button28.TabIndex = 32;
            this.button28.Text = "Trimite comanda";
            this.button28.UseVisualStyleBackColor = true;
            this.button28.Click += new System.EventHandler(this.button28_Click);
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(4, 110);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(104, 44);
            this.button27.TabIndex = 31;
            this.button27.Text = "Inapoi";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.button27_Click);
            // 
            // buc5
            // 
            this.buc5.AutoSize = true;
            this.buc5.Location = new System.Drawing.Point(671, 385);
            this.buc5.Name = "buc5";
            this.buc5.Size = new System.Drawing.Size(40, 20);
            this.buc5.TabIndex = 30;
            this.buc5.Text = "buc";
            // 
            // combo5
            // 
            this.combo5.FormattingEnabled = true;
            this.combo5.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.combo5.Location = new System.Drawing.Point(621, 382);
            this.combo5.Name = "combo5";
            this.combo5.Size = new System.Drawing.Size(44, 28);
            this.combo5.TabIndex = 29;
            this.combo5.Text = "1";
            // 
            // b5
            // 
            this.b5.BackColor = System.Drawing.Color.DarkRed;
            this.b5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b5.Font = new System.Drawing.Font("Champagne & Limousines", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.b5.Location = new System.Drawing.Point(763, 396);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(59, 30);
            this.b5.TabIndex = 28;
            this.b5.Text = "Sterge";
            this.b5.UseVisualStyleBackColor = false;
            this.b5.Click += new System.EventHandler(this.b1_Click);
            // 
            // pret5
            // 
            this.pret5.AutoSize = true;
            this.pret5.Font = new System.Drawing.Font("Champagne & Limousines", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pret5.Location = new System.Drawing.Point(759, 371);
            this.pret5.Name = "pret5";
            this.pret5.Size = new System.Drawing.Size(63, 22);
            this.pret5.TabIndex = 27;
            this.pret5.Text = "31 Lei";
            // 
            // stoc5
            // 
            this.stoc5.AutoSize = true;
            this.stoc5.BackColor = System.Drawing.Color.Lime;
            this.stoc5.Font = new System.Drawing.Font("Champagne & Limousines", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stoc5.Location = new System.Drawing.Point(126, 402);
            this.stoc5.Name = "stoc5";
            this.stoc5.Size = new System.Drawing.Size(137, 16);
            this.stoc5.TabIndex = 26;
            this.stoc5.Text = "Disponibilitate: In stoc";
            // 
            // nume5
            // 
            this.nume5.AutoSize = true;
            this.nume5.Font = new System.Drawing.Font("Champagne & Limousines", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nume5.Location = new System.Drawing.Point(125, 371);
            this.nume5.Name = "nume5";
            this.nume5.Size = new System.Drawing.Size(209, 22);
            this.nume5.TabIndex = 25;
            this.nume5.Text = "Casti Zalman ZM-HP200";
            // 
            // buc4
            // 
            this.buc4.AutoSize = true;
            this.buc4.Location = new System.Drawing.Point(671, 326);
            this.buc4.Name = "buc4";
            this.buc4.Size = new System.Drawing.Size(40, 20);
            this.buc4.TabIndex = 24;
            this.buc4.Text = "buc";
            // 
            // combo4
            // 
            this.combo4.FormattingEnabled = true;
            this.combo4.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.combo4.Location = new System.Drawing.Point(621, 323);
            this.combo4.Name = "combo4";
            this.combo4.Size = new System.Drawing.Size(44, 28);
            this.combo4.TabIndex = 23;
            this.combo4.Text = "1";
            // 
            // b4
            // 
            this.b4.BackColor = System.Drawing.Color.DarkRed;
            this.b4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b4.Font = new System.Drawing.Font("Champagne & Limousines", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.b4.Location = new System.Drawing.Point(763, 328);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(59, 30);
            this.b4.TabIndex = 22;
            this.b4.Text = "Sterge";
            this.b4.UseVisualStyleBackColor = false;
            this.b4.Click += new System.EventHandler(this.b1_Click);
            // 
            // pret4
            // 
            this.pret4.AutoSize = true;
            this.pret4.Font = new System.Drawing.Font("Champagne & Limousines", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pret4.Location = new System.Drawing.Point(759, 304);
            this.pret4.Name = "pret4";
            this.pret4.Size = new System.Drawing.Size(63, 22);
            this.pret4.TabIndex = 21;
            this.pret4.Text = "31 Lei";
            // 
            // stoc4
            // 
            this.stoc4.AutoSize = true;
            this.stoc4.BackColor = System.Drawing.Color.Lime;
            this.stoc4.Font = new System.Drawing.Font("Champagne & Limousines", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stoc4.Location = new System.Drawing.Point(126, 335);
            this.stoc4.Name = "stoc4";
            this.stoc4.Size = new System.Drawing.Size(137, 16);
            this.stoc4.TabIndex = 20;
            this.stoc4.Text = "Disponibilitate: In stoc";
            // 
            // nume4
            // 
            this.nume4.AutoSize = true;
            this.nume4.Font = new System.Drawing.Font("Champagne & Limousines", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nume4.Location = new System.Drawing.Point(125, 304);
            this.nume4.Name = "nume4";
            this.nume4.Size = new System.Drawing.Size(209, 22);
            this.nume4.TabIndex = 19;
            this.nume4.Text = "Casti Zalman ZM-HP200";
            // 
            // buc3
            // 
            this.buc3.AutoSize = true;
            this.buc3.Location = new System.Drawing.Point(671, 261);
            this.buc3.Name = "buc3";
            this.buc3.Size = new System.Drawing.Size(40, 20);
            this.buc3.TabIndex = 18;
            this.buc3.Text = "buc";
            // 
            // combo3
            // 
            this.combo3.FormattingEnabled = true;
            this.combo3.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.combo3.Location = new System.Drawing.Point(621, 258);
            this.combo3.Name = "combo3";
            this.combo3.Size = new System.Drawing.Size(44, 28);
            this.combo3.TabIndex = 17;
            this.combo3.Text = "1";
            // 
            // b3
            // 
            this.b3.BackColor = System.Drawing.Color.DarkRed;
            this.b3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b3.Font = new System.Drawing.Font("Champagne & Limousines", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.b3.Location = new System.Drawing.Point(763, 259);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(59, 30);
            this.b3.TabIndex = 16;
            this.b3.Text = "Sterge";
            this.b3.UseVisualStyleBackColor = false;
            this.b3.Click += new System.EventHandler(this.b1_Click);
            // 
            // pret3
            // 
            this.pret3.AutoSize = true;
            this.pret3.Font = new System.Drawing.Font("Champagne & Limousines", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pret3.Location = new System.Drawing.Point(759, 234);
            this.pret3.Name = "pret3";
            this.pret3.Size = new System.Drawing.Size(63, 22);
            this.pret3.TabIndex = 15;
            this.pret3.Text = "31 Lei";
            // 
            // stoc3
            // 
            this.stoc3.AutoSize = true;
            this.stoc3.BackColor = System.Drawing.Color.Lime;
            this.stoc3.Font = new System.Drawing.Font("Champagne & Limousines", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stoc3.Location = new System.Drawing.Point(126, 265);
            this.stoc3.Name = "stoc3";
            this.stoc3.Size = new System.Drawing.Size(137, 16);
            this.stoc3.TabIndex = 14;
            this.stoc3.Text = "Disponibilitate: In stoc";
            // 
            // nume3
            // 
            this.nume3.AutoSize = true;
            this.nume3.Font = new System.Drawing.Font("Champagne & Limousines", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nume3.Location = new System.Drawing.Point(125, 235);
            this.nume3.Name = "nume3";
            this.nume3.Size = new System.Drawing.Size(209, 22);
            this.nume3.TabIndex = 13;
            this.nume3.Text = "Casti Zalman ZM-HP200";
            // 
            // buc2
            // 
            this.buc2.AutoSize = true;
            this.buc2.Location = new System.Drawing.Point(671, 192);
            this.buc2.Name = "buc2";
            this.buc2.Size = new System.Drawing.Size(40, 20);
            this.buc2.TabIndex = 12;
            this.buc2.Text = "buc";
            // 
            // combo2
            // 
            this.combo2.FormattingEnabled = true;
            this.combo2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.combo2.Location = new System.Drawing.Point(621, 189);
            this.combo2.Name = "combo2";
            this.combo2.Size = new System.Drawing.Size(44, 28);
            this.combo2.TabIndex = 11;
            this.combo2.Text = "1";
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.Color.DarkRed;
            this.b2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b2.Font = new System.Drawing.Font("Champagne & Limousines", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.b2.Location = new System.Drawing.Point(763, 195);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(59, 30);
            this.b2.TabIndex = 10;
            this.b2.Text = "Sterge";
            this.b2.UseVisualStyleBackColor = false;
            this.b2.Click += new System.EventHandler(this.b1_Click);
            // 
            // pret2
            // 
            this.pret2.AutoSize = true;
            this.pret2.Font = new System.Drawing.Font("Champagne & Limousines", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pret2.Location = new System.Drawing.Point(759, 170);
            this.pret2.Name = "pret2";
            this.pret2.Size = new System.Drawing.Size(63, 22);
            this.pret2.TabIndex = 9;
            this.pret2.Text = "31 Lei";
            // 
            // stoc2
            // 
            this.stoc2.AutoSize = true;
            this.stoc2.BackColor = System.Drawing.Color.Lime;
            this.stoc2.Font = new System.Drawing.Font("Champagne & Limousines", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stoc2.Location = new System.Drawing.Point(126, 201);
            this.stoc2.Name = "stoc2";
            this.stoc2.Size = new System.Drawing.Size(137, 16);
            this.stoc2.TabIndex = 8;
            this.stoc2.Text = "Disponibilitate: In stoc";
            // 
            // nume2
            // 
            this.nume2.AutoSize = true;
            this.nume2.Font = new System.Drawing.Font("Champagne & Limousines", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nume2.Location = new System.Drawing.Point(125, 170);
            this.nume2.Name = "nume2";
            this.nume2.Size = new System.Drawing.Size(209, 22);
            this.nume2.TabIndex = 7;
            this.nume2.Text = "Casti Zalman ZM-HP200";
            // 
            // buc1
            // 
            this.buc1.AutoSize = true;
            this.buc1.Location = new System.Drawing.Point(671, 129);
            this.buc1.Name = "buc1";
            this.buc1.Size = new System.Drawing.Size(40, 20);
            this.buc1.TabIndex = 6;
            this.buc1.Text = "buc";
            // 
            // combo1
            // 
            this.combo1.FormattingEnabled = true;
            this.combo1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.combo1.Location = new System.Drawing.Point(621, 126);
            this.combo1.Name = "combo1";
            this.combo1.Size = new System.Drawing.Size(44, 28);
            this.combo1.TabIndex = 5;
            this.combo1.Text = "1";
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.Color.DarkRed;
            this.b1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b1.Font = new System.Drawing.Font("Champagne & Limousines", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.b1.Location = new System.Drawing.Point(763, 132);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(59, 30);
            this.b1.TabIndex = 4;
            this.b1.Text = "Sterge";
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // pret1
            // 
            this.pret1.AutoSize = true;
            this.pret1.Font = new System.Drawing.Font("Champagne & Limousines", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pret1.Location = new System.Drawing.Point(759, 107);
            this.pret1.Name = "pret1";
            this.pret1.Size = new System.Drawing.Size(63, 22);
            this.pret1.TabIndex = 3;
            this.pret1.Text = "31 Lei";
            // 
            // stoc1
            // 
            this.stoc1.AutoSize = true;
            this.stoc1.BackColor = System.Drawing.Color.Lime;
            this.stoc1.Font = new System.Drawing.Font("Champagne & Limousines", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stoc1.Location = new System.Drawing.Point(126, 138);
            this.stoc1.Name = "stoc1";
            this.stoc1.Size = new System.Drawing.Size(137, 16);
            this.stoc1.TabIndex = 2;
            this.stoc1.Text = "Disponibilitate: In stoc";
            // 
            // nume1
            // 
            this.nume1.AutoSize = true;
            this.nume1.Font = new System.Drawing.Font("Champagne & Limousines", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nume1.Location = new System.Drawing.Point(125, 107);
            this.nume1.Name = "nume1";
            this.nume1.Size = new System.Drawing.Size(209, 22);
            this.nume1.TabIndex = 1;
            this.nume1.Text = "Casti Zalman ZM-HP200";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Champagne & Limousines", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(51, 27);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(325, 40);
            this.label25.TabIndex = 0;
            this.label25.Text = "Cos de cumparaturi";
            // 
            // Magazin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1363, 774);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Champagne & Limousines", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Magazin";
            this.Text = "Global Shop";
            this.Load += new System.EventHandler(this.Magazin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

      

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Label pret;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label24;
        private ComboBox comboBox2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private Panel panel5;
        private Label buc1;
        private ComboBox combo1;
        private Button b1;
        private Label pret1;
        private Label stoc1;
        private Label nume1;
        private Label label25;
        private Button button21;
        private Label buc5;
        private ComboBox combo5;
        private Button b5;
        private Label pret5;
        private Label stoc5;
        private Label nume5;
        private Label buc4;
        private ComboBox combo4;
        private Button b4;
        private Label pret4;
        private Label stoc4;
        private Label nume4;
        private Label buc3;
        private ComboBox combo3;
        private Button b3;
        private Label pret3;
        private Label stoc3;
        private Label nume3;
        private Label buc2;
        private ComboBox combo2;
        private Button b2;
        private Label pret2;
        private Label stoc2;
        private Label nume2;
        private Button button27;
        private Label buc7;
        private ComboBox combo7;
        private Button b7;
        private Label pret7;
        private Label stoc7;
        private Label nume7;
        private Label buc6;
        private ComboBox combo6;
        private Button b6;
        private Label pret6;
        private Label stoc6;
        private Label nume6;
        private Label buc8;
        private ComboBox combo8;
        private Button b8;
        private Label pret8;
        private Label stoc8;
        private Label nume8;
        private Button button28;
    }
}