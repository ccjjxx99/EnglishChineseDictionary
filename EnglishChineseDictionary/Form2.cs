using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishChineseDictionary
{
    public partial class Form2 : Form
    {
        private bool isAdd = true;
        RedisHelper helper;

        //默认构造函数是添加界面
        public Form2()
        {
            InitializeComponent();
        }
        
        //如果有构造函数参数，就是修改界面
        public Form2(string word, string value)
        {
            InitializeComponent();
            textBox1.Text = word;
            textBox2.Text = value;
            isAdd = false;
            textBox1.ReadOnly = true;
        }

        //点击确认按钮时
        private void button1_Click(object sender, EventArgs e)
        {
            //能进入Form2，说明数据库配置肯定没问题，不需要try catch
            helper = new RedisHelper("127.0.0.1", 6379);
            string word = textBox1.Text;
            //判断输入是否有效
            if (!IsEnglishWord(word))
            {
                MessageBox.Show("添加的单词只能出现英文", "输入错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string mean = textBox2.Text;
            //如果是添加
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
            //如果是修改
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

        //判断输入是否有效
        public bool IsEnglishWord(string input)
        {
            string pattern = @"^[A-Za-z]+$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(input);
        }
    }
}
