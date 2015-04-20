namespace DDDSkeletonNET.Infrastructure.Common.Domain
{
	using System.Collections.Generic;

	public abstract class EntityBase<IDType>
	{
		#region Declarations

		private IList<BusinessRule> brokenRules = new List<BusinessRule>();

		#endregion

		#region Properties

		public IDType ID { get; set; }

		#endregion

		#region Implementations

		public override bool Equals(object entity)
		{
			return entity != null
					&& entity is EntityBase<IDType>
					&& this == (EntityBase<IDType>)entity;
		}

		public override int GetHashCode()
		{
			return this.ID.GetHashCode();
		}

		public static bool operator ==(EntityBase<IDType> entity1, EntityBase<IDType> entity2)
		{
			if ((object)entity1 == null && (object)entity2 == null)
			{
				return true;
			}

			if ((object)entity1 == null || (object)entity2 == null)
			{
				return false;
			}

			if (entity1.ID.ToString() == entity2.ID.ToString())
			{
				return true;
			}

			return false;
		}

		public static bool operator !=(EntityBase<IDType> entity1, EntityBase<IDType> entity2)
		{
			return (!(entity1 == entity2));
		}

		public abstract void Validate();

		#endregion

		#region Methods

		protected void AddBrokenRule(BusinessRule businessRule)
		{
			this.brokenRules.Add(businessRule);
		}

		public IEnumerable<BusinessRule> GetBrokenRules()
		{
			// We first clear the list so that we don’t return any previously stored broken rules.
			// They may have been fixed by then. 
			this.brokenRules.Clear();

			// We then run the Validate method which is implemented in the concrete domain classes.
			// The domain will fill up the list of broken rules in that implementation.
			this.Validate();

			return this.brokenRules;
		}

		#endregion
	}
}
