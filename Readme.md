<!-- default file list -->
*Files to look at*:

* [MyDataViewTemplate.cs](./CS/App_Code/MyDataViewTemplate.cs) (VB: [MyDataViewTemplate.vb](./VB/App_Code/MyDataViewTemplate.vb))
* [Default.aspx](./CS/Default.aspx) (VB: [Default.aspx](./VB/Default.aspx))
* [Default.aspx.cs](./CS/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/Default.aspx.vb))
<!-- default file list end -->
# How to fill an unbound ASPxDataView control with data items at runtime


<p>Aside from <a href="https://docs.devexpress.com/AspNet/115695/components/data-and-image-navigation/dataview/concepts/binding-to-data">binding to a data source</a>, you can populate the <a href="https://documentation.devexpress.com/#AspNet/clsDevExpressWebASPxDataViewtopic">ASPxDataView</a> control with <a href="https://docs.devexpress.com/AspNet/115725/components/data-and-image-navigation/dataview/concepts/data-items">data items</a> manually. <br><br>Data items can be added into the <a href="https://docs.devexpress.com/AspNet/DevExpress.Web.ASPxDataView.Items">ASPxDataView.Items</a> collection in code behind by using the <a href="https://docs.devexpress.com/AspNet/DevExpress.Web.Collection-1.Add(-0)">DataViewItemCollection.Add</a> method. In this case, a custom data object with the required properties should be assigned to the <a href="https://docs.devexpress.com/AspNet/DevExpress.Web.DataViewItem.DataItem">DataViewItem.DataItem</a> property value. The <a href="https://docs.devexpress.com/AspNet/DevExpress.Web.ASPxDataView.Items">ASPxDataView.Items</a> collection cannot be popularized declaratively.<br><br>In this example, an object of an anonymous type with custom data fields is created for each data item. The <a href="https://docs.devexpress.com/AspNet/DevExpress.Web.ASPxDataView.ItemTemplate">item template</a> for displaying data items is also created at runtime.</p>
<br><strong>See Also:<br></strong><a href="https://docs.devexpress.com/AspNet/115695/components/data-and-image-navigation/dataview/concepts/binding-to-data">ASPxDataView — Binding to Data</a><br><a href="https://www.devexpress.com/Support/Center/p/T358208">How to bind the ASPxDataView control to the data source declaratively</a><br><a href="https://www.devexpress.com/Support/Center/p/T358210">How to bind the ASPxDataView control to a data source at runtime</a> 

<br/>


