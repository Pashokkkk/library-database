
namespace Librarry
{
	partial class Zakrip_chutac_za_Book_Form
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox_id_zakripy = new System.Windows.Forms.TextBox();
			this.textBox_id_chutaca2 = new System.Windows.Forms.TextBox();
			this.textBox_id_book2 = new System.Windows.Forms.TextBox();
			this.btn_cleare = new System.Windows.Forms.PictureBox();
			this.btn_refrese = new System.Windows.Forms.PictureBox();
			this.btn_new_zapis = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.btn_zminutu = new System.Windows.Forms.Button();
			this.btn_savee = new System.Windows.Forms.Button();
			this.btn_searrche = new System.Windows.Forms.PictureBox();
			this.textBox_search2 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.textBox_data_zak = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btn_cleare)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btn_refrese)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btn_searrche)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(3, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(532, 36);
			this.label1.TabIndex = 0;
			this.label1.Text = "Книги які закріплені за читачами";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(28, 118);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(877, 150);
			this.dataGridView1.TabIndex = 1;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(140, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(150, 29);
			this.label2.TabIndex = 2;
			this.label2.Text = "ID закріпу :";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(140, 81);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(146, 29);
			this.label3.TabIndex = 3;
			this.label3.Text = "ID читача :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(140, 125);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(132, 29);
			this.label4.TabIndex = 4;
			this.label4.Text = "ID книги :";
			// 
			// textBox_id_zakripy
			// 
			this.textBox_id_zakripy.Location = new System.Drawing.Point(342, 45);
			this.textBox_id_zakripy.Name = "textBox_id_zakripy";
			this.textBox_id_zakripy.Size = new System.Drawing.Size(100, 22);
			this.textBox_id_zakripy.TabIndex = 5;
			// 
			// textBox_id_chutaca2
			// 
			this.textBox_id_chutaca2.Location = new System.Drawing.Point(342, 88);
			this.textBox_id_chutaca2.Name = "textBox_id_chutaca2";
			this.textBox_id_chutaca2.Size = new System.Drawing.Size(100, 22);
			this.textBox_id_chutaca2.TabIndex = 6;
			// 
			// textBox_id_book2
			// 
			this.textBox_id_book2.Location = new System.Drawing.Point(342, 132);
			this.textBox_id_book2.Name = "textBox_id_book2";
			this.textBox_id_book2.Size = new System.Drawing.Size(100, 22);
			this.textBox_id_book2.TabIndex = 7;
			// 
			// btn_cleare
			// 
			this.btn_cleare.Image = global::Librarry.Properties.Resources.eraser;
			this.btn_cleare.Location = new System.Drawing.Point(588, 16);
			this.btn_cleare.Name = "btn_cleare";
			this.btn_cleare.Size = new System.Drawing.Size(63, 51);
			this.btn_cleare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.btn_cleare.TabIndex = 8;
			this.btn_cleare.TabStop = false;
			this.btn_cleare.Click += new System.EventHandler(this.btn_cleare_Click);
			// 
			// btn_refrese
			// 
			this.btn_refrese.Image = global::Librarry.Properties.Resources.reload;
			this.btn_refrese.Location = new System.Drawing.Point(657, 17);
			this.btn_refrese.Name = "btn_refrese";
			this.btn_refrese.Size = new System.Drawing.Size(60, 51);
			this.btn_refrese.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.btn_refrese.TabIndex = 9;
			this.btn_refrese.TabStop = false;
			this.btn_refrese.Click += new System.EventHandler(this.btn_refrese_Click);
			// 
			// btn_new_zapis
			// 
			this.btn_new_zapis.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_new_zapis.Location = new System.Drawing.Point(59, 50);
			this.btn_new_zapis.Name = "btn_new_zapis";
			this.btn_new_zapis.Size = new System.Drawing.Size(223, 50);
			this.btn_new_zapis.TabIndex = 10;
			this.btn_new_zapis.Text = "Новий запис";
			this.btn_new_zapis.UseVisualStyleBackColor = true;
			this.btn_new_zapis.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button2.Location = new System.Drawing.Point(59, 106);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(223, 50);
			this.button2.TabIndex = 11;
			this.button2.Text = "Видалити";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// btn_zminutu
			// 
			this.btn_zminutu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_zminutu.Location = new System.Drawing.Point(59, 163);
			this.btn_zminutu.Name = "btn_zminutu";
			this.btn_zminutu.Size = new System.Drawing.Size(223, 50);
			this.btn_zminutu.TabIndex = 12;
			this.btn_zminutu.Text = "Змінити";
			this.btn_zminutu.UseVisualStyleBackColor = true;
			this.btn_zminutu.Click += new System.EventHandler(this.btn_zminutu_Click);
			// 
			// btn_savee
			// 
			this.btn_savee.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_savee.Location = new System.Drawing.Point(59, 219);
			this.btn_savee.Name = "btn_savee";
			this.btn_savee.Size = new System.Drawing.Size(223, 50);
			this.btn_savee.TabIndex = 13;
			this.btn_savee.Text = "Зберегти";
			this.btn_savee.UseVisualStyleBackColor = true;
			this.btn_savee.Click += new System.EventHandler(this.btn_savee_Click);
			// 
			// btn_searrche
			// 
			this.btn_searrche.Image = global::Librarry.Properties.Resources.loupe;
			this.btn_searrche.Location = new System.Drawing.Point(723, 18);
			this.btn_searrche.Name = "btn_searrche";
			this.btn_searrche.Size = new System.Drawing.Size(59, 50);
			this.btn_searrche.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.btn_searrche.TabIndex = 14;
			this.btn_searrche.TabStop = false;
			// 
			// textBox_search2
			// 
			this.textBox_search2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox_search2.Location = new System.Drawing.Point(797, 31);
			this.textBox_search2.Name = "textBox_search2";
			this.textBox_search2.Size = new System.Drawing.Size(100, 30);
			this.textBox_search2.TabIndex = 15;
			this.textBox_search2.TextChanged += new System.EventHandler(this.textBox_search2_TextChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(3, 13);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(337, 32);
			this.label5.TabIndex = 16;
			this.label5.Text = "Управління записами :";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btn_cleare);
			this.panel1.Controls.Add(this.textBox_search2);
			this.panel1.Controls.Add(this.btn_refrese);
			this.panel1.Controls.Add(this.btn_searrche);
			this.panel1.Location = new System.Drawing.Point(5, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(900, 100);
			this.panel1.TabIndex = 17;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btn_new_zapis);
			this.panel2.Controls.Add(this.button2);
			this.panel2.Controls.Add(this.btn_zminutu);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.btn_savee);
			this.panel2.Location = new System.Drawing.Point(560, 274);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(342, 283);
			this.panel2.TabIndex = 18;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.textBox_data_zak);
			this.panel3.Controls.Add(this.label6);
			this.panel3.Controls.Add(this.label19);
			this.panel3.Controls.Add(this.pictureBox6);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Controls.Add(this.label4);
			this.panel3.Controls.Add(this.textBox_id_zakripy);
			this.panel3.Controls.Add(this.textBox_id_chutaca2);
			this.panel3.Controls.Add(this.textBox_id_book2);
			this.panel3.Location = new System.Drawing.Point(14, 271);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(476, 294);
			this.panel3.TabIndex = 0;
			// 
			// textBox_data_zak
			// 
			this.textBox_data_zak.Location = new System.Drawing.Point(342, 173);
			this.textBox_data_zak.Name = "textBox_data_zak";
			this.textBox_data_zak.Size = new System.Drawing.Size(100, 22);
			this.textBox_data_zak.TabIndex = 27;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(140, 166);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(171, 29);
			this.label6.TabIndex = 26;
			this.label6.Text = "Дата закріп :";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label19.Location = new System.Drawing.Point(-2, 74);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(109, 29);
			this.label19.TabIndex = 25;
			this.label19.Text = " Запис :";
			// 
			// pictureBox6
			// 
			this.pictureBox6.Image = global::Librarry.Properties.Resources.notebook;
			this.pictureBox6.Location = new System.Drawing.Point(3, 3);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(67, 64);
			this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox6.TabIndex = 24;
			this.pictureBox6.TabStop = false;
			// 
			// Zakrip_chutac_za_Book_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(912, 555);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Zakrip_chutac_za_Book_Form";
			this.Load += new System.EventHandler(this.Zakrip_chutac_za_Book_Form_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btn_cleare)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btn_refrese)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btn_searrche)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox_id_zakripy;
		private System.Windows.Forms.TextBox textBox_id_chutaca2;
		private System.Windows.Forms.TextBox textBox_id_book2;
		private System.Windows.Forms.PictureBox btn_cleare;
		private System.Windows.Forms.PictureBox btn_refrese;
		private System.Windows.Forms.Button btn_new_zapis;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button btn_zminutu;
		private System.Windows.Forms.Button btn_savee;
		private System.Windows.Forms.PictureBox btn_searrche;
		private System.Windows.Forms.TextBox textBox_search2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.TextBox textBox_data_zak;
		private System.Windows.Forms.Label label6;
	}
}