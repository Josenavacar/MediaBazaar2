﻿namespace MediaBazaarSystem
{
    partial class AssignEmployeeSystem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnDone = new System.Windows.Forms.Button();
            this.lBoxAssignEmployee = new System.Windows.Forms.ListBox();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.comBoxEndTime = new System.Windows.Forms.ComboBox();
            this.comBoxStartTime = new System.Windows.Forms.ComboBox();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.dtpWorkDate = new System.Windows.Forms.DateTimePicker();
            this.lblWorkDate = new System.Windows.Forms.Label();
            this.lblAvailability = new System.Windows.Forms.Label();
            this.comboBoxAvailability = new System.Windows.Forms.ComboBox();
            this.comBoxEmployees = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDone.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.Location = new System.Drawing.Point(28, 460);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(520, 46);
            this.btnDone.TabIndex = 0;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // lBoxAssignEmployee
            // 
            this.lBoxAssignEmployee.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lBoxAssignEmployee.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBoxAssignEmployee.FormattingEnabled = true;
            this.lBoxAssignEmployee.ItemHeight = 23;
            this.lBoxAssignEmployee.Location = new System.Drawing.Point(28, 32);
            this.lBoxAssignEmployee.Name = "lBoxAssignEmployee";
            this.lBoxAssignEmployee.Size = new System.Drawing.Size(520, 142);
            this.lBoxAssignEmployee.TabIndex = 1;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEmployeeName.Location = new System.Drawing.Point(52, 208);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(95, 21);
            this.lblEmployeeName.TabIndex = 5;
            this.lblEmployeeName.Text = "Employee:";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblStartTime.Location = new System.Drawing.Point(51, 254);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(96, 21);
            this.lblStartTime.TabIndex = 6;
            this.lblStartTime.Text = "Start Time:";
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEndTime.Location = new System.Drawing.Point(59, 307);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(88, 21);
            this.lblEndTime.TabIndex = 7;
            this.lblEndTime.Text = "End Time:";
            // 
            // comBoxEndTime
            // 
            this.comBoxEndTime.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBoxEndTime.FormattingEnabled = true;
            this.comBoxEndTime.Location = new System.Drawing.Point(162, 304);
            this.comBoxEndTime.Name = "comBoxEndTime";
            this.comBoxEndTime.Size = new System.Drawing.Size(349, 29);
            this.comBoxEndTime.TabIndex = 2;
            this.comBoxEndTime.Text = "Select end time";
            // 
            // comBoxStartTime
            // 
            this.comBoxStartTime.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBoxStartTime.FormattingEnabled = true;
            this.comBoxStartTime.Location = new System.Drawing.Point(162, 251);
            this.comBoxStartTime.Name = "comBoxStartTime";
            this.comBoxStartTime.Size = new System.Drawing.Size(349, 29);
            this.comBoxStartTime.TabIndex = 3;
            this.comBoxStartTime.Text = "Select start time";
            // 
            // updateTimer
            // 
            this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
            // 
            // dtpWorkDate
            // 
            this.dtpWorkDate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpWorkDate.Location = new System.Drawing.Point(162, 353);
            this.dtpWorkDate.Name = "dtpWorkDate";
            this.dtpWorkDate.Size = new System.Drawing.Size(349, 28);
            this.dtpWorkDate.TabIndex = 8;
            // 
            // lblWorkDate
            // 
            this.lblWorkDate.AutoSize = true;
            this.lblWorkDate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblWorkDate.Location = new System.Drawing.Point(42, 359);
            this.lblWorkDate.Name = "lblWorkDate";
            this.lblWorkDate.Size = new System.Drawing.Size(105, 21);
            this.lblWorkDate.TabIndex = 9;
            this.lblWorkDate.Text = "Work Date:";
            // 
            // lblAvailability
            // 
            this.lblAvailability.AutoSize = true;
            this.lblAvailability.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailability.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAvailability.Location = new System.Drawing.Point(35, 402);
            this.lblAvailability.Name = "lblAvailability";
            this.lblAvailability.Size = new System.Drawing.Size(112, 21);
            this.lblAvailability.TabIndex = 11;
            this.lblAvailability.Text = "Is Available:";
            // 
            // comboBoxAvailability
            // 
            this.comboBoxAvailability.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAvailability.FormattingEnabled = true;
            this.comboBoxAvailability.Location = new System.Drawing.Point(162, 399);
            this.comboBoxAvailability.Name = "comboBoxAvailability";
            this.comboBoxAvailability.Size = new System.Drawing.Size(349, 29);
            this.comboBoxAvailability.TabIndex = 10;
            this.comboBoxAvailability.Text = "Yes";
            // 
            // comBoxEmployees
            // 
            this.comBoxEmployees.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBoxEmployees.FormattingEnabled = true;
            this.comBoxEmployees.Location = new System.Drawing.Point(162, 205);
            this.comBoxEmployees.Name = "comBoxEmployees";
            this.comBoxEmployees.Size = new System.Drawing.Size(349, 29);
            this.comBoxEmployees.TabIndex = 4;
            this.comBoxEmployees.Text = "Select employee";
            // 
            // AssignEmployeeSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(584, 525);
            this.Controls.Add(this.lblAvailability);
            this.Controls.Add(this.comboBoxAvailability);
            this.Controls.Add(this.lblWorkDate);
            this.Controls.Add(this.dtpWorkDate);
            this.Controls.Add(this.lblEndTime);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.comBoxEmployees);
            this.Controls.Add(this.comBoxStartTime);
            this.Controls.Add(this.comBoxEndTime);
            this.Controls.Add(this.lBoxAssignEmployee);
            this.Controls.Add(this.btnDone);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AssignEmployeeSystem";
            this.Text = "AssignEmployeeSystem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.ListBox lBoxAssignEmployee;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.ComboBox comBoxEndTime;
        private System.Windows.Forms.ComboBox comBoxStartTime;
        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.DateTimePicker dtpWorkDate;
        private System.Windows.Forms.Label lblWorkDate;
        private System.Windows.Forms.Label lblAvailability;
        private System.Windows.Forms.ComboBox comboBoxAvailability;
        private System.Windows.Forms.ComboBox comBoxEmployees;
    }
}