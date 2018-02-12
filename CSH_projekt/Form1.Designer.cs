namespace CSH_projekt
{
	partial class Form1
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.zoomInButton = new System.Windows.Forms.Button();
			this.zoomOutButton = new System.Windows.Forms.Button();
			this.uploadImageButton = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(664, 537);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
			this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
			this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
			this.pictureBox1.Bounds = panel1.Bounds;
			// 
			// zoomInButton
			// 
			this.zoomInButton.Enabled = false;
			this.zoomInButton.Location = new System.Drawing.Point(688, 471);
			this.zoomInButton.Name = "zoomInButton";
			this.zoomInButton.Size = new System.Drawing.Size(23, 23);
			this.zoomInButton.TabIndex = 1;
			this.zoomInButton.Text = "+";
			this.zoomInButton.UseVisualStyleBackColor = true;
			this.zoomInButton.Click += new System.EventHandler(this.zoomInButton_Click);
			// 
			// zoomOutButton
			// 
			this.zoomOutButton.Enabled = false;
			this.zoomOutButton.Location = new System.Drawing.Point(687, 501);
			this.zoomOutButton.Name = "zoomOutButton";
			this.zoomOutButton.Size = new System.Drawing.Size(24, 23);
			this.zoomOutButton.TabIndex = 2;
			this.zoomOutButton.Text = "-";
			this.zoomOutButton.UseVisualStyleBackColor = true;
			this.zoomOutButton.Click += new System.EventHandler(this.zoomOutButton_Click);
			// 
			// uploadImageButton
			// 
			this.uploadImageButton.Location = new System.Drawing.Point(688, 12);
			this.uploadImageButton.Name = "uploadImageButton";
			this.uploadImageButton.Size = new System.Drawing.Size(75, 23);
			this.uploadImageButton.TabIndex = 3;
			this.uploadImageButton.Text = "Dodaj sliku";
			this.uploadImageButton.UseVisualStyleBackColor = true;
			this.uploadImageButton.Click += new System.EventHandler(this.uploadImageButton_Click);
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(670, 537);
			this.panel1.TabIndex = 4;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(826, 561);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.uploadImageButton);
			this.Controls.Add(this.zoomOutButton);
			this.Controls.Add(this.zoomInButton);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button zoomInButton;
		private System.Windows.Forms.Button zoomOutButton;
		private System.Windows.Forms.Button uploadImageButton;
		private System.Windows.Forms.Panel panel1;
	}
}

