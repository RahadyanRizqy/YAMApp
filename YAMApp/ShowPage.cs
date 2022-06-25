using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace YAMApp
{
    public partial class ShowPage : Form
    {
        private int user_id;

        private int acctypeselectedcbox;
        private string dateinsertselectedcbox;

        private string accuidselected;
        private string accunameselected;
        private string accupassselected;
        private string accemailselected;
        private string acceemailselected;
        private string accphoneselected;
        private string accdescselected;
        private string accplatfselected;
        private string acctypeselected;
        private string accdateselected;

        private string dateupdateselected;

        public static string accuidpasstodatapage = "";
        public static string accunamepasstodatapage = "";
        public static string accupasspasstodatapage = "";
        public static string accemailpasstodatapage = "";
        public static string accphonepasstodatapage = "";
        public static string accdescpasstodatapage = "";
        public static string accplatfpasstodatapage = "";
        public static int acctypepasstodatapage = 0;
        public static string accdateinsertpasstodatapage = "";
        public static string accdateupdatepasstodatapage = "";

        private int acctypeselectedindexbyrow;

        private int cmd;
        public ShowPage(int user_id = 0)
        {
            InitializeComponent();
            this.user_id = user_id;
            DatePickerComboBox.Value = DateTime.Now;
            Query qry2 = new Query("user", "user_name", $"WHERE user_id = {user_id}");
            Database userid = new SQLDBHelper(qry2.select());
            // UserGreet.Text = "Selamat Datang User: " + Convert.ToString(userid.GetValue());
            AccTypeComboBox.Items.Add("");
            dgv1.RowHeadersVisible = false;
            for (int i = 1; i <= 5; i++)
            {
                Query qry = new Query("type", "type_name", $"WHERE type_id = {i}");
                Database acctypes = new SQLDBHelper(qry.select());
                AccTypeComboBox.Items.Add(acctypes.GetValue());
            }
            this.dgv1.DefaultCellStyle.Font = new Font("Segoe UI", 10);
        }
        private string GenerateUID()
        {
            DateTime dt = DateTime.Now;
            UIDGen uidgen = new UIDGen();
            string timestamp = dt.ToString("yyyysMMddHHmmss");
            uidgen.UID(timestamp);
            return uidgen.getUid();
        }
        private void MinButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseButtton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuShowButton_Click(object sender, EventArgs e)
        {
            this.AccTypeComboBox.SelectedIndex = 0;
            this.DatePickerComboBox.Value = DateTime.Now;
            this.FindByUIDInsert.Text = "";
            Query qry = new Query("account", "COUNT(*)");
            Database check = new SQLDBHelper(qry.select());
            if (Convert.ToInt32(check.GetValue()) > 0)
            {
                ShowAll();
            }
            else
            {
                MessageBox.Show("Data Tidak Ada Sama Sekali, Silahkan Input Data");
            }

        }
        private void ShowAll()
        {
            Query qry = new Query("account a, type t", "a.acc_uid as \"UID Akun\", a.acc_platf as \"Platform\", a.acc_uname as \"Username\", a.acc_pword as \"Password\", a.acc_email as \"Email\", a.acc_phone as \"No. Telp\", a.acc_desc as \"Deskripsi\", t.type_name as \"Tipe Akun\", a.insert_date as \"Tgl. Input\", a.update_date as \"Tgl. Ubah\"", "WHERE a.acc_type_id = t.type_id ORDER BY a.acc_type_id ASC");
            Database db = new SQLDBHelper(qry.select());
            DataTable dt = new DataTable();
            db.ExecReader(dgv1, dt);

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {
            
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = dgv1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgv1.Rows[selectedrowindex];
            this.accuidselected = Convert.ToString(selectedRow.Cells[0].Value);
            this.accplatfselected = Convert.ToString(selectedRow.Cells[1].Value);
            this.accunameselected = Convert.ToString(selectedRow.Cells[2].Value);
            this.accupassselected = Convert.ToString(selectedRow.Cells[3].Value);
            this.accemailselected = Convert.ToString(selectedRow.Cells[4].Value);
            this.accphoneselected = Convert.ToString(selectedRow.Cells[5].Value);
            this.accdescselected = Convert.ToString(selectedRow.Cells[6].Value);
            // this.acctypeselected = Convert.ToString(selectedRow.Cells[7].Value);
            Query qry = new Query("type", "type_id", $"WHERE type_name = '{Convert.ToString(selectedRow.Cells[7].Value)}'");
            Database type = new SQLDBHelper(qry.select());
            this.acctypeselectedindexbyrow = Convert.ToInt32(type.GetValue());
            this.accdateselected = Convert.ToString(selectedRow.Cells[8].Value);
            this.dateupdateselected = Convert.ToString(selectedRow.Cells[9].Value);
            SelectedAcc.Text = "ID Akun Terpilih: " + accuidselected;
        }
        private void ShowSpecific(string table = "", string col = "", string condition = "", string value = "")
        {
            try
            {
                Query query = new Query(table, col, condition, value);
                Database showspecific = new SQLDBHelper(query.select());
                DataTable dt = new DataTable();
                showspecific.ExecReader(dgv1, dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void FindButtonByUID_Click(object sender, EventArgs e)
        {
            this.cmd = 3;
            this.AccTypeComboBox.SelectedIndex = 0;
            this.DatePickerComboBox.Value = DateTime.Now;
            Query qry = new Query("account", "COUNT(*)", $"WHERE acc_uid = '{FindByUIDInsert.Text}'");
            Database db = new SQLDBHelper(qry.select());
            if (Convert.ToInt32(db.GetValue()) == 1)
            {
                ShowSpecific("account a, type t", "a.acc_uid as \"UID Akun\", a.acc_platf as \"Platform\", a.acc_uname as \"Username\", a.acc_pword as \"Password\", a.acc_email as \"Email\", a.acc_phone as \"No. Telp\", a.acc_desc as \"Deskripsi\", t.type_name as \"Tipe Akun\", a.insert_date as \"Tgl. Input\", a.update_date as \"Tgl. Ubah\"", $"WHERE a.acc_type_id = t.type_id and a.acc_uid = '{FindByUIDInsert.Text}'");
            }
            else
            {
                MessageBox.Show("Data Tidak Ditemukan");
            }

        }

        private void AccTypeComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            this.acctypeselectedcbox = AccTypeComboBox.SelectedIndex;
        }

        private void DatePickerComboBox_ValueChanged_1(object sender, EventArgs e)
        {
            this.dateinsertselectedcbox = DatePickerComboBox.Value.ToString("yyyy/MM/dd");
            // guna2HtmlLabel2.Text = DatePickerComboBox.Value.ToString("yyyy/MM/dd");

        }

        private void FindButtonByType_Click(object sender, EventArgs e)
        {
            this.cmd = 1;
            this.DatePickerComboBox.Value = DateTime.Now;
            this.FindByUIDInsert.Text = "";
            Query qry = new Query("account", "COUNT(*)", $"WHERE acc_type_id = '{acctypeselectedcbox}'");
            Database db = new SQLDBHelper(qry.select());
            if (Convert.ToInt32(db.GetValue()) > 0)
            {
                ShowSpecific("account a, type t", "a.acc_uid as \"UID Akun\", a.acc_platf as \"Platform\", a.acc_uname as \"Username\", a.acc_pword as \"Password\", a.acc_email as \"Email\", a.acc_phone as \"No. Telp\", a.acc_desc as \"Deskripsi\", t.type_name as \"Tipe Akun\", a.insert_date as \"Tgl. Input\", a.update_date as \"Tgl. Ubah\"", $"WHERE a.acc_type_id = t.type_id and a.acc_type_id = {acctypeselectedcbox}");
            }
            else
            {
                MessageBox.Show("Data Tidak Ditemukan");
            }

        }

        private void FindButtonByDate_Click(object sender, EventArgs e)
        {
            this.cmd = 2;
            this.FindByUIDInsert.Text = "";
            this.AccTypeComboBox.SelectedIndex = 0;
            Query qry = new Query("account", "COUNT(*)", $"WHERE insert_date = '{dateinsertselectedcbox}'");
            Database db = new SQLDBHelper(qry.select());
            if (Convert.ToInt32(db.GetValue()) > 0)
            {
                ShowSpecific("account a, type t", "a.acc_uid as \"UID Akun\", a.acc_platf as \"Platform\", a.acc_uname as \"Username\", a.acc_pword as \"Password\", a.acc_email as \"Email\", a.acc_phone as \"No. Telp\", a.acc_desc as \"Deskripsi\", t.type_name as \"Tipe Akun\", a.insert_date as \"Tgl. Input\", a.update_date as \"Tgl. Ubah\"", $"WHERE a.acc_type_id = t.type_id and a.insert_date = '{dateinsertselectedcbox}'");
            }
            else
            {
                MessageBox.Show("Data Tidak Ditemukan");
            }
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Query qry1 = new Query("account", "COUNT(*)", $"WHERE acc_uid = '{accuidselected}'");
            Database check = new SQLDBHelper(qry1.select());
            bool condition = true;
            if (Convert.ToInt32(check.GetValue()) > 0)
            {
                if (MessageBox.Show("Yakin Ingin Menghapus?", "Penghapusan", MessageBoxButtons.YesNo, MessageBoxIcon.Question, condition ? MessageBoxDefaultButton.Button2 : MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    Query qry = new Query("account", " ", $"WHERE acc_uid = '{accuidselected}'");
                    Database del = new SQLDBHelper(qry.delete());
                    del.ExecQuery();
                    Refresh(cmd);
                }
                else
                {
                    MessageBox.Show("Tidak Jadi Dihapus");
                }

            }
            else
            {
                MessageBox.Show("Tidak Ada Data Yang Pilih");
            }

        }
        private void Refresh(int cmd)
        {
            if (cmd == 1)
            {
                ShowSpecific("account a, type t", "a.acc_uid as \"UID Akun\", a.acc_platf as \"Platform\", a.acc_uname as \"Username\", a.acc_pword as \"Password\", a.acc_email as \"Email\", a.acc_phone as \"No. Telp\", a.acc_desc as \"Deskripsi\", t.type_name as \"Tipe Akun\", a.insert_date as \"Tgl. Input\", a.update_date as \"Tgl. Ubah\"", $"WHERE a.acc_type_id = t.type_id and a.acc_type_id = {acctypeselected}");
            }
            else if (cmd == 2)
            {
                ShowSpecific("account a, type t", "a.acc_uid as \"UID Akun\", a.acc_platf as \"Platform\", a.acc_uname as \"Username\", a.acc_pword as \"Password\", a.acc_email as \"Email\", a.acc_phone as \"No. Telp\", a.acc_desc as \"Deskripsi\", t.type_name as \"Tipe Akun\", a.insert_date as \"Tgl. Input\", a.update_date as \"Tgl. Ubah\"", $"WHERE a.acc_type_id = t.type_id and a.insert_date = '{dateinsertselectedcbox}'");
            }
            else if (cmd == 3)
            {
                ShowSpecific("account a, type t", "a.acc_uid as \"UID Akun\", a.acc_platf as \"Platform\", a.acc_uname as \"Username\", a.acc_pword as \"Password\", a.acc_email as \"Email\", a.acc_phone as \"No. Telp\", a.acc_desc as \"Deskripsi\", t.type_name as \"Tipe Akun\", a.insert_date as \"Tgl. Input\", a.update_date as \"Tgl. Ubah\"", $"WHERE a.acc_type_id = t.type_id and a.acc_uid = '{accuidselected}'");
            }
            else
            {
                ShowAll();
            }
        }
        private void CallDataPage(int status = 0, int callfrom = 0)
        {
            accuidpasstodatapage = accuidselected;
            accunamepasstodatapage = accunameselected;
            accupasspasstodatapage = accupassselected;
            accemailpasstodatapage = accemailselected;
            accphonepasstodatapage = accphoneselected;
            accdescpasstodatapage = accdescselected;
            accplatfpasstodatapage = accplatfselected;
            acctypepasstodatapage = acctypeselectedindexbyrow;
            accdateupdatepasstodatapage = dateupdateselected;
            DateTime dt = DateTime.Now;
            string thedatenow = dt.ToString("yyyy/MM/dd");
            accdateinsertpasstodatapage = thedatenow;
            DataPage dp = new DataPage(status, callfrom);
            this.Hide();
            dp.Show();
        }

        private void MenuAccButton_Click(object sender, EventArgs e)
        {
            CallDataPage(1, 1);
        }

        private void AddNewDataButton_Click(object sender, EventArgs e)
        {
            this.accuidselected = GenerateUID();
            this.accunameselected = "";
            this.accupassselected = "";
            this.accemailselected = "";
            this.accphoneselected = "";
            this.accdescselected = "";
            this.accphoneselected = "";
            this.acctypeselectedindexbyrow = 0;
            this.accdateselected = "";
            CallDataPage(1, 1);
        }
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Query qry1 = new Query("account", "COUNT(*)", $"WHERE acc_uid = '{accuidselected}'");
            Database check = new SQLDBHelper(qry1.select());
            if (Convert.ToInt32(check.GetValue()) > 0)
            {
                CallDataPage(2, 2);
            }
            else
            {
                MessageBox.Show("Tidak Ada Data Yang Pilih");
            }
        }
        private void ViewDetail_Click(object sender, EventArgs e)
        {
            Query qry1 = new Query("account", "COUNT(*)", $"WHERE acc_uid = '{accuidselected}'");
            Database check = new SQLDBHelper(qry1.select());
            if (Convert.ToInt32(check.GetValue()) > 0)
            {
                CallDataPage(3, 3);
            }
            else
            {
                MessageBox.Show("Tidak Ada Data Yang Pilih");
            }
        }

        private void ShowPage_Load(object sender, EventArgs e)
        {
            UserGreet.Text = "Selamat Datang: " + AuthPage.usernameforshowpage;
        }

        private void MenuHomeButton_Click_1(object sender, EventArgs e)
        {
            AuthPage ap = new AuthPage();
            this.Close();
            ap.Show();
        }

        private void MenuNoteButton_Click(object sender, EventArgs e)
        {
            NotesPage ap = new NotesPage();
            ap.Show();
        }
    }
}
