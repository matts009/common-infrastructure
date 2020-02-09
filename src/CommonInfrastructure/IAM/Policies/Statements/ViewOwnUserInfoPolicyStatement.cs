using Amazon.CDK.AWS.IAM;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommonInfrastructure.IAM.Policies.Statements
{
    public class ViewOwnUserInfoPolicyStatement : PolicyStatement
    {
        public ViewOwnUserInfoPolicyStatement()
            : base(new PolicyStatementProps()
            {
                Effect = Effect.ALLOW,
                Actions = new string[]
                {
                   "iam:GetUserPolicy",
                   "iam:ListGroupsForUser",
                   "iam:ListAttachedUserPolicies",
                   "iam:ListUserPolicies",
                   "iam:GetUser"
                },
                Resources = new string[]
                {
                    "arn:aws:iam::*:user/${aws:username}"
                }
            })
        {
        }
    }
}
