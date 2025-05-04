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

	public partial class log_in : Form
	{
		DataBase database = new DataBase();

		public log_in()
		{
			InitializeComponent();
			StartPosition = FormStartPosition.CenterScreen;

			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
		}

		private void log_in_Load(object sender, EventArgs e)
		{
			textBox_password.PasswordChar = '*';
			pictureBox1.Visible = false;
			textBox_login.MaxLength = 50;
			textBox_password.MaxLength = 50;
		}


		private void btnEntr_Click(object sender, EventArgs e)
		{
			var loginUser = textBox_login.Text;
			var passUser = textBox_password.Text;

			SqlDataAdapter adapter = new SqlDataAdapter();
			DataTable table = new DataTable();

			string querystring = $"select id_user, login_user, password_user from register where login_user = '{loginUser}' and password_user = '{passUser}'";

			SqlCommand command = new SqlCommand(querystring, database.getConnection());

			adapter.SelectCommand = command;
			adapter.Fill(table);

			if (table.Rows.Count == 1)
			{
				MessageBox.Show("Ви успішно ввійшли!", "Успішно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
				Form1 frm1 = new Form1();
				this.Hide();
				frm1.ShowDialog();
				//this.Show();
			}
			else
			{
				MessageBox.Show("Такого аккаунта не існує!", "Аккаунта не існує!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		//catch(){
		//}
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			sing_up frm_sign = new sing_up();
			frm_sign.Show();
			this.Hide();

		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			textBox_login.Text = "";
			textBox_password.Text = "";
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			textBox_password.UseSystemPasswordChar = false;
			pictureBox1.Visible = false;
			pictureBox2.Visible = true;
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			textBox_password.UseSystemPasswordChar = true;
			pictureBox1.Visible = true;
			pictureBox2.Visible = false;
		}
	}

}
