using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _004_cpp_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)  //button1이 클리되면 사용되는 함수
        {
           
                label1.Text = "Hello! windows Forms application!";  //label1의 텍스트 속성을 바꿔준다
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
