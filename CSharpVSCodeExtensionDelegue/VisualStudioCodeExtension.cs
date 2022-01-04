using System;

namespace CSharpVSCodeExtensionDelegue
{
    class VisualStudioCodeExtension
    {
        public string Name { get; set; }

        public virtual void Main(string[] args)
        {
            Console.WriteLine($"L'extension {this.Name} a démarré...");
        }
    }
}
