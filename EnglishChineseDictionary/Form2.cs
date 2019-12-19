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
            RedisClient client = RedisHelper.GetClient();
            textBox2.Text = client.Get<string>(word);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RedisClient client = RedisHelper.GetClient();
            string key = textBox1.Text;
            string value = textBox2.Text;
            if (isAdd)
            {
                if (client.Add(key, value))
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
                if (client.Set(key, value))
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
