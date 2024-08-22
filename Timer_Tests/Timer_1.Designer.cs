namespace Timer_Tests
{
	partial class Timer_1
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
			components = new System.ComponentModel.Container();
			btnAddFive = new Button();
			btnRemoveFive = new Button();
			lblTime = new Label();
			btnStart = new Button();
			tmrMain = new System.Windows.Forms.Timer(components);
			SuspendLayout();
			// 
			// btnAddFive
			// 
			btnAddFive.Location = new Point(172, 120);
			btnAddFive.Name = "btnAddFive";
			btnAddFive.Size = new Size(75, 23);
			btnAddFive.TabIndex = 0;
			btnAddFive.Text = "+5";
			btnAddFive.UseVisualStyleBackColor = true;

			// 
			// btnRemoveFive
			// 
			btnRemoveFive.Location = new Point(36, 120);
			btnRemoveFive.Name = "btnRemoveFive";
			btnRemoveFive.Size = new Size(75, 23);
			btnRemoveFive.TabIndex = 1;
			btnRemoveFive.Text = "-5";
			btnRemoveFive.UseVisualStyleBackColor = true;
			// 
			// lblTime
			// 
			lblTime.AutoSize = true;
			lblTime.Location = new Point(117, 124);
			lblTime.Name = "lblTime";
			lblTime.Size = new Size(49, 15);
			lblTime.TabIndex = 2;
			lblTime.Text = "00:00:00";
			// 
			// btnStart
			// 
			btnStart.Location = new Point(104, 149);
			btnStart.Name = "btnStart";
			btnStart.Size = new Size(75, 23);
			btnStart.TabIndex = 3;
			btnStart.Text = "Start";
			btnStart.UseVisualStyleBackColor = true;
			// 
			// tmrMain
			// 
			tmrMain.Interval = 300000;
			// 
			// Timer_1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(btnStart);
			Controls.Add(lblTime);
			Controls.Add(btnRemoveFive);
			Controls.Add(btnAddFive);
			Name = "Timer_1";
			Size = new Size(327, 319);
			Load += Timer_1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnAddFive;
		private Button btnRemoveFive;
		private Label lblTime;
		private Button btnStart;
		private System.Windows.Forms.Timer tmrMain;
	}
}
