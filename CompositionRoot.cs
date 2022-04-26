using System;

namespace TutorialDependencyInjection
{
    class CompositionRoot : ICompositionRoot
    {
        public void LogMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
