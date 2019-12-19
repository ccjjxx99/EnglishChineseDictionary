using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishChineseDictionary
{
    public partial class Form2 : Form
    {
        private bool isAdd = true;
        RedisHelper helper;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string word, string value)
        {
            InitializeComponent();
            textBox1.Text = word;
            textBox2.Text = value;
            isAdd = false;
            textBox1.ReadOnly = true;
            helper = new RedisHelper("127.0.0.1",6379);
            textBox2.Text = helper.Get(word);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (helper == null)
            {
                helper = new RedisHelper("127.0.0.1", 6379);
            }
            string word = textBox1.Text;
            string mean = textBox2.Text;
            if (isAdd)
            {
                if (helper.Add(word, mean))
                {
                    Dispose();
                }
                else
                {
                    MessageBox.Show("该单词已存在");
                }
            }
            else
            {
                if (helper.Set(word, mean))
                {
                    Dispose();
                }
                else
                {
                    MessageBox.Show("出现错误");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
