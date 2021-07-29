using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using T4Test.runTimeT4;

namespace T4Test
{
    class RuntimeTextTemplate1Test
    {
        [Test]
        public void CanT4()
        {
             var v= new RuntimeTextTemplate1().TransformText();
            Console.WriteLine(v);
        }

    }
}
