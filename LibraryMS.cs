using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Librart_Management_System
{
    public partial class LibraryMS : Form
    {

        public LibraryMS()
        {
            InitializeComponent();
        }

        

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void LibraryMS_Load(object sender, EventArgs e)
        {

        }

        private void LibraryMS_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void roleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sectionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void roleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Role objt = new Role();
            objt.MdiParent = this;
            objt.Show();
            objt.StartPosition = FormStartPosition.CenterScreen;
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.MdiParent = this;
            profile.Show();
            profile.StartPosition = FormStartPosition.CenterScreen;
        }

        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Member member = new member();
            member.MdiParent = this;
            member.Show();
            member.StartPosition = FormStartPosition.CenterScreen;
        }

        private void planToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Plan plan = new Plan();
            plan.MdiParent = this;
            plan.Show();
            plan.StartPosition = FormStartPosition.CenterScreen;
        }

        private void sectionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Section section = new Section();
            section.MdiParent = this;
            section.Show();
            section.StartPosition = FormStartPosition.CenterScreen;
        }

        private void rackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rack rack = new Section();
            rack.MdiParent = this;
            rack.Show();
            rack.StartPosition = FormStartPosition.CenterScreen;
        }

        private void sectionRapMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SectionRackMap sectionRack = new SectionRackMap();
            sectionRack.MdiParent = this;
            sectionRack.Show();
            sectionRack.StartPosition = FormStartPosition.CenterScreen;
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword password = new ChangePassword();
            password.MdiParent = this;
            password.Show();
            password.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
