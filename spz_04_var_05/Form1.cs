using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace spz_04_var_05
{
    public partial class Form1 : Form
    {
        private const int Elements = 10;
        private string FileName;
        private string StrNums;
        public Form1()
        {
            InitializeComponent();
        }

        private void RandomiseButton_Click(object sender, EventArgs e)//Randomise
        {
            FileName = "Numbers.txt";
            string RandomNumbers = GetRandomNumbersString(Elements);
            RandTextBox.Text = RandomNumbers;

            File.WriteAllText(FileName, RandomNumbers);

            string StrNums = File.ReadAllText(FileName);

            StrNums = MixingAlgorythm(StrNums);

            FileName = FileName.Insert(0, "Final ");

            File.WriteAllText(FileName, StrNums);
            EditedTextBox.Text = StrNums;
        }

        private void OpenFileButton_Click(object sender, EventArgs e)//Open file
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "Text files|*.txt";           
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                FileName = OFD.FileName;

                ProceedButton.Enabled = true;
                RandTextBox.Enabled = true;

                StrNums = File.ReadAllText(FileName);
                RandTextBox.Text = StrNums;
            }
        }

        private string GetRandomNumbersString(int N)//make random strNumbers
        {
            Random rand = new Random();

            int[] NumArr = new int[N];

            var sb = new StringBuilder();


            sb.Append(NumArr[0] = rand.Next(1, 10));
            for (int i = 1; i < N; ++i)
            {
                NumArr[i] = rand.Next(1, 10);
                sb.AppendFormat(",{0}", NumArr[i]);
            }

            return sb.ToString();
        }

        private string MixingAlgorythm(string StrNums)//Mix strNumbers
        {
            string[] numsArr = StrNums.Split(',');

            if (numsArr.Length == 1)
                return numsArr[0];

            StringBuilder res_str = new StringBuilder();

            for (int i = 0; i < numsArr.Length / 2; i++)
                res_str.AppendFormat("{0},{1},", numsArr[i], numsArr[numsArr.Length - 1 - i]);

            if (numsArr.Length % 2 != 0)
                res_str.Append(numsArr[(numsArr.Length / 2)]);
            else
                return res_str.ToString().TrimEnd(',');

            return res_str.ToString();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            RandTextBox.Text = "";
            EditedTextBox.Text = "";
            ProceedButton.Enabled = false;
        }

        private void ProceedButton_Click(object sender, EventArgs e)//proceed button
        {
            ProceedButton.Enabled = false;
            RandTextBox.Enabled = false;

            StrNums = RandTextBox.Text;

            StrNums = MixingAlgorythm(StrNums);

            SaveFileDialog SFD = new SaveFileDialog();
            SFD.Filter = "Text files|*.txt";
            if (SFD.ShowDialog() == DialogResult.OK)
            {
                FileName = SFD.FileName;
                File.WriteAllText(FileName, StrNums);
            }

            EditedTextBox.Text = StrNums;
        }
    }
}
