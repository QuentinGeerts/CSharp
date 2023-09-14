namespace CSharpVSCodeExtensionDelegue
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var cSharpExtension = new CSharpVSCodeExtension();
            var indentExtension = new VisualStudioCodeExtension { Name = "Indent Organizer" };
            var linterExtension = new VisualStudioCodeExtension { Name = "Easy Linter" };
            var colorExtension = new VisualStudioCodeExtension { Name = "Color Theme Manager" };

            var vsc = new VisualStudioCode(cSharpExtension, indentExtension, linterExtension, colorExtension);

            vsc.Start();
        }
    }
}