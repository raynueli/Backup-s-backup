﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bachup_s_backup
{
    public partial class Form2Test : Form
    {
        public Form2Test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.MessageForm("Nano is Gayyyyyyyyyyyyyyyyyyyyyyyyyyyyyy");
            flowLayoutPanel1.Controls.Add(new Button());
        }
    }
}
