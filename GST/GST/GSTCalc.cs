using System;

namespace GST
{
    //  This class contains functionalities to calculate GST
    public class GSTCalc
    {
        public double ProAmount { get; set; }
        public double GstPer { get; set; }

        public GSTCalc(double proAmount,double gstPer)
        {
            this.ProAmount = proAmount;
            this.GstPer = gstPer;
        }
        public double GstAmount()
        {
            double gstAmt = ProAmount / 100 * GstPer;
            return gstAmt;
        }
        public double TotalAmtWithGst()
        {
            double gstAmt = GstAmount();
            double totalWithGst = ProAmount + gstAmt;
            return totalWithGst;
        }
    }
}
