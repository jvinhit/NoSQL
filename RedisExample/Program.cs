using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            string redisServiceHost = "asd";
            int redisServicePort = 123;
            using (var redisClient = new RedisClient(redisServiceHost, redisServicePort, null))
            {
                string key = "username";
                string value = "jvinhit";
                redisClient.Set<string>(key, value);
                Console.WriteLine("Stored simple key-value pair: {0} --> {1}", key, value);
                value = redisClient.Get<string>(key);
                Console.WriteLine("Retrieved simple key-value pair: {0} --> {1}", key, value);

                var person = new Person()
                {
                    ID = Guid.NewGuid(),
                    Name = "Svetlin Nakov",
                    Gender = Gender.Male,
                    Phone = "+0985222333",
                    Address = new Address()
                    {
                        Street = "Vo Van Ngan",
                        PostCode = 7000,
                        Town = "Thu Duc",
                        Country = "Viet Nam"
                    },
                    Email = "jvinhit@gmail.com",
                    Site = "https://www.jvinhit.blogspot.com",
                    DateAdded = DateTime.Now
                };

                // Persist an object into a list
                var persons = redisClient.As<Person>().Lists["personsList"];
                persons.Add(person);
                Console.WriteLine("Added a person to the list of persons.");

                // Enumerate all persons
                foreach (var p in persons)
                {
                    Console.WriteLine(p);
                }
            }
        }
    }
}
