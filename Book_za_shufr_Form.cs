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
	enum RowState1
	{
		Existed,
		New,
		Modified,
		ModifiedNew,
		Deleted

	}
	public partial class Book_za_shufr_Form : Form
	{
		DataBase dataBase = new DataBase();

		public Book_za_shufr_Form()
		{
			InitializeComponent();
			StartPosition = FormStartPosition.CenterScreen;
		}

		private void CreateColumns()
		{
			this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 15);
			this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 15);
			//dataGridView1.Columns.Add("book_id", "ID книги");
			dataGridView1.Columns.Add("book_title", "Назва книги");
			dataGridView1.Columns.Add("book_code", "Шифр книги");

			//dataGridView1.Columns.Add("IsNew", String.Empty);
		}
		private void ReadSingleRow(DataGridView dgw, IDataRecord record)
		{
			dgw.Rows.Add(record.GetString(0), record.GetString(1));//, RowState1.ModifiedNew);
		}

		private void Search(DataGridView dgw)
		{
			dgw.Rows.Clear();

			string searchString = $"SELECT book_title , book_code FROM Book WHERE book_title LIKE '%" + textBox_search_book.Text + "%' OR book_code LIKE '%" + textBox_search_book.Text + "%'";

			SqlCommand com = new SqlCommand(searchString, dataBase.getConnection());

			dataBase.openConnection();

			SqlDataReader read = com.ExecuteReader();

			while (read.Read())
			{
				ReadSingleRow(dgw, read);
			}
			read.Close();
		}
		private void Book_za_shufr_Form_Load(object sender, EventArgs e)
		{
			CreateColumns();
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			/*selectedRow = e.RowIndex;

			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = dataGridView1.Rows[selectedRow];

				textBox_id.Text = row.Cells[0].Value.ToString();
				textBox_namebook.Text = row.Cells[1].Value.ToString();
				textBox_autor.Text = row.Cells[2].Value.ToString();
				textBox_vudavnic.Text = row.Cells[3].Value.ToString();
				textBox_yearvidanya.Text = row.Cells[4].Value.ToString();
				textBox_kistekzemp.Text = row.Cells[5].Value.ToString();
				textBox_shufr.Text = row.Cells[6].Value.ToString();
				textBox_datazakrip.Text = row.Cells[7].Value.ToString();
			}*/
		}

		private void textBox_search_book_TextChanged(object sender, EventArgs e)
		{
			Search(dataGridView1);
		}
	}
}
