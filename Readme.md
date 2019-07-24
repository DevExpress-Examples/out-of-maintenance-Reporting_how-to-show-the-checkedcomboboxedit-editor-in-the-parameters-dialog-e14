<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsApplication1/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication1/Form1.vb))
* [XtraReport1.cs](./CS/WindowsApplication1/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/WindowsApplication1/XtraReport1.vb))
* [XtraReport1.Designer.cs](./CS/WindowsApplication1/XtraReport1.Designer.cs)
<!-- default file list end -->
# Print Preview - How to use a custom multi-selection editor in the Parameters dialog


<p>This example demonstrates how to use <a href="https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.CheckedComboBoxEdit">CheckedComboBoxEdit</a> to display a multi-value dropdown list for a report parameter in the <a href="https://docs.devexpress.com/XtraReports/10707/Create-End-User-Reporting-Applications/WinForms-Reporting/Print-Preview">print preview</a> Parameters panel <br />
The main idea is to handle the <a href="https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XtraReport.ParametersRequestBeforeShow">XtraReport.ParametersRequestBeforeShow</a> event and assign a required editor to the <a href="https://docs.devexpress.com/CoreLibraries/DevExpress.XtraReports.Parameters.ParameterInfo.Editor">DevExpress.XtraReports.Parameters.ParameterInfo.Editor</a> property.<br /><br />See also:<br /><a href="https://documentation.devexpress.com/#XtraReports/CustomDocument10000">Provide a User Interface for Requesting Parameter Values</a></p>

<br/>


