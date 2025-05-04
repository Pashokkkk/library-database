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
	public partial class Add_Form2 : Form
	{
		DataBase dataBase = new DataBase();
		public Add_Form2()
		{
			InitializeComponent();
			StartPosition = FormStartPosition.CenterScreen;
		}

		private void Add_Form2_Load(object sender, EventArgs e)
		{

		}

		private void btnSave2_Click(object sender, EventArgs e)
		{
			dataBase.openConnection();

			var nameZala = textBox_nameZala2.Text;
			int mistkist;			

			if(int.TryParse(textBox_mistkist2.Text, out mistkist))
			{
				var addQuery = $"insert into Hall (hall_name, capacity) values ('{nameZala}', '{mistkist}')";
				var command = new SqlCommand(addQuery, dataBase.getConnection());
				command.ExecuteNonQuery();

				MessageBox.Show("Запис нової зали успішно створено!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				MessageBox.Show("Місткість залу повина бути числом!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}

			dataBase.closeConnection();
		}

		private void btnnClear2_Click(object sender, EventArgs e)
		{
			textBox_nameZala2.Text = "";
			textBox_mistkist2.Text = "";
		}
	}
}
