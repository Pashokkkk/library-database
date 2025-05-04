
namespace Librarry
{
	partial class Add_Form
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnZnakOkliku = new System.Windows.Forms.PictureBox();
			this.btnClear = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.textBox_namebook = new System.Windows.Forms.TextBox();
			this.textBox_autor = new System.Windows.Forms.TextBox();
			this.textBox_vudavnic = new System.Windows.Forms.TextBox();
			this.textBox_yearvidanya = new System.Windows.Forms.TextBox();
			this.textBox_kistekzemp = new System.Windows.Forms.TextBox();
			this.textBox_shufr = new System.Windows.Forms.TextBox();
			this.textBox_datazakrip = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnZnakOkliku)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnClear)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnZnakOkliku);
			this.panel1.Controls.Add(this.btnClear);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(141, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(647, 108);
			this.panel1.TabIndex = 1;
			// 
			// btnZnakOkliku
			// 
			this.btnZnakOkliku.Image = global::Librarry.Properties.Resources.information;
			this.btnZnakOkliku.Location = new System.Drawing.Point(461, 28);
			this.btnZnakOkliku.Name = "btnZnakOkliku";
			this.btnZnakOkliku.Size = new System.Drawing.Size(59, 56);
			this.btnZnakOkliku.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.btnZnakOkliku.TabIndex = 2;
			this.btnZnakOkliku.TabStop = false;
			// 
			// btnClear
			// 
			this.btnClear.Image = global::Librarry.Properties.Resources.eraser;
			this.btnClear.Location = new System.Drawing.Point(548, 28);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(64, 56);
			this.btnClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.btnClear.TabIndex = 2;
			this.btnClear.TabStop = false;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(408, 72);
			this.label1.TabIndex = 0;
			this.label1.Text = "\r\nСтворення запису книги :";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Librarry.Properties.Resources.profile;
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(105, 108);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(90, 176);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(181, 29);
			this.label2.TabIndex = 2;
			this.label2.Text = "Назва книги :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(90, 205);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 29);
			this.label3.TabIndex = 3;
			this.label3.Text = "Автор :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(90, 245);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(193, 29);
			this.label4.TabIndex = 4;
			this.label4.Text = "Видавництво :";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(90, 283);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(177, 29);
			this.label5.TabIndex = 5;
			this.label5.Text = "Рік видання :";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(90, 323);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(293, 29);
			this.label6.TabIndex = 6;
			this.label6.Text = "Кількість екземплярів";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(90, 363);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(164, 29);
			this.label7.TabIndex = 7;
			this.label7.Text = "Шифр книги";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label8.Location = new System.Drawing.Point(90, 401);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(249, 29);
			this.label8.TabIndex = 8;
			this.label8.Text = "Дата закріплення :";
			// 
			// textBox_namebook
			// 
			this.textBox_namebook.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox_namebook.Location = new System.Drawing.Point(427, 160);
			this.textBox_namebook.Name = "textBox_namebook";
			this.textBox_namebook.Size = new System.Drawing.Size(100, 34);
			this.textBox_namebook.TabIndex = 9;
			// 
			// textBox_autor
			// 
			this.textBox_autor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox_autor.Location = new System.Drawing.Point(427, 200);
			this.textBox_autor.Name = "textBox_autor";
			this.textBox_autor.Size = new System.Drawing.Size(100, 34);
			this.textBox_autor.TabIndex = 10;
			// 
			// textBox_vudavnic
			// 
			this.textBox_vudavnic.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox_vudavnic.Location = new System.Drawing.Point(427, 240);
			this.textBox_vudavnic.Name = "textBox_vudavnic";
			this.textBox_vudavnic.Size = new System.Drawing.Size(100, 34);
			this.textBox_vudavnic.TabIndex = 11;
			// 
			// textBox_yearvidanya
			// 
			this.textBox_yearvidanya.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox_yearvidanya.Location = new System.Drawing.Point(427, 278);
			this.textBox_yearvidanya.Name = "textBox_yearvidanya";
			this.textBox_yearvidanya.Size = new System.Drawing.Size(100, 34);
			this.textBox_yearvidanya.TabIndex = 12;
			// 
			// textBox_kistekzemp
			// 
			this.textBox_kistekzemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox_kistekzemp.Location = new System.Drawing.Point(427, 318);
			this.textBox_kistekzemp.Name = "textBox_kistekzemp";
			this.textBox_kistekzemp.Size = new System.Drawing.Size(100, 34);
			this.textBox_kistekzemp.TabIndex = 13;
			// 
			// textBox_shufr
			// 
			this.textBox_shufr.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox_shufr.Location = new System.Drawing.Point(427, 358);
			this.textBox_shufr.Name = "textBox_shufr";
			this.textBox_shufr.Size = new System.Drawing.Size(100, 34);
			this.textBox_shufr.TabIndex = 14;
			// 
			// textBox_datazakrip
			// 
			this.textBox_datazakrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox_datazakrip.Location = new System.Drawing.Point(427, 396);
			this.textBox_datazakrip.Name = "textBox_datazakrip";
			this.textBox_datazakrip.Size = new System.Drawing.Size(100, 34);
			this.textBox_datazakrip.TabIndex = 15;
			// 
			// btnSave
			// 
			this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnSave.Location = new System.Drawing.Point(298, 454);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(169, 53);
			this.btnSave.TabIndex = 16;
			this.btnSave.Text = "Зберегти";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// Add_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(764, 537);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.textBox_datazakrip);
			this.Controls.Add(this.textBox_shufr);
			this.Controls.Add(this.textBox_kistekzemp);
			this.Controls.Add(this.textBox_yearvidanya);
			this.Controls.Add(this.textBox_vudavnic);
			this.Controls.Add(this.textBox_autor);
			this.Controls.Add(this.textBox_namebook);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Add_Form";
			this.Load += new System.EventHandler(this.Add_Form_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnZnakOkliku)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnClear)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox btnZnakOkliku;
		private System.Windows.Forms.PictureBox btnClear;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBox_namebook;
		private System.Windows.Forms.TextBox textBox_autor;
		private System.Windows.Forms.TextBox textBox_vudavnic;
		private System.Windows.Forms.TextBox textBox_yearvidanya;
		private System.Windows.Forms.TextBox textBox_kistekzemp;
		private System.Windows.Forms.TextBox textBox_shufr;
		private System.Windows.Forms.TextBox textBox_datazakrip;
		private System.Windows.Forms.Button btnSave;
	}
}