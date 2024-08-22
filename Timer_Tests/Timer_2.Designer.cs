namespace Timer_Tests
{
	partial class Timer_2
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
			btnStart = new Button();
			lblTime = new Label();
			btnRemoveFive = new Button();
			btnAddFive = new Button();
			tmrMain = new System.Windows.Forms.Timer(components);
			btnPause = new Button();
			btnReset = new Button();
			SuspendLayout();
			// 
			// btnStart
			// 
			btnStart.Location = new Point(292, 7);
			btnStart.Name = "btnStart";
			btnStart.Size = new Size(75, 23);
			btnStart.TabIndex = 7;
			btnStart.Text = "Start";
			btnStart.UseVisualStyleBackColor = true;
			btnStart.Click += btnStart_Click;
			// 
			// lblTime
			// 
			lblTime.AutoSize = true;
			lblTime.Location = new Point(121, 11);
			lblTime.Name = "lblTime";
			lblTime.Size = new Size(128, 15);
			lblTime.TabIndex = 6;
			lblTime.Text = "000 minutes remaining";
			// 
			// btnRemoveFive
			// 
			btnRemoveFive.Location = new Point(84, 7);
			btnRemoveFive.Name = "btnRemoveFive";
			btnRemoveFive.Size = new Size(31, 23);
			btnRemoveFive.TabIndex = 5;
			btnRemoveFive.Text = "-5";
			btnRemoveFive.UseVisualStyleBackColor = true;
			btnRemoveFive.Click += btnRemoveFive_Click;
			// 
			// btnAddFive
			// 
			btnAddFive.Location = new Point(255, 7);
			btnAddFive.Name = "btnAddFive";
			btnAddFive.Size = new Size(31, 23);
			btnAddFive.TabIndex = 4;
			btnAddFive.Text = "+5";
			btnAddFive.UseVisualStyleBackColor = true;
			btnAddFive.Click += btnAddFive_Click;
			// 
			// tmrMain
			// 
			tmrMain.Interval = 60000;
			// 
			// btnPause
			// 
			btnPause.Location = new Point(3, 7);
			btnPause.Name = "btnPause";
			btnPause.Size = new Size(75, 23);
			btnPause.TabIndex = 8;
			btnPause.Text = "Pause";
			btnPause.UseVisualStyleBackColor = true;
			btnPause.Click += btnPause_Click;
			// 
			// btnReset
			// 
			btnReset.Location = new Point(373, 7);
			btnReset.Name = "btnReset";
			btnReset.Size = new Size(75, 23);
			btnReset.TabIndex = 9;
			btnReset.Text = "Reset";
			btnReset.UseVisualStyleBackColor = true;
			btnReset.Click += btnReset_Click;
			// 
			// Timer_2
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(btnReset);
			Controls.Add(btnPause);
			Controls.Add(btnStart);
			Controls.Add(lblTime);
			Controls.Add(btnRemoveFive);
			Controls.Add(btnAddFive);
			Name = "Timer_2";
			Size = new Size(470, 48);
			Load += Timer_2_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnStart;
		private Label lblTime;
		private Button btnRemoveFive;
		private Button btnAddFive;
		private System.Windows.Forms.Timer tmrMain;
		private Button btnPause;
		private Button btnReset;
	}
}
