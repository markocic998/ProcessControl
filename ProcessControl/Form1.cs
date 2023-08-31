using Opc.UaFx.Client;

namespace ProcessControl
{
    public partial class Form1 : Form
    {
        private OpcClient client;

        public Form1()
        {
            InitializeComponent();
            ConnectToOPCServer();
        }

        private void ConnectToOPCServer()
        {
            try
            {
                string endpoint = "opc.tcp://desktop-n88p201:62640/IntegrationObjects/ServerSimulator";
                this.client = new OpcClient(endpoint);
                this.client.Connect();
            }
            catch (Exception e)
            {
                MessageBox.Show("Can not connect to the OPC server:\n" + e.ToString());
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.client.Disconnect();
        }
    }
}