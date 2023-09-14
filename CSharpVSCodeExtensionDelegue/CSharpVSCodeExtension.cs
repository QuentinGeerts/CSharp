using System;

namespace CSharpVSCodeExtensionDelegue
{
    internal class CSharpVSCodeExtension : VisualStudioCodeExtension
    {
        public CSharpVSCodeExtension()
        {
            Name = "CSharp";
        }

        public override void Main(string[] args)
        {
            base.Main(args);
            Console.WriteLine("Launch interpretor...");
            StartInterpretor();
        }

        private void StartInterpretor()
        {
            Console.WriteLine("Interpretor is started");
        }
    }
}