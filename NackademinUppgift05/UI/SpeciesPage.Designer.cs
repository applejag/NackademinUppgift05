namespace NackademinUppgift05.UI
{
	partial class SpeciesPage
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
			this.speciesListBox = new System.Windows.Forms.ListBox();
			this.speciesDeleteButton = new System.Windows.Forms.Button();
			this.speciesCreateButton = new System.Windows.Forms.Button();
			this.speciesLabelTextBox = new System.Windows.Forms.TextBox();
			this.speciesEaterTypeComboBox = new System.Windows.Forms.ComboBox();
			this.speciesEnvironmentComboBox = new System.Windows.Forms.ComboBox();
			this.speciesLabelLabel = new System.Windows.Forms.Label();
			this.speciesEaterTypeLabel = new System.Windows.Forms.Label();
			this.speciesEnvironmentLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// speciesListBox
			// 
			this.speciesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.speciesListBox.FormattingEnabled = true;
			this.speciesListBox.IntegralHeight = false;
			this.speciesListBox.Location = new System.Drawing.Point(12, 139);
			this.speciesListBox.Name = "speciesListBox";
			this.speciesListBox.Size = new System.Drawing.Size(250, 132);
			this.speciesListBox.Sorted = true;
			this.speciesListBox.TabIndex = 1;
			this.speciesListBox.SelectedIndexChanged += new System.EventHandler(this.speciesListBox_SelectedIndexChanged);
			// 
			// speciesDeleteButton
			// 
			this.speciesDeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.speciesDeleteButton.Enabled = false;
			this.speciesDeleteButton.Location = new System.Drawing.Point(187, 111);
			this.speciesDeleteButton.Name = "speciesDeleteButton";
			this.speciesDeleteButton.Size = new System.Drawing.Size(75, 23);
			this.speciesDeleteButton.TabIndex = 2;
			this.speciesDeleteButton.Text = "Delete";
			this.speciesDeleteButton.UseVisualStyleBackColor = true;
			this.speciesDeleteButton.Click += new System.EventHandler(this.speciesDeleteButton_Click);
			// 
			// speciesCreateButton
			// 
			this.speciesCreateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.speciesCreateButton.Location = new System.Drawing.Point(187, 82);
			this.speciesCreateButton.Name = "speciesCreateButton";
			this.speciesCreateButton.Size = new System.Drawing.Size(75, 23);
			this.speciesCreateButton.TabIndex = 3;
			this.speciesCreateButton.Text = "New";
			this.speciesCreateButton.UseVisualStyleBackColor = true;
			this.speciesCreateButton.Click += new System.EventHandler(this.speciesCreateButton_Click);
			// 
			// speciesLabelTextBox
			// 
			this.speciesLabelTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.speciesLabelTextBox.Location = new System.Drawing.Point(12, 25);
			this.speciesLabelTextBox.MaxLength = 255;
			this.speciesLabelTextBox.Name = "speciesLabelTextBox";
			this.speciesLabelTextBox.Size = new System.Drawing.Size(169, 20);
			this.speciesLabelTextBox.TabIndex = 4;
			// 
			// speciesEaterTypeComboBox
			// 
			this.speciesEaterTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.speciesEaterTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.speciesEaterTypeComboBox.FormattingEnabled = true;
			this.speciesEaterTypeComboBox.Location = new System.Drawing.Point(12, 68);
			this.speciesEaterTypeComboBox.Name = "speciesEaterTypeComboBox";
			this.speciesEaterTypeComboBox.Size = new System.Drawing.Size(169, 21);
			this.speciesEaterTypeComboBox.Sorted = true;
			this.speciesEaterTypeComboBox.TabIndex = 5;
			// 
			// speciesEnvironmentComboBox
			// 
			this.speciesEnvironmentComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.speciesEnvironmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.speciesEnvironmentComboBox.FormattingEnabled = true;
			this.speciesEnvironmentComboBox.Location = new System.Drawing.Point(12, 112);
			this.speciesEnvironmentComboBox.Name = "speciesEnvironmentComboBox";
			this.speciesEnvironmentComboBox.Size = new System.Drawing.Size(169, 21);
			this.speciesEnvironmentComboBox.Sorted = true;
			this.speciesEnvironmentComboBox.TabIndex = 6;
			// 
			// speciesLabelLabel
			// 
			this.speciesLabelLabel.AutoSize = true;
			this.speciesLabelLabel.Location = new System.Drawing.Point(12, 9);
			this.speciesLabelLabel.Name = "speciesLabelLabel";
			this.speciesLabelLabel.Size = new System.Drawing.Size(74, 13);
			this.speciesLabelLabel.TabIndex = 7;
			this.speciesLabelLabel.Text = "Species name";
			// 
			// speciesEaterTypeLabel
			// 
			this.speciesEaterTypeLabel.AutoSize = true;
			this.speciesEaterTypeLabel.Location = new System.Drawing.Point(12, 52);
			this.speciesEaterTypeLabel.Name = "speciesEaterTypeLabel";
			this.speciesEaterTypeLabel.Size = new System.Drawing.Size(55, 13);
			this.speciesEaterTypeLabel.TabIndex = 8;
			this.speciesEaterTypeLabel.Text = "Eater type";
			// 
			// speciesEnvironmentLabel
			// 
			this.speciesEnvironmentLabel.AutoSize = true;
			this.speciesEnvironmentLabel.Location = new System.Drawing.Point(13, 96);
			this.speciesEnvironmentLabel.Name = "speciesEnvironmentLabel";
			this.speciesEnvironmentLabel.Size = new System.Drawing.Size(66, 13);
			this.speciesEnvironmentLabel.TabIndex = 9;
			this.speciesEnvironmentLabel.Text = "Environment";
			// 
			// SpeciesPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(274, 283);
			this.Controls.Add(this.speciesEnvironmentLabel);
			this.Controls.Add(this.speciesEaterTypeLabel);
			this.Controls.Add(this.speciesLabelLabel);
			this.Controls.Add(this.speciesEnvironmentComboBox);
			this.Controls.Add(this.speciesEaterTypeComboBox);
			this.Controls.Add(this.speciesLabelTextBox);
			this.Controls.Add(this.speciesCreateButton);
			this.Controls.Add(this.speciesDeleteButton);
			this.Controls.Add(this.speciesListBox);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(214, 259);
			this.Name = "SpeciesPage";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Edit species";
			this.Load += new System.EventHandler(this.SpeciesPage_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ListBox speciesListBox;
		private System.Windows.Forms.Button speciesDeleteButton;
		private System.Windows.Forms.Button speciesCreateButton;
		private System.Windows.Forms.TextBox speciesLabelTextBox;
		private System.Windows.Forms.ComboBox speciesEaterTypeComboBox;
		private System.Windows.Forms.ComboBox speciesEnvironmentComboBox;
		private System.Windows.Forms.Label speciesLabelLabel;
		private System.Windows.Forms.Label speciesEaterTypeLabel;
		private System.Windows.Forms.Label speciesEnvironmentLabel;
	}
}