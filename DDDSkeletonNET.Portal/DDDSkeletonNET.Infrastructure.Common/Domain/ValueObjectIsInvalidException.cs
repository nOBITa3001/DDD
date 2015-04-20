namespace DDDSkeletonNET.Infrastructure.Common.Domain
{
	using System;

	public class ValueObjectIsInvalidException : Exception
	{
		#region Constructors

		public ValueObjectIsInvalidException(string message)
			: base(message) { }

		#endregion
	}
}
