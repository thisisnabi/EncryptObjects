using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System.Threading;

namespace EncryptObjects
{
    public partial class FrmHome : Form
    {
        CancellationTokenSource? tokenSource;

        public FrmHome()
        {
            InitializeComponent();
        }



        private void FrmHome_Load(object sender, EventArgs e)
        {
           
        }

     



        public Task StartAction(Database database, bool encrypt,CancellationToken cancellationToken) 
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
            
            if (cancellationToken.IsCancellationRequested)
            { RtextLog("Task Canceled"); BtnStatus(true);   return Task.CompletedTask; }
         
            if (chkViews.Checked)
            {
                for (int index = 0; index < viewCount; index++)
                {
                    if (cancellationToken.IsCancellationRequested)
                    { RtextLog("Task Canceled"); BtnStatus(true); return Task.CompletedTask; }
                    currentCount++;
                    UpdateUI(totalCount, currentCount);
                    var vi = database.Views[index];

                    RtextLog($"\nstart {(encrypt ? "encrypt" : "decrypt")} [view] {vi.Name} - ");

                    try
                    {
                        if (!vi.IsEncrypted)
                        {    
                             vi.TextMode = false;
                             vi.IsEncrypted = encrypt;
                             vi.TextMode = true;
                             vi.Alter();
                        }
                        RtextLog($"done");
                    }
                    catch (Exception)
                    {
                        RtextLog($"error");
                    }
                }
            }

            if (chkProcedures.Checked)
            {
                for (int i = 0; i < spCount; i++)
                {
                    if (cancellationToken.IsCancellationRequested)
                    { RtextLog("Task Canceled"); BtnStatus(true); return Task.CompletedTask; }
                    currentCount++;
                    UpdateUI(totalCount, currentCount);
                    var sp = database.StoredProcedures[i];

                    RtextLog($"\nstart {(encrypt ? "encrypt" : "decrypt")} [sp] {sp.Name} - ");
                     
                    try
                    {
                        if (sp.IsEncrypted)
                        {
                             sp.TextMode = false;
                             sp.IsEncrypted = encrypt;
                             sp.TextMode = true;
                             sp.Alter();
                        }

                        RtextLog($"done");
                    }
                    catch (Exception)
                    {
                        RtextLog($"error");
                    }
                }
            }

            if (chkFunctions.Checked)
            {
                for (int i = 0; i < fcCount; i++)
                {
                    if (cancellationToken.IsCancellationRequested)
                    { RtextLog("Task Canceled"); BtnStatus(true); return Task.CompletedTask; }
                    currentCount++;
                    UpdateUI(totalCount, currentCount);
                    var func = database.StoredProcedures[i];

                    RtextLog($"\nstart {(encrypt ? "encrypt" : "decrypt")} [func] {func.Name} - ");
                     
                    try
                    {
                        if (func.IsEncrypted)
                        {
                            func.TextMode = false;
                            func.IsEncrypted = encrypt;
                            func.TextMode = true;
                            func.Alter();
                        }

                        RtextLog($"done");
                    }
                    catch (Exception)
                    {
                        RtextLog($"error");
                    }
                }
            }
            
            BtnStatus(true);
            RtextLog("Task Completed");
            return Task.CompletedTask;
        }
         
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            BtnStatus(false);
            TakeTokenSource();
            StartLogging("Task Encryption Started");
             
            if (TryGetDatabase(out Database? database) && database != null)
            {
                Task.Run(() => StartAction(database, true, tokenSource.Token));
 
            }
            else
            {
                MessageBox.Show("Connection failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            BtnStatus(false);
            TakeTokenSource();
            StartLogging("Task Decryption Started");
            if (TryGetDatabase(out Database? database) && database != null)
            {
                Task.Run(() => StartAction(database, false, tokenSource.Token));
            }
            else
            {
                MessageBox.Show("Connection failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tokenSource.Cancel();
            BtnStatus(true);
        }

        #region Helpers
        private void TakeTokenSource()
        {
            tokenSource = new CancellationTokenSource();
        }


        private void BtnStatus(bool status)
        {
            Invoke(new Action(() => {
                btnEncrypt.Enabled = status;
                btnDecrypt.Enabled = status;
                btnCheckConnecition.Enabled = status;
                btnCancel.Enabled = !status;
                tspProgressBar.Value = 0;
            }));
        }

        private void UpdateUI(int total, int current)
        {
            var progressValue = (100 / (double)total) * current;

            Invoke(new Action(() => {
                tspProgressBar.Value = Convert.ToInt32(progressValue);
            }));
        }

        private void RtextLog(string Description)
        {
            Invoke(new Action(() => {
                rtxtLog.AppendText($"{Description}");
                rtxtLog.Select(rtxtLog.TextLength + 1, 0);
       
            }));
        }
        private void StartLogging(string desc)
        {
            rtxtLog.AppendText($"{desc}------");
            rtxtLog.AppendText($"\nat {DateTime.Now.ToString()}------");
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

            btnEncrypt.Enabled = false;
            btnDecrypt.Enabled = false;

            if (TryGetDatabase(out _))
            {
                MessageBox.Show("Connected successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Connection failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            btnEncrypt.Enabled = true;
            btnDecrypt.Enabled = true;
        }

        #endregion


    }
}