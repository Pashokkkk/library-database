
namespace Librarry
{
	partial class Add_Form4
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox_ID_chutaca = new System.Windows.Forms.TextBox();
			this.textBox_ID_book = new System.Windows.Forms.TextBox();
			this.button_savee = new System.Windows.Forms.Button();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox_data_zakri = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(3, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(538, 36);
			this.label1.TabIndex = 0;
			this.label1.Text = "Додавання нової книги до читача";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Librarry.Properties.Resources.eraser;
			this.pictureBox1.Location = new System.Drawing.Point(562, 19);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(63, 51);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(118, 160);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(146, 29);
			this.label2.TabIndex = 2;
			this.label2.Text = "ID читача :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(118, 217);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(132, 29);
			this.label3.TabIndex = 3;
			this.label3.Text = "ID книги :";
			// 
			// textBox_ID_chutaca
			// 
			this.textBox_ID_chutaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox_ID_chutaca.Location = new System.Drawing.Point(305, 159);
			this.textBox_ID_chutaca.Name = "textBox_ID_chutaca";
			this.textBox_ID_chutaca.Size = new System.Drawing.Size(100, 30);
			this.textBox_ID_chutaca.TabIndex = 4;
			// 
			// textBox_ID_book
			// 
			this.textBox_ID_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox_ID_book.Location = new System.Drawing.Point(305, 216);
			this.textBox_ID_book.Name = "textBox_ID_book";
			this.textBox_ID_book.Size = new System.Drawing.Size(100, 30);
			this.textBox_ID_book.TabIndex = 5;
			// 
			// button_savee
			// 
			this.button_savee.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_savee.Location = new System.Drawing.Point(294, 342);
			this.button_savee.Name = "button_savee";
			this.button_savee.Size = new System.Drawing.Size(180, 47);
			this.button_savee.TabIndex = 6;
			this.button_savee.Text = "Зберегти";
			this.button_savee.UseVisualStyleBackColor = true;
			this.button_savee.Click += new System.EventHandler(this.button_savee_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::Librarry.Properties.Resources.profile;
			this.pictureBox2.Location = new System.Drawing.Point(12, 12);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(105, 108);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 7;
			this.pictureBox2.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Location = new System.Drawing.Point(123, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(639, 108);
			this.panel1.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(118, 278);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(171, 29);
			this.label4.TabIndex = 9;
			this.label4.Text = "Дата закріп :";
			// 
			// textBox_data_zakri
			// 
			this.textBox_data_zakri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox_data_zakri.Location = new System.Drawing.Point(305, 277);
			this.textBox_data_zakri.Name = "textBox_data_zakri";
			this.textBox_data_zakri.Size = new System.Drawing.Size(100, 30);
			this.textBox_data_zakri.TabIndex = 10;
			// 
			// Add_Form4
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(763, 443);
			this.Controls.Add(this.textBox_data_zakri);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.button_savee);
			this.Controls.Add(this.textBox_ID_book);
			this.Controls.Add(this.textBox_ID_chutaca);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Name = "Add_Form4";
			this.Load += new System.EventHandler(this.Add_Form4_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox_ID_chutaca;
		private System.Windows.Forms.TextBox textBox_ID_book;
		private System.Windows.Forms.Button button_savee;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox_data_zakri;
	}
}