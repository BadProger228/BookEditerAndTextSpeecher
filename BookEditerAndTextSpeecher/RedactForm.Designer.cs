namespace Learn_Project
{
    partial class RedactForm
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
            components = new System.ComponentModel.Container();
            TextOfBook = new TextBox();
            PageUp = new Button();
            PageDown = new Button();
            NameOfBook = new TextBox();
            SaveRedactBook = new Button();
            MaxCharsError = new Label();
            NumberOfPage = new TextBox();
            PageNumber = new TextBox();
            SavePage = new Button();
            AddBefore = new Button();
            AddAfter = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            voiceSelectedTextToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            deletePage = new Button();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // TextOfBook
            // 
            TextOfBook.Location = new Point(45, 69);
            TextOfBook.Multiline = true;
            TextOfBook.Name = "TextOfBook";
            TextOfBook.Size = new Size(460, 407);
            TextOfBook.TabIndex = 0;
            TextOfBook.TextChanged += TextOfBook_TextChanged;
            // 
            // PageUp
            // 
            PageUp.Location = new Point(411, 546);
            PageUp.Name = "PageUp";
            PageUp.Size = new Size(125, 50);
            PageUp.TabIndex = 1;
            PageUp.Text = "==>";
            PageUp.UseVisualStyleBackColor = true;
            PageUp.Click += PageUp_Click;
            // 
            // PageDown
            // 
            PageDown.Location = new Point(22, 546);
            PageDown.Name = "PageDown";
            PageDown.Size = new Size(125, 50);
            PageDown.TabIndex = 2;
            PageDown.Text = "<==";
            PageDown.UseVisualStyleBackColor = true;
            PageDown.Click += PageDown_Click;
            // 
            // NameOfBook
            // 
            NameOfBook.Location = new Point(195, 32);
            NameOfBook.Name = "NameOfBook";
            NameOfBook.Size = new Size(145, 23);
            NameOfBook.TabIndex = 3;
            NameOfBook.TextChanged += NameOfBook_TextChanged;
            // 
            // SaveRedactBook
            // 
            SaveRedactBook.Location = new Point(215, 557);
            SaveRedactBook.Name = "SaveRedactBook";
            SaveRedactBook.Size = new Size(125, 50);
            SaveRedactBook.TabIndex = 5;
            SaveRedactBook.Text = "Save and close";
            SaveRedactBook.UseVisualStyleBackColor = true;
            SaveRedactBook.Click += SaveRedactBook_Click;
            // 
            // MaxCharsError
            // 
            MaxCharsError.AutoSize = true;
            MaxCharsError.ForeColor = Color.Red;
            MaxCharsError.Location = new Point(63, 495);
            MaxCharsError.Name = "MaxCharsError";
            MaxCharsError.Size = new Size(0, 15);
            MaxCharsError.TabIndex = 6;
            MaxCharsError.Visible = false;
            // 
            // NumberOfPage
            // 
            NumberOfPage.Location = new Point(0, 0);
            NumberOfPage.Name = "NumberOfPage";
            NumberOfPage.Size = new Size(100, 23);
            NumberOfPage.TabIndex = 0;
            // 
            // PageNumber
            // 
            PageNumber.Location = new Point(261, 528);
            PageNumber.Name = "PageNumber";
            PageNumber.Size = new Size(29, 23);
            PageNumber.TabIndex = 8;
            PageNumber.Text = "1";
            PageNumber.TextChanged += PageNumber_TextChanged;
            // 
            // SavePage
            // 
            SavePage.Location = new Point(229, 482);
            SavePage.Name = "SavePage";
            SavePage.Size = new Size(85, 40);
            SavePage.TabIndex = 10;
            SavePage.Text = "Save page";
            SavePage.UseVisualStyleBackColor = true;
            SavePage.Click += SavePage_Click;
            // 
            // AddBefore
            // 
            AddBefore.Location = new Point(22, 499);
            AddBefore.Name = "AddBefore";
            AddBefore.Size = new Size(125, 41);
            AddBefore.TabIndex = 11;
            AddBefore.Text = "Add before";
            AddBefore.UseVisualStyleBackColor = true;
            AddBefore.Click += AddBefore_Click;
            // 
            // AddAfter
            // 
            AddAfter.Location = new Point(411, 499);
            AddAfter.Name = "AddAfter";
            AddAfter.Size = new Size(125, 41);
            AddAfter.TabIndex = 12;
            AddAfter.Text = "Add after";
            AddAfter.UseVisualStyleBackColor = true;
            AddAfter.Click += AddAfter_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { voiceSelectedTextToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(172, 26);
            // 
            // voiceSelectedTextToolStripMenuItem
            // 
            voiceSelectedTextToolStripMenuItem.Name = "voiceSelectedTextToolStripMenuItem";
            voiceSelectedTextToolStripMenuItem.Size = new Size(171, 22);
            voiceSelectedTextToolStripMenuItem.Text = "Voice selected text";
            voiceSelectedTextToolStripMenuItem.Click += voiceSelectedTextToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 35);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 13;
            label1.Text = "Name of book:";
            // 
            // deletePage
            // 
            deletePage.Location = new Point(320, 482);
            deletePage.Name = "deletePage";
            deletePage.Size = new Size(85, 40);
            deletePage.TabIndex = 14;
            deletePage.Text = "Delete this page";
            deletePage.UseVisualStyleBackColor = true;
            deletePage.Click += deletePage_Click;
            // 
            // RedactForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 608);
            Controls.Add(deletePage);
            Controls.Add(label1);
            Controls.Add(AddAfter);
            Controls.Add(AddBefore);
            Controls.Add(SavePage);
            Controls.Add(PageNumber);
            Controls.Add(MaxCharsError);
            Controls.Add(SaveRedactBook);
            Controls.Add(NameOfBook);
            Controls.Add(PageDown);
            Controls.Add(PageUp);
            Controls.Add(TextOfBook);
            Name = "RedactForm";
            Text = "RedactForm";
            Load += RedactForm_Load;
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextOfBook;
        private Button PageUp;
        private Button PageDown;
        private TextBox NameOfBook;
        private Button SaveRedactBook;
        private Label MaxCharsError;
        private TextBox NumberOfPage;
        private TextBox PageNumber;
        private Button SavePage;
        private Button AddBefore;
        private Button AddAfter;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem voiceSelectedTextToolStripMenuItem;
        private Label label1;
        private Button deletePage;
    }
}