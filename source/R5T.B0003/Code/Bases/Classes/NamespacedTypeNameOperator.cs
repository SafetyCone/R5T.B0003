using System;


namespace R5T.B0003
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class NamespacedTypeNameOperator : INamespacedTypeNameOperator
    {
        #region Static
        
        public static NamespacedTypeNameOperator Instance { get; } = new();

        #endregion
    }
}