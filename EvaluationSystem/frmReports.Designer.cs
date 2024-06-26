﻿namespace EvaluationSystem
{
    partial class frmReports
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
            this.CrystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.btnSubjPre = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.btnCurriculum = new System.Windows.Forms.Button();
            this.btnListStudents = new System.Windows.Forms.Button();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Button2 = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.cboSubjId = new System.Windows.Forms.ComboBox();
            this.GroupBox3.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CrystalReportViewer1
            // 
            this.CrystalReportViewer1.ActiveViewIndex = -1;
            this.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CrystalReportViewer1.CachedPageNumberPerDoc = 10;
            this.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CrystalReportViewer1.Location = new System.Drawing.Point(231, 0);
            this.CrystalReportViewer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CrystalReportViewer1.Name = "CrystalReportViewer1";
            this.CrystalReportViewer1.SelectionFormula = "";
            this.CrystalReportViewer1.ShowCloseButton = false;
            this.CrystalReportViewer1.ShowGroupTreeButton = false;
            this.CrystalReportViewer1.Size = new System.Drawing.Size(1025, 610);
            this.CrystalReportViewer1.TabIndex = 13;
            this.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.CrystalReportViewer1.ViewTimeSelectionFormula = "";
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.txtStudentId);
            this.GroupBox3.Controls.Add(this.Label3);
            this.GroupBox3.Controls.Add(this.btnSubjPre);
            this.GroupBox3.Location = new System.Drawing.Point(601, 293);
            this.GroupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox3.Size = new System.Drawing.Size(211, 134);
            this.GroupBox3.TabIndex = 11;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Subject to be Enrolled";
            // 
            // txtStudentId
            // 
            this.txtStudentId.Location = new System.Drawing.Point(12, 54);
            this.txtStudentId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(185, 23);
            this.txtStudentId.TabIndex = 3;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(8, 34);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(89, 16);
            this.Label3.TabIndex = 5;
            this.Label3.Text = "Student Id :";
            // 
            // btnSubjPre
            // 
            this.btnSubjPre.Location = new System.Drawing.Point(8, 86);
            this.btnSubjPre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubjPre.Name = "btnSubjPre";
            this.btnSubjPre.Size = new System.Drawing.Size(191, 32);
            this.btnSubjPre.TabIndex = 3;
            this.btnSubjPre.Text = "Preview";
            this.btnSubjPre.UseVisualStyleBackColor = true;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.Label2);
            this.GroupBox2.Controls.Add(this.txtCourse);
            this.GroupBox2.Controls.Add(this.btnCurriculum);
            this.GroupBox2.Location = new System.Drawing.Point(11, 58);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox2.Size = new System.Drawing.Size(211, 149);
            this.GroupBox2.TabIndex = 5;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Curriculum in every Course";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(8, 34);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(67, 16);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "Course :";
            // 
            // txtCourse
            // 
            this.txtCourse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCourse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCourse.Location = new System.Drawing.Point(8, 54);
            this.txtCourse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(193, 23);
            this.txtCourse.TabIndex = 4;
            // 
            // btnCurriculum
            // 
            this.btnCurriculum.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurriculum.Location = new System.Drawing.Point(8, 86);
            this.btnCurriculum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCurriculum.Name = "btnCurriculum";
            this.btnCurriculum.Size = new System.Drawing.Size(197, 34);
            this.btnCurriculum.TabIndex = 3;
            this.btnCurriculum.Text = "Preview";
            this.btnCurriculum.UseVisualStyleBackColor = true;
            this.btnCurriculum.Click += new System.EventHandler(this.btnCurriculum_Click);
            // 
            // btnListStudents
            // 
            this.btnListStudents.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListStudents.Location = new System.Drawing.Point(5, 14);
            this.btnListStudents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnListStudents.Name = "btnListStudents";
            this.btnListStudents.Size = new System.Drawing.Size(217, 34);
            this.btnListStudents.TabIndex = 2;
            this.btnListStudents.Text = "List of Students";
            this.btnListStudents.UseVisualStyleBackColor = true;
            this.btnListStudents.Click += new System.EventHandler(this.btnListStudents_Click);
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(8, 65);
            this.TextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(200, 26);
            this.TextBox1.TabIndex = 2;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.TextBox1);
            this.GroupBox1.Controls.Add(this.Button2);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(307, 127);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox1.Size = new System.Drawing.Size(217, 144);
            this.GroupBox1.TabIndex = 14;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Student Evaluation";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(8, 41);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(84, 20);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Student Id";
            // 
            // Button2
            // 
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.Location = new System.Drawing.Point(8, 101);
            this.Button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(201, 36);
            this.Button2.TabIndex = 2;
            this.Button2.Text = "Print Preview";
            this.Button2.UseVisualStyleBackColor = true;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(349, 258);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(69, 16);
            this.Label4.TabIndex = 16;
            this.Label4.Text = "Subject :";
            // 
            // Panel1
            // 
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.GroupBox2);
            this.Panel1.Controls.Add(this.btnListStudents);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(231, 610);
            this.Panel1.TabIndex = 12;
            // 
            // cboSubjId
            // 
            this.cboSubjId.FormattingEnabled = true;
            this.cboSubjId.Location = new System.Drawing.Point(351, 278);
            this.cboSubjId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboSubjId.Name = "cboSubjId";
            this.cboSubjId.Size = new System.Drawing.Size(192, 24);
            this.cboSubjId.TabIndex = 15;
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 610);
            this.Controls.Add(this.CrystalReportViewer1);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.cboSubjId);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmReports";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports Form";
            this.Load += new System.EventHandler(this.frmReports_Load);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal CrystalDecisions.Windows.Forms.CrystalReportViewer CrystalReportViewer1;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.TextBox txtStudentId;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button btnSubjPre;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtCourse;
        internal System.Windows.Forms.Button btnCurriculum;
        internal System.Windows.Forms.Button btnListStudents;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.ComboBox cboSubjId;
    }
}