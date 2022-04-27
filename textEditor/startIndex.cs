

namespace textEditor
{
    public partial class startIndex : Form
    {
        public startIndex()
        {
            InitializeComponent();
        }
        //When confirm is clicked, check if user typed in valid input
        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            IsValid();
        }
        //When enter is pressed, check if user typed in valid input
        private void userInput_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                IsValid();
            }
            //If escape is pressed, close the form
            else if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        //Checks for valid input
        private void IsValid()
        {
            int num;
            //If there is no input, default to 1
            if (string.IsNullOrEmpty(userInput.Text))
            {
                this.ReturnValue1 = 1;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            //Check to see if an integer is typed in
            else if(!int.TryParse(userInput.Text, out num))
            {
                userInput.Text = "Invalid!";
                userInput.Focus();
            }
            //Integer is given, return the value
            else
            {
                this.ReturnValue1 = num;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        public int ReturnValue1 { get; set; }
    }
}
