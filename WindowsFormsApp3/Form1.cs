using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        bool checkstatus = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            var btn = new Button();
            btn.Height = 50;
        }
        void ClickMe(object obj,EventArgs evt)
        {
            var btn = obj as Button;
            btn.Click += new System.EventHandler(this.button_Click);
            
         
        }

        public void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = Color.Red;
            var btn = sender as Button;
            if (checkstatus)
            {
                btn.BackColor = Color.Red;
                checkstatus = false;
            }
            else
            {
                btn.BackColor = Color.Chartreuse;
                checkstatus = true;
            }
        }
    }
    
}
