using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductWinApp
{
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }
        private string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            var strConnection = config["ConnectionStrings:MyStoreDB"];
            return strConnection;
        }
        DataSet dsMyStore = new DataSet();
        private void frmProduct_Load(object sender, EventArgs e)
        {
            DbProviderFactory factory = SqlClientFactory.Instance;
            using DbConnection connection = factory.CreateConnection();
            if (connection == null)
            {
                Console.WriteLine($"Unable to create the connection object");
                return;
            }
            connection.ConnectionString = GetConnectionString();
            connection.Open();
            string sql = "select ProductID, ProductName, CategoryID, Price, DateCreated from Products; select * from Categories";
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sql, GetConnectionString());
                adapter.Fill(dsMyStore);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Data From Database");
            }
        }

        private void btnViewProduct_Click(object sender, EventArgs e)
        {
            dgvData.DataSource = dsMyStore.Tables[0];
        }

        private void btnViewCatagories_Click(object sender, EventArgs e)
        {
            dgvData.DataSource = dsMyStore.Tables[1];
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();
    }
}
