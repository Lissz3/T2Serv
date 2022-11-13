namespace Ex1
{
	partial class Form2
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
			this.txbTxt = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txbTxt
			// 
			this.txbTxt.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txbTxt.Location = new System.Drawing.Point(0, 0);
			this.txbTxt.Multiline = true;
			this.txbTxt.Name = "txbTxt";
			this.txbTxt.Size = new System.Drawing.Size(361, 374);
			this.txbTxt.TabIndex = 0;
			this.txbTxt.TextChanged += new System.EventHandler(this.TxbTxt_TextChanged);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(361, 374);
			this.Controls.Add(this.txbTxt);
			this.Name = "Form2";
			this.Text = "Form2";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private TextBox textBox1;
		public TextBox txbTxt;
	}
}