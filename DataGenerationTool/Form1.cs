using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGenerationTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random random = new Random(DateTime.Now.Millisecond);
        DateTime result;
        bool isResultDateTimeDefined = false;
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime from = dateTimePicker1.Value;
            DateTime to = dateTimePicker2.Value;
            TimeSpan resultTS = TimeSpan.FromDays(random.Next((to-from).Days));
            result = from + resultTS;
            isResultDateTimeDefined = true;
            textBoxResult.Text = (result).ToString(comboBoxFormat.Text);
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxResult.Text);
            toolStripStatusLabel1.Text = "Status: Date Copied to Buffer";
        }

        private void comboBoxFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(isResultDateTimeDefined) textBoxResult.Text = (result).ToString(comboBoxFormat.Text);
        }
    }
}
