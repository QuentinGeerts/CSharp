using System;

namespace CSharpVSCodeExtensionDelegue
{
    internal class VisualStudioCodeExtension
    {
        public string Name { get; set; }

        public virtual void Main(string[] args)
        {
            Console.WriteLine($"L'extension {Name} a démarré...");
        }
    }
}