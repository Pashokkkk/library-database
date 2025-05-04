
namespace Librarry
{
	partial class Add_Form3
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
			this.pictureBox_cleree = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.textBox_num_chut_kvutka = new System.Windows.Forms.TextBox();
			this.textBox_prizvuche = new System.Windows.Forms.TextBox();
			this.textBox_num_pasport = new System.Windows.Forms.TextBox();
			this.textBox_data_narod = new System.Windows.Forms.TextBox();
			this.textBox_adressa = new System.Windows.Forms.TextBox();
			this.textBox_num_telefonu = new System.Windows.Forms.TextBox();
			this.textBox_osvita = new System.Windows.Forms.TextBox();
			this.textBox_data_zap_bibliot = new System.Windows.Forms.TextBox();
			this.btn_save33 = new System.Windows.Forms.Button();
			this.textBox_id_zally2 = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_cleree)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.pictureBox_cleree);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(133, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(655, 118);
			this.panel1.TabIndex = 0;
			// 
			// pictureBox_cleree
			// 
			this.pictureBox_cleree.Image = global::Librarry.Properties.Resources.eraser;
			this.pictureBox_cleree.Location = new System.Drawing.Point(560, 25);
			this.pictureBox_cleree.Name = "pictureBox_cleree";
			this.pictureBox_cleree.Size = new System.Drawing.Size(60, 58);
			this.pictureBox_cleree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox_cleree.TabIndex = 2;
			this.pictureBox_cleree.TabStop = false;
			this.pictureBox_cleree.Click += new System.EventHandler(this.pictureBox_cleree_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Librarry.Properties.Resources.information;
			this.pictureBox1.Location = new System.Drawing.Point(472, 25);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(68, 58);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(12, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(409, 36);
			this.label1.TabIndex = 0;
			this.label1.Text = "Створення нового читача";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(146, 129);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(257, 29);
			this.label2.TabIndex = 1;
			this.label2.Text = "Номер чит. квитка :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(146, 169);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(147, 29);
			this.label3.TabIndex = 2;
			this.label3.Text = "Прізвище :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(146, 209);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(232, 29);
			this.label4.TabIndex = 3;
			this.label4.Text = "Номер паспорта :";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(146, 249);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(248, 29);
			this.label5.TabIndex = 4;
			this.label5.Text = "Дата народження :";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(146, 289);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(115, 29);
			this.label6.TabIndex = 5;
			this.label6.Text = "Адреса :";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(146, 329);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(237, 29);
			this.label7.TabIndex = 6;
			this.label7.Text = "Номер телефону :";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label8.Location = new System.Drawing.Point(146, 370);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(108, 29);
			this.label8.TabIndex = 7;
			this.label8.Text = "Освіта :";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label9.Location = new System.Drawing.Point(146, 410);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(291, 29);
			this.label9.TabIndex = 8;
			this.label9.Text = "Дата запису у бібліот :";
			// 
			// textBox_num_chut_kvutka
			// 
			this.textBox_num_chut_kvutka.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox_num_chut_kvutka.Location = new System.Drawing.Point(514, 124);
			this.textBox_num_chut_kvutka.Name = "textBox_num_chut_kvutka";
			this.textBox_num_chut_kvutka.Size = new System.Drawing.Size(100, 34);
			this.textBox_num_chut_kvutka.TabIndex = 9;
			// 
			// textBox_prizvuche
			// 
			this.textBox_prizvuche.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox_prizvuche.Location = new System.Drawing.Point(514, 164);
			this.textBox_prizvuche.Name = "textBox_prizvuche";
			this.textBox_prizvuche.Size = new System.Drawing.Size(100, 34);
			this.textBox_prizvuche.TabIndex = 10;
			// 
			// textBox_num_pasport
			// 
			this.textBox_num_pasport.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox_num_pasport.Location = new System.Drawing.Point(514, 204);
			this.textBox_num_pasport.Name = "textBox_num_pasport";
			this.textBox_num_pasport.Size = new System.Drawing.Size(100, 34);
			this.textBox_num_pasport.TabIndex = 11;
			// 
			// textBox_data_narod
			// 
			this.textBox_data_narod.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox_data_narod.Location = new System.Drawing.Point(514, 244);
			this.textBox_data_narod.Name = "textBox_data_narod";
			this.textBox_data_narod.Size = new System.Drawing.Size(100, 34);
			this.textBox_data_narod.TabIndex = 12;
			// 
			// textBox_adressa
			// 
			this.textBox_adressa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox_adressa.Location = new System.Drawing.Point(514, 284);
			this.textBox_adressa.Name = "textBox_adressa";
			this.textBox_adressa.Size = new System.Drawing.Size(100, 34);
			this.textBox_adressa.TabIndex = 13;
			// 
			// textBox_num_telefonu
			// 
			this.textBox_num_telefonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox_num_telefonu.Location = new System.Drawing.Point(514, 324);
			this.textBox_num_telefonu.Name = "textBox_num_telefonu";
			this.textBox_num_telefonu.Size = new System.Drawing.Size(100, 34);
			this.textBox_num_telefonu.TabIndex = 14;
			// 
			// textBox_osvita
			// 
			this.textBox_osvita.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox_osvita.Location = new System.Drawing.Point(514, 365);
			this.textBox_osvita.Name = "textBox_osvita";
			this.textBox_osvita.Size = new System.Drawing.Size(100, 34);
			this.textBox_osvita.TabIndex = 15;
			// 
			// textBox_data_zap_bibliot
			// 
			this.textBox_data_zap_bibliot.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox_data_zap_bibliot.Location = new System.Drawing.Point(514, 405);
			this.textBox_data_zap_bibliot.Name = "textBox_data_zap_bibliot";
			this.textBox_data_zap_bibliot.Size = new System.Drawing.Size(100, 34);
			this.textBox_data_zap_bibliot.TabIndex = 16;
			// 
			// btn_save33
			// 
			this.btn_save33.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_save33.Location = new System.Drawing.Point(300, 496);
			this.btn_save33.Name = "btn_save33";
			this.btn_save33.Size = new System.Drawing.Size(215, 57);
			this.btn_save33.TabIndex = 3;
			this.btn_save33.Text = "Зберегти";
			this.btn_save33.UseVisualStyleBackColor = true;
			this.btn_save33.Click += new System.EventHandler(this.btn_save33_Click);
			// 
			// textBox_id_zally2
			// 
			this.textBox_id_zally2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox_id_zally2.Location = new System.Drawing.Point(514, 445);
			this.textBox_id_zally2.Name = "textBox_id_zally2";
			this.textBox_id_zally2.Size = new System.Drawing.Size(100, 34);
			this.textBox_id_zally2.TabIndex = 17;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label10.Location = new System.Drawing.Point(146, 450);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(115, 29);
			this.label10.TabIndex = 3;
			this.label10.Text = "ID залу :";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::Librarry.Properties.Resources.profile;
			this.pictureBox2.Location = new System.Drawing.Point(12, 12);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(105, 108);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 18;
			this.pictureBox2.TabStop = false;
			// 
			// Add_Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(765, 565);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.textBox_id_zally2);
			this.Controls.Add(this.btn_save33);
			this.Controls.Add(this.textBox_data_zap_bibliot);
			this.Controls.Add(this.textBox_osvita);
			this.Controls.Add(this.textBox_num_telefonu);
			this.Controls.Add(this.textBox_adressa);
			this.Controls.Add(this.textBox_data_narod);
			this.Controls.Add(this.textBox_num_pasport);
			this.Controls.Add(this.textBox_prizvuche);
			this.Controls.Add(this.textBox_num_chut_kvutka);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel1);
			this.Name = "Add_Form3";
			this.Load += new System.EventHandler(this.Add_Form3_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_cleree)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox_cleree;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textBox_num_chut_kvutka;
		private System.Windows.Forms.TextBox textBox_prizvuche;
		private System.Windows.Forms.TextBox textBox_num_pasport;
		private System.Windows.Forms.TextBox textBox_data_narod;
		private System.Windows.Forms.TextBox textBox_adressa;
		private System.Windows.Forms.TextBox textBox_num_telefonu;
		private System.Windows.Forms.TextBox textBox_osvita;
		private System.Windows.Forms.TextBox textBox_data_zap_bibliot;
		private System.Windows.Forms.Button btn_save33;
		private System.Windows.Forms.TextBox textBox_id_zally2;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.PictureBox pictureBox2;
	}
}