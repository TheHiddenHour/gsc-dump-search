﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace gsc_dump_search {
    public partial class MainForm : Form {
        private Config configuration;

        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            try { // Try to load config.json 
                string _config = File.ReadAllText("config.json"); // Read config text 
                configuration = JsonConvert.DeserializeObject<Config>(_config); // Deserialize config text 
            }
            catch(Exception) { // Failed to load config.json
                Config _config = new Config("gsc-dump"); // Create new config 
                string _serializedConfig = JsonConvert.SerializeObject(_config, Formatting.Indented); // Serialize config 
                File.WriteAllText("config.json", _serializedConfig); // Write config to file 
                configuration = _config;
            }
        }

        private void SearchButton_Click(object sender, EventArgs e) {
            if(string.IsNullOrWhiteSpace(searchTextBox.Text)) { // Check for blank search text 
                MessageBox.Show("Search text field is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }

            resultDataGrid.Rows.Clear(); // Clear previous search results 

            // Parse every file in the dump dir 
            List<DataGridViewRow> rows = new List<DataGridViewRow>();

            IEnumerable<string> dumpFiles = Directory.EnumerateFiles(configuration.dump_path, "*.gsc", SearchOption.AllDirectories); // Get all files recursively 
            foreach(string path in dumpFiles) { // Iterate over each file 
                string[] fileContents = File.ReadAllLines(path); // Read contents of file 
                for(int line_index = 0; line_index < fileContents.Length; line_index++) { // Iterate each line of contents 
                    string line = fileContents[line_index]; // Current line being iterated over 
                    if(line.Contains(searchTextBox.Text)) {
                        // Create row and populate information 
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(resultDataGrid);
                        row.Cells[0].Value = line.Trim(); // Result text 
                        row.Cells[1].Value = path; // Result path 
                        row.Cells[2].Value = line_index; // Result line 

                        rows.Add(row); // Add row to rows array 
                    }
                }
            }

            if(rows.Count < 1) { // If no search results were found 
                MessageBox.Show("No search results found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                resultDataGrid.Rows.Clear();
                return;
            }

            resultDataGrid.Rows.AddRange(rows.ToArray()); // Add results to data grid 
        }

        private void ResultDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if(e.ColumnIndex != 1 || e.RowIndex < 0) {
                return;
            }

            string resultPath = resultDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            int resultLine = (int)resultDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value;
            string scriptContents = File.ReadAllText(resultPath);

            GSCPeekForm peekForm = new GSCPeekForm(scriptContents, resultLine, resultPath);
            peekForm.Show();
        }
    }
}
