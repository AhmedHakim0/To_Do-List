namespace To_Do_List
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Head_Form = new Label();
            Title_Lable = new Label();
            Description_Lable = new Label();
            title_textBox1 = new TextBox();
            To_Lable = new Label();
            From_Lable = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            State_Lable = new Label();
            Status_comboBox1 = new ComboBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dataGridView1 = new DataGridView();
            btnLoadTasks = new Button();
            Descri_textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            ID_Lable = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Head_Form
            // 
            Head_Form.AutoSize = true;
            Head_Form.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Head_Form.ForeColor = Color.White;
            Head_Form.ImageAlign = ContentAlignment.TopCenter;
            Head_Form.Location = new Point(444, 9);
            Head_Form.Name = "Head_Form";
            Head_Form.Size = new Size(151, 37);
            Head_Form.TabIndex = 0;
            Head_Form.Text = "To_Do List";
            Head_Form.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Title_Lable
            // 
            Title_Lable.AutoSize = true;
            Title_Lable.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title_Lable.ForeColor = Color.Black;
            Title_Lable.Location = new Point(131, 87);
            Title_Lable.Name = "Title_Lable";
            Title_Lable.Size = new Size(36, 17);
            Title_Lable.TabIndex = 1;
            Title_Lable.Text = "Title";
            // 
            // Description_Lable
            // 
            Description_Lable.AutoSize = true;
            Description_Lable.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Description_Lable.Location = new Point(766, 85);
            Description_Lable.Name = "Description_Lable";
            Description_Lable.Size = new Size(83, 17);
            Description_Lable.TabIndex = 2;
            Description_Lable.Text = "Description:";
            // 
            // title_textBox1
            // 
            title_textBox1.Location = new Point(170, 85);
            title_textBox1.Name = "title_textBox1";
            title_textBox1.Size = new Size(113, 23);
            title_textBox1.TabIndex = 3;
            // 
            // To_Lable
            // 
            To_Lable.AutoSize = true;
            To_Lable.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            To_Lable.Location = new Point(538, 114);
            To_Lable.Name = "To_Lable";
            To_Lable.Size = new Size(27, 17);
            To_Lable.TabIndex = 6;
            To_Lable.Text = "To:";
            // 
            // From_Lable
            // 
            From_Lable.AutoSize = true;
            From_Lable.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            From_Lable.Location = new Point(522, 85);
            From_Lable.Name = "From_Lable";
            From_Lable.Size = new Size(44, 17);
            From_Lable.TabIndex = 11;
            From_Lable.Text = "From:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(569, 86);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(183, 23);
            dateTimePicker1.TabIndex = 14;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(571, 115);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(183, 23);
            dateTimePicker2.TabIndex = 15;
            // 
            // State_Lable
            // 
            State_Lable.AutoSize = true;
            State_Lable.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            State_Lable.Location = new Point(308, 86);
            State_Lable.Name = "State_Lable";
            State_Lable.Size = new Size(39, 17);
            State_Lable.TabIndex = 19;
            State_Lable.Text = "State";
            // 
            // Status_comboBox1
            // 
            Status_comboBox1.FormattingEnabled = true;
            Status_comboBox1.Location = new Point(349, 85);
            Status_comboBox1.Name = "Status_comboBox1";
            Status_comboBox1.Size = new Size(151, 23);
            Status_comboBox1.TabIndex = 20;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Linen;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.LimeGreen;
            btnAdd.Location = new Point(46, 244);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(117, 31);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Add Task";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Linen;
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.LimeGreen;
            btnUpdate.Location = new Point(46, 303);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(117, 31);
            btnUpdate.TabIndex = 25;
            btnUpdate.Text = "Update Task";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Linen;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.LimeGreen;
            btnDelete.Location = new Point(46, 362);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(117, 31);
            btnDelete.TabIndex = 26;
            btnDelete.Text = "Delete Task";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.SandyBrown;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(199, 184);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(828, 284);
            dataGridView1.TabIndex = 27;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnLoadTasks
            // 
            btnLoadTasks.BackColor = Color.Linen;
            btnLoadTasks.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoadTasks.ForeColor = Color.LimeGreen;
            btnLoadTasks.Location = new Point(567, 485);
            btnLoadTasks.Name = "btnLoadTasks";
            btnLoadTasks.Size = new Size(117, 31);
            btnLoadTasks.TabIndex = 28;
            btnLoadTasks.Text = "Load Tasks";
            btnLoadTasks.UseVisualStyleBackColor = false;
            btnLoadTasks.Click += btnLoadTasks_Click;
            // 
            // Descri_textBox2
            // 
            Descri_textBox2.Location = new Point(850, 87);
            Descri_textBox2.Multiline = true;
            Descri_textBox2.Name = "Descri_textBox2";
            Descri_textBox2.Size = new Size(177, 53);
            Descri_textBox2.TabIndex = 29;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(68, 85);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(39, 23);
            comboBox1.TabIndex = 30;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // ID_Lable
            // 
            ID_Lable.AutoSize = true;
            ID_Lable.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ID_Lable.Location = new Point(39, 87);
            ID_Lable.Name = "ID_Lable";
            ID_Lable.Size = new Size(22, 17);
            ID_Lable.TabIndex = 31;
            ID_Lable.Text = "ID";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1057, 528);
            Controls.Add(ID_Lable);
            Controls.Add(comboBox1);
            Controls.Add(Descri_textBox2);
            Controls.Add(btnLoadTasks);
            Controls.Add(dataGridView1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(Status_comboBox1);
            Controls.Add(State_Lable);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnAdd);
            Controls.Add(From_Lable);
            Controls.Add(To_Lable);
            Controls.Add(title_textBox1);
            Controls.Add(Description_Lable);
            Controls.Add(Title_Lable);
            Controls.Add(Head_Form);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Head_Form;
        private Label Title_Lable;
        private Label Description_Lable;
        private TextBox title_textBox1;
        private Label To_Lable;
        private Label From_Lable;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label State_Lable;
        private ComboBox Status_comboBox1;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dataGridView1;
        private Button btnLoadTasks;
        private TextBox Descri_textBox2;
        private ComboBox comboBox1;
        private Label ID_Lable;
    }
}
