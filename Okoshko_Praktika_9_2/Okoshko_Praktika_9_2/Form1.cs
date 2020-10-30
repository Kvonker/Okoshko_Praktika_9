using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Okoshko_Praktika_9_2
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      DialogResult rsl = MessageBox.Show("Vi deystvitelno hotite viti?", "Hotite Vaszelin?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

      if(rsl == DialogResult.Yes)
      {
        Application.Exit();
      }
    }

    private void toolStripButton1_Click(object sender, EventArgs e)
    {

    }

    private void toolStripButton2_Click(object sender, EventArgs e)
    {

    }

    private void toolStripButton3_Click(object sender, EventArgs e)
    {

    }
  }
}
