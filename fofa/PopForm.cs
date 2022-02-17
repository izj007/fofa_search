using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace fofa
{
    public partial class PopForm : Form
    {
        public PopForm()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btn_addsok_Click(object sender, EventArgs e)
        {
            Form1 mainForm = (Form1)this.Owner;
            foreach (string txt in rtb_keyword.Lines)
            {
                mainForm.ChangeBtnKeyword(txt);
            }
            this.Close();
        }
    }
}
