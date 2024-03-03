using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Top_CourseProject_Part1
{
    public partial class TopForm : Form
    {
        public StringBuilder sb { get; private set; }

        public TopForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void urlLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(outputText.Text);
            string nl = "\r\n";

            sb.Append(titleText.Text);
            sb.Append(nl);
            sb.Append(artistText.Text);
            sb.Append(nl);
            sb.Append(genreText.Text);
            sb.Append(nl);
            sb.Append(yearText.Text);
            sb.Append(nl);
            sb.Append(urlText.Text);
            sb.Append(nl);
            sb.Append(nl);     // Blank line
             
            outputText.Text = sb.ToString();
        }
    }
}
