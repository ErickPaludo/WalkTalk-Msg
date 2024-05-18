using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WalkTalk
{
    public partial class EscolherUser : Form
    {
        ModelMsg msg = new ModelMsg();
        public EscolherUser()
        {
            InitializeComponent();
        }

        private void init_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(comboBox1.Text))
            {
                if(comboBox1.SelectedIndex == 0) 
                {
                    Usuario.id_us = "1";
                    Usuario.id_des = "2";
                }
                else
                {
                    Usuario.id_us = "2";
                    Usuario.id_des = "1";
                }
                this.Close();
            }
        }
    }
}
