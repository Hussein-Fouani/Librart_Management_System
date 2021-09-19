
namespace Librart_Management_System
{
    partial class Rolecs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Role_ID_Label = new System.Windows.Forms.Label();
            this.Role_Name_Lb = new System.Windows.Forms.Label();
            this.Book_Status = new System.Windows.Forms.Label();
            this.Role_id_textbox = new System.Windows.Forms.TextBox();
            this.Role_Name_txtbx = new System.Windows.Forms.TextBox();
            this.status_cmbbx = new System.Windows.Forms.ComboBox();
            this.New_Button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Save_button = new System.Windows.Forms.Button();
            this.Update_Button = new System.Windows.Forms.Button();
            this.Role_Grid_view = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.role_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role_Name_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Role_Grid_view)).BeginInit();
            this.SuspendLayout();
            // 
            // Role_ID_Label
            // 
            this.Role_ID_Label.AutoSize = true;
            this.Role_ID_Label.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Role_ID_Label.Location = new System.Drawing.Point(62, 41);
            this.Role_ID_Label.Name = "Role_ID_Label";
            this.Role_ID_Label.Size = new System.Drawing.Size(55, 17);
            this.Role_ID_Label.TabIndex = 0;
            this.Role_ID_Label.Text = "Book ID:";
            // 
            // Role_Name_Lb
            // 
            this.Role_Name_Lb.AutoSize = true;
            this.Role_Name_Lb.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Role_Name_Lb.Location = new System.Drawing.Point(62, 76);
            this.Role_Name_Lb.Name = "Role_Name_Lb";
            this.Role_Name_Lb.Size = new System.Drawing.Size(82, 17);
            this.Role_Name_Lb.TabIndex = 1;
            this.Role_Name_Lb.Text = "Book Name: ";
            // 
            // Book_Status
            // 
            this.Book_Status.AutoSize = true;
            this.Book_Status.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Book_Status.Location = new System.Drawing.Point(62, 119);
            this.Book_Status.Name = "Book_Status";
            this.Book_Status.Size = new System.Drawing.Size(51, 17);
            this.Book_Status.TabIndex = 1;
            this.Book_Status.Text = "Status: ";
            // 
            // Role_id_textbox
            // 
            this.Role_id_textbox.Location = new System.Drawing.Point(150, 39);
            this.Role_id_textbox.Name = "Role_id_textbox";
            this.Role_id_textbox.ReadOnly = true;
            this.Role_id_textbox.Size = new System.Drawing.Size(215, 23);
            this.Role_id_textbox.TabIndex = 2;
            // 
            // Role_Name_txtbx
            // 
            this.Role_Name_txtbx.Location = new System.Drawing.Point(150, 70);
            this.Role_Name_txtbx.Name = "Role_Name_txtbx";
            this.Role_Name_txtbx.Size = new System.Drawing.Size(215, 23);
            this.Role_Name_txtbx.TabIndex = 2;
            // 
            // status_cmbbx
            // 
            this.status_cmbbx.FormattingEnabled = true;
            this.status_cmbbx.Items.AddRange(new object[] {
            "ACTIVE",
            "INACTIVE"});
            this.status_cmbbx.Location = new System.Drawing.Point(150, 117);
            this.status_cmbbx.Name = "status_cmbbx";
            this.status_cmbbx.Size = new System.Drawing.Size(215, 23);
            this.status_cmbbx.TabIndex = 3;
            // 
            // New_Button
            // 
            this.New_Button.BackColor = System.Drawing.Color.Lime;
            this.New_Button.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.New_Button.FlatAppearance.BorderSize = 13;
            this.New_Button.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.New_Button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.New_Button.Location = new System.Drawing.Point(423, 35);
            this.New_Button.Name = "New_Button";
            this.New_Button.Size = new System.Drawing.Size(97, 36);
            this.New_Button.TabIndex = 4;
            this.New_Button.Text = "New";
            this.New_Button.UseVisualStyleBackColor = false;
            this.New_Button.Click += new System.EventHandler(this.New_Button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.BackColor = System.Drawing.Color.DarkRed;
            this.Delete_button.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.Delete_button.FlatAppearance.BorderSize = 13;
            this.Delete_button.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Delete_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Delete_button.Location = new System.Drawing.Point(575, 35);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(97, 36);
            this.Delete_button.TabIndex = 4;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = false;
            // 
            // Save_button
            // 
            this.Save_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Save_button.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.Save_button.FlatAppearance.BorderSize = 13;
            this.Save_button.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Save_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Save_button.Location = new System.Drawing.Point(575, 100);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(97, 36);
            this.Save_button.TabIndex = 4;
            this.Save_button.Text = "Save";
            this.Save_button.UseVisualStyleBackColor = false;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // Update_Button
            // 
            this.Update_Button.BackColor = System.Drawing.Color.Navy;
            this.Update_Button.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.Update_Button.FlatAppearance.BorderSize = 13;
            this.Update_Button.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Update_Button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Update_Button.Location = new System.Drawing.Point(423, 100);
            this.Update_Button.Name = "Update_Button";
            this.Update_Button.Size = new System.Drawing.Size(97, 36);
            this.Update_Button.TabIndex = 4;
            this.Update_Button.Text = "Update";
            this.Update_Button.UseVisualStyleBackColor = false;
            this.Update_Button.Click += new System.EventHandler(this.Update_Button_Click);
            // 
            // Role_Grid_view
            // 
            this.Role_Grid_view.AllowUserToAddRows = false;
            this.Role_Grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Role_Grid_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.role_column,
            this.Role_Name_column,
            this.Status_Column});
            this.Role_Grid_view.Location = new System.Drawing.Point(12, 204);
            this.Role_Grid_view.Name = "Role_Grid_view";
            this.Role_Grid_view.RowTemplate.Height = 25;
            this.Role_Grid_view.Size = new System.Drawing.Size(693, 205);
            this.Role_Grid_view.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(319, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 6;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // role_column
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.role_column.DefaultCellStyle = dataGridViewCellStyle1;
            this.role_column.HeaderText = "Role ID";
            this.role_column.Name = "role_column";
            // 
            // Role_Name_column
            // 
            this.Role_Name_column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Role_Name_column.DefaultCellStyle = dataGridViewCellStyle2;
            this.Role_Name_column.HeaderText = "Role Name";
            this.Role_Name_column.Name = "Role_Name_column";
            // 
            // Status_Column
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Status_Column.DefaultCellStyle = dataGridViewCellStyle3;
            this.Status_Column.HeaderText = "Status";
            this.Status_Column.Name = "Status_Column";
            // 
            // Rolecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 430);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Role_Grid_view);
            this.Controls.Add(this.Update_Button);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.New_Button);
            this.Controls.Add(this.status_cmbbx);
            this.Controls.Add(this.Role_Name_txtbx);
            this.Controls.Add(this.Role_id_textbox);
            this.Controls.Add(this.Book_Status);
            this.Controls.Add(this.Role_Name_Lb);
            this.Controls.Add(this.Role_ID_Label);
            this.Name = "Rolecs";
            this.Text = "Rolecs";
            this.Load += new System.EventHandler(this.Rolecs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Role_Grid_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Role_ID_Label;
        private System.Windows.Forms.Label Role_Name_Lb;
        private System.Windows.Forms.Label Book_Status;
        private System.Windows.Forms.TextBox Role_id_textbox;
        private System.Windows.Forms.TextBox Role_Name_txtbx;
        private System.Windows.Forms.ComboBox status_cmbbx;
        private System.Windows.Forms.Button New_Button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Button Update_Button;
        private System.Windows.Forms.DataGridView Role_Grid_view;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn role_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role_Name_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status_Column;
    }
}