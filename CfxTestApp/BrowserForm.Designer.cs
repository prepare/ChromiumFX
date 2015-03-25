// Copyright (c) 2014-2015 Wolfgang Borgsmüller
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without 
// modification, are permitted provided that the following conditions 
// are met:
// 
// 1. Redistributions of source code must retain the above copyright 
//    notice, this list of conditions and the following disclaimer.
// 
// 2. Redistributions in binary form must reproduce the above copyright 
//    notice, this list of conditions and the following disclaimer in the 
//    documentation and/or other materials provided with the distribution.
// 
// 3. Neither the name of the copyright holder nor the names of its 
//    contributors may be used to endorse or promote products derived 
//    from this software without specific prior written permission.
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS 
// "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT 
// LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS 
// FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE 
// COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, 
// INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, 
// BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS 
// OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND 
// ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR 
// TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE 
// USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.



namespace CfxTestApplication {
    partial class BrowserForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowserForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BackButton = new System.Windows.Forms.ToolStripButton();
            this.FwdButton = new System.Windows.Forms.ToolStripButton();
            this.UrlTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.LoadUrlButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.LoadGoogleButton = new System.Windows.Forms.ToolStripButton();
            this.JSHelloWorldButton = new System.Windows.Forms.ToolStripButton();
            this.ResourcesTestButton = new System.Windows.Forms.ToolStripButton();
            this.VisitDomButton = new System.Windows.Forms.ToolStripButton();
            this.CountFramesButton = new System.Windows.Forms.ToolStripButton();
            this.ShowDevToolsButton = new System.Windows.Forms.ToolStripButton();
            this.CreditsButton = new System.Windows.Forms.ToolStripButton();
            this.miscDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.systemNetCompatibilityTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.WebBrowser = new Chromium.WebBrowser.ChromiumWebBrowser();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.LogTextBox = new System.Windows.Forms.TextBox();
            this.printButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackButton,
            this.FwdButton,
            this.UrlTextBox,
            this.LoadUrlButton,
            this.toolStripSeparator1,
            this.LoadGoogleButton,
            this.JSHelloWorldButton,
            this.ResourcesTestButton,
            this.VisitDomButton,
            this.CountFramesButton,
            this.ShowDevToolsButton,
            this.CreditsButton,
            this.miscDropDownButton,
            this.printButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1316, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BackButton
            // 
            this.BackButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BackButton.Image = ((System.Drawing.Image)(resources.GetObject("BackButton.Image")));
            this.BackButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(36, 22);
            this.BackButton.Text = "Back";
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // FwdButton
            // 
            this.FwdButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FwdButton.Image = ((System.Drawing.Image)(resources.GetObject("FwdButton.Image")));
            this.FwdButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FwdButton.Name = "FwdButton";
            this.FwdButton.Size = new System.Drawing.Size(33, 22);
            this.FwdButton.Text = "Fwd";
            this.FwdButton.Click += new System.EventHandler(this.FwdButton_Click);
            // 
            // UrlTextBox
            // 
            this.UrlTextBox.Name = "UrlTextBox";
            this.UrlTextBox.Size = new System.Drawing.Size(400, 25);
            this.UrlTextBox.Click += new System.EventHandler(this.UrlTextBox_Click);
            // 
            // LoadUrlButton
            // 
            this.LoadUrlButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.LoadUrlButton.Image = ((System.Drawing.Image)(resources.GetObject("LoadUrlButton.Image")));
            this.LoadUrlButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LoadUrlButton.Name = "LoadUrlButton";
            this.LoadUrlButton.Size = new System.Drawing.Size(52, 22);
            this.LoadUrlButton.Text = "LoadUrl";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // LoadGoogleButton
            // 
            this.LoadGoogleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.LoadGoogleButton.Image = ((System.Drawing.Image)(resources.GetObject("LoadGoogleButton.Image")));
            this.LoadGoogleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LoadGoogleButton.Name = "LoadGoogleButton";
            this.LoadGoogleButton.Size = new System.Drawing.Size(104, 22);
            this.LoadGoogleButton.Text = "Load google.com";
            this.LoadGoogleButton.Click += new System.EventHandler(this.LoadGoogleButton_Click);
            // 
            // JSHelloWorldButton
            // 
            this.JSHelloWorldButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.JSHelloWorldButton.Image = ((System.Drawing.Image)(resources.GetObject("JSHelloWorldButton.Image")));
            this.JSHelloWorldButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.JSHelloWorldButton.Name = "JSHelloWorldButton";
            this.JSHelloWorldButton.Size = new System.Drawing.Size(87, 22);
            this.JSHelloWorldButton.Text = "JS Hello World";
            // 
            // ResourcesTestButton
            // 
            this.ResourcesTestButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ResourcesTestButton.Image = ((System.Drawing.Image)(resources.GetObject("ResourcesTestButton.Image")));
            this.ResourcesTestButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ResourcesTestButton.Name = "ResourcesTestButton";
            this.ResourcesTestButton.Size = new System.Drawing.Size(93, 22);
            this.ResourcesTestButton.Text = "Load Resources";
            // 
            // VisitDomButton
            // 
            this.VisitDomButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.VisitDomButton.Image = ((System.Drawing.Image)(resources.GetObject("VisitDomButton.Image")));
            this.VisitDomButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.VisitDomButton.Name = "VisitDomButton";
            this.VisitDomButton.Size = new System.Drawing.Size(64, 22);
            this.VisitDomButton.Text = "Visit DOM";
            // 
            // CountFramesButton
            // 
            this.CountFramesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CountFramesButton.Image = ((System.Drawing.Image)(resources.GetObject("CountFramesButton.Image")));
            this.CountFramesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CountFramesButton.Name = "CountFramesButton";
            this.CountFramesButton.Size = new System.Drawing.Size(85, 22);
            this.CountFramesButton.Text = "Count Frames";
            this.CountFramesButton.Click += new System.EventHandler(this.CountFramesButton_Click);
            // 
            // ShowDevToolsButton
            // 
            this.ShowDevToolsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ShowDevToolsButton.Image = ((System.Drawing.Image)(resources.GetObject("ShowDevToolsButton.Image")));
            this.ShowDevToolsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ShowDevToolsButton.Name = "ShowDevToolsButton";
            this.ShowDevToolsButton.Size = new System.Drawing.Size(89, 22);
            this.ShowDevToolsButton.Text = "ShowDevTools";
            this.ShowDevToolsButton.Click += new System.EventHandler(this.ShowDevToolsButton_Click);
            // 
            // CreditsButton
            // 
            this.CreditsButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.CreditsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CreditsButton.Image = ((System.Drawing.Image)(resources.GetObject("CreditsButton.Image")));
            this.CreditsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CreditsButton.Name = "CreditsButton";
            this.CreditsButton.Size = new System.Drawing.Size(80, 22);
            this.CreditsButton.Text = "about:credits";
            this.CreditsButton.Click += new System.EventHandler(this.CreditsButton_Click);
            // 
            // miscDropDownButton
            // 
            this.miscDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.miscDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemNetCompatibilityTestToolStripMenuItem});
            this.miscDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("miscDropDownButton.Image")));
            this.miscDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.miscDropDownButton.Name = "miscDropDownButton";
            this.miscDropDownButton.Size = new System.Drawing.Size(45, 22);
            this.miscDropDownButton.Text = "Misc";
            // 
            // systemNetCompatibilityTestToolStripMenuItem
            // 
            this.systemNetCompatibilityTestToolStripMenuItem.Name = "systemNetCompatibilityTestToolStripMenuItem";
            this.systemNetCompatibilityTestToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.systemNetCompatibilityTestToolStripMenuItem.Text = "System.Net compatibility test";
            this.systemNetCompatibilityTestToolStripMenuItem.Click += new System.EventHandler(this.systemNetCompatibilityTestToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.WebBrowser);
            this.splitContainer1.Panel2Collapsed = true;
            this.splitContainer1.Size = new System.Drawing.Size(1316, 448);
            this.splitContainer1.SplitterDistance = 873;
            this.splitContainer1.TabIndex = 3;
            // 
            // WebBrowser
            // 
            this.WebBrowser.BackColor = System.Drawing.Color.White;
            this.WebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebBrowser.Location = new System.Drawing.Point(0, 0);
            this.WebBrowser.Name = "WebBrowser";
            this.WebBrowser.Size = new System.Drawing.Size(1316, 448);
            this.WebBrowser.TabIndex = 2;
            this.WebBrowser.Text = "cfxWebBrowser2";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 25);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.LogTextBox);
            this.splitContainer2.Size = new System.Drawing.Size(1316, 573);
            this.splitContainer2.SplitterDistance = 448;
            this.splitContainer2.TabIndex = 4;
            // 
            // LogTextBox
            // 
            this.LogTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogTextBox.Location = new System.Drawing.Point(0, 0);
            this.LogTextBox.Multiline = true;
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogTextBox.Size = new System.Drawing.Size(1316, 121);
            this.LogTextBox.TabIndex = 0;
            // 
            // printButton
            // 
            this.printButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.printButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.printButton.Image = ((System.Drawing.Image)(resources.GetObject("printButton.Image")));
            this.printButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(36, 22);
            this.printButton.Text = "Print";
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // BrowserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 598);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "BrowserForm";
            this.Text = "BrowserForm";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BackButton;
        private System.Windows.Forms.ToolStripButton FwdButton;
        private System.Windows.Forms.ToolStripTextBox UrlTextBox;
        private System.Windows.Forms.ToolStripButton LoadUrlButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton JSHelloWorldButton;
        private System.Windows.Forms.ToolStripButton ResourcesTestButton;
        private System.Windows.Forms.ToolStripButton VisitDomButton;
        public Chromium.WebBrowser.ChromiumWebBrowser WebBrowser;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox LogTextBox;
        private System.Windows.Forms.ToolStripButton CountFramesButton;
        private System.Windows.Forms.ToolStripButton ShowDevToolsButton;
        private System.Windows.Forms.ToolStripButton CreditsButton;
        private System.Windows.Forms.ToolStripButton LoadGoogleButton;
        private System.Windows.Forms.ToolStripDropDownButton miscDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem systemNetCompatibilityTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton printButton;
    }
}