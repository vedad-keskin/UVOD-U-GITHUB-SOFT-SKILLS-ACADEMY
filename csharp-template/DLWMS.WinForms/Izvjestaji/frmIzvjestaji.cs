using Microsoft.Reporting.WinForms;

namespace DLWMS.WinForms.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        public frmIzvjestaji()
        {
            InitializeComponent();
        }
        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {           
            reportViewer1.RefreshReport();
        }
    }
}
