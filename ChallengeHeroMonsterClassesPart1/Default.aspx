﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeHeroMonsterClassesPart1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="labelResults" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="buttonFight" runat="server" OnClick="buttonFight_Click" Text="Fight!" />
    
    </div>
    </form>
</body>
</html>
