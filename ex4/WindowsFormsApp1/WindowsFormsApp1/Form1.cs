using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        UserData user1 = new UserData();
        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }
        
        
        private void output1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            input1.user = user1;
            input1.output = output1;
        }
    }
}
