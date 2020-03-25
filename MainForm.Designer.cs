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
            this.fileToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.exportResulsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripDropButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.changeDumpDirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchProgressBar = new System.Windows.Forms.ProgressBar();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.resultDataGrid = new System.Windows.Forms.DataGridView();
            this.TextColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LineColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caseInsensitiveCheckBox = new System.Windows.Forms.CheckBox();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripButton,
            this.settingsToolStripDropButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // fileToolStripButton
            // 
            this.fileToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportResulsToolStripMenuItem});
            this.fileToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("fileToolStripButton.Image")));
            this.fileToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fileToolStripButton.Name = "fileToolStripButton";
            this.fileToolStripButton.Size = new System.Drawing.Size(38, 22);
            this.fileToolStripButton.Text = "File";
            // 
            // exportResulsToolStripMenuItem
            // 
            this.exportResulsToolStripMenuItem.Name = "exportResulsToolStripMenuItem";
            this.exportResulsToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.exportResulsToolStripMenuItem.Text = "Export Results";
            this.exportResulsToolStripMenuItem.Click += new System.EventHandler(this.ExportResulsToolStripMenuItem_Click);
            // 
            // settingsToolStripDropButton
            // 
            this.settingsToolStripDropButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.settingsToolStripDropButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeDumpDirToolStripMenuItem});
            this.settingsToolStripDropButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsToolStripDropButton.Image")));
            this.settingsToolStripDropButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.settingsToolStripDropButton.Name = "settingsToolStripDropButton";
            this.settingsToolStripDropButton.Size = new System.Drawing.Size(62, 22);
            this.settingsToolStripDropButton.Text = "Settings";
            // 
            // changeDumpDirToolStripMenuItem
            // 
            this.changeDumpDirToolStripMenuItem.Name = "changeDumpDirToolStripMenuItem";
            this.changeDumpDirToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.changeDumpDirToolStripMenuItem.Text = "Change Dump Dir.";
            this.changeDumpDirToolStripMenuItem.Click += new System.EventHandler(this.ChangeDumpDirToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.caseInsensitiveCheckBox);
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Controls.Add(this.searchProgressBar);
            this.groupBox1.Controls.Add(this.searchTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 115);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // searchProgressBar
            // 
            this.searchProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.searchProgressBar.Location = new System.Drawing.Point(3, 89);
            this.searchProgressBar.Name = "searchProgressBar";
            this.searchProgressBar.Size = new System.Drawing.Size(794, 23);
            this.searchProgressBar.TabIndex = 5;
            // 
            // searchButton
            // 
            this.searchButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.searchButton.Location = new System.Drawing.Point(3, 66);
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
            this.searchTextBox.Location = new System.Drawing.Point(3, 29);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(794, 20);
            this.searchTextBox.TabIndex = 3;
            this.searchTextBox.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search String";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.resultDataGrid);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 310);
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
            this.resultDataGrid.Size = new System.Drawing.Size(794, 291);
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
            // caseInsensitiveCheckBox
            // 
            this.caseInsensitiveCheckBox.AutoSize = true;
            this.caseInsensitiveCheckBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.caseInsensitiveCheckBox.Location = new System.Drawing.Point(3, 49);
            this.caseInsensitiveCheckBox.Name = "caseInsensitiveCheckBox";
            this.caseInsensitiveCheckBox.Size = new System.Drawing.Size(794, 17);
            this.caseInsensitiveCheckBox.TabIndex = 6;
            this.caseInsensitiveCheckBox.Text = "Case Insensitive Search";
            this.caseInsensitiveCheckBox.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.ToolStripDropDownButton fileToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem exportResulsToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripDropDownButton settingsToolStripDropButton;
        private System.Windows.Forms.ToolStripMenuItem changeDumpDirToolStripMenuItem;
        private System.Windows.Forms.DataGridView resultDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn TextColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LineColumn;
        private System.Windows.Forms.ProgressBar searchProgressBar;
        private System.Windows.Forms.CheckBox caseInsensitiveCheckBox;
    }
}

