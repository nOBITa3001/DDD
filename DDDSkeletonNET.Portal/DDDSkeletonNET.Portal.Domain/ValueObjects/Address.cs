namespace DDDSkeletonNET.Portal.Domain.ValueObjects
{
	using DDDSkeletonNET.Infrastructure.Common.Domain;

	public class Address : ValueObjectBase
	{
		#region Properties

		public string AddressLine1 { get; set; }

		public string AddressLine2 { get; set; }

		public string City { get; set; }

		public string PostalCode { get; set; }

		#endregion

		#region Implementations

		protected override void Validate()
		{
			if (string.IsNullOrWhiteSpace(this.City))
			{
				this.AddBrokenRule(ValueObjectBusinessRule.CityInAddressRequired);
			}
		}

		#endregion
	}
}
