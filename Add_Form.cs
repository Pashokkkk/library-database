using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Librarry
{
	public partial class Add_Form : Form
	{
		DataBase dataBase = new DataBase();
		public Add_Form()
		{
			InitializeComponent();
			StartPosition = FormStartPosition.CenterScreen;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			dataBase.openConnection();

			var nameBook = textBox_namebook.Text;
			var autor = textBox_autor.Text;
			var vudavnuctvo = textBox_vudavnic.Text;
			var yearVidanya = textBox_yearvidanya.Text;
			var kistEkzemp = textBox_kistekzemp.Text;
			var shufr = textBox_shufr.Text;
			var dataZak = textBox_datazakrip.Text;

			var addQuery = $"insert into Book (book_title, author, publisher, publication_year, copies_in_library, book_code, date_checked_out) values ('{nameBook}', '{autor}', '{vudavnuctvo}', '{yearVidanya}', '{kistEkzemp}', '{shufr}', '{dataZak}')";
			var command = new SqlCommand(addQuery, dataBase.getConnection());
			command.ExecuteNonQuery();

			MessageBox.Show("Запис книги успішно створена!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

			dataBase.closeConnection();
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			textBox_namebook.Text = "";
			textBox_autor.Text = "";
			textBox_vudavnic.Text = "";
			textBox_yearvidanya.Text = "";
			textBox_kistekzemp.Text = "";
			textBox_shufr.Text = "";
			textBox_datazakrip.Text = "";

		}

		private void Add_Form_Load(object sender, EventArgs e)
		{

		}
	}
}
