namespace gsc_dump_search {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripFileButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveResultsAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropSettingsButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.changeDumpDirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.resultDataGrid = new System.Windows.Forms.DataGridView();
            this.TextColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LineColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchProgressBar = new System.Windows.Forms.ProgressBar();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripFileButton,
            this.toolStripDropSettingsButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripFileButton
            // 
            this.toolStripFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripFileButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.saveResultsAsToolStripMenuItem});
            this.toolStripFileButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripFileButton.Image")));
            this.toolStripFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripFileButton.Name = "toolStripFileButton";
            this.toolStripFileButton.Size = new System.Drawing.Size(38, 22);
            this.toolStripFileButton.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.saveToolStripMenuItem.Text = "Save Results";
            // 
            // saveResultsAsToolStripMenuItem
            // 
            this.saveResultsAsToolStripMenuItem.Name = "saveResultsAsToolStripMenuItem";
            this.saveResultsAsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.saveResultsAsToolStripMenuItem.Text = "Save Results As...";
            // 
            // toolStripDropSettingsButton
            // 
            this.toolStripDropSettingsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropSettingsButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeDumpDirToolStripMenuItem});
            this.toolStripDropSettingsButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropSettingsButton.Image")));
            this.toolStripDropSettingsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropSettingsButton.Name = "toolStripDropSettingsButton";
            this.toolStripDropSettingsButton.Size = new System.Drawing.Size(62, 22);
            this.toolStripDropSettingsButton.Text = "Settings";
            // 
            // changeDumpDirToolStripMenuItem
            // 
            this.changeDumpDirToolStripMenuItem.Name = "changeDumpDirToolStripMenuItem";
            this.changeDumpDirToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.changeDumpDirToolStripMenuItem.Text = "Change Dump Dir.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchProgressBar);
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Controls.Add(this.searchTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 85);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // searchButton
            // 
            this.searchButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchButton.Location = new System.Drawing.Point(3, 36);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(794, 23);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchTextBox.Location = new System.Drawing.Point(3, 16);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(794, 20);
            this.searchTextBox.TabIndex = 3;
            this.searchTextBox.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search String";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.resultDataGrid);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 340);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results";
            // 
            // resultDataGrid
            // 
            this.resultDataGrid.AllowUserToAddRows = false;
            this.resultDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.resultDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TextColumn,
            this.LocationColumn,
            this.LineColumn});
            this.resultDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultDataGrid.Location = new System.Drawing.Point(3, 16);
            this.resultDataGrid.MultiSelect = false;
            this.resultDataGrid.Name = "resultDataGrid";
            this.resultDataGrid.ShowCellErrors = false;
            this.resultDataGrid.ShowCellToolTips = false;
            this.resultDataGrid.ShowRowErrors = false;
            this.resultDataGrid.Size = new System.Drawing.Size(794, 321);
            this.resultDataGrid.TabIndex = 0;
            this.resultDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ResultDataGrid_CellDoubleClick);
            // 
            // TextColumn
            // 
            this.TextColumn.FillWeight = 138.5787F;
            this.TextColumn.HeaderText = "Text";
            this.TextColumn.Name = "TextColumn";
            // 
            // LocationColumn
            // 
            this.LocationColumn.FillWeight = 138.5787F;
            this.LocationColumn.HeaderText = "Location";
            this.LocationColumn.Name = "LocationColumn";
            this.LocationColumn.ReadOnly = true;
            // 
            // LineColumn
            // 
            this.LineColumn.FillWeight = 22.84264F;
            this.LineColumn.HeaderText = "Line";
            this.LineColumn.Name = "LineColumn";
            this.LineColumn.ReadOnly = true;
            // 
            // searchProgressBar
            // 
            this.searchProgressBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchProgressBar.Location = new System.Drawing.Point(3, 59);
            this.searchProgressBar.Name = "searchProgressBar";
            this.searchProgressBar.Size = new System.Drawing.Size(794, 23);
            this.searchProgressBar.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MainForm";
            this.Text = "GSC Dump Searcher";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripFileButton;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveResultsAsToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropSettingsButton;
        private System.Windows.Forms.ToolStripMenuItem changeDumpDirToolStripMenuItem;
        private System.Windows.Forms.DataGridView resultDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn TextColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LineColumn;
        private System.Windows.Forms.ProgressBar searchProgressBar;
    }
}

