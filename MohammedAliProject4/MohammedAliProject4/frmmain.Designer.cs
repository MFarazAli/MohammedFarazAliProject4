namespace MohammedAliProject4
{
    partial class frmmain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmain));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNOC = new System.Windows.Forms.TextBox();
            this.txtFLN = new System.Windows.Forms.TextBox();
            this.mcCSD = new System.Windows.Forms.MonthCalendar();
            this.btnHybrid = new System.Windows.Forms.RadioButton();
            this.btnOnline = new System.Windows.Forms.RadioButton();
            this.coursesDataSet = new MohammedAliProject4.coursesDataSet();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coursesTableAdapter = new MohammedAliProject4.coursesDataSetTableAdapters.CoursesTableAdapter();
            this.tableAdapterManager = new MohammedAliProject4.coursesDataSetTableAdapters.TableAdapterManager();
            this.coursesComboBox = new System.Windows.Forms.ComboBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.txtO_NOC = new System.Windows.Forms.TextBox();
            this.txtO_FLN = new System.Windows.Forms.TextBox();
            this.txtO_CSD = new System.Windows.Forms.TextBox();
            this.txtO_Course = new System.Windows.Forms.TextBox();
            this.txtO_CM = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the Number of Courses";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(30, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter your First and Last name";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(30, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter the Class Start Date";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(30, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Select the Course";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(30, 406);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(254, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Select Class Mode";
            // 
            // txtNOC
            // 
            this.txtNOC.Location = new System.Drawing.Point(477, 32);
            this.txtNOC.Name = "txtNOC";
            this.txtNOC.Size = new System.Drawing.Size(300, 22);
            this.txtNOC.TabIndex = 5;
            // 
            // txtFLN
            // 
            this.txtFLN.Location = new System.Drawing.Point(477, 79);
            this.txtFLN.Name = "txtFLN";
            this.txtFLN.Size = new System.Drawing.Size(300, 22);
            this.txtFLN.TabIndex = 6;
            // 
            // mcCSD
            // 
            this.mcCSD.Location = new System.Drawing.Point(477, 132);
            this.mcCSD.MaxSelectionCount = 31;
            this.mcCSD.Name = "mcCSD";
            this.mcCSD.SelectionRange = new System.Windows.Forms.SelectionRange(new System.DateTime(2019, 1, 1, 0, 0, 0, 0), new System.DateTime(2019, 1, 31, 0, 0, 0, 0));
            this.mcCSD.TabIndex = 7;
            // 
            // btnHybrid
            // 
            this.btnHybrid.AutoSize = true;
            this.btnHybrid.Location = new System.Drawing.Point(385, 408);
            this.btnHybrid.Name = "btnHybrid";
            this.btnHybrid.Size = new System.Drawing.Size(70, 21);
            this.btnHybrid.TabIndex = 9;
            this.btnHybrid.TabStop = true;
            this.btnHybrid.Text = "Hybrid";
            this.btnHybrid.UseVisualStyleBackColor = true;
            this.btnHybrid.CheckedChanged += new System.EventHandler(this.btnHybrid_CheckedChanged);
            // 
            // btnOnline
            // 
            this.btnOnline.AutoSize = true;
            this.btnOnline.Location = new System.Drawing.Point(606, 408);
            this.btnOnline.Name = "btnOnline";
            this.btnOnline.Size = new System.Drawing.Size(70, 21);
            this.btnOnline.TabIndex = 10;
            this.btnOnline.TabStop = true;
            this.btnOnline.Text = "Online";
            this.btnOnline.UseVisualStyleBackColor = true;
            this.btnOnline.CheckedChanged += new System.EventHandler(this.btnOnline_CheckedChanged);
            // 
            // coursesDataSet
            // 
            this.coursesDataSet.DataSetName = "coursesDataSet";
            this.coursesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataMember = "Courses";
            this.coursesBindingSource.DataSource = this.coursesDataSet;
            // 
            // coursesTableAdapter
            // 
            this.coursesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CoursesTableAdapter = this.coursesTableAdapter;
            this.tableAdapterManager.UpdateOrder = MohammedAliProject4.coursesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // coursesComboBox
            // 
            this.coursesComboBox.DataSource = this.coursesBindingSource;
            this.coursesComboBox.DisplayMember = "Code";
            this.coursesComboBox.FormattingEnabled = true;
            this.coursesComboBox.Location = new System.Drawing.Point(477, 362);
            this.coursesComboBox.Name = "coursesComboBox";
            this.coursesComboBox.Size = new System.Drawing.Size(300, 24);
            this.coursesComboBox.TabIndex = 11;
            this.coursesComboBox.ValueMember = "Code";
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(174, 475);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(110, 40);
            this.btnSet.TabIndex = 12;
            this.btnSet.Text = "SET";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(520, 475);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(110, 40);
            this.btnGet.TabIndex = 13;
            this.btnGet.Text = "GET";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // txtO_NOC
            // 
            this.txtO_NOC.Location = new System.Drawing.Point(520, 547);
            this.txtO_NOC.Name = "txtO_NOC";
            this.txtO_NOC.Size = new System.Drawing.Size(257, 22);
            this.txtO_NOC.TabIndex = 14;
            // 
            // txtO_FLN
            // 
            this.txtO_FLN.Location = new System.Drawing.Point(520, 594);
            this.txtO_FLN.Name = "txtO_FLN";
            this.txtO_FLN.Size = new System.Drawing.Size(257, 22);
            this.txtO_FLN.TabIndex = 15;
            // 
            // txtO_CSD
            // 
            this.txtO_CSD.Location = new System.Drawing.Point(520, 647);
            this.txtO_CSD.Name = "txtO_CSD";
            this.txtO_CSD.Size = new System.Drawing.Size(257, 22);
            this.txtO_CSD.TabIndex = 16;
            // 
            // txtO_Course
            // 
            this.txtO_Course.Location = new System.Drawing.Point(520, 696);
            this.txtO_Course.Name = "txtO_Course";
            this.txtO_Course.Size = new System.Drawing.Size(257, 22);
            this.txtO_Course.TabIndex = 17;
            this.txtO_Course.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtO_CM
            // 
            this.txtO_CM.Location = new System.Drawing.Point(520, 748);
            this.txtO_CM.Name = "txtO_CM";
            this.txtO_CM.Size = new System.Drawing.Size(257, 22);
            this.txtO_CM.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 751);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(254, 23);
            this.label6.TabIndex = 23;
            this.label6.Text = "Class Mode";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 695);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(254, 23);
            this.label7.TabIndex = 22;
            this.label7.Text = "Course";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 650);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(254, 23);
            this.label8.TabIndex = 21;
            this.label8.Text = "Class Start Date";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 597);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(254, 23);
            this.label9.TabIndex = 20;
            this.label9.Text = "First and Last name";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(30, 550);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(254, 23);
            this.label10.TabIndex = 19;
            this.label10.Text = "Number of Courses";
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(310, 792);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(101, 50);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmmain
            // 
            this.AcceptButton = this.btnSet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(851, 953);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtO_CM);
            this.Controls.Add(this.txtO_Course);
            this.Controls.Add(this.txtO_CSD);
            this.Controls.Add(this.txtO_FLN);
            this.Controls.Add(this.txtO_NOC);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.coursesComboBox);
            this.Controls.Add(this.btnOnline);
            this.Controls.Add(this.btnHybrid);
            this.Controls.Add(this.mcCSD);
            this.Controls.Add(this.txtFLN);
            this.Controls.Add(this.txtNOC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmmain";
            this.Text = "COURSE CATALOG";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNOC;
        private System.Windows.Forms.TextBox txtFLN;
        private System.Windows.Forms.MonthCalendar mcCSD;
        private System.Windows.Forms.RadioButton btnHybrid;
        private System.Windows.Forms.RadioButton btnOnline;
        private coursesDataSet coursesDataSet;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private coursesDataSetTableAdapters.CoursesTableAdapter coursesTableAdapter;
        private coursesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox coursesComboBox;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.TextBox txtO_NOC;
        private System.Windows.Forms.TextBox txtO_FLN;
        private System.Windows.Forms.TextBox txtO_CSD;
        private System.Windows.Forms.TextBox txtO_Course;
        private System.Windows.Forms.TextBox txtO_CM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnExit;
    }
}

