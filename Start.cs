using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aether.DemoTool
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void Start_Load(object sender, EventArgs e)
        {

        }

        private void btn_AetherStart_Click(object sender, EventArgs e)
        {
            form_AetherStartWindow form = new form_AetherStartWindow();
            form.Show();
        }
    }
}
