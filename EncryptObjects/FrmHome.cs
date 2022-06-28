using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System.Threading;

namespace EncryptObjects
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }



        private void FrmHome_Load(object sender, EventArgs e)
        {

        }



        private void btnEncrypt_Click(object sender, EventArgs e)
        {

            var smapho = new Semaphore(1, 1);

            if (TryGetDatabase(out Database? database) && database != null)
            {
                var viewCount = database.Views.Count;
                var spCount = database.StoredProcedures.Count;
                var fcCount = database.UserDefinedFunctions.Count;
                var totalCount = 0;
                var currentCount = 0;
                #region Counter
                if (chkViews.Checked)
                {
                    totalCount += viewCount;
                }
                if (chkFunctions.Checked)
                {
                    totalCount += fcCount;
                }
                if (chkProcedures.Checked)
                {
                    totalCount += spCount;
                }
                #endregion

                if (chkViews.Checked)
                { 
                    for (int index = 0; index < viewCount; index++)
                    {
                        currentCount++;

                        var vi = database.Views[index];
                        if (!vi.IsEncrypted)
                        {
                            vi.TextMode = false;
                            vi.IsEncrypted = true;
                            vi.TextMode = true;
                            vi.Alter();
                        }
                    }
                }



                if (chkProcedures.Checked)
                {  
                    for (int i = 0; i < spCount; i++)
                    {
                        currentCount++;

                        var sp = database.StoredProcedures[i];
                        if (sp.IsEncrypted)
                        {
                            sp.TextMode = false;
                            sp.IsEncrypted = true;
                            sp.TextMode = true;
                            sp.Alter();
                        }
                    }
                }
                 
                if (chkFunctions.Checked)
                { 
                    for (int i = 0; i < fcCount; i++)
                    {
                        currentCount++;

                        var func = database.StoredProcedures[i];
 
                        if (func.IsEncrypted)
                        {
                            func.TextMode = false;
                            func.IsEncrypted = true;
                            func.TextMode = true;
                            func.Alter();
                        }
                    }

                }

            }
            else
            {
                MessageBox.Show("Connection failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool TryGetDatabase(out Database? database)
        {
            var sc = new ServerConnection(txtServer.Text.Trim(),
                     txtUsername.Text.Trim(), txtPassword.Text.Trim());

            Server srv = new Server(sc);

            if (srv.Status != ServerStatus.Online)
            {
                database = null;
                return false;
            }

            Database db = srv.Databases[txtDatabase.Text.Trim()];

            if (db == null || !db.IsAccessible)
            {
                database = null;
                return false;
            }

            database = db;
            return true;
        }

        private void btnCheckConnecition_Click(object sender, EventArgs e)
        {

            if (TryGetDatabase(out _))
            {
                MessageBox.Show("Connected successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Connection failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}