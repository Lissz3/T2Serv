namespace Ex1
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
			this.txbPath = new System.Windows.Forms.TextBox();
			this.btnIn = new System.Windows.Forms.Button();
			this.lbSubDir = new System.Windows.Forms.ListBox();
			this.lbFiles = new System.Windows.Forms.ListBox();
			this.lblDir = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblError = new System.Windows.Forms.Label();
			this.lblSize = new System.Windows.Forms.Label();
			this.btnChange = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txbPath
			// 
			this.txbPath.Location = new System.Drawing.Point(12, 12);
			this.txbPath.Name = "txbPath";
			this.txbPath.Size = new System.Drawing.Size(172, 23);
			this.txbPath.TabIndex = 0;
			// 
			// btnIn
			// 
			this.btnIn.Location = new System.Drawing.Point(190, 12);
			this.btnIn.Name = "btnIn";
			this.btnIn.Size = new System.Drawing.Size(75, 23);
			this.btnIn.TabIndex = 1;
			this.btnIn.Text = "Acceder";
			this.btnIn.UseVisualStyleBackColor = true;
			this.btnIn.Click += new System.EventHandler(this.BtnIn_Click);
			// 
			// lbSubDir
			// 
			this.lbSubDir.FormattingEnabled = true;
			this.lbSubDir.ItemHeight = 15;
			this.lbSubDir.Location = new System.Drawing.Point(12, 95);
			this.lbSubDir.Name = "lbSubDir";
			this.lbSubDir.Size = new System.Drawing.Size(259, 199);
			this.lbSubDir.TabIndex = 2;
			this.lbSubDir.Tag = "Sub";
			this.lbSubDir.SelectedIndexChanged += new System.EventHandler(this.LbSubDir_SelectedIndexChanged);
			this.lbSubDir.Enter += new System.EventHandler(this.LbSubDir_Enter);
			this.lbSubDir.Leave += new System.EventHandler(this.LbSubDir_Leave);
			this.lbSubDir.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MyMouseDoubleClick);
			// 
			// lbFiles
			// 
			this.lbFiles.FormattingEnabled = true;
			this.lbFiles.ItemHeight = 15;
			this.lbFiles.Location = new System.Drawing.Point(287, 95);
			this.lbFiles.Name = "lbFiles";
			this.lbFiles.Size = new System.Drawing.Size(259, 199);
			this.lbFiles.TabIndex = 3;
			this.lbFiles.Tag = "File";
			this.lbFiles.SelectedIndexChanged += new System.EventHandler(this.LbFiles_SelectedIndexChanged);
			// 
			// lblDir
			// 
			this.lblDir.AutoSize = true;
			this.lblDir.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblDir.Location = new System.Drawing.Point(8, 38);
			this.lblDir.Name = "lblDir";
			this.lblDir.Size = new System.Drawing.Size(161, 25);
			this.lblDir.TabIndex = 4;
			this.lblDir.Text = "Directorio actual: ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 77);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(86, 15);
			this.label2.TabIndex = 5;
			this.label2.Text = "Subdirectorios:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(284, 77);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(54, 15);
			this.label3.TabIndex = 6;
			this.label3.Text = "Ficheros:";
			// 
			// lblError
			// 
			this.lblError.AutoSize = true;
			this.lblError.ForeColor = System.Drawing.Color.Red;
			this.lblError.Location = new System.Drawing.Point(271, 15);
			this.lblError.Name = "lblError";
			this.lblError.Size = new System.Drawing.Size(0, 15);
			this.lblError.TabIndex = 7;
			// 
			// lblSize
			// 
			this.lblSize.AutoSize = true;
			this.lblSize.Location = new System.Drawing.Point(287, 300);
			this.lblSize.Name = "lblSize";
			this.lblSize.Size = new System.Drawing.Size(113, 15);
			this.lblSize.TabIndex = 8;
			this.lblSize.Text = "Tamaño del archivo:";
			// 
			// btnChange
			// 
			this.btnChange.AutoSize = true;
			this.btnChange.Location = new System.Drawing.Point(74, 300);
			this.btnChange.Name = "btnChange";
			this.btnChange.Size = new System.Drawing.Size(132, 25);
			this.btnChange.TabIndex = 9;
			this.btnChange.Text = "Cambiar de directorio";
			this.btnChange.UseVisualStyleBackColor = true;
			this.btnChange.Click += new System.EventHandler(this.BtnChange_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(558, 330);
			this.Controls.Add(this.btnChange);
			this.Controls.Add(this.lblSize);
			this.Controls.Add(this.lblError);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblDir);
			this.Controls.Add(this.lbFiles);
			this.Controls.Add(this.lbSubDir);
			this.Controls.Add(this.btnIn);
			this.Controls.Add(this.txbPath);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private TextBox txbPath;
		private Button btnIn;
		private ListBox lbSubDir;
		private ListBox lbFiles;
		private Label lblDir;
		private Label label2;
		private Label label3;
		private Label lblError;
		private Label lblSize;
		private Button btnChange;
	}
}