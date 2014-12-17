using LibraryFramework.Function;
using SchemaReader.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SchemaReader
{
    public partial class FrmMain : Form, IListener
    {
        private DataDatabaseSqlServer dataDatabaseSqlServer;
        private DataDatabaseMySql dataDatabaseMySql;
        private LibraryFramework.DatabaseSqlServer.Koneksi konSqlServer;
        private LibraryFramework.DatabaseMySql.Koneksi konMySql;
        private GridViewFunction gvfSchema;
        public static string jenisDatabase;
        private string databaseMySql;

        public FrmMain()
        {
            InitializeComponent();
            cmbPilihBahasa.SelectedIndex = 0;
        }

        private void btnPilihDatabase_Click(object sender, EventArgs e)
        {
            using (FrmPilihDatabase fpd = new FrmPilihDatabase(this))
            {
                fpd.ShowDialog();
            }
        }

        private void lstTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (jenisDatabase == "SQLSERVER")
            {
                gvfSchema.setDataGrid(dataDatabaseSqlServer.getTableSchema(lstTable.SelectedItem.ToString()));
            }
            else
            {
                gvfSchema.setDataGrid(dataDatabaseMySql.getTableSchema(databaseMySql,lstTable.SelectedItem.ToString()));
            }
            gvfSchema.setColWidth(150, 80, 100);
        }

        private void btnProperti_Click(object sender, EventArgs e)
        {
            if (lstTable.Items.Count== 0)
            {
                MessageBox.Show("Tidak ada data!!");
                return;
            }

            if (cmbPilihBahasa.SelectedIndex == 0)
            {
                MessageBox.Show("Pilih bahasa pemrograman!!");
                return;
            }

            if (lstTable.Items.Count == 0)
            {
                return;
            }
            string cpy = null;
            List<string> listSchema = new List<string>();
            foreach (DataRow row in ((DataTable)dgvSchema.DataSource).Rows)
            {
                string type = "";
                if (cmbPilihBahasa.Text == "C#")
                {
                    type = TypeConverterCSharp.convert(row["data_type"].ToString());
                }
                else
                {
                    type = TypeConverterJava.convert(row["data_type"].ToString());
                }
                string columnName = row["column_name"].ToString();
                string schema = "";
                if (cmbPilihBahasa.Text == "C#")
                {
                    schema = "public " + type + " " + columnName + "{get;set;}\n";
                }
                else
                {
                    schema = "private " + type + " " + columnName + ";\n";
                }
                listSchema.Add(schema);
            }
            foreach (string str in listSchema)
            {
                cpy += str;
            }
            Clipboard.SetText(cpy);
        }


        public void refreshSqlServer(DataTable dtb, LibraryFramework.DatabaseSqlServer.Koneksi kon)
        {
            lstTable.Items.Clear();
            foreach (DataRow row in dtb.Rows)
            {
                lstTable.Items.Add(row["table_name"].ToString());
            }
            this.konSqlServer = kon;
            dataDatabaseSqlServer = new DataDatabaseSqlServer(kon.Con);
            gvfSchema = new GridViewFunction(dgvSchema);
            lstTable.SelectedIndex = 0;
        }

        public void refreshMySql(DataTable dtb, LibraryFramework.DatabaseMySql.Koneksi con, string databaseMySql)
        {
            lstTable.Items.Clear();
            foreach (DataRow row in dtb.Rows)
            {
                lstTable.Items.Add(row["table_name"].ToString());
            }
            this.konMySql = con;
            dataDatabaseMySql = new DataDatabaseMySql(konMySql.Con);
            gvfSchema = new GridViewFunction(dgvSchema);
            this.databaseMySql = databaseMySql;
            lstTable.SelectedIndex = 0;
        }
    }
}

