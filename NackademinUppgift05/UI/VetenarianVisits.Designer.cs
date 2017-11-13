namespace NackademinUppgift05.UI
{
	partial class VetenarianVisits
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.visitsLabel = new System.Windows.Forms.Label();
			this.visitCancelButton = new System.Windows.Forms.Button();
			this.visitBookButton = new System.Windows.Forms.Button();
			this.visitsListBox = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// visitsLabel
			// 
			this.visitsLabel.AutoSize = true;
			this.visitsLabel.Location = new System.Drawing.Point(3, 0);
			this.visitsLabel.Name = "visitsLabel";
			this.visitsLabel.Size = new System.Drawing.Size(89, 13);
			this.visitsLabel.TabIndex = 22;
			this.visitsLabel.Text = "Veterinarian visits";
			// 
			// visitCancelButton
			// 
			this.visitCancelButton.Enabled = false;
			this.visitCancelButton.Location = new System.Drawing.Point(81, 14);
			this.visitCancelButton.Name = "visitCancelButton";
			this.visitCancelButton.Size = new System.Drawing.Size(75, 23);
			this.visitCancelButton.TabIndex = 21;
			this.visitCancelButton.Text = "Cancel visit";
			this.visitCancelButton.UseVisualStyleBackColor = true;
			// 
			// visitBookButton
			// 
			this.visitBookButton.Location = new System.Drawing.Point(0, 14);
			this.visitBookButton.Name = "visitBookButton";
			this.visitBookButton.Size = new System.Drawing.Size(75, 23);
			this.visitBookButton.TabIndex = 20;
			this.visitBookButton.Text = "Book visit";
			this.visitBookButton.UseVisualStyleBackColor = true;
			this.visitBookButton.Click += new System.EventHandler(this.visitsBookButton_Click);
			// 
			// visitsListBox
			// 
			this.visitsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.visitsListBox.FormattingEnabled = true;
			this.visitsListBox.IntegralHeight = false;
			this.visitsListBox.Location = new System.Drawing.Point(0, 43);
			this.visitsListBox.Name = "visitsListBox";
			this.visitsListBox.Size = new System.Drawing.Size(156, 27);
			this.visitsListBox.TabIndex = 19;
			this.visitsListBox.SelectedIndexChanged += new System.EventHandler(this.visitsListBox_SelectedIndexChanged);
			// 
			// VetenarianVisits
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.visitsLabel);
			this.Controls.Add(this.visitCancelButton);
			this.Controls.Add(this.visitBookButton);
			this.Controls.Add(this.visitsListBox);
			this.MaximumSize = new System.Drawing.Size(156, 2000000);
			this.MinimumSize = new System.Drawing.Size(156, 69);
			this.Name = "VetenarianVisits";
			this.Size = new System.Drawing.Size(156, 70);
			this.Load += new System.EventHandler(this.VetenarianVisits_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label visitsLabel;
		private System.Windows.Forms.Button visitCancelButton;
		private System.Windows.Forms.Button visitBookButton;
		private System.Windows.Forms.ListBox visitsListBox;
	}
}
