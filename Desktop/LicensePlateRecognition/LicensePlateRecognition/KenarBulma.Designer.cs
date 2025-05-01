using FontAwesome.Sharp;
namespace LicensePlateRecognition
{
    partial class KenarBulma
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KenarBulma));
            this.afterPic = new FontAwesome.Sharp.IconPictureBox();
            this.beforePic = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.btnDel = new FontAwesome.Sharp.IconButton();
            this.btnUndo = new FontAwesome.Sharp.IconButton();
            this.iconButtonFotografSec = new FontAwesome.Sharp.IconButton();
            this.btnPrewitt = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.afterPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beforePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // afterPic
            // 
            this.afterPic.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.afterPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.afterPic.IconChar = FontAwesome.Sharp.IconChar.None;
            this.afterPic.IconColor = System.Drawing.Color.White;
            this.afterPic.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.afterPic.IconSize = 561;
            this.afterPic.Location = new System.Drawing.Point(650, 20);
            this.afterPic.Name = "afterPic";
            this.afterPic.Size = new System.Drawing.Size(588, 561);
            this.afterPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.afterPic.TabIndex = 0;
            this.afterPic.TabStop = false;
            // 
            // beforePic
            // 
            this.beforePic.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.beforePic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.beforePic.IconChar = FontAwesome.Sharp.IconChar.None;
            this.beforePic.IconColor = System.Drawing.Color.White;
            this.beforePic.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.beforePic.IconSize = 561;
            this.beforePic.Location = new System.Drawing.Point(50, 20);
            this.beforePic.Name = "beforePic";
            this.beforePic.Size = new System.Drawing.Size(588, 561);
            this.beforePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.beforePic.TabIndex = 1;
            this.beforePic.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(50, 590);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Genişlik : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(220, 590);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Yükseklik : ";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblWidth.ForeColor = System.Drawing.SystemColors.Control;
            this.lblWidth.Location = new System.Drawing.Point(147, 590);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(20, 24);
            this.lblWidth.TabIndex = 8;
            this.lblWidth.Text = "0";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblHeight.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHeight.Location = new System.Drawing.Point(325, 590);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(20, 24);
            this.lblHeight.TabIndex = 7;
            this.lblHeight.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Aqua;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.btnSave.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnSave.IconColor = System.Drawing.Color.Black;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.IconSize = 32;
            this.btnSave.Location = new System.Drawing.Point(1013, 679);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(170, 60);
            this.btnSave.TabIndex = 28;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
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
            this.btnDel.Location = new System.Drawing.Point(774, 680);
            this.btnDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(170, 60);
            this.btnDel.TabIndex = 27;
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click_1);
            // 
            // btnUndo
            // 
            this.btnUndo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUndo.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.btnUndo.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnUndo.IconChar = FontAwesome.Sharp.IconChar.Backward;
            this.btnUndo.IconColor = System.Drawing.Color.Black;
            this.btnUndo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUndo.IconSize = 32;
            this.btnUndo.Location = new System.Drawing.Point(92, 679);
            this.btnUndo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(170, 60);
            this.btnUndo.TabIndex = 29;
            this.btnUndo.UseVisualStyleBackColor = false;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click_1);
            // 
            // iconButtonFotografSec
            // 
            this.iconButtonFotografSec.BackColor = System.Drawing.Color.Yellow;
            this.iconButtonFotografSec.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.iconButtonFotografSec.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.iconButtonFotografSec.IconChar = FontAwesome.Sharp.IconChar.Images;
            this.iconButtonFotografSec.IconColor = System.Drawing.Color.Black;
            this.iconButtonFotografSec.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonFotografSec.IconSize = 32;
            this.iconButtonFotografSec.Location = new System.Drawing.Point(319, 679);
            this.iconButtonFotografSec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButtonFotografSec.Name = "iconButtonFotografSec";
            this.iconButtonFotografSec.Size = new System.Drawing.Size(170, 60);
            this.iconButtonFotografSec.TabIndex = 30;
            this.iconButtonFotografSec.UseVisualStyleBackColor = false;
            this.iconButtonFotografSec.Click += new System.EventHandler(this.iconButtonFotografSec_Click);
            // 
            // btnPrewitt
            // 
            this.btnPrewitt.BackColor = System.Drawing.Color.Lime;
            this.btnPrewitt.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.btnPrewitt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnPrewitt.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.btnPrewitt.IconColor = System.Drawing.Color.Black;
            this.btnPrewitt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrewitt.IconSize = 32;
            this.btnPrewitt.Location = new System.Drawing.Point(561, 611);
            this.btnPrewitt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrewitt.Name = "btnPrewitt";
            this.btnPrewitt.Size = new System.Drawing.Size(170, 60);
            this.btnPrewitt.TabIndex = 31;
            this.btnPrewitt.UseVisualStyleBackColor = false;
            this.btnPrewitt.Click += new System.EventHandler(this.btnPrewitt_Click_1);
            // 
            // KenarBulma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1360, 820);
            this.Controls.Add(this.btnPrewitt);
            this.Controls.Add(this.iconButtonFotografSec);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.afterPic);
            this.Controls.Add(this.beforePic);
            this.Name = "KenarBulma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kenar Bulma";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KenarBulma_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.afterPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beforePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private IconPictureBox afterPic;
        private IconPictureBox beforePic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.PictureBox pictureBox1;
        private IconButton btnSave;
        private IconButton btnDel;
        private IconButton btnUndo;
        private IconButton iconButtonFotografSec;
        private IconButton btnPrewitt;
    }
}
