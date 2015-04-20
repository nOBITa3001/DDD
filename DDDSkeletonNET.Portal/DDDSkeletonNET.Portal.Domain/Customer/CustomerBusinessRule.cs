namespace DDDSkeletonNET.Portal.Domain.Customer
{
	using DDDSkeletonNET.Infrastructure.Common.Domain;

	public static class CustomerBusinessRule
	{
		public static readonly BusinessRule CustomerNameRequired = new BusinessRule("A customer must have a name.");
	}
}
