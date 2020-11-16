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
    public partial class form_AetherStartWindow : Form
    {
        public form_AetherStartWindow()
        {
            InitializeComponent();
        }
        static List<PIPinfo> pIPinfos = PIPinfo.PIPinfos();

        private void Form1_Load(object sender, EventArgs e)
        {
            cBox_PartNumber.DataSource = KnownPartNumbers();
        }

        static List<string> KnownPartNumbers()
        {
            List<string> partnumbers = new List<string>();
            foreach (var pip in pIPinfos)
            {
                partnumbers.Add(pip.PartNumber.ToString());
            }

            return partnumbers;
        }

        private void cBox_PartNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            num_PartNumber.Text = cBox_PartNumber.SelectedItem.ToString();

            List<int> operations = new List<int>();
            foreach (var pip in pIPinfos)
            {
                if(pip.PartNumber.ToString() == cBox_PartNumber.Text) { operations.Add(pip.OperationNumber); }
            }

            string helperMessage = "Type in the flowing: " + operations.First().ToString();
            if(operations.Count() > 1) { helperMessage = helperMessage + " or " + operations.Last().ToString(); }
            txt_OperationNumbers.Text = helperMessage;
            num_OperationNumber.Value = 100;
        }

        private void num_OperationNumber_ValueChanged(object sender, EventArgs e)
        {
            foreach (var pip in pIPinfos)
            {
                if (pip.PartNumber.ToString() == cBox_PartNumber.Text &&
                    pip.OperationNumber == Convert.ToInt32(num_OperationNumber.Value)) 
                { 
                    txt_PIPfileName.Text = pip.PipName;
                    pic_Preview.Image = Image.FromFile(pip.Image);
                    return; 
                }
                else { txt_PIPfileName.Text = "Unknown info"; pic_Preview.Image = null; }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
