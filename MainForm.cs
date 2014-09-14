using JasonBock.SecureRandomNumberGenerator;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace TCCC.Winners
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			this.LoadAttendees();
		}

		private void LoadAttendees()
		{
			List<string> registrations =
				new List<string>(File.ReadAllLines("Registrations.txt"));

			foreach(string registration in registrations)
			{
				this.attendeeList.Items.Add(registration);
			}
		}

		private void OnPickWinnerClick(object sender, EventArgs e)
		{
			if(this.attendeeList.Items.Count > 0)
			{
				SecureRandom random = new SecureRandom();
				int nextWinnerIndex = random.Next(0, this.attendeeList.Items.Count);
				this.currentWinner.Text = (string)this.attendeeList.Items[nextWinnerIndex];
				this.attendeeList.Items.RemoveAt(nextWinnerIndex);
			}
		}
	}
}