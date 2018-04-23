Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.ComponentModel

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Updating

Namespace WinSolution.Module.Win
	<ToolboxItemFilter("Xaf.Platform.Win")> _
	Public NotInheritable Partial Class WinSolutionWindowsFormsModule
		Inherits ModuleBase
		Public Sub New()
			InitializeComponent()
		End Sub
		Public Overrides Function GetModuleUpdaters(ByVal objectSpace As IObjectSpace, ByVal versionFromDB As Version) As IEnumerable(Of ModuleUpdater)
			Return ModuleUpdater.EmptyModuleUpdaters
		End Function
	End Class
End Namespace
