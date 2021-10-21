using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EscapeRoom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Panel[] walls;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
                  walls = this.Controls.OfType<Panel>().OrderBy(x => x.Name).ToArray();
        }

        private void tmr1_Tick(object sender, EventArgs e)
        {
            MoveBoxy();
            for(int i =0;i<walls.Length; i++)
            {
                if (pbB.Bounds.IntersectsWith(walls[i].Bounds))
                {
                    tmr1.Stop();
                    MessageBox.Show("Ran into " + walls[i].Name.ToString());
                }
            }
        }
        private void MoveBoxy()
        {
            pbB.Left += 1;
        }
      
    }
}

