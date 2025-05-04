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
	enum RowState3
	{
		Existed,
		New,
		Modified,
		ModifiedNew,
		Deleted

	}
	public partial class Zakrip_chutac_za_Book_Form : Form
	{
		DataBase dataBase = new DataBase();

		int selectedRow;
		public Zakrip_chutac_za_Book_Form()
		{
			InitializeComponent();
			StartPosition = FormStartPosition.CenterScreen;
		}

		private void CreateColumns()
		{
			this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 15);
			this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 15);
			dataGridView1.Columns.Add("operation_id", "ID закріпу");
			dataGridView1.Columns.Add("reader_id", "ID читача");
			dataGridView1.Columns.Add("book_id", "ID книги");
			dataGridView1.Columns.Add("data_zakr", "Дата закріплення книги");
			dataGridView1.Columns.Add("IsNew", String.Empty);
			dataGridView1.Columns[4].Visible = false;

		}

		private void ClearFields()
		{
			textBox_id_zakripy.Text = "";
			textBox_id_chutaca2.Text = "";
			textBox_id_book2.Text = "";
			textBox_data_zak.Text = "";
		}
		private void ReadSingleRow(DataGridView dgw, IDataRecord record)
		{
			dgw.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetInt32(2), record.GetDateTime(3), RowState3.ModifiedNew);
		}

		private void RefreshDataGrid(DataGridView dgw)
		{
			dgw.Rows.Clear();

			string queryString = $"select * from Operation";
			SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

			dataBase.openConnection();

			SqlDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				ReadSingleRow(dgw, reader);
			}
			reader.Close();
		}
		private void Zakrip_chutac_za_Book_Form_Load(object sender, EventArgs e)
		{
			CreateColumns();
			RefreshDataGrid(dataGridView1);
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			Add_Form4 addfrm = new Add_Form4();
			addfrm.Show();
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			selectedRow = e.RowIndex;

			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = dataGridView1.Rows[selectedRow];

				textBox_id_zakripy.Text = row.Cells[0].Value.ToString();
				textBox_id_chutaca2.Text = row.Cells[1].Value.ToString();
				textBox_id_book2.Text = row.Cells[2].Value.ToString();
				textBox_data_zak.Text = row.Cells[3].Value.ToString();

			}
		}

		private void Search(DataGridView dgw)
		{
			dgw.Rows.Clear();

			string searchString = $"select * from Operation where concat (operation_id, reader_id, book_id, data_zakr) like '%" + textBox_search2.Text + "%'";

			SqlCommand com = new SqlCommand(searchString, dataBase.getConnection());

			dataBase.openConnection();

			SqlDataReader read = com.ExecuteReader();

			while (read.Read())
			{
				ReadSingleRow(dgw, read);
			}
			read.Close();
		}
		private void deleteRow()
		{
			int index = dataGridView1.CurrentCell.RowIndex;

			dataGridView1.Rows[index].Visible = false;

			if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
			{
				dataGridView1.Rows[index].Cells[4].Value = RowState.Deleted;
				return;
			}
			dataGridView1.Rows[index].Cells[4].Value = RowState.Deleted;
		}

		private void Update()
		{
			dataBase.openConnection();

			for (int index = 0; index < dataGridView1.Rows.Count; index++)
			{
				var rowState = (RowState)dataGridView1.Rows[index].Cells[4].Value;

				if (rowState == RowState.Existed)
					continue;

				if (rowState == RowState.Deleted)
				{
					var operation_id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
					var deleteQuery = $"delete from Operation where operation_id = {operation_id}";

					var command = new SqlCommand(deleteQuery, dataBase.getConnection());
					command.ExecuteNonQuery();
				}

				if (rowState == RowState.Modified)
				{
					var operation_id = dataGridView1.Rows[index].Cells[0].Value.ToString();
					var reader_id = dataGridView1.Rows[index].Cells[1].Value.ToString();
					var book_id = dataGridView1.Rows[index].Cells[2].Value.ToString();				
					var data_zakr = dataGridView1.Rows[index].Cells[3].Value.ToString();				

					var changeQuery = $"update Operation set reader_id = '{reader_id}', book_id = '{book_id}', data_zakr = '{data_zakr}' where operation_id = '{operation_id}'";

					var command = new SqlCommand(changeQuery, dataBase.getConnection());
					command.ExecuteNonQuery();
				}
			}
			dataBase.closeConnection();
		}

		private void btn_refrese_Click(object sender, EventArgs e)
		{
			RefreshDataGrid(dataGridView1);
			ClearFields();
		}

		private void textBox_search2_TextChanged(object sender, EventArgs e)
		{
			Search(dataGridView1);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			deleteRow();
		}

		private void btn_savee_Click(object sender, EventArgs e)
		{
			Update();
			ClearFields();
		}

		private void Change()
		{
			var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

			var operation_id = textBox_id_zakripy.Text;
			int reader_id ;
			var book_id = textBox_id_book2.Text;
			var data_zakr = textBox_data_zak.Text;


			if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
			{
				if (int.TryParse(textBox_id_chutaca2.Text, out reader_id))
				{


					dataGridView1.Rows[selectedRowIndex].SetValues(operation_id, reader_id, book_id, data_zakr);
					dataGridView1.Rows[selectedRowIndex].Cells[4].Value = RowState3.Modified;
				}
				else
				{
					MessageBox.Show("ID читача повинен мати числовий формат!");
				}
			}
		}

		private void btn_zminutu_Click(object sender, EventArgs e)
		{
			Change();
			ClearFields();
		}

		private void btn_cleare_Click(object sender, EventArgs e)
		{
			ClearFields();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
