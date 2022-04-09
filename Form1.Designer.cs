﻿namespace MdDocsCreater
{
    partial class MdDocsCreater
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
            this.tbMdPath = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbMdPath = new MaterialSkin.Controls.MaterialLabel();
            this.btnBrowseMd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cbPublic = new MaterialSkin.Controls.MaterialCheckBox();
            this.cbPrivate = new MaterialSkin.Controls.MaterialCheckBox();
            this.btnRemoveEnding = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnStart = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cbNoReturnValue = new MaterialSkin.Controls.MaterialCheckBox();
            this.cbString = new MaterialSkin.Controls.MaterialCheckBox();
            this.cbInteger = new MaterialSkin.Controls.MaterialCheckBox();
            this.cbBool = new MaterialSkin.Controls.MaterialCheckBox();
            this.cbOther = new MaterialSkin.Controls.MaterialCheckBox();
            this.btnInfoFileEnd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cbProtected = new MaterialSkin.Controls.MaterialCheckBox();
            this.cbInternal = new MaterialSkin.Controls.MaterialCheckBox();
            this.SuspendLayout();
            // 
            // tbCodePath
            // 
            this.tbCodePath.Depth = 0;
            this.tbCodePath.Hint = "";
            this.tbCodePath.Location = new System.Drawing.Point(90, 69);
            this.tbCodePath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCodePath.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbCodePath.Name = "tbCodePath";
            this.tbCodePath.PasswordChar = '\0';
            this.tbCodePath.SelectedText = "";
            this.tbCodePath.SelectionLength = 0;
            this.tbCodePath.SelectionStart = 0;
            this.tbCodePath.Size = new System.Drawing.Size(520, 23);
            this.tbCodePath.TabIndex = 0;
            this.tbCodePath.UseSystemPasswordChar = false;
            // 
            // lblCodePath
            // 
            this.lblCodePath.AutoSize = true;
            this.lblCodePath.BackColor = System.Drawing.Color.White;
            this.lblCodePath.Depth = 0;
            this.lblCodePath.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCodePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCodePath.Location = new System.Drawing.Point(6, 72);
            this.lblCodePath.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCodePath.Name = "lblCodePath";
            this.lblCodePath.Size = new System.Drawing.Size(78, 19);
            this.lblCodePath.TabIndex = 1;
            this.lblCodePath.Text = "Code Path";
            // 
            // lbFileEnd
            // 
            this.lbFileEnd.FormattingEnabled = true;
            this.lbFileEnd.ItemHeight = 15;
            this.lbFileEnd.Location = new System.Drawing.Point(90, 98);
            this.lbFileEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbFileEnd.Name = "lbFileEnd";
            this.lbFileEnd.Size = new System.Drawing.Size(587, 94);
            this.lbFileEnd.TabIndex = 2;
            // 
            // lblFileEnding
            // 
            this.lblFileEnding.AutoSize = true;
            this.lblFileEnding.BackColor = System.Drawing.Color.White;
            this.lblFileEnding.Depth = 0;
            this.lblFileEnding.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFileEnding.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFileEnding.Location = new System.Drawing.Point(6, 98);
            this.lblFileEnding.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFileEnding.Name = "lblFileEnding";
            this.lblFileEnding.Size = new System.Drawing.Size(78, 19);
            this.lblFileEnding.TabIndex = 3;
            this.lblFileEnding.Text = "FileEnding";
            // 
            // tbFileEnd
            // 
            this.tbFileEnd.Depth = 0;
            this.tbFileEnd.Hint = "";
            this.tbFileEnd.Location = new System.Drawing.Point(90, 195);
            this.tbFileEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFileEnd.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbFileEnd.Name = "tbFileEnd";
            this.tbFileEnd.PasswordChar = '\0';
            this.tbFileEnd.SelectedText = "";
            this.tbFileEnd.SelectionLength = 0;
            this.tbFileEnd.SelectionStart = 0;
            this.tbFileEnd.Size = new System.Drawing.Size(587, 23);
            this.tbFileEnd.TabIndex = 4;
            this.tbFileEnd.UseSystemPasswordChar = false;
            // 
            // btnAddFileEnd
            // 
            this.btnAddFileEnd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddFileEnd.Depth = 0;
            this.btnAddFileEnd.Location = new System.Drawing.Point(90, 220);
            this.btnAddFileEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddFileEnd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddFileEnd.Name = "btnAddFileEnd";
            this.btnAddFileEnd.Primary = true;
            this.btnAddFileEnd.Size = new System.Drawing.Size(165, 22);
            this.btnAddFileEnd.TabIndex = 6;
            this.btnAddFileEnd.Text = "Add End";
            this.btnAddFileEnd.UseVisualStyleBackColor = false;
            this.btnAddFileEnd.Click += new System.EventHandler(this.btnAddFileEnd_Click);
            // 
            // btnBrowseCode
            // 
            this.btnBrowseCode.BackColor = System.Drawing.SystemColors.Control;
            this.btnBrowseCode.Depth = 0;
            this.btnBrowseCode.Location = new System.Drawing.Point(616, 69);
            this.btnBrowseCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBrowseCode.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBrowseCode.Name = "btnBrowseCode";
            this.btnBrowseCode.Primary = true;
            this.btnBrowseCode.Size = new System.Drawing.Size(61, 22);
            this.btnBrowseCode.TabIndex = 7;
            this.btnBrowseCode.Text = "Browse";
            this.btnBrowseCode.UseVisualStyleBackColor = false;
            this.btnBrowseCode.Click += new System.EventHandler(this.btnBrowseCode_Click);
            // 
            // tbMdPath
            // 
            this.tbMdPath.Depth = 0;
            this.tbMdPath.Hint = "";
            this.tbMdPath.Location = new System.Drawing.Point(90, 247);
            this.tbMdPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMdPath.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbMdPath.Name = "tbMdPath";
            this.tbMdPath.PasswordChar = '\0';
            this.tbMdPath.SelectedText = "";
            this.tbMdPath.SelectionLength = 0;
            this.tbMdPath.SelectionStart = 0;
            this.tbMdPath.Size = new System.Drawing.Size(520, 23);
            this.tbMdPath.TabIndex = 8;
            this.tbMdPath.UseSystemPasswordChar = false;
            // 
            // lbMdPath
            // 
            this.lbMdPath.AutoSize = true;
            this.lbMdPath.BackColor = System.Drawing.Color.White;
            this.lbMdPath.Depth = 0;
            this.lbMdPath.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbMdPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbMdPath.Location = new System.Drawing.Point(6, 247);
            this.lbMdPath.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbMdPath.Name = "lbMdPath";
            this.lbMdPath.Size = new System.Drawing.Size(64, 19);
            this.lbMdPath.TabIndex = 9;
            this.lbMdPath.Text = "Md Path";
            // 
            // btnBrowseMd
            // 
            this.btnBrowseMd.BackColor = System.Drawing.SystemColors.Control;
            this.btnBrowseMd.Depth = 0;
            this.btnBrowseMd.Location = new System.Drawing.Point(616, 248);
            this.btnBrowseMd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBrowseMd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBrowseMd.Name = "btnBrowseMd";
            this.btnBrowseMd.Primary = true;
            this.btnBrowseMd.Size = new System.Drawing.Size(61, 22);
            this.btnBrowseMd.TabIndex = 10;
            this.btnBrowseMd.Text = "Browse";
            this.btnBrowseMd.UseVisualStyleBackColor = false;
            this.btnBrowseMd.Click += new System.EventHandler(this.btnBrowseMd_Click);
            // 
            // cbPublic
            // 
            this.cbPublic.AutoSize = true;
            this.cbPublic.BackColor = System.Drawing.Color.White;
            this.cbPublic.Depth = 0;
            this.cbPublic.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbPublic.Location = new System.Drawing.Point(92, 272);
            this.cbPublic.Margin = new System.Windows.Forms.Padding(0);
            this.cbPublic.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbPublic.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbPublic.Name = "cbPublic";
            this.cbPublic.Ripple = true;
            this.cbPublic.Size = new System.Drawing.Size(68, 30);
            this.cbPublic.TabIndex = 11;
            this.cbPublic.Text = "Public";
            this.cbPublic.UseVisualStyleBackColor = false;
            // 
            // cbPrivate
            // 
            this.cbPrivate.AutoSize = true;
            this.cbPrivate.BackColor = System.Drawing.Color.White;
            this.cbPrivate.Depth = 0;
            this.cbPrivate.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbPrivate.Location = new System.Drawing.Point(92, 302);
            this.cbPrivate.Margin = new System.Windows.Forms.Padding(0);
            this.cbPrivate.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbPrivate.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbPrivate.Name = "cbPrivate";
            this.cbPrivate.Ripple = true;
            this.cbPrivate.Size = new System.Drawing.Size(73, 30);
            this.cbPrivate.TabIndex = 13;
            this.cbPrivate.Text = "Private";
            this.cbPrivate.UseVisualStyleBackColor = false;
            // 
            // btnRemoveEnding
            // 
            this.btnRemoveEnding.BackColor = System.Drawing.SystemColors.Control;
            this.btnRemoveEnding.Depth = 0;
            this.btnRemoveEnding.Location = new System.Drawing.Point(512, 222);
            this.btnRemoveEnding.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveEnding.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRemoveEnding.Name = "btnRemoveEnding";
            this.btnRemoveEnding.Primary = true;
            this.btnRemoveEnding.Size = new System.Drawing.Size(165, 22);
            this.btnRemoveEnding.TabIndex = 14;
            this.btnRemoveEnding.Text = "Remove End";
            this.btnRemoveEnding.UseVisualStyleBackColor = false;
            this.btnRemoveEnding.Click += new System.EventHandler(this.btnRemoveEnding_Click);
            // 
            // btnStart
            // 
            this.btnStart.Depth = 0;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStart.Location = new System.Drawing.Point(92, 430);
            this.btnStart.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStart.Name = "btnStart";
            this.btnStart.Primary = true;
            this.btnStart.Size = new System.Drawing.Size(587, 53);
            this.btnStart.TabIndex = 15;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // cbNoReturnValue
            // 
            this.cbNoReturnValue.AutoSize = true;
            this.cbNoReturnValue.Depth = 0;
            this.cbNoReturnValue.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbNoReturnValue.Location = new System.Drawing.Point(180, 272);
            this.cbNoReturnValue.Margin = new System.Windows.Forms.Padding(0);
            this.cbNoReturnValue.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbNoReturnValue.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbNoReturnValue.Name = "cbNoReturnValue";
            this.cbNoReturnValue.Ripple = true;
            this.cbNoReturnValue.Size = new System.Drawing.Size(93, 30);
            this.cbNoReturnValue.TabIndex = 16;
            this.cbNoReturnValue.Text = "Void/Task";
            this.cbNoReturnValue.UseVisualStyleBackColor = true;
            // 
            // cbString
            // 
            this.cbString.AutoSize = true;
            this.cbString.Depth = 0;
            this.cbString.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbString.Location = new System.Drawing.Point(180, 302);
            this.cbString.Margin = new System.Windows.Forms.Padding(0);
            this.cbString.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbString.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbString.Name = "cbString";
            this.cbString.Ripple = true;
            this.cbString.Size = new System.Drawing.Size(67, 30);
            this.cbString.TabIndex = 17;
            this.cbString.Text = "String";
            this.cbString.UseVisualStyleBackColor = true;
            // 
            // cbInteger
            // 
            this.cbInteger.AutoSize = true;
            this.cbInteger.Depth = 0;
            this.cbInteger.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbInteger.Location = new System.Drawing.Point(180, 332);
            this.cbInteger.Margin = new System.Windows.Forms.Padding(0);
            this.cbInteger.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbInteger.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbInteger.Name = "cbInteger";
            this.cbInteger.Ripple = true;
            this.cbInteger.Size = new System.Drawing.Size(73, 30);
            this.cbInteger.TabIndex = 18;
            this.cbInteger.Text = "Integer";
            this.cbInteger.UseVisualStyleBackColor = true;
            // 
            // cbBool
            // 
            this.cbBool.AutoSize = true;
            this.cbBool.Depth = 0;
            this.cbBool.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbBool.Location = new System.Drawing.Point(180, 362);
            this.cbBool.Margin = new System.Windows.Forms.Padding(0);
            this.cbBool.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbBool.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbBool.Name = "cbBool";
            this.cbBool.Ripple = true;
            this.cbBool.Size = new System.Drawing.Size(58, 30);
            this.cbBool.TabIndex = 19;
            this.cbBool.Text = "Bool";
            this.cbBool.UseVisualStyleBackColor = true;
            // 
            // cbOther
            // 
            this.cbOther.AutoSize = true;
            this.cbOther.Depth = 0;
            this.cbOther.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbOther.Location = new System.Drawing.Point(180, 392);
            this.cbOther.Margin = new System.Windows.Forms.Padding(0);
            this.cbOther.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbOther.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbOther.Name = "cbOther";
            this.cbOther.Ripple = true;
            this.cbOther.Size = new System.Drawing.Size(64, 30);
            this.cbOther.TabIndex = 20;
            this.cbOther.Text = "Other";
            this.cbOther.UseVisualStyleBackColor = true;
            // 
            // btnInfoFileEnd
            // 
            this.btnInfoFileEnd.BackColor = System.Drawing.SystemColors.Control;
            this.btnInfoFileEnd.Depth = 0;
            this.btnInfoFileEnd.Location = new System.Drawing.Point(261, 220);
            this.btnInfoFileEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInfoFileEnd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInfoFileEnd.Name = "btnInfoFileEnd";
            this.btnInfoFileEnd.Primary = true;
            this.btnInfoFileEnd.Size = new System.Drawing.Size(27, 22);
            this.btnInfoFileEnd.TabIndex = 21;
            this.btnInfoFileEnd.Text = "?";
            this.btnInfoFileEnd.UseVisualStyleBackColor = false;
            this.btnInfoFileEnd.Click += new System.EventHandler(this.btnInfoFileEnd_Click);
            // 
            // cbProtected
            // 
            this.cbProtected.AutoSize = true;
            this.cbProtected.BackColor = System.Drawing.Color.White;
            this.cbProtected.Depth = 0;
            this.cbProtected.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbProtected.Location = new System.Drawing.Point(92, 332);
            this.cbProtected.Margin = new System.Windows.Forms.Padding(0);
            this.cbProtected.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbProtected.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbProtected.Name = "cbProtected";
            this.cbProtected.Ripple = true;
            this.cbProtected.Size = new System.Drawing.Size(90, 30);
            this.cbProtected.TabIndex = 22;
            this.cbProtected.Text = "Protected";
            this.cbProtected.UseVisualStyleBackColor = false;
            // 
            // cbInternal
            // 
            this.cbInternal.AutoSize = true;
            this.cbInternal.BackColor = System.Drawing.Color.White;
            this.cbInternal.Depth = 0;
            this.cbInternal.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbInternal.Location = new System.Drawing.Point(92, 362);
            this.cbInternal.Margin = new System.Windows.Forms.Padding(0);
            this.cbInternal.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbInternal.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbInternal.Name = "cbInternal";
            this.cbInternal.Ripple = true;
            this.cbInternal.Size = new System.Drawing.Size(77, 30);
            this.cbInternal.TabIndex = 23;
            this.cbInternal.Text = "Internal";
            this.cbInternal.UseVisualStyleBackColor = false;
            // 
            // MdDocsCreater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(691, 495);
            this.Controls.Add(this.cbInternal);
            this.Controls.Add(this.cbProtected);
            this.Controls.Add(this.btnInfoFileEnd);
            this.Controls.Add(this.cbOther);
            this.Controls.Add(this.cbBool);
            this.Controls.Add(this.cbInteger);
            this.Controls.Add(this.cbString);
            this.Controls.Add(this.cbNoReturnValue);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnRemoveEnding);
            this.Controls.Add(this.cbPrivate);
            this.Controls.Add(this.cbPublic);
            this.Controls.Add(this.btnBrowseMd);
            this.Controls.Add(this.lbMdPath);
            this.Controls.Add(this.tbMdPath);
            this.Controls.Add(this.btnBrowseCode);
            this.Controls.Add(this.btnAddFileEnd);
            this.Controls.Add(this.tbFileEnd);
            this.Controls.Add(this.lblFileEnding);
            this.Controls.Add(this.lbFileEnd);
            this.Controls.Add(this.lblCodePath);
            this.Controls.Add(this.tbCodePath);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MdDocsCreater";
            this.Sizable = false;
            this.Text = "MdDocsCreater";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel lblCodePath;
        private MaterialSkin.Controls.MaterialLabel lblFileEnding;
        private MaterialSkin.Controls.MaterialRaisedButton btnAddFileEnd;
        private MaterialSkin.Controls.MaterialRaisedButton btnBrowseCode;
        private MaterialSkin.Controls.MaterialLabel lbMdPath;
        private MaterialSkin.Controls.MaterialRaisedButton btnBrowseMd;
        private MaterialSkin.Controls.MaterialRaisedButton btnRemoveEnding;
        private MaterialSkin.Controls.MaterialRaisedButton btnStart;
        public MaterialSkin.Controls.MaterialSingleLineTextField tbCodePath;
        public MaterialSkin.Controls.MaterialSingleLineTextField tbFileEnd;
        public MaterialSkin.Controls.MaterialSingleLineTextField tbMdPath;
        public MaterialSkin.Controls.MaterialCheckBox cbPublic;
        public MaterialSkin.Controls.MaterialCheckBox cbPrivate;
        public MaterialSkin.Controls.MaterialCheckBox cbNoReturnValue;
        public MaterialSkin.Controls.MaterialCheckBox cbString;
        public MaterialSkin.Controls.MaterialCheckBox cbInteger;
        public MaterialSkin.Controls.MaterialCheckBox cbBool;
        public MaterialSkin.Controls.MaterialCheckBox cbOther;
        public ListBox lbFileEnd;
        private MaterialSkin.Controls.MaterialRaisedButton btnInfoFileEnd;
        public MaterialSkin.Controls.MaterialCheckBox cbProtected;
        public MaterialSkin.Controls.MaterialCheckBox cbInternal;
    }
}