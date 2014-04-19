<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserData.aspx.cs" Inherits="SampleCloud.UserData" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td>
                    <asp:Label ID="lblfname" runat="server" Text="First Name : "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtfname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lbllname" runat="server" Text="Last Name : "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtlname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblemail" runat="server" Text="Email ID : "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblcountry" runat="server" Text="Country : "></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="drpcountry" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <asp:Button ID="btnok" runat="server" Text="OK" onclick="btnok_Click" />
                    <asp:Button ID="btncancel" runat="server" Text="Cancel" />
                </td>
            </tr>
        </table>
        <table>
            <tr>
                <td>
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                        CellPadding="4" DataKeyNames="userid" ForeColor="#333333" GridLines="None" 
                        onrowcancelingedit="GridView1_RowCancelingEdit" 
                        onrowdeleting="GridView1_RowDeleting" onrowediting="GridView1_RowEditing" 
                        onrowupdating="GridView1_RowUpdating">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:TemplateField HeaderText="First Name">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# bind("fname") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label1" runat="server" Text='<%# bind("fname") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Last Name">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox2" runat="server" Text='<%# bind("lname") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label2" runat="server" Text='<%# bind("lname") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Email">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox3" runat="server" Text='<%# bind("email") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label3" runat="server" Text='<%# bind("email") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Country">
                                <ItemTemplate>
                                    <asp:Label ID="Label4" runat="server" Text='<%# bind("countryname") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:CommandField HeaderText="Edit" ShowEditButton="True" />
                            <asp:CommandField HeaderText="Delete" ShowDeleteButton="True" />
                        </Columns>
                        <EditRowStyle BackColor="#2461BF" />
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EFF3FB" />
                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#F5F7FB" />
                        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                        <SortedDescendingCellStyle BackColor="#E9EBEF" />
                        <SortedDescendingHeaderStyle BackColor="#4870BE" />
                    </asp:GridView>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
