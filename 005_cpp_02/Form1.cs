using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _005_cpp_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = " ";
            if (rbKorea.Checked)
                result += "국적 : 대한민국\n";
            else if (rbChina.Checked)
                result += "국적 : 중국\n";
            else if (rbJapan.Checked)
                result += "국적 : 일본\n";
            else if (rbOthers.Checked)
                result += "국적 : 그외 국가\n";

            if (rbMale.Checked)
                result += "성별 : 남성";
            else if (rbFemale.Checked)
                result += "성별 : 여성";

            MessageBox.Show(result);
        }
        //성별만 골랐을때 바로 결과가 나오는 방법
        //private void rbMale_CheckedChanged(object sender, EventArgs e)
        //{
        //    if(rbMale.Checked)
        //    MessageBox.Show("성별 : 남성");
        //}

        //private void rbFemale_CheckedChanged(object sender, EventArgs e)
        //{
        //      if(rbFemale.Checked)
        //    MessageBox.Show("성별 : 여성");
        //}
    }
}
