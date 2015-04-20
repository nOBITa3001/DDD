namespace DDDSkeletonNET.Portal.Domain.Customer
{
	using DDDSkeletonNET.Infrastructure.Common.Domain;
	using DDDSkeletonNET.Portal.Domain.ValueObjects;

	public class Customer : EntityBase<int>
	{
		#region Properties

		public string Name { get; set; }

		public Address CustomerAddress { get; set; }

		#endregion

		#region Implementations

		public override void Validate()
		{
			if (string.IsNullOrWhiteSpace(this.Name))
			{
				this.AddBrokenRule(CustomerBusinessRule.CustomerNameRequired);
			}

			this.CustomerAddress.ThrowExceptionIfInvalid();
		}

		#endregion
	}
}
