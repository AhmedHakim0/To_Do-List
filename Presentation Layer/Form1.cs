using System.ComponentModel;
using System.Data;
using System.Windows.Forms.VisualStyles;
using DataBusinesLayer;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace To_Do_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            HandlingButtoms();
            HandlingGridView();
            HandlingComboBox_Status();
            HandlingLables();
            LoadComboBox();



        }


        private void btnLoadTasks_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DataBusinesLayer.TaskManager.GetAll();
            dataGridView1.ClearSelection();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataBusinesLayer.TaskManager.AddTask(title_textBox1.Text, Status_comboBox1.Text, dateTimePicker1.Value, dateTimePicker2.Value, Descri_textBox2.Text);
            title_textBox1.Text = Status_comboBox1.Text = Descri_textBox2.Text = string.Empty;
            dateTimePicker1.Value = dateTimePicker2.Value = DateTime.Today;
            ReloadDate();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (title_textBox1.Text != null)
            {
                TaskManager.UpdateTask(int.Parse(comboBox1.Text), title_textBox1.Text);
            }
            if (Status_comboBox1.Text != null)
            {
                TaskManager.UpdateTask(int.Parse(comboBox1.Text), Status_comboBox1.Text);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != null)
            {
                int id = int.Parse(comboBox1.Text);
                if (TaskManager.DeleteTask(id) == 1)
                {
                    MessageBox.Show("Deleted Sucessfully..!");
                }
                else
                {
                    MessageBox.Show("Ooops Not Deleted...!");
                }
                ReloadDate();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        public void HandlingGridView()
        {
            dataGridView1.BackgroundColor = ColorTranslator.FromHtml("#A6CDC6");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }
        public void HandlingButtoms()
        {
            this.BackColor = Color.FromArgb(200, 230, 255);
            this.Text = "To_Do List Manager";

            btnAdd.BackColor = Color.FromArgb(40, 167, 69);
            btnAdd.ForeColor = Color.White;

            btnUpdate.BackColor = Color.FromArgb(0, 123, 255);
            btnUpdate.ForeColor = Color.White;

            btnDelete.BackColor = Color.FromArgb(220, 53, 69);
            btnDelete.ForeColor = Color.White;

            btnLoadTasks.BackColor = Color.FromArgb(108, 117, 125);
            btnLoadTasks.ForeColor = Color.White;
        }
        public void HandlingComboBox_Status()
        {
            Status_comboBox1.Items.Add("Pending");
            Status_comboBox1.Items.Add("In Progress");
            Status_comboBox1.Items.Add("Completed");
        }
        public void ReloadDate()
        {
            dataGridView1.DataSource = DataBusinesLayer.TaskManager.GetAll();
            dataGridView1.ClearSelection();
        }
        public void HandlingLables()
        {

            ID_Lable.ForeColor = ColorTranslator.FromHtml("#16404D");
            Title_Lable.ForeColor = ColorTranslator.FromHtml("#16404D");
            State_Lable.ForeColor = ColorTranslator.FromHtml("#16404D");
            From_Lable.ForeColor = ColorTranslator.FromHtml("#16404D");
            To_Lable.ForeColor = ColorTranslator.FromHtml("#16404D");
            Description_Lable.ForeColor = ColorTranslator.FromHtml("#16404D");
            this.BackColor = ColorTranslator.FromHtml("#FBF5DD");
            Head_Form.ForeColor = ColorTranslator.FromHtml("#DDA853");
        }
        public void LoadComboBox()
        {
            var tasks = TaskManager.GetAll();
            foreach (var t in tasks)
            {
                comboBox1.Items.Add(t.id);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(comboBox1.Text);
            
        }
    }
}
