using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using System.Dynamic;
using System.Diagnostics;
using System.Runtime.Serialization;
using System;
using System.Net;

namespace DynamicTest
{
    [TestFixture]
    public class AsyncWait2Test
    {
        [Test]
        public void CanAsyncTest()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Console.WriteLine("开始获取博客园首页字符数量");
            Task<int> task1 = CountCharsAsync(@"http://www.cnblogs.com");
            Console.WriteLine("开始获取百度首页字符数量");
            Task<int> task2 = CountCharsAsync(@"http://www.baidu.com");

            Console.WriteLine("Main方法中做其他事情");

            Console.WriteLine("博客园:" + task1.Result);
            Console.WriteLine("百度:" + task2.Result);

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

            Console.WriteLine("开始获取博客园首页字符数量");
            var Result1 = CountChars(@"http://www.cnblogs.com");
            Console.WriteLine("开始获取百度首页字符数量");
            var Result2 = CountChars(@"http://www.baidu.com");

            Console.WriteLine("Main方法中做其他事情");

            Console.WriteLine("博客园:" + Result1);
            Console.WriteLine("百度:" + Result2);

            sw.Stop();
            Console.WriteLine("use time :" + sw.ElapsedMilliseconds.ToString());

        }
        static int CountChars(string url)
        {
            WebClient wc = new WebClient();
            string result = wc.DownloadString(new Uri(url));
            return result.Length;
        }
    }
}
