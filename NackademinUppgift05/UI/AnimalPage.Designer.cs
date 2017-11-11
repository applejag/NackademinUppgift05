namespace NackademinUppgift05.UI
{
	partial class AnimalPage
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
			this.animalNameTextBox = new System.Windows.Forms.TextBox();
			this.animalOriginTextBox = new System.Windows.Forms.TextBox();
			this.animalWeightTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.submitButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.animalSpeciesLabel = new System.Windows.Forms.Label();
			this.animalSpeciesComboBox = new NackademinUppgift05.UI.SpeciesComboBox();
			this.SuspendLayout();
			// 
			// animalNameTextBox
			// 
			this.animalNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.animalNameTextBox.Location = new System.Drawing.Point(12, 25);
			this.animalNameTextBox.Name = "animalNameTextBox";
			this.animalNameTextBox.Size = new System.Drawing.Size(303, 20);
			this.animalNameTextBox.TabIndex = 0;
			// 
			// animalOriginTextBox
			// 
			this.animalOriginTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.animalOriginTextBox.Location = new System.Drawing.Point(12, 64);
			this.animalOriginTextBox.Name = "animalOriginTextBox";
			this.animalOriginTextBox.Size = new System.Drawing.Size(303, 20);
			this.animalOriginTextBox.TabIndex = 1;
			// 
			// animalWeightTextBox
			// 
			this.animalWeightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.animalWeightTextBox.Location = new System.Drawing.Point(12, 103);
			this.animalWeightTextBox.Name = "animalWeightTextBox";
			this.animalWeightTextBox.Size = new System.Drawing.Size(303, 20);
			this.animalWeightTextBox.TabIndex = 2;
			this.animalWeightTextBox.Text = "0";
			this.animalWeightTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.animalWeightTextBox_Validating);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(34, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Origin";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 87);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Weight";
			// 
			// submitButton
			// 
			this.submitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.submitButton.Location = new System.Drawing.Point(240, 256);
			this.submitButton.Name = "submitButton";
			this.submitButton.Size = new System.Drawing.Size(75, 23);
			this.submitButton.TabIndex = 6;
			this.submitButton.Text = "Submit";
			this.submitButton.UseVisualStyleBackColor = true;
			this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new System.Drawing.Point(159, 256);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 7;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			// 
			// animalSpeciesLabel
			// 
			this.animalSpeciesLabel.AutoSize = true;
			this.animalSpeciesLabel.Location = new System.Drawing.Point(12, 126);
			this.animalSpeciesLabel.Name = "animalSpeciesLabel";
			this.animalSpeciesLabel.Size = new System.Drawing.Size(45, 13);
			this.animalSpeciesLabel.TabIndex = 8;
			this.animalSpeciesLabel.Text = "Species";
			// 
			// animalSpeciesComboBox
			// 
			this.animalSpeciesComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.animalSpeciesComboBox.Location = new System.Drawing.Point(12, 143);
			this.animalSpeciesComboBox.MaximumSize = new System.Drawing.Size(500, 21);
			this.animalSpeciesComboBox.Name = "animalSpeciesComboBox";
			this.animalSpeciesComboBox.Size = new System.Drawing.Size(303, 21);
			this.animalSpeciesComboBox.TabIndex = 9;
			this.animalSpeciesComboBox.Load += new System.EventHandler(this.speciesComboBox1_Load);
			// 
			// AnimalPage
			// 
			this.AcceptButton = this.submitButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(327, 291);
			this.Controls.Add(this.animalSpeciesComboBox);
			this.Controls.Add(this.animalSpeciesLabel);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.submitButton);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.animalWeightTextBox);
			this.Controls.Add(this.animalOriginTextBox);
			this.Controls.Add(this.animalNameTextBox);
			this.Name = "AnimalPage";
			this.Text = "AnimalPage";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox animalNameTextBox;
		private System.Windows.Forms.TextBox animalOriginTextBox;
		private System.Windows.Forms.TextBox animalWeightTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button submitButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Label animalSpeciesLabel;
		private SpeciesComboBox animalSpeciesComboBox;
	}
}