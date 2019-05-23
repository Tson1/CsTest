using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using System.Dynamic;
using System.Diagnostics;
using System.Runtime.Serialization;
namespace DynamicTest
{
    [TestFixture]
    public class DynamiallyTypeTest
    {
        [Test]
        public void canCallAdd()
        {
            dynamic obj = GetObj();
            var result=obj.Add(1, 2);
            Assert.AreEqual(result, 3);
        }


        public object GetObj()
        {
            return new DemoAdd();
        }
    }


    public class DemoAdd{
        public int Add(int x,int y){
            return x+y;
        }
    }
}
