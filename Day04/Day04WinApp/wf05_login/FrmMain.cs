using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf05_login
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
           if(TxtId.Text == "abcd")
            {
                if (TxtPassword.Text == "1234")
                {
                    MessageBox.Show("로그인 성공!!","login", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("패스워드가 일치하지 않습니다.", "로그인실패", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("존재하지 않는 ID입니다.", "로그인실패", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }                  
                     
        }
    }
}
