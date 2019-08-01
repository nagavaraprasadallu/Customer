namespace HDFC
{
    /// <summary>
    /// ROI
    /// </summary>
    public class ROI : IROI
    {
        /// <summary>
        /// Type Of Account
        /// </summary>
        public string TypeOfAccount { get; set; }

        /// <summary>
        /// Get Rate of Interest
        /// </summary>
        /// <param name="principal"></param>
        /// <param name="rate"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public double GetRateofInterest(int principal, float rate, int time)
        {
            var interest = principal * rate * time;
            return principal + interest;
        }
    }
}
