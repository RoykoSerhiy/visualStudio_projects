<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="multiWiew.aspx.cs" Inherits="_08._06._15Home.multiWiew" %>

<!DOCTYPE html>

<script runat="server">
    public enum SearchType
    {
        NotSet = -1,
        Products = 0,
        Category = 1
    }
    
    protected void Button1_Click(Object sender, System.EventArgs e)
    {
        if(MultiView1.ActiveViewIndex > -1)
        {
            String searchTerm = "";
            SearchType mSearchType = 
                 (SearchType) MultiView1.ActiveViewIndex;
            switch(mSearchType)
            {
            case SearchType.Products:
                DoSearch(textProductName.Text, mSearchType);
                break;
            case SearchType.Category:
                DoSearch(textCategory.Text, mSearchType);
                break;
            case SearchType.NotSet:
                break;
            }
        }
    }
    
    protected void DoSearch(String searchTerm, SearchType type)
    {
        // Code here to perform a search.
    }

    protected void radioButton_CheckedChanged(Object sender, 
        System.EventArgs e)
    {
        if(radioProduct.Checked)
        {
            MultiView1.ActiveViewIndex = (int) SearchType.Products;
        }
        else if(radioCategory.Checked)
        {
            MultiView1.ActiveViewIndex = (int) SearchType.Category;
        }
    }
</script>

<html>
<head id="Head1" runat="server"></head>
<body>
    <form id="form1" runat="server">
    <div>
        Search by product or by category?
        <br />
        <asp:RadioButton ID="radioProduct" 
            runat="server" 
            autopostback="true" 
            GroupName="SearchType" 
            Text="Product" 
            OnCheckedChanged="radioButton_CheckedChanged" />
        &nbsp;
        <asp:RadioButton ID="radioCategory" 
            runat="server" 
            autopostback="true" 
            GroupName="SearchType" 
            Text="Category" 
            OnCheckedChanged="radioButton_CheckedChanged" />
        <br />
        <br />
        <asp:MultiView ID="MultiView1" runat="server">
            <asp:View ID="viewProductSearch" runat="server">
                Enter product name: 
                <asp:TextBox ID="textProductName" runat="server">
                </asp:TextBox>
            </asp:View>
            <asp:View ID="viewCategorySearch" runat="server">
                Enter category: 
                <asp:TextBox ID="textCategory" runat="server">
                </asp:TextBox>
            </asp:View>
        </asp:MultiView>&nbsp;<br />
        <br />
        <asp:Button ID="btnSearch" 
           OnClick="Button1_Click" 
           runat="server" Text="Search" />
     </div>
    </form>
</body>
</html>
