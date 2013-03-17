<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="CalculatorStyle.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="main">
    <h1>Simple Calculator</h1>
        <p>This is not the most sophisitcated of calculators. For one thing you must hit the calculate button after any pair of operations. For Example you can
            do 2 + 3 calculate * 5 calculate / 5 calculate, but not 2 + 2 * 5 / 5 calculate. A challenge, if you want to play with this is, to make that kind of sequence work. </p>
        <p>There are other things you could add as well: You could make it so you can see all the operations that have occured and in the order they occured since the last clear. You could also add other operations, the modulus, the square root, various functions. It never hurst to play and you might learn some things.
        </p>
        <hr />
        <table>
            <tbody>
            <tr><td colspan="4" >
                <asp:TextBox ID="txtEntry" runat="server" Width="197px" CssClass="calctext"></asp:TextBox></td></tr>
            <tr>
                
                    <td><asp:Button ID="Button1" runat="server" Text="9" OnClick="calc_click" cssClass="buttonwidth"/></td>
                    <td><asp:Button ID="Button2" runat="server" Text="8" OnClick="calc_click" cssClass="buttonwidth"/></td>
                    <td><asp:Button ID="Button3" runat="server" Text="7" OnClick="calc_click" cssClass="buttonwidth"/></td>    
                    <td><asp:Button ID="btnMinus" runat="server" Text="-" cssClass="buttonwidth" OnClick="btnMinus_Click"/></td>
            </tr>
              <tr>
                    <td><asp:Button ID="Button4" runat="server" Text="4" OnClick="calc_click" cssClass="buttonwidth" /></td>
                    <td><asp:Button ID="Button5" runat="server" Text="5" OnClick="calc_click" cssClass="buttonwidth"/></td>
                    <td><asp:Button ID="Button6" runat="server" Text="6" OnClick="calc_click" cssClass="buttonwidth"/></td>    
                    <td><asp:Button ID="btnPlus" runat="server" Text="+" cssClass="buttonwidth" OnClick="btnPlus_Click"/></td>
            </tr>
              <tr>
                    <td><asp:Button ID="Button8" runat="server" Text="1" OnClick="calc_click" cssClass="buttonwidth" /></td>
                    <td><asp:Button ID="Button9" runat="server" Text="2" OnClick="calc_click" cssClass="buttonwidth"/></td>
                    <td><asp:Button ID="Button10" runat="server" Text="3" OnClick="calc_click" cssClass="buttonwidth"/></td>    
                    <td><asp:Button ID="btnMultiply" runat="server" Text="*" cssClass="buttonwidth" OnClick="btnMultiply_Click" /></td>
            </tr>
              <tr>
                  <td colspan="2"> <asp:Button ID="btnCalculate" runat="server" Text="Calc" Width="95" OnClick="btnCalculate_Click" /></td>
                  <td> <asp:Button ID="btnClear" runat="server" Text="Clr" cssClass="buttonwidth" OnClick="btnClear_Click" />  </td>
                  <td>
                      <asp:Button ID="btnDivide" runat="server" Text="/" cssClass="buttonwidth" OnClick="btnDivide_Click" /> </td>
                  
            </tr>
            </tbody>
        </table>
    </div>
    </form>
</body>
</html>
