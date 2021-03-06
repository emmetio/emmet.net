﻿using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Editor;
using Microsoft.VisualStudio.Language.Intellisense;
using Microsoft.VisualStudio.Text.Editor;
using Microsoft.VisualStudio.Utilities;

namespace UIHelpers
{
    /// <summary>
    /// Listener responsible for injection of our command filters into every newly created CSS editor window.
    /// </summary>
    [TextViewRole("DOCUMENT"), ContentType("CSS"), Export(typeof(IVsTextViewCreationListener))]
    public class CssViewCreationListener : ViewCreationListenerBase, IVsTextViewCreationListener
    {
        [Import]
        internal override ICompletionBroker CompletionBroker { get; set; }

        [Import]
        internal override IVsEditorAdaptersFactoryService EditorAdaptersFactoryService { get; set; }

        /// <summary>
        /// Gets the syntax of the created document.
        /// </summary>
        protected internal override EmmetSyntax Syntax
        {
            get { return EmmetSyntax.Css; }
        }
    }
}