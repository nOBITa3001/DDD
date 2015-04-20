namespace DDDSkeletonNET.Portal.Domain.ValueObjects
{
	using DDDSkeletonNET.Infrastructure.Common.Domain;

	public class ValueObjectBusinessRule
	{
		public static readonly BusinessRule CityInAddressRequired = new BusinessRule("An address must have a city.");
	}
}
