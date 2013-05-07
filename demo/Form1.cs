using System;
using System.Windows.Forms;
using GreetingMessage;

namespace demo
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var simpleGreeting = new SimpleGreeting();
            this.textBox2.Text = simpleGreeting.GetMessage();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
