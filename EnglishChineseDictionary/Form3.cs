using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EnglishChineseDictionary
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            try
            {
                //连接特定数据库
                string config = "Data Source=" + textBox1.Text + 
                    ";database=" + textBox5.Text + 
                    ";User Id=" + textBox3.Text +
                    ";Password=" + textBox4.Text + 
                    ";CharSet=utf8;port=" + textBox2.Text + ";";
                MySqlConnection conn = new MySqlConnection(config);
                string sql = "select " + textBox7.Text + ", " + textBox8.Text
                    +" from "+ textBox6.Text;
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                //遍历将所有数据添加到一个字典中
                while (reader.Read())
                {
                    dic.Add(reader[0].ToString(), reader[1].ToString());
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Mysql数据库连接错误", "错误",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Dispose();
                return;
            }
            try
            {
                //将字典全部添加到redis中
                RedisHelper helper = new RedisHelper("127.0.0.1", 6379);
                helper.AddDic(dic);
            }
            catch (Exception)
            {
                MessageBox.Show("向Redis数据库添加时发生错误", "错误",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Dispose();
                return;
            }
            MessageBox.Show("导入完成！");
            Dispose();
        }
    }
}
