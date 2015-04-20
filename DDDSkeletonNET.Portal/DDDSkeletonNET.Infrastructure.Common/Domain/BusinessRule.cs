namespace DDDSkeletonNET.Infrastructure.Common.Domain
{
	public class BusinessRule
	{
		private string ruleDescription;
		
		public string RuleDescription
		{
			get
			{
				return this.ruleDescription;
			}
		}

		public BusinessRule(string ruleDescription)
		{
			this.ruleDescription = ruleDescription;
		}
	}
}
