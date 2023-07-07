using System;
using System.Collections.Generic;

namespace ChainofResponsibility
{
    class Client
    {
        public static void ConsumerCode(AbstractHandler handler)
        {
            foreach (var operationName in new List<string> { "Show Dialog", "Set Parameters", "Print", "Copy" })
            {
                Console.WriteLine($"Consumer: Who wants to perform '{operationName}' operation?");

                var result = handler.Handle(operationName);

                if (result != null)
                {
                    Console.Write($"   {result}");
                }
                else
                {
                    Console.WriteLine($" For  '{operationName}', there is no handler.");
                }
            }
        }
    }
}
