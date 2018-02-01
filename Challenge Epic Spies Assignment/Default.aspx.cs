using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Challenge_Epic_Spies_Assignment
{
	public partial class Default : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				Calendar1.SelectedDate = DateTime.Now.Date;
				Calendar2.SelectedDate = DateTime.Now.Date.AddDays(14);
				Calendar3.SelectedDate = DateTime.Now.Date.AddDays(21);
			}
		}

		protected void okButton_Click(object sender, EventArgs e)
		{
			//Spies cost $500 per day
			TimeSpan totalDurationOfAssignment = Calendar3.SelectedDate.Subtract(Calendar2.SelectedDate);
			double totalCost = totalDurationOfAssignment.TotalDays * 500.0;

			// if more than 3 weeks add $1000
			if (totalDurationOfAssignment.TotalDays > 21)
			{
				totalCost += 1000.0;
			}
				resultLabel.Text = String.Format("Assignment of {0} to assignment {1} is authorized. Budget total: {2:C}", 
					codeTextBox.Text, 
					newTextBox.Text, 
					totalCost);

			TimeSpan timeBetweenAssignments = Calendar2.SelectedDate.Subtract(Calendar1.SelectedDate);
			if (timeBetweenAssignments.TotalDays < 14)
			{
				resultLabel.Text = "Error must allow at least two weeks" +
					" between previous assignment and new assignment.";

				DateTime earliestNewAssignmentDate = Calendar1.SelectedDate.AddDays(14);
				Calendar2.SelectedDate = earliestNewAssignmentDate;
				Calendar2.VisibleDate = earliestNewAssignmentDate;

			}

		}
	}
}