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
        List<int> generatedValues1 = new List<int>();
        List<int> generatedValues2 = new List<int>();
        List<int> generatedValues3 = new List<int>();

        public Form1()
        {
            InitializeComponent();

            lbNumStudents.Text = listBoxStudents.Items.Count.ToString();
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

            lbNumStudents.Text = listBoxStudents.Items.Count.ToString();
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

            List<string> students = new List<string>();

            while (!sr.EndOfStream)
            {
                students.Add(sr.ReadLine());
                num++;
            }

            //foreach (var item in students)
            //{
            //    listBox1.Items.Add(item);
            //}

            //SetAllNumberOfElements(students.Count);
            InsertDataInListbox(listBoxStudents, students);
        }

        private void InsertDataInListbox(ListBox lb, IEnumerable<string> arr)
        {
            foreach (var item in arr)
            {
                lb.Items.Add(item);
            }

            SetAllNumberOfElements(arr.Count());
        }
        private List<string> GetListFromListBox(ListBox lb)
        {
            List<string> list = new List<string>();
            foreach (var item in lb.Items)
            {
                list.Add(item.ToString());
            }
            return list;
        }
        private void OutputInTb(TextBox tb, List<int> num)
        {
            var students = GetListFromListBox(listBoxStudents);

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

            if(listBoxStudents.Items.Count != 0)
            {
                numberOfElements = listBoxStudents.Items.Count;
            }

            if (!ch)
            {
                if (!CheckRepeats(min, max, numberOfElements))
                {
                    tbOutput1.Clear();
                    tbOutput1.AppendText("Кол-во чисел превышает диапазон!!!\r\nРазрешите повторы!!!\r\n");
                    return;
                }
            }

            generatedValues1 = Generate(min, max, numberOfElements, ch);

            OutputInTb(tbOutput1, generatedValues1);
        }

        private void btnGenerate2_Click(object sender, EventArgs e)
        {
            int min = (int)ConvertToDoubleFromTb(tbMin2, 0);
            int max = (int)ConvertToDoubleFromTb(tbMax2, 0);
            int numberOfElements = (int)ConvertToDoubleFromTb(tbNumberOfElements2, 1);
            bool ch = chbRepeat2.Checked;

            if (listBoxStudents.Items.Count != 0)
            {
                numberOfElements = listBoxStudents.Items.Count;
            }

            if (!ch)
            {
                if (!CheckRepeats(min, max, numberOfElements))
                {
                    tbOutput2.Clear();
                    tbOutput2.AppendText("Кол-во чисел превышает диапазон!!!\r\nРазрешите повторы!!!\r\n");
                    return;
                }
            }

            generatedValues2 = Generate(min, max, numberOfElements, ch);

            OutputInTb(tbOutput2, generatedValues2);
        }

        private void btnGenerate3_Click(object sender, EventArgs e)
        {
            int min = (int)ConvertToDoubleFromTb(tbMin3, 0);
            int max = (int)ConvertToDoubleFromTb(tbMax3, 0);
            int numberOfElements = (int)ConvertToDoubleFromTb(tbNumberOfElements3, 1);
            bool ch = chbRepeat3.Checked;

            if (listBoxStudents.Items.Count != 0)
            {
                numberOfElements = listBoxStudents.Items.Count;
            }

            if (!ch)
            {
                if (!CheckRepeats(min, max, numberOfElements))
                {
                    tbOutput3.Clear();
                    tbOutput3.AppendText("Кол-во чисел превышает диапазон!!!\r\nРазрешите повторы!!!\r\n");
                    return;
                }
            }

            generatedValues3 = Generate(min, max, numberOfElements, ch);

            OutputInTb(tbOutput3, generatedValues3);
        }

        private bool CheckRepeats(int min, int max, int num)
        {
            return max - min + 1 < num ? false : true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBoxStudents.Items.Clear();
            listBoxStudents.Items.Clear();
            SetAllNumberOfElements(listBoxStudents.Items.Count);
        }
                
        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBoxStudents.SelectedItem == null) return;
            listBoxStudents.Items.Remove(listBoxStudents.SelectedItem);
            SetAllNumberOfElements(listBoxStudents.Items.Count);
        }

        private void btnGenerateAll_Click(object sender, EventArgs e)
        {
            btnGenerate1.PerformClick();
            btnGenerate2.PerformClick();
            btnGenerate3.PerformClick();
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            //Если в буфере обмена содержится текст
            if (Clipboard.ContainsText() == true)
            {
                string someText = Clipboard.GetText();

                var arrStudents = someText.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                var listStudents = new List<string>();

                foreach (var item in arrStudents)
                {
                    listStudents.Add(item.Split(' ')[0]);
                }

                InsertDataInListbox(listBoxStudents, listStudents);

                //Выводим показываем сообщение с текстом, скопированным из буфера обмена
                //MessageBox.Show(this, someText, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                //Выводим сообщение о том, что в буфере обмена нет текста
                MessageBox.Show(this, "В буфере обмена нет текста", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAllCopy_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>(listBoxStudents.Items.Count);
            for (int i = 0; i < listBoxStudents.Items.Count; i++)
            {
                list.Add("");
            }

            AddInt2List(list, generatedValues1);
            AddInt2List(list, generatedValues2);
            AddInt2List(list, generatedValues3);

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i][0] == '/')
                {
                    list[i] = list[i].Remove(0,1);
                }
            }

            var str = string.Join("\r\n", list);

            try
            {
                Clipboard.SetText(str);
            }
            catch { }
        }

        private void AddInt2List(List<string> strs, List<int> ints)
        {
            if (ints.Count == 0) return;
            if (ints.Count != strs.Count) return;

            for (int i = 0; i < ints.Count; i++)
            {
                strs[i] = strs[i] + "/" + ints[i].ToString();
            }
        }
    }

    
}
