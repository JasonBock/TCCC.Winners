namespace TCCC.Winners
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.siteImage = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.attendeeList = new System.Windows.Forms.ListBox();
			this.pickWinner = new System.Windows.Forms.Button();
			this.currentWinner = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.siteImage)).BeginInit();
			this.SuspendLayout();
			// 
			// siteImage
			// 
			this.siteImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
							| System.Windows.Forms.AnchorStyles.Right)));
			this.siteImage.Image = ((System.Drawing.Image)(resources.GetObject("siteImage.Image")));
			this.siteImage.Location = new System.Drawing.Point(12, 12);
			this.siteImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.siteImage.Name = "siteImage";
			this.siteImage.Size = new System.Drawing.Size(682, 125);
			this.siteImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.siteImage.TabIndex = 0;
			this.siteImage.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(9, 283);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(79, 19);
			this.label1.TabIndex = 1;
			this.label1.Text = "Attendees:";
			// 
			// attendeeList
			// 
			this.attendeeList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
							| System.Windows.Forms.AnchorStyles.Left)
							| System.Windows.Forms.AnchorStyles.Right)));
			this.attendeeList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.attendeeList.FormattingEnabled = true;
			this.attendeeList.IntegralHeight = false;
			this.attendeeList.ItemHeight = 19;
			this.attendeeList.Location = new System.Drawing.Point(12, 305);
			this.attendeeList.Name = "attendeeList";
			this.attendeeList.Size = new System.Drawing.Size(683, 219);
			this.attendeeList.TabIndex = 2;
			// 
			// pickWinner
			// 
			this.pickWinner.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pickWinner.Location = new System.Drawing.Point(12, 150);
			this.pickWinner.Name = "pickWinner";
			this.pickWinner.Size = new System.Drawing.Size(134, 27);
			this.pickWinner.TabIndex = 3;
			this.pickWinner.Text = "Pick Winner";
			this.pickWinner.UseVisualStyleBackColor = true;
			this.pickWinner.Click += new System.EventHandler(this.OnPickWinnerClick);
			// 
			// currentWinner
			// 
			this.currentWinner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
							| System.Windows.Forms.AnchorStyles.Right)));
			this.currentWinner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.currentWinner.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.currentWinner.Location = new System.Drawing.Point(12, 187);
			this.currentWinner.Name = "currentWinner";
			this.currentWinner.Size = new System.Drawing.Size(683, 86);
			this.currentWinner.TabIndex = 4;
			this.currentWinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(706, 535);
			this.Controls.Add(this.currentWinner);
			this.Controls.Add(this.pickWinner);
			this.Controls.Add(this.attendeeList);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.siteImage);
			this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Twin Cities Code Camp Winners!";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this.siteImage)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox siteImage;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox attendeeList;
		private System.Windows.Forms.Button pickWinner;
		private System.Windows.Forms.Label currentWinner;
	}
}

