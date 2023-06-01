using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{

    public partial class Form1 : Form
    {
        int id = 4;
        public Form1()
        {
            InitializeComponent();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            string[] pr = new string[4];
            pr[0] = id.ToString();
            pr[1] = produtoBox.Text;
            pr[2] = quantidadeBox.Text;
            pr[3] = precoBox.Text;

            ListViewItem l = new ListViewItem(pr);
            listData.Items.Add(l);

            Convert.ToInt32(id);
            id++;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            listData.Items.RemoveAt(listData.SelectedIndices[0]);
        }
    }
}
