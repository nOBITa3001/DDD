namespace DDDSkeletonNET.Infrastructure.Common.Domain
{
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	public abstract class ValueObjectBase
	{
		#region Declarations

		private IList<BusinessRule> brokenRules = new List<BusinessRule>();

		#endregion

		#region Properties



		#endregion

		#region Constructors

		public ValueObjectBase()
		{

		}

		#endregion

		#region Implementations

		protected abstract void Validate();

		#endregion

		#region Methods

		protected void AddBrokenRule(BusinessRule businessRule)
		{
			this.brokenRules.Add(businessRule);
		}

		public void ThrowExceptionIfInvalid()
		{
			// We first clear the list so that we don’t return any previously stored broken rules.
			// They may have been fixed by then. 
			this.brokenRules.Clear();

			// We then run the Validate method which is implemented in the concrete domain classes.
			// The domain will fill up the list of broken rules in that implementation.
			this.Validate();

			if (this.brokenRules.Any())
			{
				StringBuilder issues = new StringBuilder();
				foreach (BusinessRule businessRule in this.brokenRules)
				{
					issues.AppendLine(businessRule.RuleDescription);
				}

				throw new ValueObjectIsInvalidException(issues.ToString());
			}
		}

		#endregion
	}
}
