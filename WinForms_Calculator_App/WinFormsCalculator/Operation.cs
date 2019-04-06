namespace WinForms_Calculator
{
    /// <summary>
    /// Holds information about a single calculator operation
    /// </summary>
    public class Operation
    {
        #region Public Properties

        //The left side of the operation
        public string LeftSide { get; set; }

        //The right side of the operation
        public string RightSide { get; set; }

        //The type of operation to perform
        public OperationType OperationType { get; set; }

        // The inner operation to be performed intially before this operation
        public Operation InnerOperation { get; set; }

        #endregion

        #region Constructor

        //Default Constructor
        public Operation()
        {
            //Create empty strings instead of having nulls
            this.LeftSide = string.Empty;
            this.RightSide = string.Empty;
        }

        #endregion
    }
}
