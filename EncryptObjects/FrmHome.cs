using Microsoft.SqlServer.Management.Smo;

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

        public void SMO() {

               //Connect to the local, default instance of SQL Server.   
                Server srv;
                srv = new Server();
                //Define a Database object variable by supplying the parent server and the database name arguments in the constructor.   
                Database db;
                db = new Database(srv, "Test_SMO_Database");
                //Call the Create method to create the database on the instance of SQL Server.   
                db.Create();


            var sp = db.StoredProcedures[0];
            sp.IsEncrypted = true;

            sp.Alter();


            var views = db.Views[1];
            views.IsEncrypted= true;
            views.Alter();

        }

    }
}