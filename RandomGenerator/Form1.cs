using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace RandomGenerator
{
    public partial class Form1 : Form
    {
       List<string> students = new List<string>();

        public Form1()
        {
            InitializeComponent();

            lbNumStudents.Text = students.Count.ToString();
        }
        private double ConvertToDoubleFromTb(TextBox tb, double defaultValue)
        {
            double ret;

            try
            {
                ret = Convert.ToDouble(tb.Text);
            }
            catch
            {
                try
                {
                    ret = Convert.ToDouble(tb.Text.Replace('.', ','));
                }
                catch
                {
                    tb.Text = Convert.ToString(defaultValue);
                    ret = defaultValue;
                }
            }

            return ret;
        }

        private void SetAllNumberOfElements(int num)
        {
            tbNumberOfElements1.Text = num.ToString();
            tbNumberOfElements2.Text = num.ToString();
            tbNumberOfElements3.Text = num.ToString();

            lbNumStudents.Text = students.Count.ToString();
        }
        private List<int> Generate(int min, int max, int numberOfElements, bool repeat)
        {            
            Generator g = new Generator(min, max);

            List<int> numbers = new List<int>();
           
            for (int i = 0; i < numberOfElements; i++)
            {
                int temp = g.GetNumber();
                                
                if (!repeat)
                {
                    while (numbers.Any(n => n == temp))
                    {
                        temp = g.GetNumber();
                    }
                }

                numbers.Add(temp);
            }

            return numbers;            
        }
        
        
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            var f = openFileDialog1.OpenFile();
            
            StreamReader sr = new StreamReader(openFileDialog1.FileName);
            int num = 1;
            while (!sr.EndOfStream)
            {
                students.Add(sr.ReadLine());
                num++;
            }
            
            foreach (var item in students)
            {
                listBox1.Items.Add(item);
            }

            SetAllNumberOfElements(students.Count);
        }

        private void OutputInTb(TextBox tb, List<int> num)
        {
            if (students.Count != 0 && num.Count != students.Count) return;

            int count = 0;

            tb.Clear();
            foreach (var item in num)
            {
                try
                {
                    tb.AppendText(students[count] + ": " + item.ToString() + "\r\n");
                }
                catch
                {
                    tb.AppendText((count+1).ToString() + ": " + item.ToString() + "\r\n");
                }
                count++;
            }

        }

        private void btnGenerate1_Click(object sender, EventArgs e)
        {
            int min = (int)ConvertToDoubleFromTb(tbMin1, 0);
            int max = (int)ConvertToDoubleFromTb(tbMax1, 0);
            int numberOfElements = (int)ConvertToDoubleFromTb(tbNumberOfElements1, 1);
            bool ch = chbRepeat1.Checked;

            if(students.Count != 0)
            {
                numberOfElements = students.Count;
            }

            if (!ch)
            {
                if (max - min < numberOfElements)
                {
                    tbOutput1.Clear();
                    tbOutput1.AppendText("Кол-во чисел превышает диапазон!!!\r\nРазрешите повторы!!!\r\n");
                    return;
                }
            }

            var num = Generate(min, max, numberOfElements, ch);

            OutputInTb(tbOutput1, num);
        }

        private void btnGenerate2_Click(object sender, EventArgs e)
        {
            int min = (int)ConvertToDoubleFromTb(tbMin2, 0);
            int max = (int)ConvertToDoubleFromTb(tbMax2, 0);
            int numberOfElements = (int)ConvertToDoubleFromTb(tbNumberOfElements2, 1);
            bool ch = chbRepeat2.Checked;

            if (students.Count != 0)
            {
                numberOfElements = students.Count;
            }

            if (!ch)
            {
                if (max - min < numberOfElements)
                {
                    tbOutput2.Clear();
                    tbOutput2.AppendText("Кол-во чисел превышает диапазон!!!\r\nРазрешите повторы!!!\r\n");
                    return;
                }
            }

            var num = Generate(min, max, numberOfElements, ch);

            OutputInTb(tbOutput2, num);
        }

        private void btnGenerate3_Click(object sender, EventArgs e)
        {
            int min = (int)ConvertToDoubleFromTb(tbMin3, 0);
            int max = (int)ConvertToDoubleFromTb(tbMax3, 0);
            int numberOfElements = (int)ConvertToDoubleFromTb(tbNumberOfElements3, 1);
            bool ch = chbRepeat3.Checked;

            if (students.Count != 0)
            {
                numberOfElements = students.Count;
            }

            if (!ch)
            {
                if (max - min < numberOfElements)
                {
                    tbOutput3.Clear();
                    tbOutput3.AppendText("Кол-во чисел превышает диапазон!!!\r\nРазрешите повторы!!!\r\n");
                    return;
                }
            }

            var num = Generate(min, max, numberOfElements, ch);

            OutputInTb(tbOutput3, num);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            students.Clear();
            SetAllNumberOfElements(students.Count);
        }
                
        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedItem == null) return;

            var studentsTemp = students.First(s => s == (string)listBox1.SelectedItem);
            students.Remove(studentsTemp);
            var a = listBox1.SelectedItem;
            listBox1.Items.Remove(a);
            SetAllNumberOfElements(students.Count);
        }

        private void btnGenerateAll_Click(object sender, EventArgs e)
        {
            btnGenerate1.PerformClick();
            btnGenerate2.PerformClick();
            btnGenerate3.PerformClick();
        }

        
    }

    
}
