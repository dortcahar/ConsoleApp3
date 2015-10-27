using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public class Class1
    {
        public Class1()
        {
        }

        public void TestClass()
        {
            ConverterFunc twoMultiplier = i => i * 2;
            int a = ConvertUsingMethod(twoMultiplier, 2);
            if (a != 5) throw new Exception("birşeyler ters gitti");
        }

        public int ConvertUsingMethod(ConverterFunc converterCallback, int numberToConvert)
        {
            return converterCallback(numberToConvert);
        }
    }

    public delegate int ConverterFunc(int numberToConvert);

}
