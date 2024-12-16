using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL_STACK_AND_QUEUES
{
    public partial class Stack : Form
    {
        private Stack<string[]> stack = new Stack<string[]>(); // Stack to hold first and last names as string arrays
        private string filePath = "stackData.txt";  // Default file path to save the stack data
        public Stack()
        {
            InitializeComponent();
            InitializeDataGridView(); // Initialize DataGridView on load
        }

        private void InitializeDataGridView()
        {
            dgvQueue.Columns.Clear(); // Clear existing columns
            dgvQueue.Columns.Add("FirstName", "First Name");
            dgvQueue.Columns.Add("LastName", "Last Name");
        }
        // private void Stack_Load(object sender, EventArgs e)
        // {
        //     LoadStackFromFile();  // Automatically load stack data when form loads
        // }

        private void Stack_Load(object sender, EventArgs e)
        {
            LoadStackFromFile();  // Automatically load stack data when form loads
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnQue_Click(object sender, EventArgs e)
        {
            string firstName = txtFname.Text;  // Assuming txtFirstName is your first name TextBox
            string lastName = txtLname.Text;    // Assuming txtLastName is your last name TextBox

            if (!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName))
            {
                stack.Push(new string[] { firstName, lastName });  // Push both names as a string array
                UpdateStackGrid();     // Update the Stack DataGridView
                txtFname.Clear();  // Clear the textboxes
                txtLname.Clear();

                SaveStackToFile();  // Automatically save the stack after a push operation
            }
            else
            {
                MessageBox.Show("Please enter both first name and last name!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (stack.Count > 0)
            {
                // Peek the top item from the stack
                string[] item = stack.Peek();
                MessageBox.Show("Peeked: " + item[0] + " " + item[1]); // Display first and last name of top item
            }
            else
            {
                MessageBox.Show("Stack is empty!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] item = stack.Count > 0 ? stack.Pop() : null;
            if (item != null)
            {
                MessageBox.Show("Popped: " + item[0] + " " + item[1]); // Display first and last name
                UpdateStackGrid(); // Update the Stack DataGridView

                SaveStackToFile();  // Automatically save the stack after a pop operation
            }
            else
            {
                MessageBox.Show("Stack is empty!");
            }
        }

        // Update Stack DataGridView
        private void UpdateStackGrid()
        {
            dgvQueue.Rows.Clear(); // Clear the current grid data
            foreach (var item in stack)
            {
                dgvQueue.Rows.Add(item[0], item[1]); // Add first and last names to the DataGridView
            }
        }

        private void SaveStackToFile()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (var item in stack)
                    {
                        writer.WriteLine($"{item[0]} {item[1]}");  // Save the first name and last name
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving stack to file: " + ex.Message);
            }
        }

        // Load the Stack from a File
        private void LoadStackFromFile()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    // Clear the existing stack and DataGridView before loading new data
                    stack.Clear();
                    dgvQueue.Rows.Clear();

                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] nameParts = line.Split(' ');  // Assuming space separates the first and last name
                            if (nameParts.Length == 2)  // Make sure there are exactly two parts (first and last name)
                            {
                                stack.Push(new string[] { nameParts[0], nameParts[1] });
                            }
                        }
                    }

                    UpdateStackGrid();  // Update the grid with the loaded data
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading stack from file: " + ex.Message);
            }
        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvQueue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 h = new Form1();
            h.Show();
        }

        private void Stack_Load_1(object sender, EventArgs e)
        {

        }

        private void dgvQueue_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
