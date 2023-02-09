<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SummaryBD.aspx.cs" Inherits="ITMO.ASPNET.WebForms.RSVP.SummaryBD" MasterPageFile="~/Site.master" %>

<asp:Content ID="MainContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Список участников</h2>

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="LinqDataSource1">
    <Columns>
        <asp:BoundField DataField="Name" HeaderText="Имя" ReadOnly="True" SortExpression="Name" />
        <asp:BoundField DataField="Email" HeaderText="Электронный адрес" ReadOnly="True" SortExpression="Email" />
        <asp:BoundField DataField="Phone" HeaderText="Телефон" ReadOnly="True" SortExpression="Phone" />
        <asp:CheckBoxField DataField="WillAttend" HeaderText="Докладчик" ReadOnly="True" SortExpression="WillAttend" />
        <asp:BoundField DataField="Rdata" HeaderText="Дата регистрации" ReadOnly="True" SortExpression="Rdata" />
    </Columns>
    </asp:GridView>
    <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="ITMO.ASPNET.WebForms.RSVP.SampleContext" EntityTypeName="" Select="new (Name, Email, Phone, WillAttend, Rdata, Reports)" TableName="GuestResponses">
    </asp:LinqDataSource>
</asp:Content>
