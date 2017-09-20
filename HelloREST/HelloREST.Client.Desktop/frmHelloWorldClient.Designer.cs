namespace HelloREST.Client.Desktop
{
	partial class frmHelloWorldClient
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNama = new System.Windows.Forms.TextBox();
			this.lblRetVal = new System.Windows.Forms.Label();
			this.btnSend = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(127, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(362, 36);
			this.label1.TabIndex = 0;
			this.label1.Text = "Client Service Hello World";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(13, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 25);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nama";
			// 
			// txtNama
			// 
			this.txtNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNama.Location = new System.Drawing.Point(117, 57);
			this.txtNama.MaxLength = 20;
			this.txtNama.Name = "txtNama";
			this.txtNama.Size = new System.Drawing.Size(202, 30);
			this.txtNama.TabIndex = 2;
			// 
			// lblRetVal
			// 
			this.lblRetVal.AutoSize = true;
			this.lblRetVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRetVal.Location = new System.Drawing.Point(13, 104);
			this.lblRetVal.Name = "lblRetVal";
			this.lblRetVal.Size = new System.Drawing.Size(241, 25);
			this.lblRetVal.TabIndex = 3;
			this.lblRetVal.Text = "Return value tampil di sini..";
			// 
			// btnSend
			// 
			this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSend.Location = new System.Drawing.Point(359, 55);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(121, 35);
			this.btnSend.TabIndex = 4;
			this.btnSend.Text = "SEND";
			this.btnSend.UseVisualStyleBackColor = true;
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// btnReset
			// 
			this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReset.Location = new System.Drawing.Point(486, 55);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(121, 35);
			this.btnReset.TabIndex = 5;
			this.btnReset.Text = "RESET";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// frmHelloWorldClient
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(638, 153);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.btnSend);
			this.Controls.Add(this.lblRetVal);
			this.Controls.Add(this.txtNama);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmHelloWorldClient";
			this.Text = ".:: Hello World (REST)::.";
			this.Load += new System.EventHandler(this.frmHelloWorldClient_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNama;
		private System.Windows.Forms.Label lblRetVal;
		private System.Windows.Forms.Button btnSend;
		private System.Windows.Forms.Button btnReset;
	}
}

