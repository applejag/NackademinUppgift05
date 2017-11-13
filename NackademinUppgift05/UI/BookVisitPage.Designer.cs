namespace NackademinUppgift05.UI
{
	partial class BookVisitPage
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
			this.veterinariansComboBox = new System.Windows.Forms.ComboBox();
			this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.veterinariansLabel = new System.Windows.Forms.Label();
			this.dateTimeLabel = new System.Windows.Forms.Label();
			this.buttonOK = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// veterinariansComboBox
			// 
			this.veterinariansComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.veterinariansComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.veterinariansComboBox.FormattingEnabled = true;
			this.veterinariansComboBox.Location = new System.Drawing.Point(12, 29);
			this.veterinariansComboBox.Name = "veterinariansComboBox";
			this.veterinariansComboBox.Size = new System.Drawing.Size(260, 21);
			this.veterinariansComboBox.TabIndex = 0;
			// 
			// dateTimePicker
			// 
			this.dateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dateTimePicker.Location = new System.Drawing.Point(12, 73);
			this.dateTimePicker.Name = "dateTimePicker";
			this.dateTimePicker.Size = new System.Drawing.Size(260, 20);
			this.dateTimePicker.TabIndex = 1;
			// 
			// veterinariansLabel
			// 
			this.veterinariansLabel.AutoSize = true;
			this.veterinariansLabel.Location = new System.Drawing.Point(12, 13);
			this.veterinariansLabel.Name = "veterinariansLabel";
			this.veterinariansLabel.Size = new System.Drawing.Size(63, 13);
			this.veterinariansLabel.TabIndex = 2;
			this.veterinariansLabel.Text = "Veterinarian";
			// 
			// dateTimeLabel
			// 
			this.dateTimeLabel.AutoSize = true;
			this.dateTimeLabel.Location = new System.Drawing.Point(12, 57);
			this.dateTimeLabel.Name = "dateTimeLabel";
			this.dateTimeLabel.Size = new System.Drawing.Size(30, 13);
			this.dateTimeLabel.TabIndex = 3;
			this.dateTimeLabel.Text = "Date";
			// 
			// buttonOK
			// 
			this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonOK.Location = new System.Drawing.Point(196, 110);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 4;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCancel.Location = new System.Drawing.Point(115, 110);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 5;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// BookVisitPage
			// 
			this.AcceptButton = this.buttonOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(284, 145);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.dateTimeLabel);
			this.Controls.Add(this.veterinariansLabel);
			this.Controls.Add(this.dateTimePicker);
			this.Controls.Add(this.veterinariansComboBox);
			this.MinimumSize = new System.Drawing.Size(300, 184);
			this.Name = "BookVisitPage";
			this.Text = "Book veterinarian visit";
			this.Load += new System.EventHandler(this.BookVisitPage_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox veterinariansComboBox;
		private System.Windows.Forms.DateTimePicker dateTimePicker;
		private System.Windows.Forms.Label veterinariansLabel;
		private System.Windows.Forms.Label dateTimeLabel;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Button buttonCancel;
	}
}