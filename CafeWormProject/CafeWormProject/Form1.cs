using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeWormProject.Properties;

namespace CafeWormProject
{
    public partial class Form1 : Form
    {
        Cafe cafe;

        Bitmap[,] array = {
            { Resources.Boy_01, Resources.Boy_02, Resources.Boy_03, Resources.Boy_04 },
            { Resources.Girl_01, Resources.Girl_02, Resources.Girl_03, Resources.Girl_04 },
            { Resources.Man_01, Resources.Man_02, Resources.Man_03, Resources.Man_04},
            { Resources.Woman_01, Resources.Woman_02, Resources.Woman_03, Resources.Woman_04 },
            { Resources.GrandMather_01, Resources.GrandMather_02, Resources.GrandMather_03, Resources.GrandMather_04 },
            { Resources.Grandfather_01, Resources.Grandfather_02, Resources.Grandfather_03, Resources.Grandfather_04 }
        };

        public Form1()
        {
            InitializeComponent();
            EnterForm form = new EnterForm(labelCurrentMoney, labelNeedMoney);
            form.ShowDialog();
            int currentMuney = Convert.ToInt32(labelCurrentMoney.Text), needMoney = Convert.ToInt32(labelNeedMoney.Text);
            cafe = new Cafe(currentMuney, needMoney);
            
        }

        private void buttonSendAnswer_Click(object sender, EventArgs e)
        {
            
        }
    }
}
