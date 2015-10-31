using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.Redis;
namespace Redis_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string redisHost = "pub-redis-asd.asdus-easdast-asasdd.asd.asdasd.asd.com";
            int redisPort = 321321;
            string redisPass = "";
            using (var redisClient =new RedisClient(redisHost,redisPort,null))
            {
                string key = "email";
                string value = "jvinhit@gmail.com";
                redisClient.Set<string>(key, value);
                Console.WriteLine(redisClient.Get<string>(key));
            }
        }
    }
}
