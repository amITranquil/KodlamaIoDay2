namespace KodlamaIO_UI
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            btnCourses = new Button();
            cbCategory = new ComboBox();
            cbInstructor = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.Size = new Size(666, 311);
            dataGridView1.TabIndex = 0;
            // 
            // btnCourses
            // 
            btnCourses.Location = new Point(12, 21);
            btnCourses.Name = "btnCourses";
            btnCourses.Size = new Size(97, 57);
            btnCourses.TabIndex = 0;
            btnCourses.Text = "Courses";
            btnCourses.UseVisualStyleBackColor = true;
            btnCourses.Click += btnCourses_Click;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(132, 55);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(121, 23);
            cbCategory.TabIndex = 2;
            cbCategory.SelectedIndexChanged += cbCategory_SelectedIndexChanged;
            // 
            // cbInstructor
            // 
            cbInstructor.FormattingEnabled = true;
            cbInstructor.Location = new Point(269, 55);
            cbInstructor.Name = "cbInstructor";
            cbInstructor.Size = new Size(121, 23);
            cbInstructor.TabIndex = 3;
            cbInstructor.SelectedIndexChanged += cbInstructor_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(132, 21);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 3;
            label1.Text = "Categories";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(269, 21);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 3;
            label2.Text = "Instructors";
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(1, 111);
            panel1.Name = "panel1";
            panel1.Size = new Size(666, 311);
            panel1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(667, 423);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbInstructor);
            Controls.Add(cbCategory);
            Controls.Add(btnCourses);
            Name = "Form1";
            Text = "KodlamaIO";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnCourses;
        private ComboBox cbCategory;
        private ComboBox cbInstructor;
        private Label label1;
        private Label label2;
        private Panel panel1;
    }
}