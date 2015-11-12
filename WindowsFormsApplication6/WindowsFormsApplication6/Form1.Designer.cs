namespace WindowsFormsApplication6
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.favouritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tFav = new System.Windows.Forms.ToolStripMenuItem();
            this.tSavFav = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tHist = new System.Windows.Forms.ToolStripMenuItem();
            this.tClearHist = new System.Windows.Forms.ToolStripMenuItem();
            this.newTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tNewTab = new System.Windows.Forms.ToolStripMenuItem();
            this.tNextTab = new System.Windows.Forms.ToolStripMenuItem();
            this.tPreTab = new System.Windows.Forms.ToolStripMenuItem();
            this.tSaveHomePgae = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectedTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnPrePage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SelectedTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.favouritesToolStripMenuItem,
            this.historyToolStripMenuItem,
            this.newTabToolStripMenuItem,
            this.tNextTab,
            this.tPreTab,
            this.tSaveHomePgae});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(901, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // favouritesToolStripMenuItem
            // 
            this.favouritesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tFav,
            this.tSavFav});
            this.favouritesToolStripMenuItem.Name = "favouritesToolStripMenuItem";
            this.favouritesToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.favouritesToolStripMenuItem.Text = "Favourites";
            // 
            // tFav
            // 
            this.tFav.Name = "tFav";
            this.tFav.Size = new System.Drawing.Size(167, 22);
            this.tFav.Text = "View Favourites";
            this.tFav.Click += new System.EventHandler(this.tFav_Click);
            // 
            // tSavFav
            // 
            this.tSavFav.Name = "tSavFav";
            this.tSavFav.Size = new System.Drawing.Size(167, 22);
            this.tSavFav.Text = "Add to Favourites";
            this.tSavFav.Click += new System.EventHandler(this.tSavFav_Click);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tHist,
            this.tClearHist});
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.historyToolStripMenuItem.Text = "History";
            // 
            // tHist
            // 
            this.tHist.Name = "tHist";
            this.tHist.Size = new System.Drawing.Size(146, 22);
            this.tHist.Text = "View History";
            this.tHist.Click += new System.EventHandler(this.tHist_Click);
            // 
            // tClearHist
            // 
            this.tClearHist.Name = "tClearHist";
            this.tClearHist.Size = new System.Drawing.Size(146, 22);
            this.tClearHist.Text = "Clear Hisrtory";
            this.tClearHist.Click += new System.EventHandler(this.tClearHist_Click);
            // 
            // newTabToolStripMenuItem
            // 
            this.newTabToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tNewTab});
            this.newTabToolStripMenuItem.Name = "newTabToolStripMenuItem";
            this.newTabToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.newTabToolStripMenuItem.Text = "New Tab";
            // 
            // tNewTab
            // 
            this.tNewTab.Name = "tNewTab";
            this.tNewTab.Size = new System.Drawing.Size(157, 22);
            this.tNewTab.Text = "Create New Tab";
            this.tNewTab.Click += new System.EventHandler(this.tNewTab_Click);
            // 
            // tNextTab
            // 
            this.tNextTab.Name = "tNextTab";
            this.tNextTab.Size = new System.Drawing.Size(65, 20);
            this.tNextTab.Text = "Next Tab";
            this.tNextTab.Click += new System.EventHandler(this.tNextTab_Click);
            // 
            // tPreTab
            // 
            this.tPreTab.Name = "tPreTab";
            this.tPreTab.Size = new System.Drawing.Size(86, 20);
            this.tPreTab.Text = "Previous Tab";
            this.tPreTab.Click += new System.EventHandler(this.tPreTab_Click);
            // 
            // tSaveHomePgae
            // 
            this.tSaveHomePgae.Name = "tSaveHomePgae";
            this.tSaveHomePgae.Size = new System.Drawing.Size(113, 20);
            this.tSaveHomePgae.Text = "Set As HomePage";
            this.tSaveHomePgae.Click += new System.EventHandler(this.tSaveHomePgae_Click);
            // 
            // SelectedTab
            // 
            this.SelectedTab.Controls.Add(this.tabPage1);
            this.SelectedTab.Location = new System.Drawing.Point(12, 111);
            this.SelectedTab.Name = "SelectedTab";
            this.SelectedTab.SelectedIndex = 0;
            this.SelectedTab.Size = new System.Drawing.Size(748, 390);
            this.SelectedTab.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(740, 364);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(-4, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(744, 364);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(314, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(16, 64);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(61, 34);
            this.btnGo.TabIndex = 3;
            this.btnGo.Text = "GO";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(83, 64);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(61, 34);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(150, 64);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(61, 34);
            this.btnHome.TabIndex = 5;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(217, 64);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(61, 34);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "RELOAD";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(762, 133);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 368);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnPrePage
            // 
            this.btnPrePage.Location = new System.Drawing.Point(586, 80);
            this.btnPrePage.Name = "btnPrePage";
            this.btnPrePage.Size = new System.Drawing.Size(61, 34);
            this.btnPrePage.TabIndex = 8;
            this.btnPrePage.Text = "<";
            this.btnPrePage.UseVisualStyleBackColor = true;
            this.btnPrePage.Click += new System.EventHandler(this.btnPrePage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.Location = new System.Drawing.Point(653, 80);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(61, 34);
            this.btnNextPage.TabIndex = 9;
            this.btnNextPage.Text = ">";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(766, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 513);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.btnPrePage);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SelectedTab);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Web Browser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.SelectedTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem favouritesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tFav;
        private System.Windows.Forms.ToolStripMenuItem tSavFav;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tHist;
        private System.Windows.Forms.ToolStripMenuItem tClearHist;
        private System.Windows.Forms.ToolStripMenuItem newTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tNewTab;
        private System.Windows.Forms.TabControl SelectedTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ToolStripMenuItem tNextTab;
        private System.Windows.Forms.ToolStripMenuItem tPreTab;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ToolStripMenuItem tSaveHomePgae;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnPrePage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
    }
}

