<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsApplication1/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication1/Form1.vb))
* [Program.cs](./CS/WindowsApplication1/Program.cs) (VB: [Program.vb](./VB/WindowsApplication1/Program.vb))
* [XtraReport1.cs](./CS/WindowsApplication1/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/WindowsApplication1/XtraReport1.vb))
<!-- default file list end -->
# How to show the CheckedComboBoxEdit editor in the Parameters dialog


<p>This example demonstrates how to embed a <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraEditorsCheckedComboBoxEdittopic">CheckedComboBoxEdit</a> control to the Parameters panel in a  <a href="https://documentation.devexpress.com/XtraReports/CustomDocument10707.aspx">Print Prevew</a> for parameters editing.<br />The main idea is to handle the <a href="https://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsUIXtraReport_ParametersRequestBeforeShowtopic">XtraReport.ParametersRequestBeforeShow</a> event and assign a required editor to the <a href="https://documentation.devexpress.com/CoreLibraries/DevExpressXtraReportsParametersParameterInfo_Editortopic.aspx">DevExpress.XtraReports.Parameters.ParameterInfo.Editor</a> property.<br /><br />See also:<br /><a href="https://documentation.devexpress.com/#XtraReports/CustomDocument10000">Provide a User Interface for Requesting Parameter Values</a></p>

<br/>


