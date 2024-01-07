namespace carManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddNewCustomerForm addNewCustomerForm = new AddNewCustomerForm();
            addNewCustomerForm.ShowDialog();
        }



        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {


            // Yeni formu oluþturun ve gösterin
            DeleteCustomerForm deleteCustomerForm = new DeleteCustomerForm();
            deleteCustomerForm.ShowDialog();


        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            UpdateCustomerForm updateCustomerForm = new UpdateCustomerForm();
            updateCustomerForm.ShowDialog();
        }

        private void btnViewCustomer_Click(object sender, EventArgs e)
        {
            ViewCustomerInfoForm viewCustomerInfoForm = new ViewCustomerInfoForm();
            viewCustomerInfoForm.ShowDialog();
        }

        private void btnFindCustomerID_Click(object sender, EventArgs e)
        {
            FindCustomerIDForm findCustomerIDForm = new FindCustomerIDForm();
            findCustomerIDForm.ShowDialog();
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            AddCarForm addCarForm = new AddCarForm();
            addCarForm.ShowDialog();
        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            DeleteCarForm deleteCarForm = new DeleteCarForm();
            deleteCarForm.ShowDialog();
        }

        private void btnViewCar_Click(object sender, EventArgs e)
        {
            ViewCarForm viewCarForm = new ViewCarForm();
            viewCarForm.ShowDialog();
        }

        private void btnFindCarID_Click(object sender, EventArgs e)
        {
            FindCarID findCarID = new FindCarID();
            findCarID.ShowDialog();
        }

        private void btnAddSale_Click(object sender, EventArgs e)
        {
            AddSaleForm addSaleForm = new AddSaleForm();
            addSaleForm.ShowDialog();
        }

        private void btnViewSales_Click(object sender, EventArgs e)
        {
            ViewSalesForm viewSalesForm = new ViewSalesForm();
            viewSalesForm.ShowDialog();
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            AddServiceForm addServiceForm = new AddServiceForm();
            addServiceForm.ShowDialog();
        }

        private void btnViewService_Click(object sender, EventArgs e)
        {
            ViewServiceForm viewServiceForm = new ViewServiceForm();    
            viewServiceForm.ShowDialog();
        }
    }
}
