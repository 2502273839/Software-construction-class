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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int result = 0;
                int first_num = Convert.ToInt32(num1.Text);
                int second_num = Convert.ToInt32(num2.Text);
                String operations = operation.SelectedItem.ToString();
                switch (operations)
                {
                    case "+":
                        result = first_num + second_num;
                        break;
                    case "-":
                        result = first_num - second_num;
                        break;
                    case "*":
                        result = first_num * second_num;
                        break;
                    case "/":
                        while(second_num==0)
                        {
                            Console.WriteLine("请输入一个不为零的整数：\n");
                            second_num = Convert.ToInt32(Console.ReadLine());
                        }
                        result = first_num / second_num;
                        break;
                }
                result_num.Text = result.ToString();
            }
            catch(FormatException)
            {
                Console.WriteLine("格式错误！");
            }catch(OverflowException)
            {
                Console.WriteLine("溢出！");
            }catch (Exception)
            {
                Console.WriteLine("错误！");
            }



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void result_num_Click(object sender, EventArgs e)
        {

        }
    }


}
