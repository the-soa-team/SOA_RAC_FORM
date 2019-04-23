﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SOA_RAC_Form_App.CarService;
using SOA_RAC_Form_App.Enums;
using AirgBagEnum = SOA_RAC_Form_App.CarService.AirgBagEnum;

namespace SOA_RAC_Form_App
{
    public partial class Cars : Form
    {
        public Cars()
        {
            InitializeComponent();
        }

        private void ListBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var CarsSoapClient = new CarsClient())
                {
                    List<Car> cars = new List<Car>();
                    foreach (Car car in CarsSoapClient.ListCars(null))
                    {

                        cars.Add(car);
                    }

                    CompaniesGridView.DataSource = cars.ToList();
                    CompaniesGridView.Columns["ID"].DisplayIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error happened: " + ex.Message);
            }

        }

        private void CompaniesGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (CompaniesGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow row = CompaniesGridView.SelectedRows[0];
                Console.WriteLine(row.Cells["ID"].Value);
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
