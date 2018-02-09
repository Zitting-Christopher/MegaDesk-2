using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_ChrisZitting
{
    public class DeskQuote
    {
        private const double BASE_PRICE = 200;
        private const double COST_DRAWER = 50;
        private const double AREA_THRESHOLD = 1000; //Inches squared for the area of desk
        private const double EXCESS_SURF_AREA = 1; //Cost per square inch over threshold
        private const string RUSH1 = "3";
        private const string RUSH2 = "5";
        private const string RUSH3 = "7";
        private const int RUSH_THRESHOLD = 2000; //Inches squared area of desk

        //Desk quote variables
        private string CustomerName { get; set; }
        private DateTime QuoteDate { get; set; }
        private string RushDays { get; set; }
        private Desk Desk = new Desk();
        private double QuoteAmount { get; set; }

        //local variables
        private double SurfaceArea = 0;

        public DeskQuote(string customerName, string rushDays, double width, double depth, int numOfDrawers, SurfaceMaterial material)
        {
            CustomerName = customerName;
            RushDays = rushDays;
            Desk.Width = width;
            Desk.Depth = depth;
            Desk.NumDrawers = numOfDrawers;
            Desk.Material = material;

            //Calculate SurfaceArea
            SurfaceArea = Desk.Width * Desk.Depth;
        }

        public double CalculateAreaCost()
        {
            if (SurfaceArea > AREA_THRESHOLD)
            {
                return (SurfaceArea - AREA_THRESHOLD) * EXCESS_SURF_AREA;
            }
            else
            {
                return 0;
            }
        }

        public double CalculateDrawerCost()
        {
            return Desk.NumDrawers * COST_DRAWER;
        }
        
        public double RushCost()
        {
            int rCost = 0;
            if (RushDays != "Standard")
            {
                int[,] rushOrderPrices = GetRushOrderPrices();

                switch(RushDays)
                {
                    case RUSH1:
                        if (SurfaceArea < AREA_THRESHOLD)
                        {
                            rCost = rushOrderPrices[0, 0];
                        }
                        else if(SurfaceArea <= RUSH_THRESHOLD)
                        {
                            rCost = rushOrderPrices[0, 1];
                        }
                        else
                        {
                            rCost = rushOrderPrices[0, 2];
                        }
                        break;
                    case RUSH2:
                        if (SurfaceArea < AREA_THRESHOLD)
                        {
                            rCost = rushOrderPrices[1, 0];
                        }
                        else if (SurfaceArea <= RUSH_THRESHOLD)
                        {
                            rCost = rushOrderPrices[1, 1];
                        }
                        else
                        {
                            rCost = rushOrderPrices[1, 2];
                        }
                        break;
                    case RUSH3:
                        if (SurfaceArea < AREA_THRESHOLD)
                        {
                            rCost = rushOrderPrices[2, 0];
                        }
                        else if (SurfaceArea <= RUSH_THRESHOLD)
                        {
                            rCost = rushOrderPrices[2, 1];
                        }
                        else
                        {
                            rCost = rushOrderPrices[2, 2];
                        }
                        break;
                }
                return rCost;
            }
            else
            {
                return 0;
            }

        }

        public int[,] GetRushOrderPrices()
        {
            int[,] rushOrderPrices = new int[3, 3];
            try
            {
                string[] lines = File.ReadAllLines("rushOrderPrices.txt");
                int readLineCount = 0;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        rushOrderPrices[i, j] = int.Parse(lines[readLineCount]);
                        readLineCount++;
                    }
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Rush Order Price Data Read Error: " + e.Message);
            }
            return rushOrderPrices;
        }



        public double CaculateQuoteTotal()
        {
            return BASE_PRICE + CalculateAreaCost() + CalculateDrawerCost() + (int)Desk.Material + RushCost();
        }
    }

        

        
}
