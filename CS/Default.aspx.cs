#region #usings
using System.Collections;
using System.Linq;
using DevExpress.Web;
#endregion #usings

public partial class _Default : System.Web.UI.Page {
    #region #addingItems
    const int itemsCount = 10;
    protected void DataView_Load(object sender, System.EventArgs e) {
        DataView.DataSource = GetDataSource();
        DataView.ItemTemplate = new MyDataViewTemplate();
        DataView.DataBind();
    }
    public IEnumerable GetDataSource() {
        IEnumerable dataSource = Enumerable.Range(1, itemsCount).Select(i => new {
            ID = i,
            Name = "Name" + i,
            Description = "Sample description for the item"
        });
        return dataSource;
    }
    #endregion #addingItems
}
