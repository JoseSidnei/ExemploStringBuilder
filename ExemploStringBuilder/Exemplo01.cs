using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploStringBuilder
{
    public partial class Exemplo01 : Form
    {
        public Exemplo01()
        {
            InitializeComponent();
        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            //String texto = "";
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 50000; i++)
            {
                sb.Append(i).Append(" / 2 = ").Append(Convert.ToString(i / 2.0));
                //texto += i + " / " + 2 + " = " + i / 2;
            }
            //txtApresentar.Text = texto;
            txtApresentar.Text = sb.ToString();
        }

      
    }
}
