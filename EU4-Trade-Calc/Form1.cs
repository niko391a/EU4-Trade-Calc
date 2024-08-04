using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EU4_Trade_Calc
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void downstreamTextBox_TextChanged(object sender, EventArgs e)
        {
            CalculateTrade();
        }
        private void upstreamTextBox_TextChanged(object sender, EventArgs e)
        {
            CalculateTrade();
        }
        public void CalculateTrade() {
            // Calculate trade
            try
            {
                if (upstreamTextBox.Text.Length > 0 && downstreamTextBox.Text.Length > 0)
                {
                    double currentTradeShare = Convert.ToDouble(upstreamTextBox.Text) / 100;
                    double downstreamTradeShare = Convert.ToDouble(downstreamTextBox.Text) / 100;
                    double tradePower = 1 / (2 - currentTradeShare);
                    if (currentTradeShare >= 0 && currentTradeShare <= 1 && downstreamTradeShare >= 0 && downstreamTradeShare <= 1)
                    {
                        if (downstreamTradeShare < tradePower) labelResult.Text = "Collect in the target node!";
                        else labelResult.Text = "Steer to next node!";
                    }

                }
            }
            catch (Exception e)
            {
                // Do no thing
            }
                                  
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
                // URL to open
                string url = "https://www.reddit.com/r/eu4/comments/v6bg3p/biggest_myth_in_eu4_click_to_save_braincells/";

                // Open the URL in the default web browser
                try
                {
                    Process.Start(url);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to open URL. Error: {ex.Message}");
                }
            }
       
    }
}
