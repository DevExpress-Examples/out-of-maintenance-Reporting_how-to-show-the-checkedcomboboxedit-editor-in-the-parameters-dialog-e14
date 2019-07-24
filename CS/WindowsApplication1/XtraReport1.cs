using DevExpress.DataAccess.Sql.DataApi;
using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace WindowsApplication1 {
    public partial class XtraReport1: DevExpress.XtraReports.UI.XtraReport {
        public XtraReport1() {
            InitializeComponent();
        }

        private void XtraReport1_ParametersRequestBeforeShow(object sender,DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e) {
            BaseEdit customEditor = InitCustomEditor();            
            e.ParametersInformation[0].Editor = customEditor;
        }

        private BaseEdit InitCustomEditor() {
            CheckedComboBoxEdit editor = new CheckedComboBoxEdit();            
            parameterDataSource.Fill();
            IResultSet result = parameterDataSource.Result;
            ITable categoriesTable = result["Categories"];
            foreach(IRow item in categoriesTable) {
                    editor.Properties.Items.Add(item["CategoryID"], item["CategoryName"].ToString(), CheckState.Unchecked, true);
            }
            return editor;
        }

        private void XtraReport1_ParametersRequestSubmit(object sender,DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e) {
            this.FilterString = @"[CategoryID] In ("+e.ParametersInformation[0].Parameter.Value +")";
        }

    }
}
