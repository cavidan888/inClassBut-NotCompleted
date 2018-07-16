namespace Bawir
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnShowStud = new System.Windows.Forms.Button();
            this.btnStdeuntAdder = new System.Windows.Forms.Button();
            this.studCount = new System.Windows.Forms.TextBox();
            this.studName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.teachName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnShowTeacher = new System.Windows.Forms.Button();
            this.btnTeacherAdder = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.btnShowStud);
            this.panel1.Controls.Add(this.btnStdeuntAdder);
            this.panel1.Controls.Add(this.studCount);
            this.panel1.Controls.Add(this.studName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(31, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 419);
            this.panel1.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(129, 81);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(36, 179);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(260, 220);
            this.textBox2.TabIndex = 9;
            // 
            // btnShowStud
            // 
            this.btnShowStud.Location = new System.Drawing.Point(36, 122);
            this.btnShowStud.Name = "btnShowStud";
            this.btnShowStud.Size = new System.Drawing.Size(75, 23);
            this.btnShowStud.TabIndex = 8;
            this.btnShowStud.Text = "Show Pro";
            this.btnShowStud.UseVisualStyleBackColor = true;
            this.btnShowStud.Click += new System.EventHandler(this.btnShowStud_Click);
            // 
            // btnStdeuntAdder
            // 
            this.btnStdeuntAdder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStdeuntAdder.Location = new System.Drawing.Point(204, 122);
            this.btnStdeuntAdder.Name = "btnStdeuntAdder";
            this.btnStdeuntAdder.Size = new System.Drawing.Size(75, 23);
            this.btnStdeuntAdder.TabIndex = 6;
            this.btnStdeuntAdder.Text = "Add Student";
            this.btnStdeuntAdder.UseVisualStyleBackColor = true;
            this.btnStdeuntAdder.Click += new System.EventHandler(this.btnStdeuntAdder_Click);
            // 
            // studCount
            // 
            this.studCount.Location = new System.Drawing.Point(129, 53);
            this.studCount.Name = "studCount";
            this.studCount.Size = new System.Drawing.Size(150, 20);
            this.studCount.TabIndex = 4;
            // 
            // studName
            // 
            this.studName.Location = new System.Drawing.Point(129, 23);
            this.studName.Name = "studName";
            this.studName.Size = new System.Drawing.Size(150, 20);
            this.studName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Student Teachers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student Count";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Teacher Name";
            // 
            // teachName
            // 
            this.teachName.Location = new System.Drawing.Point(89, 28);
            this.teachName.Name = "teachName";
            this.teachName.Size = new System.Drawing.Size(180, 20);
            this.teachName.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTeacherAdder);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnShowTeacher);
            this.groupBox1.Controls.Add(this.teachName);
            this.groupBox1.Location = new System.Drawing.Point(366, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 418);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 110);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 302);
            this.textBox1.TabIndex = 9;
            // 
            // btnShowTeacher
            // 
            this.btnShowTeacher.Location = new System.Drawing.Point(21, 58);
            this.btnShowTeacher.Name = "btnShowTeacher";
            this.btnShowTeacher.Size = new System.Drawing.Size(99, 23);
            this.btnShowTeacher.TabIndex = 6;
            this.btnShowTeacher.Text = "Show Teachers";
            this.btnShowTeacher.UseVisualStyleBackColor = true;
            this.btnShowTeacher.Click += new System.EventHandler(this.btnShowTeacher_Click);
            // 
            // btnTeacherAdder
            // 
            this.btnTeacherAdder.Location = new System.Drawing.Point(151, 58);
            this.btnTeacherAdder.Name = "btnTeacherAdder";
            this.btnTeacherAdder.Size = new System.Drawing.Size(118, 23);
            this.btnTeacherAdder.TabIndex = 10;
            this.btnTeacherAdder.Text = "Add Teacher";
            this.btnTeacherAdder.UseVisualStyleBackColor = true;
            this.btnTeacherAdder.Click += new System.EventHandler(this.btnTeacherAdder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 529);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnShowStud;
        private System.Windows.Forms.Button btnStdeuntAdder;
        private System.Windows.Forms.TextBox studCount;
        private System.Windows.Forms.TextBox studName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox teachName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnShowTeacher;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnTeacherAdder;
    }
}

