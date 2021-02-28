using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ProductivityCenter
{
    public partial class frm_MainScreen : Form
    {
        public frm_MainScreen()
        {
            InitializeComponent();
        }

        private void frm_MainScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            switch (button.Name)
            {
                case "btn_Notes":
                    workArea.Controls.Clear();
                    makeNotes();
                    break;

                case "btn_Schedule":
                    workArea.Controls.Clear();
                    makeSchedule();
                    break;

                case "btn_ToDo":
                    workArea.Controls.Clear();
                    makeToDo();
                    break;

                case "btn_Tools":
                    workArea.Controls.Clear();
                    makeTools();
                    break;
            }
        }

        #region Controls Definition
        private void makeNotes()
        {
            Button saveNote = new Button();
            saveNote.Name = "btn_saveNote";
            saveNote.Text = "Save";
            saveNote.Size = new Size(247, 77);
            saveNote.Location = new Point(62, 725);
            saveNote.Click += SaveNote_Click;
            workArea.Controls.Add(saveNote);

            Button viewNotes = new Button();
            viewNotes.Name = "btn_viewNotes";
            viewNotes.Text = "View Notes";
            viewNotes.Size = new Size(247, 77);
            viewNotes.Location = new Point(424, 725);
            viewNotes.Click += ViewNotes_Click;
            workArea.Controls.Add(viewNotes);

            TextBox body = new TextBox();
            body.Name = "txt_Body";
            body.Multiline = true;
            body.Size = new Size(700, 564);
            body.Location = new Point(37, 150);
            workArea.Controls.Add(body);

            TextBox title = new TextBox();
            title.Name = "txt_Title";
            title.Size = new Size(700, 22);
            title.Location = new Point(37, 60);
            workArea.Controls.Add(title);

            Label bodyLabel = new Label();
            bodyLabel.Name = "lbl_Body";
            bodyLabel.Text = "Body:";
            bodyLabel.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            bodyLabel.Location = new Point(34, 108);
            workArea.Controls.Add(bodyLabel);

            Label titleLabel = new Label();
            titleLabel.Name = "lbl_Title";
            titleLabel.Text = "Title:";
            titleLabel.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            titleLabel.Location = new Point(34, 18);
            workArea.Controls.Add(titleLabel);
        }

        private void makeSchedule()
        {
            Label eventNameLabel = new Label();
            eventNameLabel.Name = "lbl_eventName";
            eventNameLabel.Text = "Name:";
            eventNameLabel.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            eventNameLabel.Location = new Point(34, 18);
            workArea.Controls.Add(eventNameLabel);

            TextBox eventName = new TextBox();
            eventName.Name = "txt_eventName";
            eventName.Size = new Size(700, 22);
            eventName.Location = new Point(37, 60);
            workArea.Controls.Add(eventName);

            DateTimePicker picker = new DateTimePicker();
            picker.Name = "event_Date";
            picker.Format = DateTimePickerFormat.Short;
            picker.Location = new Point(250, 100);
            workArea.Controls.Add(picker);

            Button saveEvent = new Button();
            saveEvent.Name = "btn_saveEvent";
            saveEvent.Text = "Save";
            saveEvent.Size = new Size(250, 80);
            saveEvent.Location = new Point(250, 190);
            saveEvent.Click += SaveEvent_Click;
            workArea.Controls.Add(saveEvent);

            DataGridView schedule = new DataGridView();
            schedule.Name = "dgv_Schedule";
            schedule.Dock = DockStyle.Bottom;
            schedule.Height = 500;

            SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Coding\MyProjects\ProductivityCenter\DB_Storage.mdf;Integrated Security=True");
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM tbl_Schedule WHERE Date = '" + DateTime.Now.ToShortDateString() + "'", sqlcon);
            DataTable dtbl = new DataTable();
            adapter.Fill(dtbl);
            schedule.DataSource = dtbl;

            workArea.Controls.Add(schedule);
        }

        private void makeToDo()
        {
            TextBox insertTask = new TextBox();
            insertTask.Name = "txt_insertTask";
            insertTask.Size = new Size(500, 22);
            insertTask.Location = new Point(37, 60);
            workArea.Controls.Add(insertTask);

            Button addTask = new Button();
            addTask.Name = "btn_addTask";
            addTask.Text = "Add";
            addTask.Size = new Size(200, 50);
            addTask.Click += AddTask_Click;
            addTask.Location = new Point(550, 30);
            workArea.Controls.Add(addTask);

            Button removeTask = new Button();
            removeTask.Name = "btn_removeTask";
            removeTask.Text = "Remove Done Tasks";
            removeTask.Size = new Size(200, 50);
            removeTask.Location = new Point(550, 90);
            removeTask.Click += RemoveTask_Click;
            workArea.Controls.Add(removeTask);

            chkdlstbx_Tasks.Visible = true;
            workArea.Controls.Add(chkdlstbx_Tasks);
        }

        private void makeTools()
        {
            Button calculator = new Button();
            calculator.Name = "btn_Calculator";
            calculator.Text = "Calculator";
            calculator.Size = new Size(250, 80);
            calculator.Location = new Point(250, 10);
            calculator.Click += Calculator_Click;
            workArea.Controls.Add(calculator);

            Button word = new Button();
            word.Name = "btn_Word";
            word.Text = "Word";
            word.Size = new Size(250, 80);
            word.Location = new Point(250, 100);
            word.Click += Word_Click;
            workArea.Controls.Add(word);

            Button ppt = new Button();
            ppt.Name = "btn_PowerPoint";
            ppt.Text = "PowerPoint";
            ppt.Size = new Size(250, 80);
            ppt.Location = new Point(250, 190);
            ppt.Click += Ppt_Click;
            workArea.Controls.Add(ppt);

            Button excel = new Button();
            excel.Name = "btn_Excel";
            excel.Text = "Excel";
            excel.Size = new Size(250, 80);
            excel.Location = new Point(250, 280);
            excel.Click += Excel_Click;
            workArea.Controls.Add(excel);
        }
        #endregion


        #region Actions
        private void SaveNote_Click(object sender, EventArgs e)
        {
            foreach (Control x in workArea.Controls)
            {
                foreach (Control y in workArea.Controls)
                {
                    if ((x is TextBox && x.Name == "txt_Title") && (y is TextBox && y.Name == "txt_Body"))
                    {
                        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Coding\MyProjects\ProductivityCenter\DB_Storage.mdf;Integrated Security=True");
                        SqlCommand cmd = new SqlCommand("INSERT INTO tbl_Notes([Title], [Body]) VALUES (@Title, @Body)", sqlcon);
                        sqlcon.Open();
                        cmd.Parameters.AddWithValue("@Title", x.Text);
                        cmd.Parameters.AddWithValue("@Body", y.Text);
                        cmd.ExecuteNonQuery();
                        sqlcon.Close();

                        MessageBox.Show("Note saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        x.Text = "";
                        y.Text = "";
                    }
                }
            }
        }

        private void SaveEvent_Click(object sender, EventArgs e)
        {
            foreach (Control d in workArea.Controls)
            {
                foreach (Control t in workArea.Controls)
                {
                    if ((d is DateTimePicker && d.Name == "event_Date") && (t is TextBox && t.Name == "txt_eventName"))
                    {
                        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Coding\MyProjects\ProductivityCenter\DB_Storage.mdf;Integrated Security=True");
                        SqlCommand cmd = new SqlCommand("INSERT INTO tbl_Schedule([Name], [Date]) VALUES (@Name, @Date)", sqlcon);
                        sqlcon.Open();
                        cmd.Parameters.AddWithValue("@Name", t.Text);
                        cmd.Parameters.AddWithValue("@Date", d.Text);
                        cmd.ExecuteNonQuery();
                        sqlcon.Close();

                        MessageBox.Show("Event saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        t.Text = "";

                        makeSchedule();
                    }
                }
            }
        }

        private void ViewNotes_Click(object sender, EventArgs e)
        {
            new frm_Notes().Show();
            this.Hide();
        }

        private void AddTask_Click(object sender, EventArgs e)
        {
            foreach (Control t in workArea.Controls)
            {
                if (t is TextBox && t.Name == "txt_insertTask")
                {
                    chkdlstbx_Tasks.Items.Add(t.Text);

                    t.Text = "";
                }
            }
        }

        private void RemoveTask_Click(object sender, EventArgs e)
        {
            if (chkdlstbx_Tasks.Items.Count != 0)
            {
                for (int i = chkdlstbx_Tasks.Items.Count - 1; i >= 0; i--)
                {
                    if (MessageBox.Show("Do you really want to remove the selected tasks?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (chkdlstbx_Tasks.GetItemChecked(i))
                        {
                            chkdlstbx_Tasks.Items.Remove(chkdlstbx_Tasks.Items[i]);
                            MessageBox.Show("Done tasks removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        } 
                    }
                }
            }
            else
                MessageBox.Show("Select a task to remove!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Excel_Click(object sender, EventArgs e)
        {
            Process.Start("excel.exe");
        }

        private void Ppt_Click(object sender, EventArgs e)
        {
            Process.Start("powerpnt.exe");
        }

        private void Word_Click(object sender, EventArgs e)
        {
            Process.Start("winword.exe");
        }

        private void Calculator_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }
        #endregion
    }
}
