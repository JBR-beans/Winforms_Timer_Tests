using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer_Tests
{
	public partial class Timer_1 : UserControl
	{
		// 300,000 milliseconds (300 seconds) is 5 minutes

		private TimeOnly _maxtime;
		private TimeOnly _elapsedtime;
		private Stopwatch _stopwatch;
		public Timer_1()
		{
			InitializeComponent();

		}

		private void Timer_1_Load(object sender, EventArgs e)
		{
			//lblTime.Text = string.Format("{0}:{1}:{2}", DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);

			btnAddFive.Click += AddFiveMinutes;
			btnRemoveFive.Click += RemoveFiveMinutes;
			btnStart.Click += StartTimer;
			// 300,000 milliseconds/5 minutes interval
			tmrMain.Tick += MainTimerTick;

			lblTime.Text = _maxtime.ToString();

			
		}

		private void MainTimerTick(object sender, EventArgs e)
		{
			TimeOnly tmp = new TimeOnly();
			tmp = _elapsedtime.AddMinutes(5);

			_elapsedtime = new TimeOnly();
			_elapsedtime = tmp;

			lblTime.Text += _elapsedtime.ToString();
		}

		public void StartTimer(object sender, EventArgs e)
		{
			tmrMain.Start();
			MessageBox.Show("Timer started.");
		}

		public void AddFiveMinutes(object sender, EventArgs e)
		{
			// TimeOnly is immutable, so it can never be modified
			// you have to make a new instance to assign a value

			// assign current value to new tmp, process 5 new minutes to it
			// ass tmp to new _maxtime, _maxtime can be reused when tmp is created again

			// https://stackoverflow.com/questions/8269622/datetime-addminutes-method-not-working

			TimeOnly tmp = _maxtime.AddMinutes(5);
			_maxtime = new TimeOnly();
			_maxtime = tmp;
			lblTime.Text = tmp.ToString();
		}

		public void RemoveFiveMinutes(object sender, EventArgs e)
		{
			TimeOnly tmp = _maxtime.AddMinutes(-5);
			_maxtime = new TimeOnly();
			_maxtime = tmp;
			lblTime.Text = _maxtime.ToString();
		}
	}
}
