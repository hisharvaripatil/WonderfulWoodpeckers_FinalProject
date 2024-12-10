<!--
 * Name: Jacob Brumfield, Sharvari Patil, Rithu Aynampudi
 * Email: brumfijb@mail.uc.edu, patilsg@mail.uc.edu, aynampru@mail.uc.edu
 * Assignment Number: Final Project- Wonderful Woodpeckers
 * Due Date: 12/10
 * Course #/Section: IS 3050 001
 * Semester/Year: Fall 2024
 * Brief Desciption of the assignment: Creating a functional website that solves 3 hard Leetcode problems with the help of GitHub. 
 * Citations: GoogleGemini and ChatGPT. -->


<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WonderfulWoodpeckers_FinalProject.index" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>LeetCode Problems</title>
    <link rel="stylesheet" type="text/css" href="styles.css" />
</head>
<body>
    <form runat="server">
        <div>
            <h2>Best Leetcode Problems Ever!</h2>

            <label for="problemsDropdown">Select Problem:</label>
            <asp:DropDownList ID="problemsDropdown" runat="server">
                <asp:ListItem Text="select your lovely problem" Value="Problem" />
                <asp:ListItem Text="Regular Expression Matching" Value="ExpressionProblem" />
                <asp:ListItem Text="Substring with Concatenation of All Words" Value="SubstringProblem" />
                <asp:ListItem Text="Median of Two Sorted Arrays" Value="MedianProblem" />
            </asp:DropDownList>

             <br /><br />

 <asp:Button ID="problembtn" runat="server" Text="Show me the solution please!" OnClick="problembtn_Click" />


            <br /><br />

            <label></label>
            <asp:Label ID="problemDescription" runat="server"></asp:Label>

            <br /><br />

            <label></label>
            <asp:Label ID="testCase" runat="server"></asp:Label>

            <br /><br />
            <label></label>
            <asp:Label ID="solutionOutput" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>