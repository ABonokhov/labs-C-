
namespace lab7
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
			this.ColseForm = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ColseForm
			// 
			this.ColseForm.Location = new System.Drawing.Point(254, 133);
			this.ColseForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ColseForm.Name = "ColseForm";
			this.ColseForm.Size = new System.Drawing.Size(70, 19);
			this.ColseForm.TabIndex = 0;
			this.ColseForm.Text = "Close form";
			this.ColseForm.UseVisualStyleBackColor = true;
			this.ColseForm.Click += new System.EventHandler(this.ColseForm_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(593, 294);
			this.Controls.Add(this.ColseForm);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Location = new System.Drawing.Point(100, 200);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Trey Research";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button ColseForm;
	}
}



