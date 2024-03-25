using System;
using System.Windows.Forms;

namespace oop15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Task1
        private void button1_Click(object sender, EventArgs e)//дія для виконання завдання 1
        {
            try
            {
                double _answer = Math.Pow((1 - Math.Tan(Convert.ToDouble(textBox1_1.Text))),
                    1 / Math.Tan(Convert.ToDouble(textBox1_1.Text))) +
                   Math.Cos(Convert.ToDouble(textBox1_1.Text) - Convert.ToDouble(textBox1_2.Text));
                label_ans_1.Text = _answer.ToString();
                return;
            }
            catch (FormatException)
            {
                label_ans_1.Text = "Bad index";
                return;
            }
        }
        #endregion
        #region Task2
        private void button2_Click(object sender, EventArgs e)//дія для виконання завдання 2
        {
            try
            {
                double _answer = Convert.ToDouble(textBox2.Text);
                for (int i = 0; i < 4; i++)
                {
                    _answer *= _answer;
                    if (i == 2)
                    {
                        label_ans_2_1.Text = Convert.ToString(_answer);
                    }
                }
                label_ans_2_2.Text = Convert.ToString(_answer);
                return;
            }
            catch (FormatException)
            {
                label_ans_2_1.Text = "Bad index";
                label_ans_2_2.Text = "Bad index";
                return;
            }
        }
        #endregion
        #region Task3
        private void button4_Click(object sender, EventArgs e)//дія для виконання завдання 3
        {
            try
            {
                double a = Convert.ToDouble(textBox3_1.Text);
                double b = Convert.ToDouble(textBox3_2.Text);
                double c = Convert.ToDouble(textBox3_3.Text);

                if (a + b == 0 || a + c == 0 || b + c == 0)
                {
                    label_ans_3.Text = "True";
                }
                else
                {
                    label_ans_3.Text = "False";
                }
                return;
            }
            catch (FormatException)
            {
                label_ans_3.Text = "Bad index";
                return;
            }
        }
        #endregion
        #region Task4
        private void button4_Click_1(object sender, EventArgs e)//дія для виконання завдання 4
        {
            try
            {
                double _a1 = Convert.ToDouble(textBox4_1.Text);
                double _a2 = Convert.ToDouble(textBox4_2.Text);
                double _a3 = Convert.ToDouble(textBox4_3.Text);
                double _a4 = Convert.ToDouble(textBox4_4.Text);
                double n;

                if (_a1 == _a2 && _a2 == _a3 && _a3 == _a4)//захист
                {
                    label_ans_4.Text = "Bad numbers";
                    return;
                }

                if (_a1 == _a2 && _a2 == _a3)//усі прораховані варіанти (лінійно)
                {
                    n = 4;
                    label_ans_4.Text = "4";
                }
                else if (_a1 == _a2 && _a2 == _a4)
                {
                    n = 3;
                    label_ans_4.Text = "3";
                }
                else if (_a1 == _a3 && _a3 == _a4)
                {
                    n = 2;
                    label_ans_4.Text = "2";
                }
                else if (_a2 == _a3 && _a3 == _a4)
                {
                    n = 1;
                    label_ans_4.Text = "1";
                }
                else
                {
                    label_ans_4.Text = "Bad numbers";
                }
                return;
            }
            catch (FormatException)
            {
                label_ans_4.Text = "Bad index";
                return;
            }
        }

        #endregion
        #region Task5
        private void button5_Click(object sender, EventArgs e)//дія для виконання завдання 5
        {
            try
            {
                int _num = Convert.ToInt32(textBox5.Text);
                int[] _number_munth_day = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };//масив днів у місяцях
                string[] _month = { "January", "February", "March", "April", "May", "June",
                "July", "August", "September", "October", "November", "December" };//масив місяців
                int i;

                if (_num > 365 && checkBox5.Checked == false || _num > 366 && checkBox5.Checked || _num <= 0)//захист
                {
                    label_ans_5.Text = "Num must be from 1 to 365 or 366 if leap year";
                    return;
                }
                else if (_num == 365 && checkBox5.Checked == false || _num == 366 && checkBox5.Checked)//щоб не запускати цикл на випадок останнього числа
                {
                    label_ans_5.Text = "December31";
                    return;
                }

                if (checkBox5.Checked)//високосний рік
                    _number_munth_day[1] = 29;

                for (i = 0; _num > _number_munth_day[i]; i++)//цикл для обрахування
                    _num -= _number_munth_day[i];

                label_ans_5.Text = _month[i] + _num;
                return;
            }
            catch (FormatException)
            {
                label_ans_5.Text = "Bad index";
                return;
            }
        }

        #endregion
        #region Task6
        private void button6_Click(object sender, EventArgs e)//дія для виконання завдання 6 
        {
            try
            {
                double _first_num;
                double _last_num;
                double _step;

                string consistency = string.Empty;//масив для зберігання результату

                _first_num = Convert.ToSingle(textBox6_1.Text);
                _last_num = Convert.ToSingle(textBox6_2.Text);
                _step = Convert.ToSingle(textBox6_3.Text);

                if (_first_num >= _last_num || _step <= 0) { //захист
                    label_ans_6.Text = "Bad index";
                    return;
                }

                for (double i = _first_num; i <= _last_num; i = i + _step)//цикл для обрахування
                {
                    Console.WriteLine(i);
                    if (i >= 0)
                    {
                        label_ans_6.Text += (Math.Round(i * _first_num * _first_num,4)) + "; ";

                    }
                    else
                    {
                        label_ans_6.Text += (Math.Round( i * _last_num * _last_num, 4)) + "; ";
                    }
                }
                label_ans_6.Text = consistency;

            }
            catch (FormatException)
            {
                label_ans_6.Text = "Bad index";
                return;
            }
        }
        #endregion
        #region Task7

        private void button7_Click(object sender, EventArgs e)//дія для виконання завдання 7 по заміні заданого на задане
        {
            try
            {
                label_ans_7.Text = textBox7_1.Text.Replace(textBox7_2.Text, textBox7_3.Text);
            }
            catch (FormatException)
            {
                label_ans_7.Text = "Bad index";
                return;
            }
        }
        #endregion
    }
}