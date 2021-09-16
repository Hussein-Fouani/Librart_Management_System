
namespace Librart_Management_System
{
    partial class LibraryMS
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
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sectionRapMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksUnregisteredToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterToolStripMenuItem,
            this.inventoryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(737, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
            this.memberToolStripMenuItem,
            this.roleToolStripMenuItem,
            this.planToolStripMenuItem,
            this.sectionToolStripMenuItem,
            this.rackToolStripMenuItem,
            this.sectionRapMasterToolStripMenuItem,
            this.changePasswordToolStripMenuItem});
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.masterToolStripMenuItem.Text = "Master";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.profileToolStripMenuItem.Text = "Profile";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // memberToolStripMenuItem
            // 
            this.memberToolStripMenuItem.Name = "memberToolStripMenuItem";
            this.memberToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.memberToolStripMenuItem.Text = "Member";
            this.memberToolStripMenuItem.Click += new System.EventHandler(this.memberToolStripMenuItem_Click);
            // 
            // roleToolStripMenuItem
            // 
            this.roleToolStripMenuItem.Name = "roleToolStripMenuItem";
            this.roleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.roleToolStripMenuItem.Text = "Role";
            this.roleToolStripMenuItem.Click += new System.EventHandler(this.roleToolStripMenuItem_Click_1);
            // 
            // planToolStripMenuItem
            // 
            this.planToolStripMenuItem.Name = "planToolStripMenuItem";
            this.planToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.planToolStripMenuItem.Text = "Plan";
            this.planToolStripMenuItem.Click += new System.EventHandler(this.planToolStripMenuItem_Click);
            // 
            // sectionToolStripMenuItem
            // 
            this.sectionToolStripMenuItem.Name = "sectionToolStripMenuItem";
            this.sectionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sectionToolStripMenuItem.Text = "Section";
            this.sectionToolStripMenuItem.Click += new System.EventHandler(this.sectionToolStripMenuItem_Click_1);
            // 
            // rackToolStripMenuItem
            // 
            this.rackToolStripMenuItem.Name = "rackToolStripMenuItem";
            this.rackToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rackToolStripMenuItem.Text = "Rack";
            this.rackToolStripMenuItem.Click += new System.EventHandler(this.rackToolStripMenuItem_Click);
            // 
            // sectionRapMasterToolStripMenuItem
            // 
            this.sectionRapMasterToolStripMenuItem.Name = "sectionRapMasterToolStripMenuItem";
            this.sectionRapMasterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sectionRapMasterToolStripMenuItem.Text = "SectionRackMap";
            this.sectionRapMasterToolStripMenuItem.Click += new System.EventHandler(this.sectionRapMasterToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseToolStripMenuItem,
            this.bookInToolStripMenuItem,
            this.booksUnregisteredToolStripMenuItem,
            this.memberTransactionToolStripMenuItem});
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // purchaseToolStripMenuItem
            // 
            this.purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
            this.purchaseToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.purchaseToolStripMenuItem.Text = "Purchase";
            // 
            // bookInToolStripMenuItem
            // 
            this.bookInToolStripMenuItem.Name = "bookInToolStripMenuItem";
            this.bookInToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.bookInToolStripMenuItem.Text = "Books Registered";
            // 
            // booksUnregisteredToolStripMenuItem
            // 
            this.booksUnregisteredToolStripMenuItem.Name = "booksUnregisteredToolStripMenuItem";
            this.booksUnregisteredToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.booksUnregisteredToolStripMenuItem.Text = "Books Unregistered";
            // 
            // memberTransactionToolStripMenuItem
            // 
            this.memberTransactionToolStripMenuItem.Name = "memberTransactionToolStripMenuItem";
            this.memberTransactionToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.memberTransactionToolStripMenuItem.Text = "Member Transaction";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 501);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(737, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // LibraryMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 523);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "LibraryMS";
            this.Text = "LibraryMS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LibraryMS_FormClosed);
            this.Load += new System.EventHandler(this.LibraryMS_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sectionRapMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksUnregisteredToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memberTransactionToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}



