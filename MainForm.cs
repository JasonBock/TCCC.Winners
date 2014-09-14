using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Spackle;

namespace TCCC.Winners
{
	public partial class MainForm 
		: Form
	{
		public MainForm()
		{
			this.InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			this.LoadAttendees();
		}

		private void LoadAttendees()
		{
			var registrations =
				new List<string>(File.ReadAllLines("Registrations.txt"));

			foreach(var registration in registrations)
			{
				this.attendeeList.Items.Add(registration);
			}
		}

		private void OnPickWinnerClick(object sender, EventArgs e)
		{
			if(this.attendeeList.Items.Count > 0)
			{
				var random = new SecureRandom();
				var nextWinnerIndex = random.Next(0, this.attendeeList.Items.Count);
				this.currentWinner.Text = (string)this.attendeeList.Items[nextWinnerIndex];
				this.attendeeList.Items.RemoveAt(nextWinnerIndex);
			}
		}
	}
}