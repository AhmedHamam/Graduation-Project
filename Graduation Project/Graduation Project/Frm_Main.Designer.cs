namespace Graduation_Project
{
    partial class Frm_Main
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
            this.lab_address = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Panel_medical = new System.Windows.Forms.Panel();
            this.Panel_management = new System.Windows.Forms.Panel();
            this.btn_management = new System.Windows.Forms.Button();
            this.btn_setting = new System.Windows.Forms.Button();
            this.btn_medical = new System.Windows.Forms.Button();
            this.Panel_setting = new System.Windows.Forms.Panel();
            this.label_booking_patient = new System.Windows.Forms.Label();
            this.label_patient_exit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.Panel_medical.SuspendLayout();
            this.Panel_management.SuspendLayout();
            this.Panel_setting.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.lab_address);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Tahoma", 13F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 103);
            this.panel1.TabIndex = 0;
            // 
            // lab_address
            // 
            this.lab_address.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lab_address.AutoSize = true;
            this.lab_address.Font = new System.Drawing.Font("Arabic Typesetting", 58F, System.Drawing.FontStyle.Bold);
            this.lab_address.Location = new System.Drawing.Point(123, 3);
            this.lab_address.Name = "lab_address";
            this.lab_address.Size = new System.Drawing.Size(542, 92);
            this.lab_address.TabIndex = 5;
            this.lab_address.Text = "مستشفى صحة المرأة الجامعى ";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.Panel_medical, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Panel_management, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_management, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_setting, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_medical, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Panel_setting, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 103);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(760, 378);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // Panel_medical
            // 
            this.Panel_medical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Panel_medical.Controls.Add(this.label7);
            this.Panel_medical.Controls.Add(this.label6);
            this.Panel_medical.Controls.Add(this.label_patient_exit);
            this.Panel_medical.Controls.Add(this.label_booking_patient);
            this.Panel_medical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_medical.Location = new System.Drawing.Point(509, 53);
            this.Panel_medical.Name = "Panel_medical";
            this.Panel_medical.Size = new System.Drawing.Size(248, 322);
            this.Panel_medical.TabIndex = 5;
            // 
            // Panel_management
            // 
            this.Panel_management.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Panel_management.Controls.Add(this.label5);
            this.Panel_management.Controls.Add(this.label4);
            this.Panel_management.Controls.Add(this.label3);
            this.Panel_management.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_management.Location = new System.Drawing.Point(256, 53);
            this.Panel_management.Name = "Panel_management";
            this.Panel_management.Size = new System.Drawing.Size(247, 322);
            this.Panel_management.TabIndex = 4;
            // 
            // btn_management
            // 
            this.btn_management.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_management.Location = new System.Drawing.Point(256, 3);
            this.btn_management.Name = "btn_management";
            this.btn_management.Size = new System.Drawing.Size(247, 44);
            this.btn_management.TabIndex = 2;
            this.btn_management.Text = "القسم الادارى ";
            this.btn_management.UseVisualStyleBackColor = true;
            // 
            // btn_setting
            // 
            this.btn_setting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_setting.Location = new System.Drawing.Point(3, 3);
            this.btn_setting.Name = "btn_setting";
            this.btn_setting.Size = new System.Drawing.Size(247, 44);
            this.btn_setting.TabIndex = 1;
            this.btn_setting.Text = "الاعدادات ";
            this.btn_setting.UseVisualStyleBackColor = true;
            // 
            // btn_medical
            // 
            this.btn_medical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_medical.Location = new System.Drawing.Point(509, 3);
            this.btn_medical.Name = "btn_medical";
            this.btn_medical.Size = new System.Drawing.Size(248, 44);
            this.btn_medical.TabIndex = 0;
            this.btn_medical.Text = "القسم الطبى ";
            this.btn_medical.UseVisualStyleBackColor = true;
            // 
            // Panel_setting
            // 
            this.Panel_setting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Panel_setting.Controls.Add(this.label2);
            this.Panel_setting.Controls.Add(this.label1);
            this.Panel_setting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_setting.Location = new System.Drawing.Point(3, 53);
            this.Panel_setting.Name = "Panel_setting";
            this.Panel_setting.Size = new System.Drawing.Size(247, 322);
            this.Panel_setting.TabIndex = 3;
            // 
            // label_booking_patient
            // 
            this.label_booking_patient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_booking_patient.AutoSize = true;
            this.label_booking_patient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_booking_patient.Font = new System.Drawing.Font("Tahoma", 15.25F, System.Drawing.FontStyle.Bold);
            this.label_booking_patient.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label_booking_patient.Location = new System.Drawing.Point(113, 6);
            this.label_booking_patient.Name = "label_booking_patient";
            this.label_booking_patient.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_booking_patient.Size = new System.Drawing.Size(129, 25);
            this.label_booking_patient.TabIndex = 0;
            this.label_booking_patient.Text = "حجز مريض ";
            this.label_booking_patient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_booking_patient.Click += new System.EventHandler(this.label_booking_patient_Click);
            // 
            // label_patient_exit
            // 
            this.label_patient_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_patient_exit.AutoSize = true;
            this.label_patient_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_patient_exit.Font = new System.Drawing.Font("Tahoma", 15.25F, System.Drawing.FontStyle.Bold);
            this.label_patient_exit.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label_patient_exit.Location = new System.Drawing.Point(106, 41);
            this.label_patient_exit.Name = "label_patient_exit";
            this.label_patient_exit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_patient_exit.Size = new System.Drawing.Size(139, 25);
            this.label_patient_exit.TabIndex = 1;
            this.label_patient_exit.Text = "خروج مريض ";
            this.label_patient_exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.25F, System.Drawing.FontStyle.Bold);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label1.Location = new System.Drawing.Point(49, 4);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(194, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "إدارة المستخدمين ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.25F, System.Drawing.FontStyle.Bold);
            this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label2.Location = new System.Drawing.Point(74, 39);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(168, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "إدارة الصلاحيات ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15.25F, System.Drawing.FontStyle.Bold);
            this.label3.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label3.Location = new System.Drawing.Point(100, 4);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(141, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "إدارة الاطباء   ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15.25F, System.Drawing.FontStyle.Bold);
            this.label4.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label4.Location = new System.Drawing.Point(61, 41);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(180, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "إدارة الموظفين    ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15.25F, System.Drawing.FontStyle.Bold);
            this.label5.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label5.Location = new System.Drawing.Point(97, 79);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(144, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "إدارة الاقسام ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Tahoma", 15.25F, System.Drawing.FontStyle.Bold);
            this.label6.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label6.Location = new System.Drawing.Point(99, 78);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(144, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "فحص مريض ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Tahoma", 15.25F, System.Drawing.FontStyle.Bold);
            this.label7.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label7.Location = new System.Drawing.Point(97, 117);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(147, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "متابعة مريض ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 481);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 13F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "النافذة الرئيسية";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MaximumSizeChanged += new System.EventHandler(this.Frm_Main_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.Panel_medical.ResumeLayout(false);
            this.Panel_medical.PerformLayout();
            this.Panel_management.ResumeLayout(false);
            this.Panel_management.PerformLayout();
            this.Panel_setting.ResumeLayout(false);
            this.Panel_setting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lab_address;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel Panel_medical;
        private System.Windows.Forms.Panel Panel_management;
        private System.Windows.Forms.Button btn_management;
        private System.Windows.Forms.Button btn_setting;
        private System.Windows.Forms.Button btn_medical;
        private System.Windows.Forms.Panel Panel_setting;
        private System.Windows.Forms.Label label_booking_patient;
        private System.Windows.Forms.Label label_patient_exit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}