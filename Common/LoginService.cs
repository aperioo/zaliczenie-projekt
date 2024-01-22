using System;
using System.Collections.Generic;

namespace Common
{
    public class LoginService
    {
        public static void WriteToFile(List<ILogging> ChangedElements) 
        {
            foreach (var element in ChangedElements)
            {
                Console.WriteLine(element.Log());
            }
        }
    }
}
