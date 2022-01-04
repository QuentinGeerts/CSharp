using System;
using System.Collections.Generic;

namespace CSharpVSCodeExtensionDelegue
{
    public delegate void ExtensionMain(string[] args);

    class VisualStudioCode
    {
        public List<VisualStudioCodeExtension> Extensions { get; set; }
        public ExtensionMain ExecExtention = null;

        public VisualStudioCode(params VisualStudioCodeExtension[] extensions)
        {
            Extensions = new List<VisualStudioCodeExtension>();

            foreach ( VisualStudioCodeExtension extension in extensions )
            {
                Extensions.Add(extension);
            }

            foreach ( VisualStudioCodeExtension extension in Extensions )
            {
                ExecExtention += extension.Main;
            }
        }

        internal void Start()
        {
            if ( ExecExtention != null ) ExecExtention(null);
        }
    }
}
