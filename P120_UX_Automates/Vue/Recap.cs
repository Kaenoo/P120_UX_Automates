﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P120_UX_Automates.Vue
{
    public partial class Recap : Form
    {
        Controleur.ControlTickets _controller;
        public Controleur.ControlTickets Controller { get { return _controller; } set { _controller = value; } }

        public Recap()
        {
            InitializeComponent();
        }

        public void ShowTickets()
        {
            lbl_recap.Text = _controller.ShowTicketsData();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Hide();
            _controller.SwitchView("Menu");
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.Hide();
            _controller.SwitchView("typeOfPayment");
        }

        public void UpdateLang(ResourceManager RMANAGER)
        {
            ResourceManager rManager = RMANAGER;

            foreach (Control c in Controls)
            {
                if (rManager.GetString(c.Name) != null)
                {
                    c.Text = rManager.GetString(c.Name);
                }
            }
        }
    }
}
