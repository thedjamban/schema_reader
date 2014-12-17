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
    public partial class FrmPilihDatabase : Form
    {
        private LibraryFramework.DatabaseSqlServer.Koneksi koneksiSqlServer;
        private LibraryFramework.DatabaseMySql.Koneksi koneksiMySql;
        private DataDatabaseSqlServer dataDatabaseSqlServer;
        private DataDatabaseMySql dataDatabaseMySql;
        private IListener il;

        public FrmPilihDatabase(IListener il)
        {
            InitializeComponent();
            this.il = il;
            cmbJenisDatabase.SelectedIndex = 0;
        }

        private void btnSambungkan_Click(object sender, EventArgs e)
        {
            if(!CommonFunction.validasi(cmbJenisDatabase, txtServer, txtUsername, txtPassword))
            {
                return;
            }

            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string server = txtServer.Text;
            if (cmbJenisDatabase.Text == "SQLSERVER")
            {
                koneksiSqlServer = new LibraryFramework.DatabaseSqlServer.Koneksi(username, password, server, "master");
                if (!koneksiSqlServer.Login())
                {
                    return;
                }

                dataDatabaseSqlServer = new DataDatabaseSqlServer(koneksiSqlServer.Con);
                CommonFunction.setCombo(cmbDatabase, dataDatabaseSqlServer.getDatabase(), "database_name", "database_name", 0, 0);
            }
            else
            {
                koneksiMySql = new LibraryFramework.DatabaseMySql.Koneksi(username, password, server, "test");
                if (!koneksiMySql.Login())
                {
                    return;
                }

                dataDatabaseMySql = new DataDatabaseMySql(koneksiMySql.Con);
                CommonFunction.setCombo(cmbDatabase, dataDatabaseMySql.getDatabase(), "database", "database", 0, 0);
            }
            cmbJenisDatabase.Enabled = false;
            txtServer.Enabled = false;
            txtUsername.Enabled = false;
            txtPassword.Enabled = false;
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (cmbDatabase.SelectedIndex == 0)
            {
                MessageBox.Show("Pilih database!!");
                return;
            }

            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string server = txtServer.Text;
            FrmMain.jenisDatabase = cmbJenisDatabase.Text;
            if (cmbJenisDatabase.Text == "SQLSERVER")
            {
                koneksiSqlServer = new LibraryFramework.DatabaseSqlServer.Koneksi(username, password, server, cmbDatabase.Text);
                dataDatabaseSqlServer = new DataDatabaseSqlServer(koneksiSqlServer.Con);
                il.refreshSqlServer(dataDatabaseSqlServer.getTableName(), koneksiSqlServer);
            }
            else
            {
                koneksiMySql = new LibraryFramework.DatabaseMySql.Koneksi(username, password, server, cmbDatabase.Text);
                dataDatabaseMySql = new DataDatabaseMySql(koneksiMySql.Con);
                il.refreshMySql(dataDatabaseMySql.getTableName(cmbDatabase.Text), koneksiMySql, cmbDatabase.Text);
            }
            Close();
        }
    }
}

