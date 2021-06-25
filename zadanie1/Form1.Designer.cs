
namespace zadanie1
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
			this.label1 = new System.Windows.Forms.Label();
			this.sumZaim = new System.Windows.Forms.TextBox();
			this.daysZaim = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dayAndProcentText = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.doButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(167, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(158, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Сумма займа в рублях.";
			// 
			// sumZaim
			// 
			this.sumZaim.Location = new System.Drawing.Point(170, 67);
			this.sumZaim.Name = "sumZaim";
			this.sumZaim.Size = new System.Drawing.Size(155, 22);
			this.sumZaim.TabIndex = 1;
			// 
			// daysZaim
			// 
			this.daysZaim.Location = new System.Drawing.Point(170, 122);
			this.daysZaim.Name = "daysZaim";
			this.daysZaim.Size = new System.Drawing.Size(155, 22);
			this.daysZaim.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(167, 102);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(133, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Срок займа в днях.";
			// 
			// dayAndProcentText
			// 
			this.dayAndProcentText.Location = new System.Drawing.Point(170, 174);
			this.dayAndProcentText.Multiline = true;
			this.dayAndProcentText.Name = "dayAndProcentText";
			this.dayAndProcentText.Size = new System.Drawing.Size(155, 22);
			this.dayAndProcentText.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(167, 154);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(260, 17);
			this.label3.TabIndex = 4;
			this.label3.Text = "Проценты по дням(по умолчанию 9%)";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// doButton
			// 
			this.doButton.Location = new System.Drawing.Point(170, 218);
			this.doButton.Name = "doButton";
			this.doButton.Size = new System.Drawing.Size(155, 23);
			this.doButton.TabIndex = 6;
			this.doButton.Tag = "";
			this.doButton.Text = "Рассчитать";
			this.doButton.UseVisualStyleBackColor = true;
			this.doButton.Click += new System.EventHandler(this.doButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.doButton);
			this.Controls.Add(this.dayAndProcentText);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.daysZaim);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.sumZaim);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox sumZaim;
		private System.Windows.Forms.TextBox daysZaim;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox dayAndProcentText;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button doButton;
	}
}

