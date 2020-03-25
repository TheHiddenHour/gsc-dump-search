using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
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
            if(!Directory.Exists(configuration.DumpPath)) { // Check for dump directory 
                MessageBox.Show("Dump directory does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }

            if(string.IsNullOrWhiteSpace(searchTextBox.Text)) { // Check for blank search text 
                MessageBox.Show("Search text field is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }

            // Parse every file in the dump dir 
            List<DataGridViewRow> rows = new List<DataGridViewRow>();
            StringComparison searchCulture = (caseInsensitiveCheckBox.Checked) ? StringComparison.CurrentCultureIgnoreCase : StringComparison.CurrentCulture;
            string[] dumpFiles = Directory.GetFiles(configuration.DumpPath, "*.gsc", SearchOption.AllDirectories); // Get all files recursively 

            searchProgressBar.Maximum = dumpFiles.Length;

            foreach(string path in dumpFiles) { // Iterate over each file 
                string[] fileContents = File.ReadAllLines(path); // Read contents of file 

                for(int line_index = 0; line_index < fileContents.Length; line_index++) { // Iterate each line of contents 
                    string line = fileContents[line_index]; // Current line being iterated over 

                    if(StringExtensions.Contains(ref line, searchTextBox.Text, searchCulture)) {
                        // Create row and populate information 
                        DataGridViewRow row = new DataGridViewRow();

                        row.CreateCells(resultDataGrid);
                        row.Cells[0].Value = line.Trim(); // Result text 
                        row.Cells[1].Value = path; // Result path 
                        row.Cells[2].Value = line_index; // Result line 

                        rows.Add(row); // Add row to rows array 
                    }
                }

                searchProgressBar.Value++;
            }

            resultDataGrid.Rows.Clear(); // Clear previous search results 
            searchProgressBar.Value = 0; // Reset progress bar 

            if(rows.Count < 1) { // If no search results were found 
                MessageBox.Show("No search results found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
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

        private void ChangeDumpDirToolStripMenuItem_Click(object sender, EventArgs e) {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if(dialog.ShowDialog() == DialogResult.OK) {
                configuration.DumpPath = dialog.SelectedPath;
                string _config = JsonConvert.SerializeObject(configuration, Formatting.Indented);

                File.WriteAllText("config.json", _config);
                MessageBox.Show("Dump directory changed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            dialog.Dispose();
        }

        private void ExportResulsToolStripMenuItem_Click(object sender, EventArgs e) {
            if(resultDataGrid.Rows.Count < 1) {
                MessageBox.Show("No results to dump", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }

            try {
                searchProgressBar.Maximum = resultDataGrid.RowCount; // Set progress bar max value 

                // Create CSV writer stream 
                using(StreamWriter writer = new StreamWriter("export.csv"))
                using(CsvWriter csv = new CsvWriter(writer, CultureInfo.InvariantCulture)) {
                    // Get header text 
                    int headerCount = resultDataGrid.Columns.Count;
                    int rowCount = resultDataGrid.RowCount;

                    // Write header fields to CSV stream 
                    for(int i = 0; i < headerCount; i++) {
                        csv.WriteField(resultDataGrid.Columns[i].HeaderText);
                    }
                    csv.NextRecord(); // End header record 

                    foreach(DataGridViewRow row in resultDataGrid.Rows) { // Iterate over each row in results 
                        int cellCount = row.Cells.Count; // Get amount of cells in current row 
                        object[] rowValues = new object[cellCount]; // Get values of cells in current row 

                        for(int cellIndex = 0; cellIndex < cellCount; cellIndex++) {
                            rowValues[cellIndex] = row.Cells[cellIndex].Value;
                        }

                        // Create record from row 
                        SearchResult record = new SearchResult() {
                            Text = (string)rowValues[0],
                            Path = (string)rowValues[1],
                            Line = (int)rowValues[2]
                        };

                        csv.WriteRecord(record); // Write record to CSV stream 
                        csv.NextRecord();

                        searchProgressBar.Value++;
                    }
                }

                searchProgressBar.Value = 0;

                MessageBox.Show("Results saved to export.csv", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            catch(Exception ex) {
                MessageBox.Show("There was an error exporting results.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }
        }
    }
}
