namespace hd44780_editor
{
    partial class CEditDialog
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
            this.charPanel = new System.Windows.Forms.Panel();
            this.okBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.invertBtn = new System.Windows.Forms.Button();
            this.fillBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.nameBox = new System.Windows.Forms.ComboBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.loadBtn = new System.Windows.Forms.Button();
            this.codeTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.hexCodeBox = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.binCodeBox = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.decCodeBox = new System.Windows.Forms.RichTextBox();
            this.lineBreaks = new System.Windows.Forms.CheckBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dialogPanel = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.codeTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.dialogPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // charPanel
            // 
            this.charPanel.Location = new System.Drawing.Point(12, 12);
            this.charPanel.Name = "charPanel";
            this.charPanel.Size = new System.Drawing.Size(285, 442);
            this.charPanel.TabIndex = 0;
            this.charPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.charPanel_Paint);
            // 
            // okBtn
            // 
            this.okBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okBtn.Location = new System.Drawing.Point(3, 3);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 1;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(122, 3);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 2;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.invertBtn);
            this.panel2.Controls.Add(this.fillBtn);
            this.panel2.Controls.Add(this.clearBtn);
            this.panel2.Location = new System.Drawing.Point(303, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(147, 90);
            this.panel2.TabIndex = 3;
            // 
            // invertBtn
            // 
            this.invertBtn.Location = new System.Drawing.Point(37, 61);
            this.invertBtn.Name = "invertBtn";
            this.invertBtn.Size = new System.Drawing.Size(75, 23);
            this.invertBtn.TabIndex = 2;
            this.invertBtn.Text = "Invert";
            this.invertBtn.UseVisualStyleBackColor = true;
            this.invertBtn.Click += new System.EventHandler(this.invertBtn_Click);
            // 
            // fillBtn
            // 
            this.fillBtn.Location = new System.Drawing.Point(37, 32);
            this.fillBtn.Name = "fillBtn";
            this.fillBtn.Size = new System.Drawing.Size(75, 23);
            this.fillBtn.TabIndex = 1;
            this.fillBtn.Text = "Fill";
            this.fillBtn.UseVisualStyleBackColor = true;
            this.fillBtn.Click += new System.EventHandler(this.fillBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(37, 3);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 0;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.nameBox);
            this.panel3.Controls.Add(this.saveBtn);
            this.panel3.Controls.Add(this.loadBtn);
            this.panel3.Location = new System.Drawing.Point(468, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(147, 93);
            this.panel3.TabIndex = 4;
            // 
            // nameBox
            // 
            this.nameBox.FormattingEnabled = true;
            this.nameBox.Location = new System.Drawing.Point(13, 3);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(121, 21);
            this.nameBox.TabIndex = 3;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(37, 59);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(37, 30);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(75, 23);
            this.loadBtn.TabIndex = 1;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // codeTabControl
            // 
            this.codeTabControl.Controls.Add(this.tabPage1);
            this.codeTabControl.Controls.Add(this.tabPage2);
            this.codeTabControl.Controls.Add(this.tabPage3);
            this.codeTabControl.Location = new System.Drawing.Point(3, 32);
            this.codeTabControl.Multiline = true;
            this.codeTabControl.Name = "codeTabControl";
            this.codeTabControl.SelectedIndex = 0;
            this.codeTabControl.Size = new System.Drawing.Size(312, 220);
            this.codeTabControl.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.hexCodeBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(304, 194);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hexadecimal";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // hexCodeBox
            // 
            this.hexCodeBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hexCodeBox.Location = new System.Drawing.Point(3, 3);
            this.hexCodeBox.Name = "hexCodeBox";
            this.hexCodeBox.Size = new System.Drawing.Size(298, 188);
            this.hexCodeBox.TabIndex = 0;
            this.hexCodeBox.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.binCodeBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage2.Size = new System.Drawing.Size(304, 194);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Binary";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // binCodeBox
            // 
            this.binCodeBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.binCodeBox.Location = new System.Drawing.Point(3, 3);
            this.binCodeBox.Name = "binCodeBox";
            this.binCodeBox.Size = new System.Drawing.Size(298, 188);
            this.binCodeBox.TabIndex = 1;
            this.binCodeBox.Text = "";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.decCodeBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(304, 194);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Decimal";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // decCodeBox
            // 
            this.decCodeBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.decCodeBox.Location = new System.Drawing.Point(0, 0);
            this.decCodeBox.Name = "decCodeBox";
            this.decCodeBox.Size = new System.Drawing.Size(304, 194);
            this.decCodeBox.TabIndex = 1;
            this.decCodeBox.Text = "";
            // 
            // lineBreaks
            // 
            this.lineBreaks.AutoSize = true;
            this.lineBreaks.Checked = true;
            this.lineBreaks.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lineBreaks.Location = new System.Drawing.Point(84, 7);
            this.lineBreaks.Name = "lineBreaks";
            this.lineBreaks.Size = new System.Drawing.Size(77, 17);
            this.lineBreaks.TabIndex = 6;
            this.lineBreaks.Text = "line breaks";
            this.lineBreaks.UseVisualStyleBackColor = true;
            this.lineBreaks.CheckedChanged += new System.EventHandler(this.lineBreaks_CheckedChanged);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(3, 3);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 7;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.codeTabControl);
            this.panel1.Controls.Add(this.lineBreaks);
            this.panel1.Controls.Add(this.updateBtn);
            this.panel1.Location = new System.Drawing.Point(303, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 255);
            this.panel1.TabIndex = 8;
            // 
            // dialogPanel
            // 
            this.dialogPanel.Controls.Add(this.CancelBtn);
            this.dialogPanel.Controls.Add(this.okBtn);
            this.dialogPanel.Location = new System.Drawing.Point(359, 423);
            this.dialogPanel.Name = "dialogPanel";
            this.dialogPanel.Size = new System.Drawing.Size(200, 31);
            this.dialogPanel.TabIndex = 9;
            // 
            // CEditDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 484);
            this.Controls.Add(this.dialogPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.charPanel);
            this.Name = "CEditDialog";
            this.Text = "CEditDialog";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.codeTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.dialogPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel charPanel;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button invertBtn;
        private System.Windows.Forms.Button fillBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox nameBox;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.TabControl codeTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox hexCodeBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox binCodeBox;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox decCodeBox;
        private System.Windows.Forms.CheckBox lineBreaks;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel dialogPanel;
    }
}