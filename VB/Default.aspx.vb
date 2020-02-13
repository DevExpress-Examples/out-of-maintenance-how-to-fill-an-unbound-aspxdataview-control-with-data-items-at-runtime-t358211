#Region "#usings"
Imports DevExpress.Web
#End Region ' #usings

Partial Public Class _Default
	Inherits System.Web.UI.Page

	#Region "#addingItems"
	Private Const itemsCount As Integer = 10
	Protected Sub DataView_Load(ByVal sender As Object, ByVal e As System.EventArgs)
		AddDataItems(DataView)
		DataView.ItemTemplate = New MyDataViewTemplate()
	End Sub
	Private Sub AddDataItems(ByVal dataView As ASPxDataView)
		For i As Integer = 1 To itemsCount
			dataView.Items.Add().DataItem = New With {
				Key .ID = i,
				Key .Name = "Name" & i,
				Key .Description = "Sample description for the item"
			}
		Next i
	End Sub
	#End Region ' #addingItems
End Class
