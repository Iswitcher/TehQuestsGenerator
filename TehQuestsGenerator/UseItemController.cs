﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TehQuestsGenerator
{
    public partial class UseItemController : UserControl
    {
        public UseItemController()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            itemIdsListBox.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            itemIdsListBox.Items.RemoveAt(itemIdsListBox.SelectedIndex);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
                e.Handled = true;
        }

        private void countTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
                e.Handled = true;
        }
    }
}
