
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
            this.Book_ID_Label = new System.Windows.Forms.Label();
            this.Book_Name_Lb = new System.Windows.Forms.Label();
            this.Book_Status = new System.Windows.Forms.Label();
            this.book_id_textbox = new System.Windows.Forms.TextBox();
            this.bkname_txtbx = new System.Windows.Forms.TextBox();
            this.status_cmbbx = new System.Windows.Forms.ComboBox();
            this.New_Button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Save_button = new System.Windows.Forms.Button();
            this.Update_Button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Book_ID_Label
            // 
            this.Book_ID_Label.AutoSize = true;
            this.Book_ID_Label.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Book_ID_Label.Location = new System.Drawing.Point(62, 41);
            this.Book_ID_Label.Name = "Book_ID_Label";
            this.Book_ID_Label.Size = new System.Drawing.Size(55, 17);
            this.Book_ID_Label.TabIndex = 0;
            this.Book_ID_Label.Text = "Book ID:";
            // 
            // Book_Name_Lb
            // 
            this.Book_Name_Lb.AutoSize = true;
            this.Book_Name_Lb.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Book_Name_Lb.Location = new System.Drawing.Point(62, 76);
            this.Book_Name_Lb.Name = "Book_Name_Lb";
            this.Book_Name_Lb.Size = new System.Drawing.Size(82, 17);
            this.Book_Name_Lb.TabIndex = 1;
            this.Book_Name_Lb.Text = "Book Name: ";
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
            // book_id_textbox
            // 
            this.book_id_textbox.Location = new System.Drawing.Point(150, 39);
            this.book_id_textbox.Name = "book_id_textbox";
            this.book_id_textbox.ReadOnly = true;
            this.book_id_textbox.Size = new System.Drawing.Size(215, 23);
            this.book_id_textbox.TabIndex = 2;
            // 
            // bkname_txtbx
            // 
            this.bkname_txtbx.Location = new System.Drawing.Point(150, 70);
            this.bkname_txtbx.Name = "bkname_txtbx";
            this.bkname_txtbx.Size = new System.Drawing.Size(215, 23);
            this.bkname_txtbx.TabIndex = 2;
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(693, 205);
            this.dataGridView1.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(319, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 6;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // Rolecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 430);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Update_Button);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.New_Button);
            this.Controls.Add(this.status_cmbbx);
            this.Controls.Add(this.bkname_txtbx);
            this.Controls.Add(this.book_id_textbox);
            this.Controls.Add(this.Book_Status);
            this.Controls.Add(this.Book_Name_Lb);
            this.Controls.Add(this.Book_ID_Label);
            this.Name = "Rolecs";
            this.Text = "Rolecs";
            this.Load += new System.EventHandler(this.Rolecs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Book_ID_Label;
        private System.Windows.Forms.Label Book_Name_Lb;
        private System.Windows.Forms.Label Book_Status;
        private System.Windows.Forms.TextBox book_id_textbox;
        private System.Windows.Forms.TextBox bkname_txtbx;
        private System.Windows.Forms.ComboBox status_cmbbx;
        private System.Windows.Forms.Button New_Button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Button Update_Button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}