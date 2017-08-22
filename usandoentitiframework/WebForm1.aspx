<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication4.usandoentitiframework.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ListView ID="ListView1" runat="server">
            <LayoutTemplate>
                <table runat="server"  id="table1">
                    <tr runat="server" style="border-style: dotted; border-width: 1px" id="groupPlaceholder"></tr>
                </table>
                <asp:DataPager runat="server" ID="DataPager"
                               PageSize="4">
                   <Fields>
                     <asp:NumericPagerField ButtonCount="7"
                          PreviousPageText="<--"
                          NextPageText="-->" />
                   </Fields>
                </asp:DataPager>
            </LayoutTemplate>
            <GroupTemplate>
                <tr runat="server" id="productRow" style="border-style: dotted; border-width: 1px">
                    <td runat="server" style="border-style: dotted; border-width: 1px" id="itemPlaceholder">
                    </td>
                </tr>
            </GroupTemplate>
            <ItemTemplate>
                    <td id="Td1" valign="top" align="center" style="border-style: dotted; border-width: 1px" runat="server">
                        <asp:Image ID="Fax" runat="server"
                           ImageUrl='<%#"/Images/" + Eval("Fax") %>'
                           Height="49" /><br />
                        <asp:Label ID="CompanyName" runat="server" Text='<%#Eval("CompanyName")%>' />
                    </td>

            </ItemTemplate>
            <InsertItemTemplate>
            </InsertItemTemplate>
        </asp:ListView>
    </div>
    </form>
</body>
</html>
