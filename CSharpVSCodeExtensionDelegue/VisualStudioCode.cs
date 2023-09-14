using System.Collections.Generic;

namespace CSharpVSCodeExtensionDelegue
{
    public delegate void ExtensionMain(string[] args);

    internal class VisualStudioCode
    {
        public ExtensionMain ExecExtention;

        public VisualStudioCode(params VisualStudioCodeExtension[] extensions)
        {
            Extensions = new List<VisualStudioCodeExtension>();

            foreach (var extension in extensions) Extensions.Add(extension);

            foreach (var extension in Extensions) ExecExtention += extension.Main;
        }

        public List<VisualStudioCodeExtension> Extensions { get; set; }

        internal void Start()
        {
            if (ExecExtention != null) ExecExtention(null);
        }
    }
}