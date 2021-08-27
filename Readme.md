<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128603392/19.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1404)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsApplication1/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication1/Form1.vb))
* [XtraReport1.cs](./CS/WindowsApplication1/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/WindowsApplication1/XtraReport1.vb))
* [XtraReport1.Designer.cs](./CS/WindowsApplication1/XtraReport1.Designer.cs)
<!-- default file list end -->
# Print Preview - How to use a custom multi-selection editor in the Parameters dialog

<p>Report parameters support the multi-value functionality out of the box. Enable the <a href="https://docs.devexpress.com/CoreLibraries/DevExpress.DocumentServices.ServiceModel.DataContracts.ReportParameter.MultiValue">MultiValue</a> property so that a parameter can store a list of values instead of a single value. The default editor for this type of parameters is a multi-select drop-down list. See <a href="https://docs.devexpress.com/XtraReports/9998/Detailed-Guide-to-DevExpress-Reporting/Shape-Report-Data/Use-Report-Parameters/Create-Multi-Value-and-Cascading-Report-Parameters">Create Multi-Value and Cascading Report Parameters</a> for more information.</p>
<p>This example demonstrates how to use a custom <a href="https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.CheckedComboBoxEdit">CheckedComboBoxEdit</a> to display a multi-value drop-down list for a report parameter in the <a href="https://docs.devexpress.com/XtraReports/10707/Create-End-User-Reporting-Applications/WinForms-Reporting/Print-Preview">print preview</a> Parameters panel. <br />
The main idea is to handle the <a href="https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XtraReport.ParametersRequestBeforeShow">XtraReport.ParametersRequestBeforeShow</a> event and assign a required editor to the <a href="https://docs.devexpress.com/CoreLibraries/DevExpress.XtraReports.Parameters.ParameterInfo.Editor">DevExpress.XtraReports.Parameters.ParameterInfo.Editor</a> property.<br /><br />
<br/>


