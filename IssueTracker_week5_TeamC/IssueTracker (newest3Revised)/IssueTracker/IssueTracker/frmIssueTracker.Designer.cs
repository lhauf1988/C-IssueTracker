namespace IssueTracker
{
    partial class frmIssueTracker
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblIssueNum = new System.Windows.Forms.Label();
            this.lblErrorCat = new System.Windows.Forms.Label();
            this.lblPriority = new System.Windows.Forms.Label();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.rbtnOpen = new System.Windows.Forms.RadioButton();
            this.rbtnClose = new System.Windows.Forms.RadioButton();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCreatedDate = new System.Windows.Forms.Label();
            this.lblCreator = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblModified = new System.Windows.Forms.Label();
            this.lblLast = new System.Windows.Forms.Label();
            this.lblModifiedDate = new System.Windows.Forms.Label();
            this.lblQuery = new System.Windows.Forms.Label();
            this.lblSort = new System.Windows.Forms.Label();
            this.cmbxQuery = new System.Windows.Forms.ComboBox();
            this.cmbxSort = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblIssueId = new System.Windows.Forms.Label();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblModifiedBy = new System.Windows.Forms.Label();
            this.dgvIssueList = new System.Windows.Forms.DataGridView();
            this.cmbError = new System.Windows.Forms.ComboBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssueList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(12, 248);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(98, 16);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Issue Details";
            // 
            // lblIssueNum
            // 
            this.lblIssueNum.AutoSize = true;
            this.lblIssueNum.Location = new System.Drawing.Point(19, 284);
            this.lblIssueNum.Name = "lblIssueNum";
            this.lblIssueNum.Size = new System.Drawing.Size(75, 13);
            this.lblIssueNum.TabIndex = 1;
            this.lblIssueNum.Text = "Issue Number:";
            // 
            // lblErrorCat
            // 
            this.lblErrorCat.AutoSize = true;
            this.lblErrorCat.Location = new System.Drawing.Point(22, 320);
            this.lblErrorCat.Name = "lblErrorCat";
            this.lblErrorCat.Size = new System.Drawing.Size(77, 13);
            this.lblErrorCat.TabIndex = 3;
            this.lblErrorCat.Text = "Error Category:";
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(58, 387);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(41, 13);
            this.lblPriority.TabIndex = 8;
            this.lblPriority.Text = "Priority:";
            // 
            // cmbPriority
            // 
            this.cmbPriority.FormattingEnabled = true;
            this.cmbPriority.Location = new System.Drawing.Point(121, 387);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(152, 21);
            this.cmbPriority.TabIndex = 9;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(59, 425);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Status:";
            // 
            // rbtnOpen
            // 
            this.rbtnOpen.AutoSize = true;
            this.rbtnOpen.Location = new System.Drawing.Point(121, 425);
            this.rbtnOpen.Name = "rbtnOpen";
            this.rbtnOpen.Size = new System.Drawing.Size(51, 17);
            this.rbtnOpen.TabIndex = 11;
            this.rbtnOpen.TabStop = true;
            this.rbtnOpen.Text = "&Open";
            this.rbtnOpen.UseVisualStyleBackColor = true;
            // 
            // rbtnClose
            // 
            this.rbtnClose.AutoSize = true;
            this.rbtnClose.Location = new System.Drawing.Point(196, 425);
            this.rbtnClose.Name = "rbtnClose";
            this.rbtnClose.Size = new System.Drawing.Size(51, 17);
            this.rbtnClose.TabIndex = 12;
            this.rbtnClose.TabStop = true;
            this.rbtnClose.Text = "&Close";
            this.rbtnClose.UseVisualStyleBackColor = true;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(375, 287);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(73, 13);
            this.lblDate.TabIndex = 14;
            this.lblDate.Text = "Date Created:";
            // 
            // lblCreatedDate
            // 
            this.lblCreatedDate.AutoSize = true;
            this.lblCreatedDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCreatedDate.Location = new System.Drawing.Point(494, 287);
            this.lblCreatedDate.Name = "lblCreatedDate";
            this.lblCreatedDate.Size = new System.Drawing.Size(84, 15);
            this.lblCreatedDate.TabIndex = 15;
            this.lblCreatedDate.Text = "MM/DD/YYYY ";
            // 
            // lblCreator
            // 
            this.lblCreator.AutoSize = true;
            this.lblCreator.Location = new System.Drawing.Point(386, 320);
            this.lblCreator.Name = "lblCreator";
            this.lblCreator.Size = new System.Drawing.Size(62, 13);
            this.lblCreator.TabIndex = 16;
            this.lblCreator.Text = "Created By:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(36, 460);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 17;
            this.lblDescription.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(121, 460);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(494, 20);
            this.txtDescription.TabIndex = 18;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(40, 504);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 19;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(564, 503);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(124, 503);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(429, 503);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(595, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 23;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblModified
            // 
            this.lblModified.AutoSize = true;
            this.lblModified.Location = new System.Drawing.Point(360, 387);
            this.lblModified.Name = "lblModified";
            this.lblModified.Size = new System.Drawing.Size(88, 13);
            this.lblModified.TabIndex = 24;
            this.lblModified.Text = "Last Modified By:";
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Location = new System.Drawing.Point(349, 352);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(99, 13);
            this.lblLast.TabIndex = 25;
            this.lblLast.Text = "Last Modified Date:";
            // 
            // lblModifiedDate
            // 
            this.lblModifiedDate.AutoSize = true;
            this.lblModifiedDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblModifiedDate.Location = new System.Drawing.Point(494, 356);
            this.lblModifiedDate.Name = "lblModifiedDate";
            this.lblModifiedDate.Size = new System.Drawing.Size(81, 15);
            this.lblModifiedDate.TabIndex = 26;
            this.lblModifiedDate.Text = "MM/DD/YYYY";
            // 
            // lblQuery
            // 
            this.lblQuery.AutoSize = true;
            this.lblQuery.Location = new System.Drawing.Point(22, 60);
            this.lblQuery.Name = "lblQuery";
            this.lblQuery.Size = new System.Drawing.Size(38, 13);
            this.lblQuery.TabIndex = 28;
            this.lblQuery.Text = "Query:";
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Location = new System.Drawing.Point(232, 60);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(29, 13);
            this.lblSort.TabIndex = 29;
            this.lblSort.Text = "Sort:";
            // 
            // cmbxQuery
            // 
            this.cmbxQuery.FormattingEnabled = true;
            this.cmbxQuery.Items.AddRange(new object[] {
            "Error Category",
            "Priority",
            "Status",
            "All"});
            this.cmbxQuery.Location = new System.Drawing.Point(78, 57);
            this.cmbxQuery.Name = "cmbxQuery";
            this.cmbxQuery.Size = new System.Drawing.Size(121, 21);
            this.cmbxQuery.TabIndex = 30;
            this.cmbxQuery.SelectedIndexChanged += new System.EventHandler(this.cmbxQuery_SelectedIndexChanged);
            // 
            // cmbxSort
            // 
            this.cmbxSort.FormattingEnabled = true;
            this.cmbxSort.Location = new System.Drawing.Point(277, 57);
            this.cmbxSort.Name = "cmbxSort";
            this.cmbxSort.Size = new System.Drawing.Size(121, 21);
            this.cmbxSort.TabIndex = 31;
            this.cmbxSort.SelectedIndexChanged += new System.EventHandler(this.cmbxSort_SelectedIndexChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(15, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(212, 20);
            this.lblTitle.TabIndex = 32;
            this.lblTitle.Text = "Issue Tracker Application";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(538, 60);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(60, 13);
            this.lblUser.TabIndex = 33;
            this.lblUser.Text = "User Name";
            // 
            // lblIssueId
            // 
            this.lblIssueId.AutoSize = true;
            this.lblIssueId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIssueId.Location = new System.Drawing.Point(121, 283);
            this.lblIssueId.Name = "lblIssueId";
            this.lblIssueId.Size = new System.Drawing.Size(15, 15);
            this.lblIssueId.TabIndex = 34;
            this.lblIssueId.Text = "0";
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCreatedBy.Location = new System.Drawing.Point(497, 320);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(53, 15);
            this.lblCreatedBy.TabIndex = 35;
            this.lblCreatedBy.Text = "First User";
            // 
            // lblModifiedBy
            // 
            this.lblModifiedBy.AutoSize = true;
            this.lblModifiedBy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblModifiedBy.Location = new System.Drawing.Point(497, 386);
            this.lblModifiedBy.Name = "lblModifiedBy";
            this.lblModifiedBy.Size = new System.Drawing.Size(54, 15);
            this.lblModifiedBy.TabIndex = 36;
            this.lblModifiedBy.Text = "Last User";
            // 
            // dgvIssueList
            // 
            this.dgvIssueList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIssueList.Location = new System.Drawing.Point(25, 98);
            this.dgvIssueList.Name = "dgvIssueList";
            this.dgvIssueList.Size = new System.Drawing.Size(626, 147);
            this.dgvIssueList.TabIndex = 37;
            // 
            // cmbError
            // 
            this.cmbError.FormattingEnabled = true;
            this.cmbError.Location = new System.Drawing.Point(121, 320);
            this.cmbError.Name = "cmbError";
            this.cmbError.Size = new System.Drawing.Size(152, 21);
            this.cmbError.TabIndex = 38;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(267, 503);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 39;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(348, 503);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 40;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(485, 60);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(55, 13);
            this.lblWelcome.TabIndex = 41;
            this.lblWelcome.Text = "Welcome,";
            // 
            // frmIssueTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 554);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.cmbError);
            this.Controls.Add(this.dgvIssueList);
            this.Controls.Add(this.lblModifiedBy);
            this.Controls.Add(this.lblCreatedBy);
            this.Controls.Add(this.lblIssueId);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.cmbxSort);
            this.Controls.Add(this.cmbxQuery);
            this.Controls.Add(this.lblSort);
            this.Controls.Add(this.lblQuery);
            this.Controls.Add(this.lblModifiedDate);
            this.Controls.Add(this.lblLast);
            this.Controls.Add(this.lblModified);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblCreator);
            this.Controls.Add(this.lblCreatedDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.rbtnClose);
            this.Controls.Add(this.rbtnOpen);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cmbPriority);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.lblErrorCat);
            this.Controls.Add(this.lblIssueNum);
            this.Controls.Add(this.lblHeader);
            this.Name = "frmIssueTracker";
            this.Text = "Issue Tracker";
            this.Load += new System.EventHandler(this.frmIssueTracker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssueList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblIssueNum;
        private System.Windows.Forms.Label lblErrorCat;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.ComboBox cmbPriority;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.RadioButton rbtnOpen;
        private System.Windows.Forms.RadioButton rbtnClose;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCreatedDate;
        private System.Windows.Forms.Label lblCreator;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblModified;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.Label lblModifiedDate;
        private System.Windows.Forms.Label lblQuery;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.ComboBox cmbxQuery;
        private System.Windows.Forms.ComboBox cmbxSort;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblIssueId;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblModifiedBy;
        private System.Windows.Forms.DataGridView dgvIssueList;
        private System.Windows.Forms.ComboBox cmbError;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblWelcome;

    }
}

