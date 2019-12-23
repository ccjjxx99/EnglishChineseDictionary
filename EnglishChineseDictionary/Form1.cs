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

        //启动时创建helper类
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                helper = new RedisHelper("127.0.0.1", 6379);
            }
            catch
            {
                MessageBox.Show("Redis数据库配置错误", "数据库错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            GetAllWord();
        }

        //获取所有单词，即启动时或添加单词后刷新列表
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

        //搜索单词
        private void SearchWord(string word)
        {
            //搜索以输入内容开头的单词
            List<string> keylist = helper.SearchWord(word);
            //清空listbox
            listBox1.Items.Clear();
            if (keylist.Count == 0)
            {
                return;
            }
            keylist.Sort();
            //添加到listbox
            foreach (string key in keylist)
            {
                listBox1.Items.Add(key);
            }
            //默认选中第一个单词，以显示释义
            listBox1.SetSelected(0, true);
        }

        //搜索框只要有变化，就查询这个单词
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string word = textBox1.Text;
            SearchWord(word);
        }

        //listbox中选择
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

        //菜单栏中添加单词
        private void 添加单词ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
            GetAllWord();
        }
        //菜单栏中退出程序
        private void 退出程序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        //菜单栏中导入单词
        private void 从MySQL导入单词ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form3().ShowDialog();
            GetAllWord();
        }

        //listbox右键菜单的修改单词
        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            string key = label1.Text;
            string value = textBox2.Text;
            new Form2(key, value).ShowDialog();
            listBox1.SetSelected(index, true);
        }
        //listbox右键菜单的删除单词
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
