using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using T4Test.runTimeT4;
namespace T4Test
{
    class T4HasParamTest
    {
        [Test]
        public void CanT4()
        {
            T4HasParam t4 = new T4HasParam(GetMyData())  ;
            var text = t4.TransformText();
            Console.WriteLine(text);

        }
        MyData GetMyData()
        {
            MyData data = new MyData();
            data.Items.Add(new MyDataItem() { Name = "a", Value = "v__A" });
            data.Items.Add(new MyDataItem() { Name = "B", Value = "v__B" });
            data.Items.Add(new MyDataItem() { Name = "C", Value = "v__C" });
            data.Items.Add(new MyDataItem() { Name = "D", Value = "v__D" });


            return data;
        }


    }
}
