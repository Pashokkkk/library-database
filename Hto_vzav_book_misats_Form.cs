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
	public partial class Hto_vzav_book_misats_Form : Form
	{
		DataBase dataBase = new DataBase();
		public Hto_vzav_book_misats_Form()
		{
			InitializeComponent();
			StartPosition = FormStartPosition.CenterScreen;
		}

		private void CreateColumns()
		{
			this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 15);
			this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 15);
			//dataGridView1.Columns.Add("book_id", "ID книги");
			dataGridView1.Columns.Add("name_chut", "Прізвище читача");
			dataGridView1.Columns.Add("name_bok", "Назва книги");
			dataGridView1.Columns.Add("data_zak", "Дата закріплення");
			
			//dataGridView1.Columns.Add("IsNew", String.Empty);
		}

		private void ReadSingleRow(DataGridView dgw, IDataRecord record)
		{
			dgw.Rows.Add(record.GetString(0), record.GetString(1), record.GetDateTime(2));//, RowState1.ModifiedNew);
		}

		private void RefreshDataGrid(DataGridView dgw)
		{
			dgw.Rows.Clear();

			string queryString = $"select * from Who_z_chut";
			SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

			dataBase.openConnection();

			SqlDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				ReadSingleRow(dgw, reader);
			}
			reader.Close();
		}
		private void Hto_vzav_book_misats_Form_Load(object sender, EventArgs e)
		{
			CreateColumns();
			RefreshDataGrid(dataGridView1);
		}
	}
}
