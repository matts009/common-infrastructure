using Amazon.CDK;
using Amazon.CDK.AWS.IAM;
using CommonInfrastructure.ECR.Policies.Statements;
using CommonInfrastructure.IAM.Policies.Statements;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommonInfrastructure.IAM.Policies
{
    public class DeveloperPolicy : Policy
    {
        public DeveloperPolicy(Construct scope, IRole role, IGroup group) 
            : base(scope, "DeveloperPolicy", new DeveloperPolicyProperties(role, group))
        {
            
        }
    }

    public class DeveloperPolicyProperties : PolicyProps
    {
        public DeveloperPolicyProperties(IRole role, IGroup group) 
            : base()
        {
            AddStatements(role, group);
        }

        private void AddStatements(IRole role, IGroup group)
        {
            PolicyName = "DeveloperPolicy";

            Roles = new IRole[]
            {
                role
            };

            Groups = new IGroup[]
            {
                group
            };

            Statements = new PolicyStatement[]
            {
                new GetAuthorizationTokenPolicyStatement(),
                new ViewOwnUserInfoPolicyStatement()
            };
        }
    }
}
