
namespace ProductivityCenter
{
    partial class frm_MainScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Schedule = new System.Windows.Forms.Button();
            this.btn_Notes = new System.Windows.Forms.Button();
            this.btn_ToDo = new System.Windows.Forms.Button();
            this.btn_Tools = new System.Windows.Forms.Button();
            this.workArea = new System.Windows.Forms.Panel();
            this.chkdlstbx_Tasks = new System.Windows.Forms.CheckedListBox();
            this.lbl_defaultText = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.workArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_Schedule);
            this.flowLayoutPanel1.Controls.Add(this.btn_Notes);
            this.flowLayoutPanel1.Controls.Add(this.btn_ToDo);
            this.flowLayoutPanel1.Controls.Add(this.btn_Tools);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(207, 824);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btn_Schedule
            // 
            this.btn_Schedule.BackgroundImage = global::ProductivityCenter.Properties.Resources.schedule;
            this.btn_Schedule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Schedule.Location = new System.Drawing.Point(3, 3);
            this.btn_Schedule.Name = "btn_Schedule";
            this.btn_Schedule.Size = new System.Drawing.Size(200, 200);
            this.btn_Schedule.TabIndex = 1;
            this.btn_Schedule.UseVisualStyleBackColor = true;
            this.btn_Schedule.Click += new System.EventHandler(this.button_Click);
            // 
            // btn_Notes
            // 
            this.btn_Notes.BackgroundImage = global::ProductivityCenter.Properties.Resources.notes;
            this.btn_Notes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Notes.Location = new System.Drawing.Point(3, 209);
            this.btn_Notes.Name = "btn_Notes";
            this.btn_Notes.Size = new System.Drawing.Size(200, 200);
            this.btn_Notes.TabIndex = 0;
            this.btn_Notes.UseVisualStyleBackColor = true;
            this.btn_Notes.Click += new System.EventHandler(this.button_Click);
            // 
            // btn_ToDo
            // 
            this.btn_ToDo.BackgroundImage = global::ProductivityCenter.Properties.Resources.todo;
            this.btn_ToDo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ToDo.Location = new System.Drawing.Point(3, 415);
            this.btn_ToDo.Name = "btn_ToDo";
            this.btn_ToDo.Size = new System.Drawing.Size(200, 200);
            this.btn_ToDo.TabIndex = 2;
            this.btn_ToDo.UseVisualStyleBackColor = true;
            this.btn_ToDo.Click += new System.EventHandler(this.button_Click);
            // 
            // btn_Tools
            // 
            this.btn_Tools.BackgroundImage = global::ProductivityCenter.Properties.Resources.tools;
            this.btn_Tools.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Tools.Location = new System.Drawing.Point(3, 621);
            this.btn_Tools.Name = "btn_Tools";
            this.btn_Tools.Size = new System.Drawing.Size(200, 200);
            this.btn_Tools.TabIndex = 3;
            this.btn_Tools.UseVisualStyleBackColor = true;
            this.btn_Tools.Click += new System.EventHandler(this.button_Click);
            // 
            // workArea
            // 
            this.workArea.Controls.Add(this.chkdlstbx_Tasks);
            this.workArea.Controls.Add(this.lbl_defaultText);
            this.workArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workArea.Location = new System.Drawing.Point(207, 0);
            this.workArea.Name = "workArea";
            this.workArea.Size = new System.Drawing.Size(775, 824);
            this.workArea.TabIndex = 1;
            // 
            // chkdlstbx_Tasks
            // 
            this.chkdlstbx_Tasks.FormattingEnabled = true;
            this.chkdlstbx_Tasks.Location = new System.Drawing.Point(37, 150);
            this.chkdlstbx_Tasks.Name = "chkdlstbx_Tasks";
            this.chkdlstbx_Tasks.Size = new System.Drawing.Size(700, 548);
            this.chkdlstbx_Tasks.TabIndex = 1;
            this.chkdlstbx_Tasks.ThreeDCheckBoxes = true;
            this.chkdlstbx_Tasks.Visible = false;
            // 
            // lbl_defaultText
            // 
            this.lbl_defaultText.AutoSize = true;
            this.lbl_defaultText.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_defaultText.Location = new System.Drawing.Point(89, 395);
            this.lbl_defaultText.Name = "lbl_defaultText";
            this.lbl_defaultText.Size = new System.Drawing.Size(597, 34);
            this.lbl_defaultText.TabIndex = 0;
            this.lbl_defaultText.Text = "Seleciona Um Botão Lateral Para Continuar";
            // 
            // frm_MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 824);
            this.Controls.Add(this.workArea);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productivity Center";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_MainScreen_FormClosed);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.workArea.ResumeLayout(false);
            this.workArea.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_Notes;
        private System.Windows.Forms.Button btn_Schedule;
        private System.Windows.Forms.Button btn_ToDo;
        private System.Windows.Forms.Button btn_Tools;
        private System.Windows.Forms.Panel workArea;
        private System.Windows.Forms.Label lbl_defaultText;
        private System.Windows.Forms.CheckedListBox chkdlstbx_Tasks;
    }
}

