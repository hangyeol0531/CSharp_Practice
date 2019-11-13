using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm04_MessageBox_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MessageBoxButtons msgBoxBtn;
        MessageBoxIcon msgBoxIcon;

        private void BTNSHOW_Click(object sender, EventArgs e)
        {
            if (this.RBOK.Checked) msgBoxBtn = MessageBoxButtons.OK;
            else if (this.RBCANCEL.Checked) msgBoxBtn = MessageBoxButtons.OKCancel;
            else if (this.RBYESNO.Checked) msgBoxBtn = MessageBoxButtons.YesNo;

            if (this.RBERROR.Checked) msgBoxIcon = MessageBoxIcon.Error;
            else if (this.RBINFO.Checked) msgBoxIcon = MessageBoxIcon.Information;
            else if (this.RBQUES.Checked) msgBoxIcon = MessageBoxIcon.Question;

            MessageBox.Show("메시지 박스입니다.", "Hello MessageBox!", msgBoxBtn, msgBoxIcon);
        }
    }
}