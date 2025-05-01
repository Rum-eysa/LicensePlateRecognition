using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using FontAwesome.Sharp;
using static System.Net.Mime.MediaTypeNames;

namespace LicensePlateRecognition
{
    partial class Aritmetikİslemler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aritmetikİslemler));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.BtnSubtact = new FontAwesome.Sharp.IconButton();
            this.BtnPlus = new FontAwesome.Sharp.IconButton();
            this.ıconButton2 = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.btnDel = new FontAwesome.Sharp.IconButton();
            this.BtnSave = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.WindowText;
            this.pictureBox2.Location = new System.Drawing.Point(488, 119);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(377, 300);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.WindowText;
            this.pictureBox3.Location = new System.Drawing.Point(945, 119);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(377, 300);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // BtnSubtact
            // 
            this.BtnSubtact.BackColor = System.Drawing.Color.Red;
            this.BtnSubtact.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.BtnSubtact.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.BtnSubtact.IconColor = System.Drawing.Color.Black;
            this.BtnSubtact.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSubtact.IconSize = 60;
            this.BtnSubtact.Location = new System.Drawing.Point(395, 290);
            this.BtnSubtact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSubtact.Name = "BtnSubtact";
            this.BtnSubtact.Size = new System.Drawing.Size(67, 62);
            this.BtnSubtact.TabIndex = 11;
            this.BtnSubtact.UseVisualStyleBackColor = false;
            this.BtnSubtact.Click += new System.EventHandler(this.BtnMultiply_Click_1);
            // 
            // BtnPlus
            // 
            this.BtnPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(195)))), ((int)(((byte)(52)))));
            this.BtnPlus.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.BtnPlus.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.BtnPlus.IconColor = System.Drawing.Color.Black;
            this.BtnPlus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnPlus.IconSize = 60;
            this.BtnPlus.Location = new System.Drawing.Point(395, 197);
            this.BtnPlus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnPlus.Name = "BtnPlus";
            this.BtnPlus.Size = new System.Drawing.Size(67, 59);
            this.BtnPlus.TabIndex = 12;
            this.BtnPlus.UseVisualStyleBackColor = false;
            this.BtnPlus.Click += new System.EventHandler(this.BtnPlus_Click_1);
            // 
            // ıconButton2
            // 
            this.ıconButton2.BackColor = System.Drawing.Color.Yellow;
            this.ıconButton2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.ıconButton2.IconChar = FontAwesome.Sharp.IconChar.Equals;
            this.ıconButton2.IconColor = System.Drawing.Color.Black;
            this.ıconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButton2.IconSize = 50;
            this.ıconButton2.Location = new System.Drawing.Point(871, 246);
            this.ıconButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ıconButton2.Name = "ıconButton2";
            this.ıconButton2.Size = new System.Drawing.Size(54, 39);
            this.ıconButton2.TabIndex = 13;
            this.ıconButton2.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(195)))), ((int)(((byte)(52)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.btnAdd.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAdd.IconColor = System.Drawing.Color.Black;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.IconSize = 32;
            this.btnAdd.Location = new System.Drawing.Point(1069, 512);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 39);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Red;
            this.btnDel.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.btnDel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnDel.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnDel.IconColor = System.Drawing.Color.Black;
            this.btnDel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDel.IconSize = 32;
            this.btnDel.Location = new System.Drawing.Point(1202, 453);
            this.btnDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(103, 39);
            this.btnDel.TabIndex = 24;
            this.btnDel.UseVisualStyleBackColor = false;
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.Aqua;
            this.BtnSave.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.BtnSave.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.BtnSave.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.BtnSave.IconColor = System.Drawing.Color.Black;
            this.BtnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSave.IconSize = 32;
            this.BtnSave.Location = new System.Drawing.Point(1202, 512);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(103, 39);
            this.BtnSave.TabIndex = 25;
            this.BtnSave.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.WindowText;
            this.pictureBox1.Location = new System.Drawing.Point(12, 119);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(377, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(12, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(45, 43);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 28;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // Aritmetikİslemler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1365, 603);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.ıconButton2);
            this.Controls.Add(this.BtnPlus);
            this.Controls.Add(this.BtnSubtact);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Aritmetikİslemler";
            this.Text = "Aritmetik";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Aritmetikİslemler_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private FontAwesome.Sharp.IconButton BtnSubtact;
        private FontAwesome.Sharp.IconButton BtnPlus;
        private FontAwesome.Sharp.IconButton ıconButton2;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnDel;
        private FontAwesome.Sharp.IconButton BtnSave;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
    }
}
