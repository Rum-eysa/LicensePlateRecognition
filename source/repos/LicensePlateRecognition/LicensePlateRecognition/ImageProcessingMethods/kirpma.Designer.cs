using FontAwesome.Sharp;

namespace LicensePlateRecognition
{
    partial class Kirpma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kirpma));
            this.afterPic = new FontAwesome.Sharp.IconPictureBox();
            this.beforePic = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtWidthStart = new System.Windows.Forms.TextBox();
            this.txtHeightStart = new System.Windows.Forms.TextBox();
            this.txtWidthEnd = new System.Windows.Forms.TextBox();
            this.txtHeightEnd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCrop = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.btnDel = new FontAwesome.Sharp.IconButton();
            this.btnUndo = new FontAwesome.Sharp.IconButton();
            this.ıconButtonfotografsec = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.afterPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beforePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // afterPic
            // 
            this.afterPic.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.afterPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.afterPic.ForeColor = System.Drawing.SystemColors.Control;
            this.afterPic.IconChar = FontAwesome.Sharp.IconChar.None;
            this.afterPic.IconColor = System.Drawing.SystemColors.Control;
            this.afterPic.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.afterPic.IconSize = 561;
            this.afterPic.Location = new System.Drawing.Point(649, 21);
            this.afterPic.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.afterPic.Name = "afterPic";
            this.afterPic.Size = new System.Drawing.Size(588, 561);
            this.afterPic.TabIndex = 5;
            this.afterPic.TabStop = false;
            // 
            // beforePic
            // 
            this.beforePic.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.beforePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.beforePic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.beforePic.ForeColor = System.Drawing.SystemColors.Control;
            this.beforePic.IconChar = FontAwesome.Sharp.IconChar.None;
            this.beforePic.IconColor = System.Drawing.SystemColors.Control;
            this.beforePic.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.beforePic.IconSize = 561;
            this.beforePic.Location = new System.Drawing.Point(55, 21);
            this.beforePic.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.beforePic.Name = "beforePic";
            this.beforePic.Size = new System.Drawing.Size(588, 561);
            this.beforePic.TabIndex = 4;
            this.beforePic.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(55, 585);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Genişlik : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(224, 585);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Yükseklik : ";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblWidth.ForeColor = System.Drawing.SystemColors.Control;
            this.lblWidth.Location = new System.Drawing.Point(152, 585);
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
            this.lblHeight.Location = new System.Drawing.Point(333, 585);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(20, 24);
            this.lblHeight.TabIndex = 9;
            this.lblHeight.Text = "0";
            // 
            // txtWidthStart
            // 
            this.txtWidthStart.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtWidthStart.Location = new System.Drawing.Point(302, 694);
            this.txtWidthStart.Name = "txtWidthStart";
            this.txtWidthStart.Size = new System.Drawing.Size(138, 34);
            this.txtWidthStart.TabIndex = 10;
            // 
            // txtHeightStart
            // 
            this.txtHeightStart.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtHeightStart.Location = new System.Drawing.Point(302, 740);
            this.txtHeightStart.Name = "txtHeightStart";
            this.txtHeightStart.Size = new System.Drawing.Size(138, 34);
            this.txtHeightStart.TabIndex = 11;
            // 
            // txtWidthEnd
            // 
            this.txtWidthEnd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtWidthEnd.Location = new System.Drawing.Point(489, 694);
            this.txtWidthEnd.Name = "txtWidthEnd";
            this.txtWidthEnd.Size = new System.Drawing.Size(138, 34);
            this.txtWidthEnd.TabIndex = 12;
            // 
            // txtHeightEnd
            // 
            this.txtHeightEnd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtHeightEnd.Location = new System.Drawing.Point(489, 740);
            this.txtHeightEnd.Name = "txtHeightEnd";
            this.txtHeightEnd.Size = new System.Drawing.Size(138, 34);
            this.txtHeightEnd.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(139, 740);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 31);
            this.label6.TabIndex = 15;
            this.label6.Text = "Yükseklik : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(139, 692);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 31);
            this.label7.TabIndex = 16;
            this.label7.Text = "Genişlik : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(325, 654);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 28);
            this.label8.TabIndex = 17;
            this.label8.Text = "Başlangıç ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(522, 654);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 28);
            this.label9.TabIndex = 18;
            this.label9.Text = "Bitiş : ";
            // 
            // btnCrop
            // 
            this.btnCrop.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnCrop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrop.ForeColor = System.Drawing.Color.White;
            this.btnCrop.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCrop.IconColor = System.Drawing.Color.White;
            this.btnCrop.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCrop.Location = new System.Drawing.Point(768, 679);
            this.btnCrop.Name = "btnCrop";
            this.btnCrop.Size = new System.Drawing.Size(169, 58);
            this.btnCrop.TabIndex = 19;
            this.btnCrop.Text = "Kırp";
            this.btnCrop.UseVisualStyleBackColor = false;
            this.btnCrop.Click += new System.EventHandler(this.btnCrop_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 24;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAdd.IconColor = System.Drawing.Color.White;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.Location = new System.Drawing.Point(957, 679);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(169, 58);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSave.IconColor = System.Drawing.Color.White;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.Location = new System.Drawing.Point(1153, 679);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(169, 58);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnDel.IconColor = System.Drawing.Color.White;
            this.btnDel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDel.Location = new System.Drawing.Point(1153, 745);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(169, 58);
            this.btnDel.TabIndex = 22;
            this.btnDel.Text = "Sil";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUndo.ForeColor = System.Drawing.Color.White;
            this.btnUndo.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnUndo.IconColor = System.Drawing.Color.White;
            this.btnUndo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUndo.Location = new System.Drawing.Point(957, 745);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(169, 58);
            this.btnUndo.TabIndex = 23;
            this.btnUndo.Text = "Değişikliği Geri Al";
            this.btnUndo.UseVisualStyleBackColor = false;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // ıconButtonfotografsec
            // 
            this.ıconButtonfotografsec.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ıconButtonfotografsec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButtonfotografsec.ForeColor = System.Drawing.Color.White;
            this.ıconButtonfotografsec.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ıconButtonfotografsec.IconColor = System.Drawing.Color.White;
            this.ıconButtonfotografsec.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButtonfotografsec.Location = new System.Drawing.Point(768, 745);
            this.ıconButtonfotografsec.Name = "ıconButtonfotografsec";
            this.ıconButtonfotografsec.Size = new System.Drawing.Size(169, 58);
            this.ıconButtonfotografsec.TabIndex = 25;
            this.ıconButtonfotografsec.Text = "Fotoğraf Seç";
            this.ıconButtonfotografsec.UseVisualStyleBackColor = false;
            this.ıconButtonfotografsec.Click += new System.EventHandler(this.ıconButtonfotografsec_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Kirpma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1360, 820);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ıconButtonfotografsec);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnCrop);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHeightEnd);
            this.Controls.Add(this.txtWidthEnd);
            this.Controls.Add(this.txtHeightStart);
            this.Controls.Add(this.txtWidthStart);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.afterPic);
            this.Controls.Add(this.beforePic);
            this.Name = "Kirpma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kirpma";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Kirpma_FormClosed);
            this.Load += new System.EventHandler(this.kirpma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.afterPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beforePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox afterPic;
        private FontAwesome.Sharp.IconPictureBox beforePic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtWidthStart;
        private System.Windows.Forms.TextBox txtHeightStart;
        private System.Windows.Forms.TextBox txtWidthEnd;
        private System.Windows.Forms.TextBox txtHeightEnd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private FontAwesome.Sharp.IconButton btnCrop;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnSave;
        private FontAwesome.Sharp.IconButton btnDel;
        private FontAwesome.Sharp.IconButton btnUndo;
        private IconButton ıconButtonfotografsec;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
