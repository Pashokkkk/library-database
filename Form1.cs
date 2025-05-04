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

   enum RowState
	{
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted

	}
    public partial class Form1 : Form
    {

        DataBase dataBase = new DataBase();

        int selectedRow;
        int selectedRow2;
        int selectedRow3;
        public Form1()
        {
            InitializeComponent();
    
        }

       private void CreateColumns()
		{
            dataGridView1.Columns.Add("book_id", "ID книги");
            dataGridView1.Columns.Add("book_title", "Назва книги");
            dataGridView1.Columns.Add("author", "Автор");
            dataGridView1.Columns.Add("publisher", "Видавництво");
            dataGridView1.Columns.Add("publication_year", "Рік видання");
            dataGridView1.Columns.Add("copies_in_library", "Кількість екземплярів");
            dataGridView1.Columns.Add("book_code", "Шифр книги");
            dataGridView1.Columns.Add("date_checked_out", "Дата закріплення");
            dataGridView1.Columns.Add("IsNew", String.Empty);
            dataGridView1.Columns[8].Visible = false;
        }

        private void CreateColumns2()
        {
            dataGridView2.Columns.Add("hall_id", "ID залу");
            dataGridView2.Columns.Add("hall_name", "Назва залу");
            dataGridView2.Columns.Add("capacity", "Місткість");
            dataGridView2.Columns.Add("IsNew", String.Empty);
            dataGridView2.Columns[3].Visible = false;
        }

        private void CreateColumns3()
        {
            dataGridView3.Columns.Add("reader_id", "ID читача");
            dataGridView3.Columns.Add("library_card_number", "Номер чит. квитка");
            dataGridView3.Columns.Add("last_name", "Прізвище");
            dataGridView3.Columns.Add("passport_number", "Номер паспорта");
            dataGridView3.Columns.Add("date_of_birth", "Дата народження");
            dataGridView3.Columns.Add("addres", "Адреса");
            dataGridView3.Columns.Add("phone_number", "Номер телефону");
            dataGridView3.Columns.Add("education", "Освіта");
            dataGridView3.Columns.Add("has_degree", "Дата запису у бібліотеку");
            dataGridView3.Columns.Add("hall_id", "Номер залу");
            dataGridView3.Columns.Add("IsNew", String.Empty);
            dataGridView3.Columns[10].Visible = false;
        }

        private void ClearFields()
        {
            textBox_id.Text = "";
            textBox_namebook.Text = "";
            textBox_autor.Text = "";
            textBox_vudavnic.Text = "";
            textBox_yearvidanya.Text = "";
            textBox_kistekzemp.Text = "";
            textBox_shufr.Text = "";
            textBox_datazakrip.Text = "";
        }

        private void ClearFields2()
        {
            textBox_hall_id.Text = "";
            textBox_hall_name.Text = "";
            textBox_mistkist.Text = "";
           
        }

        private void ClearFields3()
        {
            textBox_id_chutacha.Text = "";
            textBox_num_chut_kvutka.Text = "";
            textBox_prizvuche.Text = "";
            textBox_num_pasport.Text = "";
            textBox_data_narod.Text = "";
            textBox_adressa.Text = "";
            textBox_num_telefonu.Text = "";
            textBox_osvita.Text = "";
            textBox_data_zap_bibliot.Text = "";
            textBox_id_zally.Text = "";
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
		{
          dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetInt32(4), record.GetInt32(5), record.GetString(6),record.GetDateTime(7),RowState.ModifiedNew);
		}

        private void ReadSingleRow2(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2), RowState.ModifiedNew);
        }

        private void ReadSingleRow3(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetDateTime(4), record.GetString(5), record.GetInt32(6), record.GetString(7), record.GetDateTime(8), record.GetInt32(9), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
		{
            dgw.Rows.Clear();

            string queryString = $"select * from Book";
            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
                ReadSingleRow(dgw, reader);
			}
            reader.Close();
		}

        private void RefreshDataGrid2(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from Hall";
            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow2(dgw, reader);
            }
            reader.Close();
        }

        private void RefreshDataGrid3(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from Reader";
            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow3(dgw, reader);
            }
            reader.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           CreateColumns();
           RefreshDataGrid(dataGridView1);
           CreateColumns2();
           RefreshDataGrid2(dataGridView2);
           CreateColumns3();
           RefreshDataGrid3(dataGridView3);
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
		{
            sing_up frm_sign = new sing_up();
            frm_sign.Close();
            log_in frm = new log_in();
            frm.Hide();
            Application.Exit();
		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void textBox6_TextChanged(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void tabPage1_Click(object sender, EventArgs e)
		{

		}

		private void файлToolStripMenuItem_Click(object sender, EventArgs e)
		{
            sing_up frm_sign = new sing_up();
            frm_sign.Close();
            log_in frm = new log_in();
            frm.Hide();
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

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
            }
		}

        private void Search(DataGridView dgw)
		{
            dgw.Rows.Clear();

            string searchString = $"select * from Book where concat (book_id, book_title, author, publisher, publication_year, copies_in_library, book_code, date_checked_out) like '%" + textBox_search.Text + "%'";

            SqlCommand com = new SqlCommand(searchString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader read = com.ExecuteReader();

			while (read.Read())
			{
                ReadSingleRow(dgw, read);
			}
            read.Close();
		}

        private void Search2(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchString = $"select * from Hall where concat (hall_id, hall_name, capacity) like '%" + textBox_search2.Text + "%'";

            SqlCommand com = new SqlCommand(searchString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRow2(dgw, read);
            }
            read.Close();
        }

        private void Search3(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchString = $"select * from Reader where concat (reader_id, library_card_number, last_name, passport_number, date_of_birth, addres, phone_number, education, has_degree, hall_id) like '%" + textBox_search3.Text + "%'";

            SqlCommand com = new SqlCommand(searchString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRow3(dgw, read);
            }
            read.Close();
        }

        private void deleteRow()
		{
            int index = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows[index].Visible = false;

			if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
			{
                dataGridView1.Rows[index].Cells[8].Value = RowState.Deleted;
                return;
            }
            dataGridView1.Rows[index].Cells[8].Value = RowState.Deleted;
		}

        private void deleteRow2()
        {
            int index = dataGridView2.CurrentCell.RowIndex;

            dataGridView2.Rows[index].Visible = false;

            if (dataGridView2.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView2.Rows[index].Cells[3].Value = RowState.Deleted;
                return;
            }
            dataGridView2.Rows[index].Cells[3].Value = RowState.Deleted;
        }

        private void deleteRow3()
        {
            int index = dataGridView3.CurrentCell.RowIndex;

            dataGridView3.Rows[index].Visible = false;

            if (dataGridView3.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView3.Rows[index].Cells[10].Value = RowState.Deleted;
                return;
            }
            dataGridView3.Rows[index].Cells[10].Value = RowState.Deleted;
        }
        private void Update()
		{
            dataBase.openConnection();

            for(int index = 0; index < dataGridView1.Rows.Count; index++)
			{
                var rowState = (RowState)dataGridView1.Rows[index].Cells[8].Value;

                if (rowState == RowState.Existed)
                    continue;

                if(rowState == RowState.Deleted)
				{
                    var book_id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from Book where book_id = {book_id}";

                    var command = new SqlCommand(deleteQuery, dataBase.getConnection());
                    command.ExecuteNonQuery();
				}

                if(rowState == RowState.Modified)
				{
                    var book_id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var nameBook = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var autor = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var vidavnic = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    var yearVidana = dataGridView1.Rows[index].Cells[4].Value.ToString();
                    var kistEkzemp = dataGridView1.Rows[index].Cells[5].Value.ToString();
                    var shufr = dataGridView1.Rows[index].Cells[6].Value.ToString();
                    var dataZak = dataGridView1.Rows[index].Cells[7].Value.ToString();

                    var changeQuery = $"update Book set book_title = '{nameBook}', author = '{autor}', publisher = '{vidavnic}', publication_year = '{yearVidana}', copies_in_library = '{kistEkzemp}', book_code = '{shufr}', date_checked_out = '{dataZak}' where book_id = '{book_id}'";

                    var command = new SqlCommand(changeQuery, dataBase.getConnection());
                    command.ExecuteNonQuery();
				}
			}
            dataBase.closeConnection();
		}

        private void Update2()
        {
            dataBase.openConnection();

            for (int index = 0; index < dataGridView2.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView2.Rows[index].Cells[3].Value;

                if (rowState == RowState.Existed)
                    continue;

                if (rowState == RowState.Deleted)
                {
                    var hall_id = Convert.ToInt32(dataGridView2.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from Hall where hall_id = {hall_id}";

                    var command = new SqlCommand(deleteQuery, dataBase.getConnection());
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {
                    var hall_id = dataGridView2.Rows[index].Cells[0].Value.ToString();
                    var nameHall = dataGridView2.Rows[index].Cells[1].Value.ToString();
                    var mistkist = dataGridView2.Rows[index].Cells[2].Value.ToString();

                    var changeQuery = $"update Hall set hall_name = '{nameHall}', capacity  = '{mistkist}' where hall_id  = '{hall_id}'";

                    var command = new SqlCommand(changeQuery, dataBase.getConnection());
                    command.ExecuteNonQuery();
                }
            }
            dataBase.closeConnection();
        }

        private void Update3()
        {
            dataBase.openConnection();

            for (int index = 0; index < dataGridView3.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView3.Rows[index].Cells[10].Value;

                if (rowState == RowState.Existed)
                    continue;

                if (rowState == RowState.Deleted)
                {
                    var reader_id = Convert.ToInt32(dataGridView3.Rows[index].Cells[10].Value);
                    var deleteQuery = $"delete from Reader where reader_id = {reader_id}";

                    var command = new SqlCommand(deleteQuery, dataBase.getConnection());
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {
                    var reader_id = dataGridView3.Rows[index].Cells[0].Value.ToString();
                    var nameBook = dataGridView3.Rows[index].Cells[1].Value.ToString();
                    var autor = dataGridView3.Rows[index].Cells[2].Value.ToString();
                    var vidavnic = dataGridView3.Rows[index].Cells[3].Value.ToString();
                    var yearVidana = dataGridView3.Rows[index].Cells[4].Value.ToString();
                    var kistEkzemp = dataGridView3.Rows[index].Cells[5].Value.ToString();
                    var shufr = dataGridView3.Rows[index].Cells[6].Value.ToString();
                    var dataZak = dataGridView3.Rows[index].Cells[7].Value.ToString();
                    var dataZak1 = dataGridView3.Rows[index].Cells[8].Value.ToString();
                    var id_zaly = dataGridView3.Rows[index].Cells[9].Value.ToString();

                    var changeQuery = $"update Reader set library_card_number = '{nameBook}', last_name = '{autor}', passport_number = '{vidavnic}', date_of_birth = '{yearVidana}', addres = '{kistEkzemp}', phone_number = '{shufr}', education = '{dataZak}', has_degree = '{dataZak1}', hall_id = '{id_zaly}' where reader_id = '{reader_id}'";

                    var command = new SqlCommand(changeQuery, dataBase.getConnection());
                    command.ExecuteNonQuery();
                }
            }
            dataBase.closeConnection();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
		{
            RefreshDataGrid(dataGridView1);
            ClearFields();

        }

		private void btn_newzapis_Click(object sender, EventArgs e)
		{
            Add_Form addfrm = new Add_Form();
            addfrm.Show();

		}

		private void textBox_search_TextChanged(object sender, EventArgs e)
		{

            Search(dataGridView1);
		}

		private void btn_delete_Click(object sender, EventArgs e)
		{
            deleteRow();
		}

		private void btn_save_Click(object sender, EventArgs e)
		{
            Update();
            ClearFields();

        }

        private void Change()
		{
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            var book_id = textBox_id.Text;
            var nameBook = textBox_namebook.Text;
            var autor = textBox_autor.Text;
            var vudavnuctvo = textBox_vudavnic.Text;
            var yearVidanya = textBox_yearvidanya.Text;
            int kistEkzemp; 
            var shufr = textBox_shufr.Text;
            var dataZak = textBox_datazakrip.Text;

			if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
			{
               if (int.TryParse(textBox_kistekzemp.Text, out kistEkzemp))
                {


                    dataGridView1.Rows[selectedRowIndex].SetValues(book_id, nameBook, autor, vudavnuctvo, yearVidanya, kistEkzemp, shufr, dataZak);
                    dataGridView1.Rows[selectedRowIndex].Cells[8].Value = RowState.Modified;
                }
				else
				{
                    MessageBox.Show("Кількість екземплярів повина мати числовий формат!");
				}
			}
        }

        private void Change2()
        {
            var selectedRowIndex = dataGridView2.CurrentCell.RowIndex;

            var hall_id = textBox_hall_id.Text;
            var nameHall = textBox_hall_name.Text;
            int mistkist;

            if (dataGridView2.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if (int.TryParse(textBox_mistkist.Text, out mistkist))
                {


                    dataGridView2.Rows[selectedRowIndex].SetValues(hall_id, nameHall, mistkist);
                    dataGridView2.Rows[selectedRowIndex].Cells[3].Value = RowState.Modified;
                }
                else
                {
                    MessageBox.Show("Місткість залу повина мати числовий формат!");
                }
            }
        }

        private void Change3()
        {
            var selectedRowIndex = dataGridView3.CurrentCell.RowIndex;

            var book_id = textBox_id_chutacha.Text;
            var nameBook = textBox_num_chut_kvutka.Text;
            var autor = textBox_prizvuche.Text;
            var vudavnuctvo = textBox_num_pasport.Text;
            var yearVidanya = textBox_data_narod.Text;
            var shufr = textBox_adressa.Text;
            int kistEkzemp;
            var shufr1 = textBox_osvita.Text;
            var dataZak = textBox_data_zap_bibliot.Text;
            var id_zaly = textBox_id_zally.Text;

            if (dataGridView3.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if (int.TryParse(textBox_num_telefonu.Text, out kistEkzemp))
                {


                    dataGridView3.Rows[selectedRowIndex].SetValues(book_id, nameBook, autor, vudavnuctvo, yearVidanya, shufr, kistEkzemp, shufr1, dataZak,id_zaly);
                    dataGridView3.Rows[selectedRowIndex].Cells[10].Value = RowState.Modified;
                }
                else
                {
                    MessageBox.Show("Номер телефону повинен мати числовий формат!");
                }
            }
        }
        private void btn_zminutu_Click(object sender, EventArgs e)
		{
            Change();
            ClearFields();

        }

		private void btnClear_Click(object sender, EventArgs e)
		{
            ClearFields();

        }

		private void tabPage2_Click(object sender, EventArgs e)
		{

		}

		private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
		{
            selectedRow2 = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[selectedRow2];

                textBox_hall_id.Text = row.Cells[0].Value.ToString();
                textBox_hall_name.Text = row.Cells[1].Value.ToString();
                textBox_mistkist.Text = row.Cells[2].Value.ToString();

            }
        }

		private void pictureBox4_Click(object sender, EventArgs e)
		{
            RefreshDataGrid2(dataGridView2);
            ClearFields2();
        }

		private void btn_newzapis2_Click(object sender, EventArgs e)
		{
            Add_Form2 addfrm2 = new Add_Form2();
            addfrm2.Show();
        }

		private void textBox_search2_TextChanged(object sender, EventArgs e)
		{
            Search2(dataGridView2);

        }

		private void btn_delete2_Click(object sender, EventArgs e)
		{
            deleteRow2();
            ClearFields2();

        }

		private void btn_save2_Click(object sender, EventArgs e)
		{
            Update2();

        }

		private void btn_zminutu2_Click(object sender, EventArgs e)
		{
            Change2();
            ClearFields2();

        }

		private void pictureBox3_Click(object sender, EventArgs e)
		{
            ClearFields2();

        }

		private void label26_Click(object sender, EventArgs e)
		{

		}

		private void tabPage3_Click(object sender, EventArgs e)
		{

		}

		private void label29_Click(object sender, EventArgs e)
		{

		}

		private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
		{
            selectedRow3 = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView3.Rows[selectedRow3];

                textBox_id_chutacha.Text = row.Cells[0].Value.ToString();
                textBox_num_chut_kvutka.Text = row.Cells[1].Value.ToString();
                textBox_prizvuche.Text = row.Cells[2].Value.ToString();
                textBox_num_pasport.Text = row.Cells[3].Value.ToString();
                textBox_data_narod.Text = row.Cells[4].Value.ToString();
                textBox_adressa.Text = row.Cells[5].Value.ToString();
                textBox_num_telefonu.Text = row.Cells[6].Value.ToString();
                textBox_osvita.Text = row.Cells[7].Value.ToString();
                textBox_data_zap_bibliot.Text = row.Cells[8].Value.ToString();
                textBox_id_zally.Text = row.Cells[9].Value.ToString();
            }
        }

		private void pictureBox_Refresh3_Click(object sender, EventArgs e)
		{
            RefreshDataGrid3(dataGridView3);
            ClearFields3();

        }

		private void btn_newZapis3_Click(object sender, EventArgs e)
		{
            Add_Form3 addfrm3 = new Add_Form3();
            addfrm3.Show();
        }

		private void textBox_search3_TextChanged(object sender, EventArgs e)
		{
            Search3(dataGridView3);

        }

		private void btn_delete3_Click(object sender, EventArgs e)
		{
            deleteRow3();
            ClearFields3();

        }

		private void btn_savee3_Click(object sender, EventArgs e)
		{
            Update3();
		}

		private void btn_zminutu3_Click(object sender, EventArgs e)
		{
            Change3();
            ClearFields3();

        }

		private void pictureBox_cClear3_Click(object sender, EventArgs e)
		{
            ClearFields3();

        }

		private void btn_book_za_shufr_Click(object sender, EventArgs e)
		{
            Book_za_shufr_Form addfrm = new Book_za_shufr_Form();
            addfrm.Show();
        }

		private void btn_zakrip_chutach_za_book_Click(object sender, EventArgs e)
		{
            Zakrip_chutac_za_Book_Form addfrm = new Zakrip_chutac_za_Book_Form();
            addfrm.Show();
        }

		private void label8_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
            Hto_vzav_book_misats_Form addfrm = new Hto_vzav_book_misats_Form();
            addfrm.Show();
        }

		private void button2_Click(object sender, EventArgs e)
		{
            Skilku_za_20_Form addfrm = new Skilku_za_20_Form();
            addfrm.Show();
        }

		private void button3_Click(object sender, EventArgs e)
		{
            Yaki_book_u_chutacha_Form addfrm = new Yaki_book_u_chutacha_Form();
            addfrm.Show();
        }
	}
}
