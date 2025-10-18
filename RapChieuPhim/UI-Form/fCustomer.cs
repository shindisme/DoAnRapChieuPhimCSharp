using System;
using System.Windows.Forms;

namespace RapChieuPhim.UI_Form
{
    public partial class fCustomer : Form
    {
        public fCustomer()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            errorProvide.SetError(txbTicketID, "");
            errorProvide.SetError(txbName, ""); 
            errorProvide.SetError(txbPhone, "");
            if (txbTicketID.Text == "")
                errorProvide.SetError(txbTicketID, "Nhập mã!");
            if (txbName.Text =="" )
            {
                errorProvide.SetError(txbName, "Nhập tên khách hàng!");
            }
            if(txbPhone.Text =="")
            {
                errorProvide.SetError(txbName, "Nhập số điện thoại!");
            }
            else
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
