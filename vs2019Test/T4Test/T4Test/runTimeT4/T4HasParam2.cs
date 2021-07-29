using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4Test.runTimeT4
{
    public partial class T4HasParam
    {
        MyData m_data { get; set; }
        public T4HasParam(MyData m_data)
        {
            this.m_data = m_data;
        }
    }

    public class MyData
    {
        public List<MyDataItem> Items { get; set; } = new List<MyDataItem>();
        public string Name { get; set; }
        public string vaule { get; set; }
    }
    public class MyDataItem
    {

        public string Name { get; set; }
        public string Value { get; set; }
    }
}
