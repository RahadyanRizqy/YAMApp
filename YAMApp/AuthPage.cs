using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SQLite;

namespace YAMApp
{
    public partial class AuthPage : Form
    {
        private int user_id;
        private int user_exist_status;
        private int check_user_exist;
        private bool auth;
        public string username;
        public static string usernameforshowpage = "";
        public AuthPage()
        {
            InitializeComponent();
            CheckExisting();
            if (check_user_exist == 1)
            {
                AuthButton.Text = "Login";
                this.auth = true;
            }
            else
            {
                AuthButton.Text = "Register";
                this.auth = false;
            }
        }

        private void Welcome_Click(object sender, EventArgs e) { }

        private void RegistButton_Click(object sender, EventArgs e)
        {
            Authenticate();
            Query qry = new Query("user", "(user_id, user_name, user_pin)", "", $"((SELECT COUNT(*) FROM user)+1, '{UNameInsert.Text}', {Convert.ToInt32(UPINInsert.Text)})");
            this.username = UNameInsert.Text;
            Database adduser = new SQLDBHelper(qry.insert());
            adduser.ExecQuery();
            MessageBox.Show("User Baru Data Berhasil Dimasukkan");
            MessageBox.Show("Silahkan Mulai Menggunakan YAMApp!");
            CallShowPage();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Authenticate();
            if (user_exist_status == 1)
            {
                MessageBox.Show($"User dengan ID {Convert.ToString(user_id)} Ditemukan Silahkan Masuk");
                this.username = UNameInsert.Text;
                CallShowPage();
            }
            else
            {
                MessageBox.Show("User Tidak Ditemukan Silahkan Register");
            }
        }

        private void UNameInsert_TextChanged(object sender, EventArgs e) { }

        private void UPINInsert_TextChanged(object sender, EventArgs e) { }
        private void Authenticate()
        {
            Database verif = new SQLDBHelper($"SELECT EXISTS (SELECT user_id FROM user WHERE user_name = '{UNameInsert.Text}' and user_pin = '{UPINInsert.Text}') as found;");
            Query qry = new Query("user", "user_id", $"WHERE user_name = '{UNameInsert.Text}' and user_pin = {Convert.ToInt32(UPINInsert.Text)};");
            Database userid = new SQLDBHelper(qry.select());
            this.user_exist_status = Convert.ToInt32(verif.GetValue());
            if (user_exist_status == 1)
            {
                this.user_id = Convert.ToInt32(userid.GetValue());
            }
            else
            {
                this.user_id = 0;
            }
                
        }
        private void CheckExisting()
        {
            Query qry = new Query("user", "COUNT(*)");
            Database checkexist = new SQLDBHelper(qry.select());
            if (Convert.ToInt32(checkexist.GetValue()) == 1)
            {
                this.check_user_exist = 1;
            }
            else
            {
                this.check_user_exist = 0;
            }
        }
        public int GetUserID()
        {
            return user_id;
        }

        private void MinButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseButtton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e) { }
        private void AuthButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (auth == true)
                {
                    LoginButton_Click(sender, e);
                }
                else
                {
                    RegistButton_Click(sender, e);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Isi dengan benar!");
            }

        }
        private void CallShowPage(int user_id = 0)
        {
            usernameforshowpage = username;
            ShowPage sp = new ShowPage(user_id);
            this.Hide();
            sp.Show();
        }
    }
}
