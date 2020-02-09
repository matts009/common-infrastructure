using Amazon.CDK;
using Amazon.CDK.AWS.IAM;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommonInfrastructure.IAM.Roles
{
    public class ECSInstanceRole : Role
    {
        public ECSInstanceRole(Construct scope)
            : base(scope, "ECSInstanceRole", new RoleProps()
            {
                RoleName = "ecsInstanceRole",
                ManagedPolicies = new IManagedPolicy[] {
                    ManagedPolicy.FromAwsManagedPolicyName("service-role/AmazonEC2ContainerServiceforEC2Role")
                },
                AssumedBy = new ServicePrincipal("ecs.amazonaws.com")
            })
        {
        }
    }
}
