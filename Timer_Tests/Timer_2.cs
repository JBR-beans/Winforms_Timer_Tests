using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer_Tests
{
	public partial class Timer_2 : UserControl
	{
		private int _elapsedtime; // in minutes
		private int _tmptime;
		private int _totaltime = 0;
		public Timer_2()
		{
			InitializeComponent();
		}

		private void Timer_2_Load(object sender, EventArgs e)
		{
			btnAddFive.Click += AddFiveMinutes;
			btnRemoveFive.Click += RemoveFiveMinutes;
			btnStart.Click += StartTimer;
			btnPause.Click += PauseTimer;
			btnReset.Click += ResetTimer;
			tmrMain.Tick += OneMinuteTick;


			ButtonResets(false, false, false, true, false);
			
			lblTime.Text = "00"+DisplayTimeRemaining();
		}

		private void ButtonResets(bool start, bool pause, bool reset, bool add5, bool remove5)
		{
			btnStart.Enabled = start;
			btnPause.Enabled = pause;
			btnReset.Enabled = reset;
			btnAddFive.Enabled = add5;
			btnRemoveFive.Enabled = remove5;
		}

		private string DisplayTimeRemaining()
		{
			string _timeremaining = (_totaltime-_elapsedtime).ToString()+" Minutes remaining";

			return _timeremaining;
		}

		private void ResetTimer(object sender, EventArgs e)
		{
			tmrMain.Stop();
			_elapsedtime = 0;
			_totaltime = 0;

			ButtonResets(false, false, false, true, false);

			lblTime.Text = DisplayTimeRemaining();
		}

		private void PauseTimer(object sender, EventArgs e)
		{
			tmrMain.Stop();
			ButtonResets(true, false, true, false, false);

		}

		private void OneMinuteTick(object sender, EventArgs e)
		{
			_elapsedtime += 1;
			lblTime.Text = DisplayTimeRemaining();
			if (_elapsedtime >= _totaltime)
			{
				TimesUp();
			}
		}

		private void TimesUp()
		{
			tmrMain.Stop();
			_tmptime = _elapsedtime;
			_elapsedtime = 0;

			ButtonResets(false, false, true, false, false);

			MessageBox.Show("Times up!");
		}
		private void StartTimer(object sender, EventArgs e)
		{
			tmrMain.Start();
			lblTime.Text = DisplayTimeRemaining();

			ButtonResets(false, true, true, false, false);

		}

		private void RemoveFiveMinutes(object sender, EventArgs e)
		{
			if (_totaltime <= 5)
			{
				ButtonResets(false, false, false, true, false);
				MessageBox.Show("Time must be at least 5 minutes.");
			}

			if (_totaltime > 5)
			{
				_totaltime -= 5;
				ButtonResets(true, false, false, true, true);
			}

			lblTime.Text = DisplayTimeRemaining();
		}

		private void AddFiveMinutes(object sender, EventArgs e)
		{
			_totaltime += 5;
			if (_totaltime < 5)
			{
				ButtonResets(false, false, false, true, false);
			}
			if (_totaltime >= 5)
			{
				ButtonResets(true, false, false, true, true);
			}
			lblTime.Text = DisplayTimeRemaining();
		}

		private void btnRemoveFive_Click(object sender, EventArgs e)
		{

		}

		private void btnAddFive_Click(object sender, EventArgs e)
		{

		}

		private void btnStart_Click(object sender, EventArgs e)
		{

		}

		private void btnPause_Click(object sender, EventArgs e)
		{

		}

		private void btnReset_Click(object sender, EventArgs e)
		{

		}
	}
}
