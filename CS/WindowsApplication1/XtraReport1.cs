using System;
using DevExpress.XtraEditors;

namespace WindowsApplication1 {
    public partial class XtraReport1: DevExpress.XtraReports.UI.XtraReport {
        public XtraReport1() {
            InitializeComponent();
        }

        private void XtraReport1_ParametersRequestBeforeShow(object sender,DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e) {
            CheckedComboBoxEdit cbc = new CheckedComboBoxEdit();
            e.ParametersInformation[0].Editor = cbc;
            categoriesTableAdapter.Fill(nwindDataSet1.Categories);
            for (int i = 0; i < nwindDataSet1.Categories.Count; i++)
                cbc.Properties.Items.Add(nwindDataSet1.Categories[i].CategoryID, nwindDataSet1.Categories[i].CategoryName,System.Windows.Forms.CheckState.Unchecked,true);
            //nwindDataSet1.Categories
            //cbc.Items.Add(
            //e.ParametersInformation[0].Editor 
        }

        private void XtraReport1_ParametersRequestSubmit(object sender,DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e) {
            this.FilterString = @"[CategoryID] In ("+e.ParametersInformation[0].Parameter.Value +")";
        }

    }
}
