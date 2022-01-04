using System;

namespace CSharpVSCodeExtensionDelegue
{
    class Program
    {
        static void Main(string[] args)
        {
            CSharpVSCodeExtension cSharpExtension = new CSharpVSCodeExtension();
            VisualStudioCodeExtension indentExtension = new VisualStudioCodeExtension() { Name = "Indent Organizer" };
            VisualStudioCodeExtension linterExtension = new VisualStudioCodeExtension() { Name = "Easy Linter" };
            VisualStudioCodeExtension colorExtension = new VisualStudioCodeExtension() { Name = "Color Theme Manager" };

            VisualStudioCode vsc = new VisualStudioCode(cSharpExtension, indentExtension, linterExtension, colorExtension);

            vsc.Start();
        }
    }
}
