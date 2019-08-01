namespace HDFC
{
    /// <summary>
    /// IROI
    /// </summary>
    public interface IROI
    {
        /// <summary>
        /// Type Of Account
        /// </summary>
        string TypeOfAccount { get; set; }

        /// <summary>
        /// Get Rate of Interest
        /// </summary>
        double GetRateofInterest(int principal, float rate, int time);
    }
}
