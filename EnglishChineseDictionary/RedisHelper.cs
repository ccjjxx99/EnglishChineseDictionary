using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishChineseDictionary
{
    class RedisHelper
    {
        RedisClient client;
        public RedisHelper(string host, int port)
        {
            client = new RedisClient(host, port);
        }

        //添加单词
        public bool Add(string word, string mean)
        {
            return client.Add(word, mean);
        }
        //删除单词
        public bool Remove(string word)
        {
            return client.Remove(word);
        }
        //修改单词
        public bool Set(string word, string mean)
        {
            return client.Set(word, mean);
        }
        //查询一个单词
        public string Get(string word)
        {
            return client.Get<string>(word);
        }
        //查询单词列表
        public List<string> GetAllWord(){
            return client.GetAllKeys();
        }
        //模糊查询一个单词
        public List<string> SearchWord(string word)
        {
            return client.SearchKeys(word + "*");
        }
    }
}
