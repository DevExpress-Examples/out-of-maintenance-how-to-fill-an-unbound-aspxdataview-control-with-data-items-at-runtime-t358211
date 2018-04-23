#region #usings
using DevExpress.Web;
#endregion #usings

public partial class _Default : System.Web.UI.Page {
    #region #addingItems
    const int itemsCount = 10;
    protected void DataView_Load(object sender, System.EventArgs e) {
        AddDataItems(DataView);
        DataView.ItemTemplate = new MyDataViewTemplate();
    }
    void AddDataItems(ASPxDataView dataView) {
        for (int i = 1; i <= itemsCount; i++) {
            dataView.Items.Add().DataItem = new {
                ID = i,
                Name = "Name" + i,
                Description = "Sample description for the item"
            };
        }
    }
    #endregion #addingItems
}