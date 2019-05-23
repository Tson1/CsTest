using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using System.Dynamic;
using System.Diagnostics;
using System.Runtime.Serialization;
using System;
using System.Net;
using System.Collections.Generic;

namespace DynamicTest
{
    [TestFixture]
    public class AsyncWait3Test
    {
        [Test]
        public void CanAsyncTest()
        {
            List<Task<int>> ls = new List<Task<int>>();
            Stopwatch sw = new Stopwatch();
            sw.Start();

            for (int i = 0; i < 50; i++)
            {
                //Console.WriteLine("开始获取博客园首页字符数量");
                ls.Add(CountCharsAsync(@"http://www.cnblogs.com"));
                //Console.WriteLine("博客园:" + task1.Result);         //<====ここでアクセスすると遅くなる。同期と変わらない６０秒。
            }


            foreach (var item in ls)
            {
                Console.WriteLine(string.Format( "获取博客园首页字符数量:{0}",item.Result));
            }

            sw.Stop();
            Console.WriteLine("use time :" + sw.ElapsedMilliseconds.ToString());

        }


        static async Task<int> CountCharsAsync(string url)
        {
            WebClient wc = new WebClient();
            string result = await wc.DownloadStringTaskAsync(new Uri(url));
            return result.Length;
        }

        [Test]
        public void CanSlowTest()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 50; i++)
            {
                //Console.WriteLine("开始获取博客园首页字符数量");
                var Result1 = CountChars(@"http://www.cnblogs.com");
                //Console.WriteLine("博客园:" + Result1);
            }
            sw.Stop();
            Console.WriteLine("use time :" + sw.ElapsedMilliseconds.ToString());

        }
        static int CountChars(string url)
        {
            WebClient wc = new WebClient();
            string result = wc.DownloadString(new Uri(url));
            return result.Length;
        }

        [Test]
        public void CanGetWeb()
        {
            Debug.WriteLine(GetWebContent(@"http://www.cnblogs.com"));
        }
        static string GetWebContent(string url)
        {
            WebClient wc = new WebClient();
            string result = wc.DownloadString(new Uri(url));
            return result;
        }
    }
}
