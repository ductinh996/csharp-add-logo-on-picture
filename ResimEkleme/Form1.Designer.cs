namespace ResimEkleme
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PreviewPanel = new System.Windows.Forms.Panel();
            this.PreviewPicturebox = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.epWaterMark = new System.Windows.Forms.ErrorProvider(this.components);
            this.openDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.odEklenecekLogo = new System.Windows.Forms.OpenFileDialog();
            this.btnEkleneceklogo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbSolUst = new System.Windows.Forms.RadioButton();
            this.rdbSagUst = new System.Windows.Forms.RadioButton();
            this.rdbSolAlt = new System.Windows.Forms.RadioButton();
            this.rdbSagAlt = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYukseklik = new System.Windows.Forms.TextBox();
            this.txtGenislik = new System.Windows.Forms.TextBox();
            this.btnOnizleme = new System.Windows.Forms.Button();
            this.btnSifirla = new System.Windows.Forms.Button();
            this.PreviewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewPicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWaterMark)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PreviewPanel
            // 
            this.PreviewPanel.Controls.Add(this.btnSifirla);
            this.PreviewPanel.Controls.Add(this.btnOnizleme);
            this.PreviewPanel.Controls.Add(this.PreviewPicturebox);
            this.PreviewPanel.Location = new System.Drawing.Point(12, 12);
            this.PreviewPanel.Name = "PreviewPanel";
            this.PreviewPanel.Size = new System.Drawing.Size(760, 457);
            this.PreviewPanel.TabIndex = 0;
            // 
            // PreviewPicturebox
            // 
            this.PreviewPicturebox.Location = new System.Drawing.Point(0, 0);
            this.PreviewPicturebox.Name = "PreviewPicturebox";
            this.PreviewPicturebox.Size = new System.Drawing.Size(760, 457);
            this.PreviewPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PreviewPicturebox.TabIndex = 0;
            this.PreviewPicturebox.TabStop = false;
            this.PreviewPicturebox.Click += new System.EventHandler(this.PreviewPicturebox_Click);
            this.PreviewPicturebox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PreviewPicturebox_MouseDown);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(12, 479);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(114, 24);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Kullanılacak Resim";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(252, 480);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // epWaterMark
            // 
            this.epWaterMark.ContainerControl = this;
            // 
            // openDialog
            // 
            this.openDialog.FileName = "openFileDialog1";
            // 
            // odEklenecekLogo
            // 
            this.odEklenecekLogo.FileName = "openFileDialog1";
            // 
            // btnEkleneceklogo
            // 
            this.btnEkleneceklogo.Enabled = false;
            this.btnEkleneceklogo.Location = new System.Drawing.Point(132, 480);
            this.btnEkleneceklogo.Name = "btnEkleneceklogo";
            this.btnEkleneceklogo.Size = new System.Drawing.Size(114, 23);
            this.btnEkleneceklogo.TabIndex = 4;
            this.btnEkleneceklogo.Text = "Eklenecek Logo";
            this.btnEkleneceklogo.UseVisualStyleBackColor = true;
            this.btnEkleneceklogo.Click += new System.EventHandler(this.btnEkleneceklogo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbSolUst);
            this.groupBox1.Controls.Add(this.rdbSagUst);
            this.groupBox1.Controls.Add(this.rdbSolAlt);
            this.groupBox1.Controls.Add(this.rdbSagAlt);
            this.groupBox1.Location = new System.Drawing.Point(629, 475);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 75);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Logo Konumu";
            // 
            // rdbSolUst
            // 
            this.rdbSolUst.AutoSize = true;
            this.rdbSolUst.Location = new System.Drawing.Point(12, 45);
            this.rdbSolUst.Name = "rdbSolUst";
            this.rdbSolUst.Size = new System.Drawing.Size(59, 17);
            this.rdbSolUst.TabIndex = 3;
            this.rdbSolUst.TabStop = true;
            this.rdbSolUst.Text = "Sol Üst";
            this.rdbSolUst.UseVisualStyleBackColor = true;
            // 
            // rdbSagUst
            // 
            this.rdbSagUst.AutoSize = true;
            this.rdbSagUst.Location = new System.Drawing.Point(73, 45);
            this.rdbSagUst.Name = "rdbSagUst";
            this.rdbSagUst.Size = new System.Drawing.Size(63, 17);
            this.rdbSagUst.TabIndex = 2;
            this.rdbSagUst.TabStop = true;
            this.rdbSagUst.Text = "Sağ Üst";
            this.rdbSagUst.UseVisualStyleBackColor = true;
            // 
            // rdbSolAlt
            // 
            this.rdbSolAlt.AutoSize = true;
            this.rdbSolAlt.Location = new System.Drawing.Point(12, 22);
            this.rdbSolAlt.Name = "rdbSolAlt";
            this.rdbSolAlt.Size = new System.Drawing.Size(55, 17);
            this.rdbSolAlt.TabIndex = 1;
            this.rdbSolAlt.TabStop = true;
            this.rdbSolAlt.Text = "Sol Alt";
            this.rdbSolAlt.UseVisualStyleBackColor = true;
            // 
            // rdbSagAlt
            // 
            this.rdbSagAlt.AutoSize = true;
            this.rdbSagAlt.Location = new System.Drawing.Point(73, 22);
            this.rdbSagAlt.Name = "rdbSagAlt";
            this.rdbSagAlt.Size = new System.Drawing.Size(59, 17);
            this.rdbSagAlt.TabIndex = 0;
            this.rdbSagAlt.TabStop = true;
            this.rdbSagAlt.Text = "Sağ Alt";
            this.rdbSagAlt.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pcbLogo);
            this.groupBox2.Location = new System.Drawing.Point(372, 475);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 75);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Logo";
            // 
            // pcbLogo
            // 
            this.pcbLogo.Location = new System.Drawing.Point(6, 16);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(239, 52);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLogo.TabIndex = 0;
            this.pcbLogo.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtYukseklik);
            this.groupBox3.Controls.Add(this.txtGenislik);
            this.groupBox3.Location = new System.Drawing.Point(12, 509);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(354, 41);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Logo Yükseklik/Genişlik (Varsayılan: 200 x 54 px)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yükseklik :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Genişlik :";
            // 
            // txtYukseklik
            // 
            this.txtYukseklik.Location = new System.Drawing.Point(250, 16);
            this.txtYukseklik.Name = "txtYukseklik";
            this.txtYukseklik.Size = new System.Drawing.Size(98, 20);
            this.txtYukseklik.TabIndex = 1;
            this.txtYukseklik.Text = "54";
            this.txtYukseklik.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGenislik
            // 
            this.txtGenislik.Location = new System.Drawing.Point(62, 16);
            this.txtGenislik.Name = "txtGenislik";
            this.txtGenislik.Size = new System.Drawing.Size(98, 20);
            this.txtGenislik.TabIndex = 0;
            this.txtGenislik.Text = "200";
            this.txtGenislik.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnOnizleme
            // 
            this.btnOnizleme.Enabled = false;
            this.btnOnizleme.Location = new System.Drawing.Point(3, 431);
            this.btnOnizleme.Name = "btnOnizleme";
            this.btnOnizleme.Size = new System.Drawing.Size(75, 23);
            this.btnOnizleme.TabIndex = 3;
            this.btnOnizleme.Text = "Önizleme";
            this.btnOnizleme.UseVisualStyleBackColor = true;
            this.btnOnizleme.Click += new System.EventHandler(this.btnOnizleme_Click);
            // 
            // btnSifirla
            // 
            this.btnSifirla.Enabled = false;
            this.btnSifirla.Location = new System.Drawing.Point(84, 431);
            this.btnSifirla.Name = "btnSifirla";
            this.btnSifirla.Size = new System.Drawing.Size(75, 23);
            this.btnSifirla.TabIndex = 4;
            this.btnSifirla.Text = "Sıfırla";
            this.btnSifirla.UseVisualStyleBackColor = true;
            this.btnSifirla.Click += new System.EventHandler(this.btnSifirla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEkleneceklogo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.PreviewPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Logo on Picture - v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PreviewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PreviewPicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWaterMark)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PreviewPanel;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider epWaterMark;
        private System.Windows.Forms.OpenFileDialog openDialog;
        private System.Windows.Forms.SaveFileDialog saveDialog;
        private System.Windows.Forms.OpenFileDialog odEklenecekLogo;
        private System.Windows.Forms.Button btnEkleneceklogo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbSolUst;
        private System.Windows.Forms.RadioButton rdbSagUst;
        private System.Windows.Forms.RadioButton rdbSolAlt;
        private System.Windows.Forms.RadioButton rdbSagAlt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYukseklik;
        private System.Windows.Forms.TextBox txtGenislik;
        private System.Windows.Forms.PictureBox PreviewPicturebox;
        private System.Windows.Forms.Button btnOnizleme;
        private System.Windows.Forms.Button btnSifirla;

    }
}

