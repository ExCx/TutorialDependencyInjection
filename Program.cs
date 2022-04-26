using Castle.MicroKernel.Registration;
using Castle.Windsor;
using System;

namespace TutorialDependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new WindsorContainer();
            container.Register(Component.For<ICompositionRoot>().ImplementedBy<CompositionRoot>());

            var root = container.Resolve<ICompositionRoot>();
            root.LogMessage("Hello from my very first resolved class!");

            Console.ReadLine();
        }
    }
}