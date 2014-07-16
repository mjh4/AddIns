using System;
using Mono.Addins;
using Mono.Addins.Description;

[assembly:Addin (
	"DateInserter", 
	Namespace = "DateInserter",
	Version = "1.0"
)]

[assembly:AddinName ("DateInserter")]
[assembly:AddinCategory ("DateInserter")]
[assembly:AddinDescription ("DateInserter")]
[assembly:AddinAuthor ("Max Hoffman")]

[assembly:AddinDependency ("::MonoDevelop.Core", MonoDevelop.BuildInfo.Version)]
[assembly:AddinDependency ("::MonoDevelop.Ide", MonoDevelop.BuildInfo.Version)]
