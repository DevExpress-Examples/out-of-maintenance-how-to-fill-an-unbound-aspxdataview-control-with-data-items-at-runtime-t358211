#Region "#usings"
Imports System.Collections
Imports System.Linq
Imports DevExpress.Web
#End Region ' #usings

Partial Public Class _Default
	Inherits System.Web.UI.Page

	#Region "#addingItems"
	Private Const itemsCount As Integer = 10
	Protected Sub DataView_Load(ByVal sender As Object, ByVal e As System.EventArgs)
		DataView.DataSource = GetDataSource()
		DataView.ItemTemplate = New MyDataViewTemplate()
		DataView.DataBind()
	End Sub
	Public Function GetDataSource() As IEnumerable
		Dim dataSource As IEnumerable = Enumerable.Range(1, itemsCount).Select(Function(i) New With {
			Key .ID = i,
			Key .Name = "Name" & i,
			Key .Description = "Sample description for the item"
		})
		Return dataSource
	End Function
	#End Region ' #addingItems
End Class
