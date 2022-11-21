namespace Ex2
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
			this.lblPath = new System.Windows.Forms.Label();
			this.txbPath = new System.Windows.Forms.TextBox();
			this.txbForSearch = new System.Windows.Forms.TextBox();
			this.lblSentence = new System.Windows.Forms.Label();
			this.lbAppearings = new System.Windows.Forms.ListBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.cbxCaseSensitive = new System.Windows.Forms.CheckBox();
			this.lblError = new System.Windows.Forms.Label();
			this.lblFilter = new System.Windows.Forms.Label();
			this.txbFilters = new System.Windows.Forms.TextBox();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblPath
			// 
			this.lblPath.AutoSize = true;
			this.lblPath.Location = new System.Drawing.Point(12, 9);
			this.lblPath.Name = "lblPath";
			this.lblPath.Size = new System.Drawing.Size(62, 15);
			this.lblPath.TabIndex = 0;
			this.lblPath.Text = "Directorio:";
			// 
			// txbPath
			// 
			this.txbPath.Location = new System.Drawing.Point(12, 27);
			this.txbPath.Name = "txbPath";
			this.txbPath.Size = new System.Drawing.Size(156, 23);
			this.txbPath.TabIndex = 1;
			this.txbPath.Text = "C:\\Users\\bdisa\\OneDrive\\Escritorio";
			this.txbPath.Enter += new System.EventHandler(this.SearchEnter);
			// 
			// txbForSearch
			// 
			this.txbForSearch.Location = new System.Drawing.Point(181, 27);
			this.txbForSearch.Name = "txbForSearch";
			this.txbForSearch.Size = new System.Drawing.Size(156, 23);
			this.txbForSearch.TabIndex = 2;
			this.txbForSearch.Enter += new System.EventHandler(this.SearchEnter);
			// 
			// lblSentence
			// 
			this.lblSentence.AutoSize = true;
			this.lblSentence.Location = new System.Drawing.Point(181, 9);
			this.lblSentence.Name = "lblSentence";
			this.lblSentence.Size = new System.Drawing.Size(128, 15);
			this.lblSentence.TabIndex = 3;
			this.lblSentence.Text = "Frase/palabra a buscar:";
			// 
			// lbAppearings
			// 
			this.lbAppearings.FormattingEnabled = true;
			this.lbAppearings.HorizontalScrollbar = true;
			this.lbAppearings.ItemHeight = 15;
			this.lbAppearings.Location = new System.Drawing.Point(12, 85);
			this.lbAppearings.Name = "lbAppearings";
			this.lbAppearings.Size = new System.Drawing.Size(496, 244);
			this.lbAppearings.TabIndex = 6;
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(181, 56);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(156, 23);
			this.btnSearch.TabIndex = 5;
			this.btnSearch.Text = "Búsqueda";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
			// 
			// cbxCaseSensitive
			// 
			this.cbxCaseSensitive.AutoSize = true;
			this.cbxCaseSensitive.Location = new System.Drawing.Point(12, 59);
			this.cbxCaseSensitive.Name = "cbxCaseSensitive";
			this.cbxCaseSensitive.Size = new System.Drawing.Size(108, 19);
			this.cbxCaseSensitive.TabIndex = 4;
			this.cbxCaseSensitive.Text = "Sensible al caso";
			this.cbxCaseSensitive.UseVisualStyleBackColor = true;
			// 
			// lblError
			// 
			this.lblError.AutoSize = true;
			this.lblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lblError.Location = new System.Drawing.Point(12, 340);
			this.lblError.Name = "lblError";
			this.lblError.Size = new System.Drawing.Size(0, 15);
			this.lblError.TabIndex = 7;
			// 
			// lblFilter
			// 
			this.lblFilter.AutoSize = true;
			this.lblFilter.Location = new System.Drawing.Point(352, 9);
			this.lblFilter.Name = "lblFilter";
			this.lblFilter.Size = new System.Drawing.Size(42, 15);
			this.lblFilter.TabIndex = 9;
			this.lblFilter.Text = "Filtros:";
			// 
			// txbFilters
			// 
			this.txbFilters.Location = new System.Drawing.Point(352, 27);
			this.txbFilters.Name = "txbFilters";
			this.txbFilters.Size = new System.Drawing.Size(156, 23);
			this.txbFilters.TabIndex = 3;
			this.txbFilters.Enter += new System.EventHandler(this.TxbFilters_Enter);
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(352, 56);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(156, 23);
			this.btnGuardar.TabIndex = 5;
			this.btnGuardar.Text = "Guardar filtros";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(523, 364);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.lblFilter);
			this.Controls.Add(this.txbFilters);
			this.Controls.Add(this.lblError);
			this.Controls.Add(this.cbxCaseSensitive);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.lbAppearings);
			this.Controls.Add(this.lblSentence);
			this.Controls.Add(this.txbForSearch);
			this.Controls.Add(this.txbPath);
			this.Controls.Add(this.lblPath);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label lblPath;
		private TextBox txbPath;
		private TextBox txbForSearch;
		private Label lblSentence;
		private ListBox lbAppearings;
		private Button btnSearch;
		private CheckBox cbxCaseSensitive;
		private Label lblError;
		private Label lblFilter;
		private TextBox txbFilters;
		private Button btnGuardar;
	}
}