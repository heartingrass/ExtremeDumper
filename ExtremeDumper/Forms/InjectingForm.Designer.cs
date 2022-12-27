namespace ExtremeDumper.Forms
{
    partial class InjectingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkWaitReturn = new System.Windows.Forms.CheckBox();
            this.btInject = new System.Windows.Forms.Button();
            this.cmbEntryPoint = new System.Windows.Forms.ComboBox();
            this.btSelectAssembly = new System.Windows.Forms.Button();
            this.tbAssemblyPath = new System.Windows.Forms.TextBox();
            this.tbArgument = new System.Windows.Forms.TextBox();
            this.odlgSelectAssembly = new System.Windows.Forms.OpenFileDialog();
            this.cmbCLRVersion = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // chkWaitReturn
            // 
            this.chkWaitReturn.AutoSize = true;
            this.chkWaitReturn.Location = new System.Drawing.Point(1116, 45);
            this.chkWaitReturn.Name = "chkWaitReturn";
            this.chkWaitReturn.Size = new System.Drawing.Size(64, 24);
            this.chkWaitReturn.TabIndex = 11;
            this.chkWaitReturn.Text = "Wait";
            this.chkWaitReturn.UseVisualStyleBackColor = true;
            // 
            // btInject
            // 
            this.btInject.Location = new System.Drawing.Point(1186, 45);
            this.btInject.Name = "btInject";
            this.btInject.Size = new System.Drawing.Size(174, 28);
            this.btInject.TabIndex = 9;
            this.btInject.Text = "Inject";
            this.btInject.UseVisualStyleBackColor = true;
            this.btInject.Click += new System.EventHandler(this.btInject_Click);
            // 
            // cmbEntryPoint
            // 
            this.cmbEntryPoint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEntryPoint.FormattingEnabled = true;
            this.cmbEntryPoint.Location = new System.Drawing.Point(12, 43);
            this.cmbEntryPoint.Name = "cmbEntryPoint";
            this.cmbEntryPoint.Size = new System.Drawing.Size(766, 28);
            this.cmbEntryPoint.TabIndex = 8;
            this.cmbEntryPoint.SelectedIndexChanged += new System.EventHandler(this.cmbEntryPoint_SelectedIndexChanged);
            // 
            // btSelectAssembly
            // 
            this.btSelectAssembly.Location = new System.Drawing.Point(1186, 12);
            this.btSelectAssembly.Name = "btSelectAssembly";
            this.btSelectAssembly.Size = new System.Drawing.Size(174, 28);
            this.btSelectAssembly.TabIndex = 7;
            this.btSelectAssembly.Text = "Select Assembly...";
            this.btSelectAssembly.UseVisualStyleBackColor = true;
            this.btSelectAssembly.Click += new System.EventHandler(this.btSelectAssembly_Click);
            // 
            // tbAssemblyPath
            // 
            this.tbAssemblyPath.Location = new System.Drawing.Point(12, 13);
            this.tbAssemblyPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbAssemblyPath.Name = "tbAssemblyPath";
            this.tbAssemblyPath.Size = new System.Drawing.Size(1168, 27);
            this.tbAssemblyPath.TabIndex = 6;
            this.tbAssemblyPath.TextChanged += new System.EventHandler(this.tbAssemblyPath_TextChanged);
            // 
            // tbArgument
            // 
            this.tbArgument.Location = new System.Drawing.Point(884, 43);
            this.tbArgument.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbArgument.Name = "tbArgument";
            this.tbArgument.Size = new System.Drawing.Size(226, 27);
            this.tbArgument.TabIndex = 12;
            this.tbArgument.Text = "<Optional Argument>";
            this.tbArgument.TextChanged += new System.EventHandler(this.tbArgument_TextChanged);
            // 
            // cmbCLRVersion
            // 
            this.cmbCLRVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCLRVersion.FormattingEnabled = true;
            this.cmbCLRVersion.Items.AddRange(new object[] {
            "CLR 2.x",
            "CLR 4.x"});
            this.cmbCLRVersion.Location = new System.Drawing.Point(784, 43);
            this.cmbCLRVersion.Name = "cmbCLRVersion";
            this.cmbCLRVersion.Size = new System.Drawing.Size(94, 28);
            this.cmbCLRVersion.TabIndex = 13;
            // 
            // InjectingForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 82);
            this.Controls.Add(this.cmbCLRVersion);
            this.Controls.Add(this.tbArgument);
            this.Controls.Add(this.chkWaitReturn);
            this.Controls.Add(this.btInject);
            this.Controls.Add(this.cmbEntryPoint);
            this.Controls.Add(this.btSelectAssembly);
            this.Controls.Add(this.tbAssemblyPath);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.Icon = global::ExtremeDumper.Forms.Resources.Icon;
            this.Name = "InjectingForm";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.InjectingForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.InjectingForm_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkWaitReturn;
        private System.Windows.Forms.Button btInject;
        private System.Windows.Forms.ComboBox cmbEntryPoint;
        private System.Windows.Forms.Button btSelectAssembly;
        private System.Windows.Forms.TextBox tbAssemblyPath;
        private System.Windows.Forms.TextBox tbArgument;
        private System.Windows.Forms.OpenFileDialog odlgSelectAssembly;
		private System.Windows.Forms.ComboBox cmbCLRVersion;
	}
}
