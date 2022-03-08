namespace ListofStudentsbyClass
{
    partial class Form1
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
            System.Windows.Forms.Label classIDLabel;
            System.Windows.Forms.Label classNameLabel;
            System.Windows.Forms.Label yearLabel;
            this.btnView = new System.Windows.Forms.Button();
            this.sTUDENTDataGridView = new System.Windows.Forms.DataGridView();
            this.cboClassName = new System.Windows.Forms.ComboBox();
            this.cLASSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTUDENTMANAGEMENTDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTUDENT_MANAGEMENTDataSet = new ListofStudentsbyClass.STUDENT_MANAGEMENTDataSet();
            this.cboClassID = new System.Windows.Forms.ComboBox();
            this.cLASSTableAdapter = new ListofStudentsbyClass.STUDENT_MANAGEMENTDataSetTableAdapters.CLASSTableAdapter();
            this.cLASSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new ListofStudentsbyClass.STUDENT_MANAGEMENTDataSetTableAdapters.TableAdapterManager();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            classIDLabel = new System.Windows.Forms.Label();
            classNameLabel = new System.Windows.Forms.Label();
            yearLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLASSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTMANAGEMENTDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENT_MANAGEMENTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLASSBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // classIDLabel
            // 
            classIDLabel.AutoSize = true;
            classIDLabel.Location = new System.Drawing.Point(183, 42);
            classIDLabel.Name = "classIDLabel";
            classIDLabel.Size = new System.Drawing.Size(49, 13);
            classIDLabel.TabIndex = 9;
            classIDLabel.Text = "Class ID:";
            // 
            // classNameLabel
            // 
            classNameLabel.AutoSize = true;
            classNameLabel.Location = new System.Drawing.Point(183, 68);
            classNameLabel.Name = "classNameLabel";
            classNameLabel.Size = new System.Drawing.Size(66, 13);
            classNameLabel.TabIndex = 10;
            classNameLabel.Text = "Class Name:";
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnView.Location = new System.Drawing.Point(491, 42);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(100, 44);
            this.btnView.TabIndex = 16;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // sTUDENTDataGridView
            // 
            this.sTUDENTDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sTUDENTDataGridView.Location = new System.Drawing.Point(186, 150);
            this.sTUDENTDataGridView.Name = "sTUDENTDataGridView";
            this.sTUDENTDataGridView.Size = new System.Drawing.Size(432, 263);
            this.sTUDENTDataGridView.TabIndex = 13;
            // 
            // cboClassName
            // 
            this.cboClassName.DataSource = this.cLASSBindingSource;
            this.cboClassName.DisplayMember = "ClassName";
            this.cboClassName.FormattingEnabled = true;
            this.cboClassName.Location = new System.Drawing.Point(255, 65);
            this.cboClassName.Name = "cboClassName";
            this.cboClassName.Size = new System.Drawing.Size(183, 21);
            this.cboClassName.TabIndex = 14;
            // 
            // cLASSBindingSource
            // 
            this.cLASSBindingSource.DataMember = "CLASS";
            this.cLASSBindingSource.DataSource = this.sTUDENTMANAGEMENTDataSetBindingSource;
            // 
            // sTUDENTMANAGEMENTDataSetBindingSource
            // 
            this.sTUDENTMANAGEMENTDataSetBindingSource.DataSource = this.sTUDENT_MANAGEMENTDataSet;
            this.sTUDENTMANAGEMENTDataSetBindingSource.Position = 0;
            // 
            // sTUDENT_MANAGEMENTDataSet
            // 
            this.sTUDENT_MANAGEMENTDataSet.DataSetName = "STUDENT_MANAGEMENTDataSet";
            this.sTUDENT_MANAGEMENTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboClassID
            // 
            this.cboClassID.DataSource = this.cLASSBindingSource;
            this.cboClassID.DisplayMember = "ClassID";
            this.cboClassID.FormattingEnabled = true;
            this.cboClassID.Location = new System.Drawing.Point(255, 39);
            this.cboClassID.Name = "cboClassID";
            this.cboClassID.Size = new System.Drawing.Size(183, 21);
            this.cboClassID.TabIndex = 17;
            // 
            // cLASSTableAdapter
            // 
            this.cLASSTableAdapter.ClearBeforeFill = true;
            // 
            // cLASSBindingSource1
            // 
            this.cLASSBindingSource1.DataMember = "CLASS";
            this.cLASSBindingSource1.DataSource = this.sTUDENT_MANAGEMENTDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CLASSTableAdapter = this.cLASSTableAdapter;
            this.tableAdapterManager.STUDENTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ListofStudentsbyClass.STUDENT_MANAGEMENTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new System.Drawing.Point(183, 96);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new System.Drawing.Size(32, 13);
            yearLabel.TabIndex = 17;
            yearLabel.Text = "Year:";
            // 
            // yearTextBox
            // 
            this.yearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLASSBindingSource1, "Year", true));
            this.yearTextBox.Location = new System.Drawing.Point(255, 93);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(183, 20);
            this.yearTextBox.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(yearLabel);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.cboClassID);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.sTUDENTDataGridView);
            this.Controls.Add(this.cboClassName);
            this.Controls.Add(classIDLabel);
            this.Controls.Add(classNameLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLASSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTMANAGEMENTDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENT_MANAGEMENTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLASSBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.DataGridView sTUDENTDataGridView;
        private System.Windows.Forms.ComboBox cboClassName;
        private STUDENT_MANAGEMENTDataSet sTUDENT_MANAGEMENTDataSet;
        private System.Windows.Forms.BindingSource sTUDENTMANAGEMENTDataSetBindingSource;
        private System.Windows.Forms.ComboBox cboClassID;
        private System.Windows.Forms.BindingSource cLASSBindingSource;
        private STUDENT_MANAGEMENTDataSetTableAdapters.CLASSTableAdapter cLASSTableAdapter;
        private System.Windows.Forms.BindingSource cLASSBindingSource1;
        private STUDENT_MANAGEMENTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox yearTextBox;
    }
}

