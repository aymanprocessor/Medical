using LiteDB;
using Medical.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical
{
    public partial class Reception : Form
    {
        Reception_frm reception_Frm;
        public int rowSelected;
        public Reception()
        {
            InitializeComponent();
        }



        private void btnNew_Click(object sender, EventArgs e)
        {
            reception_Frm = new Reception_frm(this);
            reception_Frm.Show();
            reception_Frm.clear();
        }

        private void Reception_Load(object sender, EventArgs e)
        {
            loadReserves();

        }

        private void loadReserves()
        {
            var list = new List<Reserve>();
            using (var db = new LiteDB.LiteDatabase(@"database.db"))
            {
                var col = db.GetCollection<Reserve>("Reserves");
                var result = col.FindAll().Select(x => new
                {
                    Code = x.ID,
                    Name = x.name,
                    Mobile = x.mobile,
                    Job = x.job,
                    Department = x.dept,
                    Date = x.reserveDate.ToString("d/MM/yyyy")
                });

                dgReception.DataSource = result.ToList();
            }



        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedRows = dgReception.SelectedRows
               .OfType<DataGridViewRow>()
               .Where(r => !r.IsNewRow)
               .ToArray();
            try
            {
                using (var db = new LiteDB.LiteDatabase(@"Database.db"))
                {

                    var col = db.GetCollection<Reserve>("Reserves");



                    int rowwIndex = dgReception.FirstDisplayedScrollingRowIndex;


                    foreach (var i in selectedRows)
                    {
                        var row = col.FindById((int)i.Cells[0].Value);
                        col.Delete(row.ID);
                    }




                    loadReserves();

                    dgReception.FirstDisplayedScrollingRowIndex = rowwIndex;



                }
            }
            catch (Exception exp)
            {
                // MessageBox.Show(exp.ToString());
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            update();
        }

        private void dgReception_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            update();
        }

        private void dgReception_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowSelected = e.RowIndex;
        }

        private void update()
        {
            reception_Frm = new Reception_frm(this);
            reception_Frm.clear();
            reception_Frm.btnOk.Text = "Update";
            using (var db = new LiteDB.LiteDatabase(@"database.db"))
            {
                var coll = db.GetCollection<Reserve>("Reserves");
                var row = coll.FindById((int)dgReception.Rows[rowSelected].Cells[0].Value);

                reception_Frm.dtpReserveDate.Value = row.reserveDate;
                reception_Frm.tbName.Text = row.name;
                reception_Frm.tbMobile.Text = row.mobile;
                reception_Frm.cbJob.Text = row.job;
                reception_Frm.cbDept.Text = row.dept;
            }
            reception_Frm.Show();
        }

        private void search(string by, string what)
        {
            try
            {
                reception_Frm = new Reception_frm(this);

                using (var db = new LiteDB.LiteDatabase(@"database.db"))
                {
                    var coll = db.GetCollection<Reserve>("Reserves");
                    coll.EnsureIndex(x => x.name);
                    coll.EnsureIndex(x => x.reserveDate);

                    var row = coll.Find(Query.StartsWith(by, what)).Select(x => new
                    {
                        Code = x.ID,
                        Name = x.name,
                        Mobile = x.mobile,
                        Job = x.job,
                        Department = x.dept,
                        Date = x.reserveDate.ToString("d/MM/yyyy")
                    });

                    dgReception.DataSource = row.ToList();
                }
            }
            catch (Exception)
            {

                
            }

        }
        

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbSearch.Text == "")
            {
                loadReserves();
            }
            else
            {
                if (rbName.Checked)
                {
                    
                    search("name", tbSearch.Text);
                }
                else if (rbDate.Checked)
                {

                    try
                    {
                        reception_Frm = new Reception_frm(this);

                        using (var db = new LiteDatabase(@"database.db"))
                        {
                            var coll = db.GetCollection<Reserve>("Reserves");
                            coll.EnsureIndex(x => x.name);
                            coll.EnsureIndex(x => x.reserveDate);

                            var row = coll.Find(Query.StartsWith("reserveDate", Convert.ToDateTime(tbSearch.Text).ToString("d/MM/yyyy"))).Select(x => new
                            {
                                Code = x.ID,
                                Name = x.name,
                                Mobile = x.mobile,
                                Job = x.job,
                                Department = x.dept,
                                Date = x.reserveDate.ToString("d/MM/yyyy")
                            });
                            label2.Text = Convert.ToDateTime(tbSearch.Text).Date.ToShortDateString();
                            dgReception.DataSource = row.ToList();
                        }
                    }
                    catch (Exception)
                    {


                    }
                }
            }
        }

       
    }
}

