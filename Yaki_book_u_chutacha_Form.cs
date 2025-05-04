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
	enum RowState2
	{
		Existed,
		New,
		Modified,
		ModifiedNew,
		Deleted

	}
	public partial class Yaki_book_u_chutacha_Form : Form
	{
		DataBase dataBase = new DataBase();
		public Yaki_book_u_chutacha_Form()
		{
			InitializeComponent();
			StartPosition = FormStartPosition.CenterScreen;
		}

		private void CreateColumns()
		{
			this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 15);
			this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 15);
	
			dataGridView1.Columns.Add("name_chut", "Прізвище читача");
			dataGridView1.Columns.Add("name_bok1", "Книга №1");
			dataGridView1.Columns.Add("name_bok2", "Книга №2");
			dataGridView1.Columns.Add("name_bok3", "Книга №3");
			dataGridView1.Columns.Add("name_bok4", "Книга №4");
			dataGridView1.Columns.Add("name_bok5", "Книга №5");
			dataGridView1.Columns.Add("name_bok6", "Книга №6");

			//dataGridView1.Columns.Add("IsNew", String.Empty);
		}

		private void ReadSingleRow(DataGridView dgw, IDataRecord record)
		{
			dgw.Rows.Add(record.GetString(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetString(5), record.GetString(6));//, RowState1.ModifiedNew);
		}

		private void Search(DataGridView dgw)
		{
			dgw.Rows.Clear();

			string searchString = $"SELECT name_chut , name_bok1 , name_bok2 , name_bok3 , name_bok4 , name_bok5 , name_bok6 FROM Yaki_book_u_chutachiv WHERE name_chut LIKE '%" + textBox_search_book.Text + "%' OR name_bok1 LIKE '%" + textBox_search_book.Text + "%'";

			SqlCommand com = new SqlCommand(searchString, dataBase.getConnection());

			dataBase.openConnection();

			SqlDataReader read = com.ExecuteReader();

			while (read.Read())
			{
				ReadSingleRow(dgw, read);
			}
			read.Close();
		}

		private void Yaki_book_u_chutacha_Form_Load(object sender, EventArgs e)
		{
			CreateColumns();
		}

		private void textBox_search_book_TextChanged(object sender, EventArgs e)
		{
			Search(dataGridView1);
		}
	}
}
