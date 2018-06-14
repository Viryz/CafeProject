using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeWormProject
{
    public partial class EnterForm : Form
    {
        Label l1;
        Label l2;
        public EnterForm(Label currentMoney, Label needMoney)
        {
            InitializeComponent();
            l1 = currentMoney;
            l2 = needMoney;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            l1.Text = textBoxCurrentMoney.Text;
            l2.Text = textBoxNeedMoney.Text;
            this.Close();
        }

        private void textBoxCurrentMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
                return;
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (sender.Equals(textBoxCurrentMoney))
                        textBoxNeedMoney.Focus();
                    else button1.Focus();
                }
                return;
            }
            e.Handled = true;
        }

        private void EnterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (textBoxCurrentMoney.Text != "" && textBoxNeedMoney.Text != "")
                return;
            else
            {
                MessageBox.Show("Введіть всі дані");
                e.Cancel = true;
            }
        }
    }
}
