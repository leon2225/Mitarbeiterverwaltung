﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mitarbeiterverwaltung.LL;

namespace Mitarbeiterverwaltung
{
    public partial class EditTimeSpanView : Form
    {
        public EditTimeSpanView()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public void changeToTime()
        {
            dtpBegin.Format = DateTimePickerFormat.Custom;
            dtpBegin.ShowUpDown = true;
            dtpBegin.CustomFormat = "HH:mm";
            dtpEnd.Format = DateTimePickerFormat.Custom;
            dtpEnd.ShowUpDown = true;
            dtpEnd.CustomFormat = "HH:mm";
        }

        public void changeToDate()
        {
            dtpBegin.Format = DateTimePickerFormat.Short;
            dtpBegin.ShowUpDown = false;
            dtpEnd.Format = DateTimePickerFormat.Short;
            dtpEnd.ShowUpDown= false;
        }

        public TimePeriod getTimePeriod()
        {
            var begin = dtpBegin.Value;
            var end = dtpEnd.Value;
            if (begin > end)
            {

                throw new WarningException("Der Anfangszeitpunkt muss vor dem Endzeitpunkt liegen");
            }
            else
            {
                return new TimePeriod(dtpBegin.Value, dtpEnd.Value);
            }

        }

    }
}
