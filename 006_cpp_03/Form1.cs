using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _006_cpp_03
{
    public partial class Form1 : Form
    {
        TextBox[] titles;
        ComboBox[] crs;  //학점
        ComboBox[] grs;  //성적
        public Form1()
        {
            InitializeComponent();
        }

        private void txtGrade_Click(object sender, EventArgs e)
        {
            double totalScore = 0;
            int totalCredits = 0;

            for(int i = 0; i < grs.Length; i++)
            {
                if(grs[i].SelectedItem != null)
                {
                    int cid = int.Parse(crs[i].SelectedItem.ToString());
                    totalCredits += cid;
                    totalScore += cid * GetGrade(grs[i].SelectedItem.ToString());
                }
            }
            button1.Text = (totalScore / totalCredits).ToString("0.00");
        }

        private double GetGrade(string v)
        {
            double grade;
            
            if (v == "A+") grade = 4.5;
            else if (v == "A0") grade = 4.0;
            else if (v == "B+") grade = 3.5;
            else if (v == "B0") grade = 3.0;
            else if (v == "C+") grade = 2.5;
            else if (v == "C0") grade = 2.0;
            else if (v == "D+") grade = 1.5;
            else if (v == "D0") grade = 1.0;
            else grade = 0;
            return grade;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt1.Text = "인체구조와기능";
            txt2.Text = "일반수학";
            txt3.Text = "데이터사이언스";
            txt4.Text = "영화와과학";
            txt5.Text = "창업개론";
            txt6.Text = "비주얼프로그래밍";

            titles = new TextBox[7] { txt1, txt2, txt3, txt4, txt5, txt6, txt7 };
            crs = new ComboBox[] { cid1, cid2, cid3, cid4, cid5, cid6, cid7 };
            grs = new ComboBox[] { gid1, gid2, gid3, gid4, gid5, gid6, gid7 };

            int[] arrCredit = { 1, 2, 3, 4, 5 };
            List<string> listGrade = new List<string>
            {
                "A+", "A0", "B+", "B0", "C+", "C0", "D+", "D0", "F"
            };
            foreach (var c in crs)
            {
                foreach (var i in arrCredit)
                    c.Items.Add(i);
                c.SelectedItem = 3;
            }
            foreach(var g in grs)
                foreach(var c in listGrade)
                    g.Items.Add(c);
            
        }
    }
}
