﻿namespace NackademinUppgift05.UI
{
	partial class HomePage
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
			this.animalsListBox = new System.Windows.Forms.ListBox();
			this.animalCreateButton = new System.Windows.Forms.Button();
			this.animalDeleteButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// animalsListBox
			// 
			this.animalsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.animalsListBox.FormattingEnabled = true;
			this.animalsListBox.IntegralHeight = false;
			this.animalsListBox.Location = new System.Drawing.Point(12, 112);
			this.animalsListBox.Name = "animalsListBox";
			this.animalsListBox.Size = new System.Drawing.Size(383, 235);
			this.animalsListBox.TabIndex = 0;
			this.animalsListBox.DoubleClick += new System.EventHandler(this.animalsListBox_DoubleClick);
			// 
			// animalCreateButton
			// 
			this.animalCreateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.animalCreateButton.Location = new System.Drawing.Point(401, 112);
			this.animalCreateButton.Name = "animalCreateButton";
			this.animalCreateButton.Size = new System.Drawing.Size(103, 43);
			this.animalCreateButton.TabIndex = 1;
			this.animalCreateButton.Text = "New animal";
			this.animalCreateButton.UseVisualStyleBackColor = true;
			this.animalCreateButton.Click += new System.EventHandler(this.animalCreateButton_Click);
			// 
			// animalDeleteButton
			// 
			this.animalDeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.animalDeleteButton.Location = new System.Drawing.Point(401, 161);
			this.animalDeleteButton.Name = "animalDeleteButton";
			this.animalDeleteButton.Size = new System.Drawing.Size(103, 43);
			this.animalDeleteButton.TabIndex = 2;
			this.animalDeleteButton.Text = "Delete animal";
			this.animalDeleteButton.UseVisualStyleBackColor = true;
			this.animalDeleteButton.Click += new System.EventHandler(this.animalDeleteButton_Click);
			// 
			// HomePage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(654, 359);
			this.Controls.Add(this.animalDeleteButton);
			this.Controls.Add(this.animalCreateButton);
			this.Controls.Add(this.animalsListBox);
			this.Name = "HomePage";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Zoophobia";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox animalsListBox;
		private System.Windows.Forms.Button animalCreateButton;
		private System.Windows.Forms.Button animalDeleteButton;
	}
}

