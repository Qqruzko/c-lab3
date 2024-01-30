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
    public partial class InputControl : UserControl
    {
        public InputControl()
        {
            InitializeComponent();
        }
        public object user;
        public Output output;
        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (IntputBox.Text == "")
            {
                e.Cancel = false;
            }
            else
            {
                try
                {
                    double.Parse(IntputBox.Text);
                    e.Cancel = false;
                }
                catch
                {
                    e.Cancel = true;
                    MessageBox.Show("Поле PIN не может содержать буквы");
                }
            }
        }

        private void IntputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            UserData userref = user as UserData;
            userref.name = (IntputBox.Text);
            output.set_text(userref.name);
            
        }

        

        private void button1_Validating(object sender, CancelEventArgs e)
        {
            
        }
    }
}
