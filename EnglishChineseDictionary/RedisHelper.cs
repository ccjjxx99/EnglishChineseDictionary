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
        static readonly RedisClient client = new RedisClient("127.0.0.1", 6379);
        public static RedisClient GetClient()
        {
            return client;
        }
    }
}
