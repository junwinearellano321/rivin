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
    public partial class Queue : Form
    {
        private Queue<string> queue = new Queue<string>();  // Queue to hold names as strings
        private string filePath = "queueData.txt";  // File path to save the queue data
        public Queue()
        {
            InitializeComponent();
            InitializeDataGridView(); // Initialize DataGridView on load
        }

        // Initialize DataGridView with one column for the names
        private void InitializeDataGridView()
        {
            dgvQueue.Columns.Clear(); // Clear existing columns
            dgvQueue.Columns.Add("Name", "Name"); // Add column for the name
        }

        private void QueueForm_Load(object sender, EventArgs e)
        {
            // Optionally, auto-load queue data when the form starts
            LoadQueueFromFile();  // Load queue from file
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string inputName = textBox1.Text;  // Get name from the TextBox

            if (!string.IsNullOrEmpty(inputName))
            {
                queue.Enqueue(inputName);  // Enqueue the name
                UpdateQueueGrid();     // Update the DataGridView
                textBox1.Clear();  // Clear the text box

                SaveQueueToFile();  // Save the updated queue to the file
            }
            else
            {
                MessageBox.Show("Please enter a name!");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (queue.Count > 0)
            {
                string dequeuedItem = queue.Dequeue();  // Dequeue the first item
                MessageBox.Show("Dequeued: " + dequeuedItem);  // Show the dequeued item
                UpdateQueueGrid();  // Update the DataGridView

                SaveQueueToFile();  // Save the updated queue to the file
            }
            else
            {
                MessageBox.Show("Queue is empty!");
            }
        }

        private void Queue_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            Form1 hooo = new Form1();
            hooo.Show();
        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            if (queue.Count > 0)
            {
                string peekedItem = queue.Peek();  // Peek at the first item
                MessageBox.Show("Peeked: " + peekedItem);  // Show the peeked item
            }
            else
            {
                MessageBox.Show("Queue is empty!");
            }
        }

        private void UpdateQueueGrid()
        {
            dgvQueue.Rows.Clear(); // Clear the current grid data
            foreach (var item in queue)
            {
                dgvQueue.Rows.Add(item);  // Add each item in the queue to the DataGridView
            }
        }

        // Save the Queue to a File
        private void SaveQueueToFile()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (var item in queue)
                    {
                        writer.WriteLine(item);  // Save each name in the queue to the file
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving queue to file: " + ex.Message);
            }
        }

        // Load the Queue from a File
        private void LoadQueueFromFile()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    // Clear the existing queue and DataGridView before loading new data
                    queue.Clear();
                    dgvQueue.Rows.Clear();

                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            queue.Enqueue(line);  // Enqueue each line (name) from the file
                        }
                    }

                    UpdateQueueGrid();  // Update the grid with the loaded data
                }
                else
                {
                    MessageBox.Show("No saved queue found, starting with an empty queue.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading queue from file: " + ex.Message);
            }
        }

    }
}
