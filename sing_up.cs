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
	public partial class sing_up : Form
	{
		DataBase dataBase = new DataBase();
		public sing_up()
		{
			InitializeComponent();
			StartPosition = FormStartPosition.CenterScreen;
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;

		}

		private void sing_up_Load(object sender, EventArgs e)
		{
			textBox_password2.PasswordChar = '*';
			pictureBox1.Visible = false;
			textBox_login2.MaxLength = 50;
			textBox_password2.MaxLength = 50;
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			

			var login = textBox_login2.Text;
			var password = textBox_password2.Text;

			string querystring = $"insert into register (login_user, password_user) values('{login}','{password}')";
			SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

			dataBase.openConnection();

			if(command.ExecuteNonQuery() == 1)
			{
				MessageBox.Show("Аккаунт успішно створен!", "Успіх!");
				log_in frm_login = new log_in();
				this.Hide();
				frm_login.ShowDialog();
			}
			else
			{
				MessageBox.Show("Аккаунт не створено");
			}
			dataBase.closeConnection();
		}

		private Boolean checkUser()
		{
			var loginUser = textBox_login2;
			var passUser = textBox_password2;

			SqlDataAdapter adapter = new SqlDataAdapter();
			DataTable table = new DataTable();
			string querystring = $"select id_user, login_user, password_user from register where login_user = '{loginUser}' and password_user = '{passUser}'";

			SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

			adapter.SelectCommand = command;
			adapter.Fill(table);

			if (table.Rows.Count > 0)
			{
				MessageBox.Show("Користувач уже існує!");
				return true;
			}
			else
			{
				return false;
			}

		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			textBox_login2.Text = "";
			textBox_password2.Text = "";
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			textBox_password2.UseSystemPasswordChar = true;
			pictureBox1.Visible = true;
			pictureBox2.Visible = false;
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			textBox_password2.UseSystemPasswordChar = false;
			pictureBox1.Visible = false;
			pictureBox2.Visible = true;
		}
	}
}
