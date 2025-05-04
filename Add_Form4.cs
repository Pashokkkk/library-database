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
	public partial class Add_Form4 : Form
	{
		DataBase dataBase = new DataBase();
		public Add_Form4()
		{
			InitializeComponent();
			StartPosition = FormStartPosition.CenterScreen;
		}

		private void Add_Form4_Load(object sender, EventArgs e)
		{

		}

		private void button_savee_Click(object sender, EventArgs e)
		{
			dataBase.openConnection();

			int id_chutacha;
			var id_knuhu = textBox_ID_book.Text;
			var data_zak = textBox_data_zakri.Text;


			if (int.TryParse(textBox_ID_chutaca.Text, out id_chutacha))
			{
				var addQuery = $"insert into Operation (reader_id, book_id, data_zakr) values ('{id_chutacha}', '{id_knuhu}', '{data_zak}')";
				var command = new SqlCommand(addQuery, dataBase.getConnection());
				command.ExecuteNonQuery();

				MessageBox.Show("Закріплення нової книги до читача успішно створено!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				MessageBox.Show("ID читача повинно бути числом!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}

			dataBase.closeConnection();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			textBox_ID_chutaca.Text = "";
			textBox_ID_book.Text = "";
			textBox_data_zakri.Text = "";
		}
	}
}
