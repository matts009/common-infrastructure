using Amazon.CDK.AWS.IAM;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommonInfrastructure.ECR.Policies.Statements
{
    public class GetAuthorizationTokenPolicyStatement : PolicyStatement
    {
        public GetAuthorizationTokenPolicyStatement()
            : base(new PolicyStatementProps()
            {
                Effect = Effect.ALLOW,
                Actions = new string[]
                {
                   "ecr:GetAuthorizationToken",
                },
                Resources = new string[]
                {
                    "*"
                }
            })
        {
        }
    }
}
