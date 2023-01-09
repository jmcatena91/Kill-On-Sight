using System;
using System.Xml.Linq;

namespace Kill_On_Sight
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstColum = playerName.Text;
            string secondColum = "0";
            string dateKilled = DateTime.Now.ToString("M-d-y");
            string[] row = { firstColum, secondColum, dateKilled};
            dataGridView1.Rows.Add(row);
            playerName.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }  
    
}