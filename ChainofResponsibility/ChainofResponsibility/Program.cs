using System;

namespace ChainofResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var parameterHandler = new ParameterHandler();
            var dialogHandler = new DialogHandler();
            var printHandler = new PrintHandler();

            parameterHandler.SetNext(dialogHandler).SetNext(printHandler);

            
            Console.WriteLine("Chain: Parameter > Dialog > Print\n");
            Client.ConsumerCode(parameterHandler);
            Console.WriteLine();

            Console.WriteLine("Subchain: Dialog > Print\n");
            Client.ConsumerCode(dialogHandler);

            Console.ReadKey();
        }
    }
}
