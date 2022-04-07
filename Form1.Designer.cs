namespace MdDocsCreater
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbCodePath = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblCodePath = new MaterialSkin.Controls.MaterialLabel();
            this.lbFileEnd = new System.Windows.Forms.ListBox();
            this.lblFileEnding = new MaterialSkin.Controls.MaterialLabel();
            this.tbFileEnd = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnAddFileEnd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnBrowseCode = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbMdPath = new MaterialSkin.Controls.MaterialLabel();
            this.btnBrowseMd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cbPublic = new MaterialSkin.Controls.MaterialCheckBox();
            this.cbPrivate = new MaterialSkin.Controls.MaterialCheckBox();
            this.btnRemoveEnding = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // tbCodePath
            // 
            this.tbCodePath.Depth = 0;
            this.tbCodePath.Hint = "";
            this.tbCodePath.Location = new System.Drawing.Point(170, 12);
            this.tbCodePath.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbCodePath.Name = "tbCodePath";
            this.tbCodePath.PasswordChar = '\0';
            this.tbCodePath.SelectedText = "";
            this.tbCodePath.SelectionLength = 0;
            this.tbCodePath.SelectionStart = 0;
            this.tbCodePath.Size = new System.Drawing.Size(315, 28);
            this.tbCodePath.TabIndex = 0;
            this.tbCodePath.UseSystemPasswordChar = false;
            // 
            // lblCodePath
            // 
            this.lblCodePath.AutoSize = true;
            this.lblCodePath.Depth = 0;
            this.lblCodePath.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCodePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCodePath.Location = new System.Drawing.Point(9, 16);
            this.lblCodePath.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCodePath.Name = "lblCodePath";
            this.lblCodePath.Size = new System.Drawing.Size(97, 24);
            this.lblCodePath.TabIndex = 1;
            this.lblCodePath.Text = "Code Path";
            // 
            // lbFileEnd
            // 
            this.lbFileEnd.FormattingEnabled = true;
            this.lbFileEnd.ItemHeight = 20;
            this.lbFileEnd.Location = new System.Drawing.Point(170, 50);
            this.lbFileEnd.Name = "lbFileEnd";
            this.lbFileEnd.Size = new System.Drawing.Size(315, 124);
            this.lbFileEnd.TabIndex = 2;
            // 
            // lblFileEnding
            // 
            this.lblFileEnding.AutoSize = true;
            this.lblFileEnding.Depth = 0;
            this.lblFileEnding.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFileEnding.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFileEnding.Location = new System.Drawing.Point(9, 50);
            this.lblFileEnding.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFileEnding.Name = "lblFileEnding";
            this.lblFileEnding.Size = new System.Drawing.Size(99, 24);
            this.lblFileEnding.TabIndex = 3;
            this.lblFileEnding.Text = "FileEnding";
            // 
            // tbFileEnd
            // 
            this.tbFileEnd.Depth = 0;
            this.tbFileEnd.Hint = "";
            this.tbFileEnd.Location = new System.Drawing.Point(170, 180);
            this.tbFileEnd.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbFileEnd.Name = "tbFileEnd";
            this.tbFileEnd.PasswordChar = '\0';
            this.tbFileEnd.SelectedText = "";
            this.tbFileEnd.SelectionLength = 0;
            this.tbFileEnd.SelectionStart = 0;
            this.tbFileEnd.Size = new System.Drawing.Size(315, 28);
            this.tbFileEnd.TabIndex = 4;
            this.tbFileEnd.UseSystemPasswordChar = false;
            // 
            // btnAddFileEnd
            // 
            this.btnAddFileEnd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddFileEnd.Depth = 0;
            this.btnAddFileEnd.Location = new System.Drawing.Point(170, 214);
            this.btnAddFileEnd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddFileEnd.Name = "btnAddFileEnd";
            this.btnAddFileEnd.Primary = true;
            this.btnAddFileEnd.Size = new System.Drawing.Size(124, 29);
            this.btnAddFileEnd.TabIndex = 6;
            this.btnAddFileEnd.Text = "Add End";
            this.btnAddFileEnd.UseVisualStyleBackColor = false;
            this.btnAddFileEnd.Click += new System.EventHandler(this.btnAddFileEnd_Click);
            // 
            // btnBrowseCode
            // 
            this.btnBrowseCode.BackColor = System.Drawing.SystemColors.Control;
            this.btnBrowseCode.Depth = 0;
            this.btnBrowseCode.Location = new System.Drawing.Point(491, 11);
            this.btnBrowseCode.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBrowseCode.Name = "btnBrowseCode";
            this.btnBrowseCode.Primary = true;
            this.btnBrowseCode.Size = new System.Drawing.Size(104, 29);
            this.btnBrowseCode.TabIndex = 7;
            this.btnBrowseCode.Text = "Browse";
            this.btnBrowseCode.UseVisualStyleBackColor = false;
            this.btnBrowseCode.Click += new System.EventHandler(this.btnBrowseCode_Click);
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(170, 249);
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(315, 28);
            this.materialSingleLineTextField1.TabIndex = 8;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // lbMdPath
            // 
            this.lbMdPath.AutoSize = true;
            this.lbMdPath.Depth = 0;
            this.lbMdPath.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbMdPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbMdPath.Location = new System.Drawing.Point(9, 249);
            this.lbMdPath.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbMdPath.Name = "lbMdPath";
            this.lbMdPath.Size = new System.Drawing.Size(81, 24);
            this.lbMdPath.TabIndex = 9;
            this.lbMdPath.Text = "Md Path";
            // 
            // btnBrowseMd
            // 
            this.btnBrowseMd.BackColor = System.Drawing.SystemColors.Control;
            this.btnBrowseMd.Depth = 0;
            this.btnBrowseMd.Location = new System.Drawing.Point(491, 244);
            this.btnBrowseMd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBrowseMd.Name = "btnBrowseMd";
            this.btnBrowseMd.Primary = true;
            this.btnBrowseMd.Size = new System.Drawing.Size(104, 29);
            this.btnBrowseMd.TabIndex = 10;
            this.btnBrowseMd.Text = "Browse";
            this.btnBrowseMd.UseVisualStyleBackColor = false;
            // 
            // cbPublic
            // 
            this.cbPublic.AutoSize = true;
            this.cbPublic.Depth = 0;
            this.cbPublic.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbPublic.Location = new System.Drawing.Point(170, 280);
            this.cbPublic.Margin = new System.Windows.Forms.Padding(0);
            this.cbPublic.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbPublic.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbPublic.Name = "cbPublic";
            this.cbPublic.Ripple = true;
            this.cbPublic.Size = new System.Drawing.Size(79, 30);
            this.cbPublic.TabIndex = 11;
            this.cbPublic.Text = "Public";
            this.cbPublic.UseVisualStyleBackColor = true;
            // 
            // cbPrivate
            // 
            this.cbPrivate.AutoSize = true;
            this.cbPrivate.Depth = 0;
            this.cbPrivate.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbPrivate.Location = new System.Drawing.Point(170, 310);
            this.cbPrivate.Margin = new System.Windows.Forms.Padding(0);
            this.cbPrivate.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbPrivate.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbPrivate.Name = "cbPrivate";
            this.cbPrivate.Ripple = true;
            this.cbPrivate.Size = new System.Drawing.Size(85, 30);
            this.cbPrivate.TabIndex = 13;
            this.cbPrivate.Text = "Private";
            this.cbPrivate.UseVisualStyleBackColor = true;
            // 
            // btnRemoveEnding
            // 
            this.btnRemoveEnding.BackColor = System.Drawing.SystemColors.Control;
            this.btnRemoveEnding.Depth = 0;
            this.btnRemoveEnding.Location = new System.Drawing.Point(360, 214);
            this.btnRemoveEnding.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRemoveEnding.Name = "btnRemoveEnding";
            this.btnRemoveEnding.Primary = true;
            this.btnRemoveEnding.Size = new System.Drawing.Size(125, 29);
            this.btnRemoveEnding.TabIndex = 14;
            this.btnRemoveEnding.Text = "Remove End";
            this.btnRemoveEnding.UseVisualStyleBackColor = false;
            this.btnRemoveEnding.Click += new System.EventHandler(this.btnRemoveEnding_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 345);
            this.Controls.Add(this.btnRemoveEnding);
            this.Controls.Add(this.cbPrivate);
            this.Controls.Add(this.cbPublic);
            this.Controls.Add(this.btnBrowseMd);
            this.Controls.Add(this.lbMdPath);
            this.Controls.Add(this.materialSingleLineTextField1);
            this.Controls.Add(this.btnBrowseCode);
            this.Controls.Add(this.btnAddFileEnd);
            this.Controls.Add(this.tbFileEnd);
            this.Controls.Add(this.lblFileEnding);
            this.Controls.Add(this.lbFileEnd);
            this.Controls.Add(this.lblCodePath);
            this.Controls.Add(this.tbCodePath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField tbCodePath;
        private MaterialSkin.Controls.MaterialLabel lblCodePath;
        private ListBox lbFileEnd;
        private MaterialSkin.Controls.MaterialLabel lblFileEnding;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbFileEnd;
        private MaterialSkin.Controls.MaterialRaisedButton btnAddFileEnd;
        private MaterialSkin.Controls.MaterialRaisedButton btnBrowseCode;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialSkin.Controls.MaterialLabel lbMdPath;
        private MaterialSkin.Controls.MaterialRaisedButton btnBrowseMd;
        private MaterialSkin.Controls.MaterialCheckBox cbPublic;
        private MaterialSkin.Controls.MaterialCheckBox cbPrivate;
        private MaterialSkin.Controls.MaterialRaisedButton btnRemoveEnding;
    }
}