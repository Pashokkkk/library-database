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
	public partial class Add_Form3 : Form
	{
		DataBase dataBase = new DataBase();
		public Add_Form3()
		{
			InitializeComponent();
			StartPosition = FormStartPosition.CenterScreen;
		}

		private void Add_Form3_Load(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void btn_save33_Click(object sender, EventArgs e)
		{
			dataBase.openConnection();

			var num_chut_kvt = textBox_num_chut_kvutka.Text;
			var prizvuche = textBox_prizvuche.Text;
			var num_pasport = textBox_num_pasport.Text;
			var dataNarodz = textBox_data_narod.Text;
			var adressa = textBox_adressa.Text;
			int telefon_num;
			var osvita = textBox_osvita.Text;
			var dataZakBibliot = textBox_data_zap_bibliot.Text;
			var id_zaly = textBox_id_zally2.Text;

			if (int.TryParse(textBox_num_telefonu.Text, out telefon_num))
			{
				var addQuery = $"insert into Reader (library_card_number, last_name, passport_number, date_of_birth, addres, phone_number, education, has_degree, hall_id) values ('{num_chut_kvt}', '{prizvuche}', '{num_pasport}', '{dataNarodz}', '{adressa}', '{telefon_num}', '{osvita}', '{dataZakBibliot}', '{id_zaly}')";
				var command = new SqlCommand(addQuery, dataBase.getConnection());
				command.ExecuteNonQuery();

				MessageBox.Show("Запис нового читача успішно створено!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				MessageBox.Show("Номер телефону повинен бути числом!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}

			dataBase.closeConnection();
		}

		private void pictureBox_cleree_Click(object sender, EventArgs e)
		{
			textBox_num_chut_kvutka.Text = "";
			textBox_prizvuche.Text = "";
			textBox_num_pasport.Text = "";
			textBox_data_narod.Text = "";
			textBox_adressa.Text = "";
			textBox_num_telefonu.Text = "";
			textBox_osvita.Text = "";
			textBox_data_zap_bibliot.Text = "";
			textBox_id_zally2.Text = "";
		}
	}
}
