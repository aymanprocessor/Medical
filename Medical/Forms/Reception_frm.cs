using LiteDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Medical.Forms
{
    public partial class Reception_frm : Form
    {
        private Reception reception;
        public Reception_frm(Reception mreception)
        {
            reception = mreception;
            InitializeComponent();
        }

        public Reception_frm()
        {
            InitializeComponent();
        }

        private void Reception_frm_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnOk.Text == "Insert")
                {
                    using (var db = new LiteDatabase(@"database.db"))
                    {
                        var coll = db.GetCollection<Reserve>("Reserves");
                        var reserve = new Reserve
                        {

                            name = tbName.Text.ToString(),
                            mobile = tbMobile.Text.ToString(),
                            reserveDate = dtpReserveDate.Value,
                            job = cbJob.Text.ToString(),
                            dept = cbDept.Text.ToString(),
                            treatment = cbTreatment.Checked,
                            invoice = cbInvoice.Checked,
                            vacation = cbVacation.Checked
                        };

                        coll.Insert(reserve);
                        loadReserves();
                        clear();
                    }
                }
                else if (btnOk.Text == "Update")
                {
                    using (var db = new LiteDatabase(@"database.db"))
                    {
                        var coll = db.GetCollection<Reserve>("Reserves");
                        var row = coll.FindById((int)reception.dgReception.Rows[reception.rowSelected].Cells[0].Value);
                        row.name = tbName.Text;
                        row.mobile = tbMobile.Text;
                        row.reserveDate = dtpReserveDate.Value;
                        row.job = cbJob.Text;
                        row.dept = cbDept.Text;
                        row.vacation = cbVacation.Checked;
                        row.invoice = cbInvoice.Checked;
                        row.treatment = cbTreatment.Checked;

                        coll.Update(row);
                    }
                    loadReserves();
                    this.Hide();
                }
            }
            catch (Exception x)
            {

                MessageBox.Show(x.ToString());
            }

        }


        private void loadReserves()
        {
            var list = new List<Reserve>();
            using (var db = new LiteDB.LiteDatabase(@"database.db"))
            {
                var col = db.GetCollection<Reserve>("Reserves");
                var result = col.FindAll().Select(x => new
                {
                    ID = x.ID,
                    Name = x.name,
                    Mobile = x.mobile,
                    Job = x.job,
                    Department = x.dept,
                    Date = x.reserveDate.ToString("d/MM/yyyy"),
                    Treatment = x.treatment,
                    Invoice = x.invoice,
                    Vacation = x.vacation
                });

                reception.dgReception.DataSource = result.ToList();

            }
        }
        public void clear()
        {
            tbName.Text = "";
            tbMobile.Text = "";
            dtpReserveDate.Value = DateTime.Today;
            cbJob.Text = "";
            cbDept.Text = "";
            cbTreatment.Checked = false;
            cbInvoice.Checked = false;
            cbVacation.Checked = false;
        }

        private void tbMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !(e.KeyChar == '+') && !(char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }

        } 
    }
}
