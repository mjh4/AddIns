using MonoDevelop.Components.Commands;
using MonoDevelop.Ide;
using MonoDevelop.Ide.Gui;   
using Mono.TextEditor;
using System;  

namespace DateInserter
{
	class InsertDateHandler : CommandHandler
	{
		protected override void Run ()
		{
			Document doc = IdeApp.Workbench.ActiveDocument;
			var textEditorData = doc.GetContent<ITextEditorDataProvider> ().GetTextEditorData ();  
			string date = DateTime.Now.ToString ();  
			textEditorData.InsertAtCaret (date); 

		}

		protected override void Update (CommandInfo info)
		{
			Document doc = IdeApp.Workbench.ActiveDocument;  
			info.Enabled = doc != null && doc.GetContent<ITextEditorDataProvider> () != null;  

		}   
	}
}