﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf13_bookrentalshop
{
    public partial class FrmMain : Form
    {

        #region < 생성자 >
        public FrmMain()
        {
            InitializeComponent();
        }
        #endregion

        #region < 이벤트 핸들러>

        private void FrmMain_Load(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.ShowDialog();
        }
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); // 전체 프로그램 종료!
        }

        private void MniGenre_Click(object sender, EventArgs e)
        {
            FrmGenre frm = new FrmGenre();
            frm.TopLevel = false;
            this.Controls.Add(frm);
            frm.Show();
        }

        private void MniBookInfo_Click(object sender, EventArgs e)
        {

        }

        private void MniMember_Click(object sender, EventArgs e)
        {

        }

        private void MniLental_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion

    }
}
