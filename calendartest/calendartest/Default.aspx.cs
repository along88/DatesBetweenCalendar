﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace calendartest
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Calendar1.SelectedDate = DateTime.Now.Date;
                Calendar2.SelectedDate = DateTime.Now.Date;
            }
        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            if (Calendar1.SelectedDate > Calendar2.SelectedDate)
            {
                resultLabel.Text = Calendar1.SelectedDate.Subtract(Calendar2.SelectedDate).TotalDays.ToString();
            }
            else if (Calendar2.SelectedDate > Calendar1.SelectedDate)
            {
                resultLabel.Text = Calendar2.SelectedDate.Subtract(Calendar1.SelectedDate).TotalDays.ToString();
            }
            else if (Calendar1.SelectedDate == Calendar2.SelectedDate)
            {
                resultLabel.Text = Calendar1.SelectedDate.Subtract(Calendar2.SelectedDate).TotalDays.ToString();
            }
            else
                resultLabel.Text = string.Format("Something went wrong, please pick a date from both calendars and try again");
        }

    }
}