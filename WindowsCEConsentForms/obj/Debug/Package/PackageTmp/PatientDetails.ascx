﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PatientDetails.ascx.cs"
    Inherits="WindowsCEConsentForms.PatientDetails" %>
<ul class="content">
    <li>
        <div class="right smallest">
            MR#:
        </div>
        <div class="right small">
            <asp:Label ID="LblPatientMRId" runat="server" CssClass="errorInfo"></asp:Label></div>
        <div class="right smallest">
            Name:
        </div>
        <div class="right small">
            <asp:Label runat="server" ID="LblPatientName" CssClass="errorInfo"></asp:Label></div>
        <div class="clear">
        </div>
    </li>
    <li>
        <div class="right smallest">
            Date:
        </div>
        <div class="right small">
            <asp:Label runat="server" ID="LblDate" CssClass="errorInfo"></asp:Label></div>
        <div class="right smallest">
            Time:
        </div>
        <div class="right small">
            <asp:Label runat="server" ID="LblTime" CssClass="errorInfo"></asp:Label></div>
        <div class="clear">
        </div>
    </li>
</ul>