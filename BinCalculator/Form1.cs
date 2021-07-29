using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 콤보박스 데이터 초기화
            //comboBox1.Items.AddRange(data);
            // 처음 선택값 지정
            
            comboBox1.Items.AddRange(new string[] {"2진","8진","16진","10진"});
            comboBox1.SelectedIndex = 0;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string Input = textIn.Text;

            if (comboBox1.SelectedIndex == 0) //2진
            {
                int In = Convert.ToInt32(Input, 2);
                textBin.Text = Input.ToString();
                textOctal.Text = Convert.ToString(In, 8);
                textDecimal.Text = In.ToString();
                textHexade.Text = Convert.ToString(In, 16);
                
            }
            else if (comboBox1.SelectedIndex == 1) //8진
            {
                int In = Convert.ToInt32(Input, 8);
                textBin.Text = Convert.ToString(In, 2);
                textOctal.Text = Input.ToString();
                textDecimal.Text = In.ToString();
                textHexade.Text = Convert.ToString(In, 16);
            }
            else if (comboBox1.SelectedIndex == 2) //16진
            {
                int In = Int32.Parse(Input, System.Globalization.NumberStyles.HexNumber);
                textBin.Text = Convert.ToString(In, 2);
                textOctal.Text = Convert.ToString(In, 8);
                textHexade.Text = Input.ToString();
                textDecimal.Text = In.ToString();
            }
            else //10진
            {
                int In = Int32.Parse(Input);
                textBin.Text = Convert.ToString(In,2);
                textOctal.Text = Convert.ToString(In, 8);
                textDecimal.Text = In.ToString();
                textHexade.Text = Convert.ToString(In, 16);
            }
        }

        private void textIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) //2진
            {
                if (!(e.KeyChar=='1' || e.KeyChar == '0'|| e.KeyChar ==8))              {
                    e.Handled = true;
                }
            }
            else if (comboBox1.SelectedIndex == 1) //8진
            {
                if (!(e.KeyChar >= '0' && e.KeyChar <= '7' || e.KeyChar == 8))
                {
                    e.Handled = true;
                }
            }
            else if (comboBox1.SelectedIndex == 2) //16진
            {
                bool A = (e.KeyChar >= '0' && e.KeyChar <= '9');
                bool B = (e.KeyChar >= 'A' && e.KeyChar <= 'F');
                bool C = (e.KeyChar >= 'a' && e.KeyChar <= 'f');
                bool D = (e.KeyChar == 8);
                if (!(A||B||C||D))
                {
                    e.Handled = true;
                }
            }
            else //10진
            {
                if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == 8))
                {
                    e.Handled = true;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textIn.Text = "";
            textBin.Text = "";
            textOctal.Text = "";
            textHexade.Text = "";
            textDecimal.Text = "";
        }
        private void textIn_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBin_TextChanged(object sender, EventArgs e)
        {

        }
        private void textOctal_TextChanged(object sender, EventArgs e)
        {

        }

        private void textHexade_TextChanged(object sender, EventArgs e)
        {

        }

        private void textDecimal_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
