<!-- default file list -->
*Files to look at*:

* [MyDataViewTemplate.cs](./CS/App_Code/MyDataViewTemplate.cs) (VB: [MyDataViewTemplate.vb](./VB/App_Code/MyDataViewTemplate.vb))
* [Default.aspx](./CS/Default.aspx) (VB: [Default.aspx](./VB/Default.aspx))
* [Default.aspx.cs](./CS/Default.aspx.cs) (VB: [Default.aspx](./VB/Default.aspx))
<!-- default file list end -->
# How to fill an unbound ASPxDataView control with data items at runtime


<p>Aside from <a href="http://help.devexpress.com/#AspNet/CustomDocument115695">binding to a data source</a>, you can populate the <a href="https://documentation.devexpress.com/#AspNet/clsDevExpressWebASPxDataViewtopic">ASPxDataView</a> control with <a href="http://help.devexpress.com/#AspNet/CustomDocument115725">data items</a> manually. <br><br>Data items can be added into the <a href="http://larix/ReferenceBrowserMain_16_1/LoadItem.aspx?Member=P%3aDevExpress.Web.ASPxDataView.Items&Template=MemberPropertyTopic">ASPxDataView.Items</a> collection in code behind by using the <a href="http://larix/ReferenceBrowserMain_16_1/LoadItem.aspx?Member=M%3aDevExpress.Web.DataViewItemCollection.Add&Template=MemberOverloadTopic">DataViewItemCollection.Add</a> method. In this case, a custom data object with the required properties should be assigned to the <a href="http://larix/ReferenceBrowserMain_16_1/LoadItem.aspx?Member=P%3aDevExpress.Web.DataViewItem.DataItem&Template=MemberPropertyTopic">DataViewItem.DataItem</a> property value. The <a href="http://larix/ReferenceBrowserMain_16_1/LoadItem.aspx?Member=P%3aDevExpress.Web.ASPxDataView.Items&Template=MemberPropertyTopic">ASPxDataView.Items</a> collection cannot be popularized declaratively.<br><br>In this example, an object of an anonymous type with custom data fields is created for each data item. The <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebASPxDataView_ItemTemplatetopic">item template</a> for displaying data items is also created at runtime.</p>
<br><strong>See Also:<br></strong><a href="http://help.devexpress.com/#AspNet/CustomDocument115695">ASPxDataView — Binding to Data</a><br><a href="https://www.devexpress.com/Support/Center/p/T358208">How to bind the ASPxDataView control to the data source declaratively</a><br><a href="https://www.devexpress.com/Support/Center/p/T358210">How to bind the ASPxDataView</a><a href="https://www.devexpress.com/Support/Center/p/T358210"> c</a><a href="https://www.devexpress.com/Support/Center/p/T358210">ontrol</a><a href="https://www.devexpress.com/Support/Center/p/T358210"> to the data</a><a href="https://www.devexpress.com/Support/Center/p/T358210"> sour</a><a href="https://www.devexpress.com/Support/Center/p/T358210">ce</a><a href="https://www.devexpress.com/Support/Center/p/T358210"> at runtime</a>

<br/>


