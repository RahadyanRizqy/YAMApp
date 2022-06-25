using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace YAMApp
{
    public interface Select { public string select(); }
    public interface Insert { public string insert(); }
    public interface Delete { public string delete(); }
    public interface Update { public string update(); }
    public class Query : Select, Insert, Delete, Update
    {
        public string table;
        public string col;
        public string condition;
        public string value;
        public Query(string table="", string col="", string condition="", string value = "") { this.table = table; this.col = col; this.condition = condition; this.value = value; }
        public string select() { return $"SELECT {col} FROM {table} {condition}"; }
        public string insert() { return $"INSERT INTO {table} {col} VALUES {value}"; }
        public string delete() { return $"DELETE FROM {table} {condition}"; }
        public string update() { return $"UPDATE {table} SET {col} {condition}"; }
    }
    public abstract class Database
    {
        public SQLiteConnection conn;
        public string query;
        string dbname = "yamdb.sqlite3";
        public Database(string query)
        {
            conn = new SQLiteConnection($"Data Source={dbname}");
            if (!File.Exists($"./{dbname}"))
            {
                SQLiteConnection.CreateFile($"{dbname}");
                MakeDb();
            }
            this.query = query;
        }
        public abstract void ExecQuery();
        public abstract void ExecReader(DataGridView dgv, DataTable dt);
        public abstract string GetValue(int col = 0);
        private void MakeDb()
        {
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(conn);
            cmd.CommandText = ("CREATE TABLE IF NOT EXISTS \"user\" (\"user_id\" INTEGER,\"user_name\" TEXT,\"user_pin\" INTEGER, PRIMARY KEY (\"user_id\")); CREATE TABLE IF NOT EXISTS \"type\" (\"type_id\" INTEGER NOT NULL,\"type_name\"	TEXT NOT NULL, PRIMARY KEY(\"type_id\")); CREATE TABLE IF NOT EXISTS \"account\" (\"acc_uid\" TEXT NOT NULL, \"acc_platf\"	TEXT,\"acc_uname\" TEXT NOT NULL, \"acc_pword\" TEXT NOT NULL, \"acc_email\" TEXT NOT NULL, \"acc_phone\"	TEXT, \"acc_desc\" TEXT, \"acc_type_id\" INTEGER NOT NULL, \"acc_user_id\" INTEGER NOT NULL, \"insert_date\"	TEXT NOT NULL, \"update_date\"	TEXT, FOREIGN KEY(\"acc_type_id\") REFERENCES \"type\"(\"type_id\"), FOREIGN KEY(\"acc_user_id\") REFERENCES \"user\"(\"user_id\"),PRIMARY KEY(\"acc_uid\")); INSERT INTO \"type\" (\"type_id\",\"type_name\") VALUES (1,'Akun email'), (2,'Akun akademik'), (3,'Akun media sosial'), (4,'Akun teknikal'), (5,'Akun lainnya');");
            cmd.ExecuteNonQuery();
            conn.Close();
            cmd.Dispose();
        }
    }
    class SQLDBHelper : Database
    {
        public SQLDBHelper(string query) : base(query) { this.query = query; }
        public override void ExecQuery()
        {
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            cmd.Dispose();
        }
        public override void ExecReader(DataGridView dgv, DataTable dt)
        {
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            SQLiteDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            dgv.DataSource = dt;
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                dgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            conn.Close();
            cmd.Dispose();
        }
        public override string GetValue(int col)
        {
            string value = "";
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                try
                {
                    value = reader.GetString(col);
                }
                catch (FormatException)
                {
                    value = Convert.ToString(reader.GetInt32(col));
                }
                catch (InvalidCastException)
                {
                    try
                    {
                        value = Convert.ToString(reader.GetInt32(col));
                    }
                    catch
                    {
                        value = "";
                    }

                }

            }
            conn.Close();
            cmd.Dispose();
            if (value == "")
            {
                return "-";
            }
            else
            {
                return value;
            }

        }
    }
}
