
namespace LoginForm
{
    partial class examdetails
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.courseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hallDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examDetails4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new LoginForm.databaseDataSet();
            this.examdetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databazaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databazaDataSet = new LoginForm.databazaDataSet();
            this.examdetailsTableAdapter = new LoginForm.databazaDataSetTableAdapters.examdetailsTableAdapter();
            this.databazaDataSet1 = new LoginForm.databazaDataSet1();
            this.examdetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.examdetailsTableAdapter1 = new LoginForm.databazaDataSet1TableAdapters.examdetailsTableAdapter();
            this.examDetails4TableAdapter = new LoginForm.databaseDataSetTableAdapters.examDetails4TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examDetails4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examdetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databazaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databazaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databazaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examdetailsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseIDDataGridViewTextBoxColumn,
            this.courseNameDataGridViewTextBoxColumn,
            this.examTimeDataGridViewTextBoxColumn,
            this.hallDataGridViewTextBoxColumn,
            this.professorDataGridViewTextBoxColumn,
            this.examDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.examDetails4BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1066, 442);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // courseIDDataGridViewTextBoxColumn
            // 
            this.courseIDDataGridViewTextBoxColumn.DataPropertyName = "CourseID";
            this.courseIDDataGridViewTextBoxColumn.HeaderText = "CourseID";
            this.courseIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.courseIDDataGridViewTextBoxColumn.Name = "courseIDDataGridViewTextBoxColumn";
            this.courseIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.courseIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // courseNameDataGridViewTextBoxColumn
            // 
            this.courseNameDataGridViewTextBoxColumn.DataPropertyName = "CourseName";
            this.courseNameDataGridViewTextBoxColumn.HeaderText = "CourseName";
            this.courseNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.courseNameDataGridViewTextBoxColumn.Name = "courseNameDataGridViewTextBoxColumn";
            this.courseNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.courseNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // examTimeDataGridViewTextBoxColumn
            // 
            this.examTimeDataGridViewTextBoxColumn.DataPropertyName = "ExamTime";
            this.examTimeDataGridViewTextBoxColumn.HeaderText = "ExamTime";
            this.examTimeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.examTimeDataGridViewTextBoxColumn.Name = "examTimeDataGridViewTextBoxColumn";
            this.examTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.examTimeDataGridViewTextBoxColumn.Width = 150;
            // 
            // hallDataGridViewTextBoxColumn
            // 
            this.hallDataGridViewTextBoxColumn.DataPropertyName = "Hall";
            this.hallDataGridViewTextBoxColumn.HeaderText = "Hall";
            this.hallDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.hallDataGridViewTextBoxColumn.Name = "hallDataGridViewTextBoxColumn";
            this.hallDataGridViewTextBoxColumn.ReadOnly = true;
            this.hallDataGridViewTextBoxColumn.Width = 150;
            // 
            // professorDataGridViewTextBoxColumn
            // 
            this.professorDataGridViewTextBoxColumn.DataPropertyName = "Professor";
            this.professorDataGridViewTextBoxColumn.HeaderText = "Professor";
            this.professorDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.professorDataGridViewTextBoxColumn.Name = "professorDataGridViewTextBoxColumn";
            this.professorDataGridViewTextBoxColumn.ReadOnly = true;
            this.professorDataGridViewTextBoxColumn.Width = 150;
            // 
            // examDateDataGridViewTextBoxColumn
            // 
            this.examDateDataGridViewTextBoxColumn.DataPropertyName = "ExamDate";
            this.examDateDataGridViewTextBoxColumn.HeaderText = "ExamDate";
            this.examDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.examDateDataGridViewTextBoxColumn.Name = "examDateDataGridViewTextBoxColumn";
            this.examDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.examDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // examDetails4BindingSource
            // 
            this.examDetails4BindingSource.DataMember = "examDetails4";
            this.examDetails4BindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "databaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // examdetailsBindingSource
            // 
            this.examdetailsBindingSource.DataMember = "examdetails";
            this.examdetailsBindingSource.DataSource = this.databazaDataSetBindingSource;
            // 
            // databazaDataSetBindingSource
            // 
            this.databazaDataSetBindingSource.DataSource = this.databazaDataSet;
            this.databazaDataSetBindingSource.Position = 0;
            // 
            // databazaDataSet
            // 
            this.databazaDataSet.DataSetName = "databazaDataSet";
            this.databazaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // examdetailsTableAdapter
            // 
            this.examdetailsTableAdapter.ClearBeforeFill = true;
            // 
            // databazaDataSet1
            // 
            this.databazaDataSet1.DataSetName = "databazaDataSet1";
            this.databazaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // examdetailsBindingSource1
            // 
            this.examdetailsBindingSource1.DataMember = "examdetails";
            this.examdetailsBindingSource1.DataSource = this.databazaDataSet1;
            // 
            // examdetailsTableAdapter1
            // 
            this.examdetailsTableAdapter1.ClearBeforeFill = true;
            // 
            // examDetails4TableAdapter
            // 
            this.examDetails4TableAdapter.ClearBeforeFill = true;
            // 
            // examdetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "examdetails";
            this.Text = "examdetails";
            this.Load += new System.EventHandler(this.examdetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examDetails4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examdetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databazaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databazaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databazaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examdetailsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource databazaDataSetBindingSource;
        private databazaDataSet databazaDataSet;
        private System.Windows.Forms.BindingSource examdetailsBindingSource;
        private databazaDataSetTableAdapters.examdetailsTableAdapter examdetailsTableAdapter;
        private databazaDataSet1 databazaDataSet1;
        private System.Windows.Forms.BindingSource examdetailsBindingSource1;
        private databazaDataSet1TableAdapters.examdetailsTableAdapter examdetailsTableAdapter1;
        private databaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource examDetails4BindingSource;
        private databaseDataSetTableAdapters.examDetails4TableAdapter examDetails4TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn examTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hallDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn professorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn examDateDataGridViewTextBoxColumn;
    }
}