<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="EnitityFramework.WebForm1" %>

<!DOCTYPE html>

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
                    <asp:Label ID="Label1" runat="server" Text="Id"></asp:Label></td>
                <td>



                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <br />
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label></td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    <br />
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Salary"></asp:Label></td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    <br />
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Gender"></asp:Label></td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    <br />
                </td>
            </tr>

            <tr>
                <td> 
                    <br />
                    <asp:Button ID="Button1" runat="server" Text="Insert" OnClick="Button1_Click1" Width="120px" />
                   
                </td>
                <td> 
                    <br />
                    <asp:Button ID="Button2" runat="server" Text="Update" Width="120px" OnClick="Button2_Click" />
                    </td>
                <td>
                    <br />
                    <asp:Button ID="Button3" runat="server" Text="Delete" Width="120px" OnClick="Button3_Click"/>
                </td>
                <td>
                    <br />
                </td>
               
            </tr>

            <tr>
                <td>
                    &nbsp;</td>
            </tr>
           

        </table>

        <table>
            <tr>
                <td>
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                </td>
                 <td>
                    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                </td>
                 <td>
                    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                </td>
            </tr>

                <tr>
                <td>
                    <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                </td>
                 <td>
                    <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                </td>
                 <td>
                    <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>

    </div>
    </form>
</body>
</html>
