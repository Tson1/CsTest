using System;
using System.Collections.Generic;
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
    public class DynamicObjTest
    {
        [Test]
        public void canDynamic()
        {

            dynamic person = new ExpandoObject();  //ExpandoObject 为密封类

            person.Nm1 = "test1";
            person.Nm2 = "Test2";
            person.Nm3 = "test3";

            var t = person.Nm1;
            Console.WriteLine(person.Nm1);
            Console.WriteLine(person.Nm2);
            Console.WriteLine(person.Nm3);

            //下記はNG　＜＝Why?
            //Debug.WriteLine(t);
            //Debug.WriteLine(person.Nm2);
            //Debug.WriteLine(person.Nm3);


        }

        [Test]
        public void canDynamic2()
        {

            dynamic person = new ExpandoObject();  //ExpandoObject 为密封类

            person.Nm1 = "test1";
            person.Nm2 = "Test2";
            person.Nm3 = "test3";

            var t = person.Nm1;

            dynamic parent = new ExpandoObject();  //ExpandoObject 为密封类
            parent.son = person;

            parent.sonNm1 = person.Nm1;
            Console.WriteLine(parent);
            Console.WriteLine(parent.son);
            
            Console.WriteLine(parent.sonNm1);
            Console.WriteLine(person.Nm1);
            parent.sonNm1 = "sss";
            Console.WriteLine(parent.sonNm1);
            Console.WriteLine(person.Nm1);
            //SerializationInfo

        }
    }
}
