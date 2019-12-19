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
    public partial class Form1 : Form
    {
        RedisHelper helper;

        public Form1()
        {
            InitializeComponent();
        }

        private void GetAllWord()
        {
            List<string> keylist = helper.GetAllWord();
            listBox1.Items.Clear();
            if (keylist.Count == 0)
            {
                return;
            }
            keylist.Sort();
            foreach (string key in keylist)
            {
                listBox1.Items.Add(key);
            }
            listBox1.SetSelected(0, true);
        }

        private void GetWord(string word)
        {
            List<string> keylist = helper.SearchWord(word);
            listBox1.Items.Clear();
            if (keylist.Count == 0)
            {
                return;
            }
            keylist.Sort();
            foreach (string key in keylist)
            {
                listBox1.Items.Add(key);
            }
            listBox1.SetSelected(0, true);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                helper = new RedisHelper("127.0.0.1",6379);
            }
            catch
            {
                MessageBox.Show("Redis数据库配置错误", "数据库错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            GetAllWord();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string word = textBox1.Text;
            GetWord(word);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string key = listBox1.SelectedItem.ToString();
                label1.Text = key;
                textBox2.Text = helper.Get(key);
            }
            catch 
            {
                label1.Text = "";
                textBox2.Text = "";
            }
        }

        private void 添加单词ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
            GetAllWord();
        }

        private void 退出程序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }


        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            string key = label1.Text;
            string value = textBox2.Text;
            new Form2(key,value).ShowDialog();
            listBox1.SetSelected(index, true);
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            string key = listBox1.SelectedItem.ToString();
            DialogResult ret = MessageBox.Show("确定删除单词\"" + key + "\"吗？", "确定删除", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                helper.Remove(key);
                listBox1.Items.RemoveAt(index);
                try
                {
                    listBox1.SetSelected(0, true);
                }
                catch { }
            }
        }
    }
}
