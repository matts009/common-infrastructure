using Amazon.CDK;
using Amazon.CDK.AWS.IAM;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommonInfrastructure.IAM.Roles
{
    public class ECSServiceRole : Role
    {
        public ECSServiceRole(Construct scope)
            : base(scope, "ECSServiceRole", new RoleProps()
            {
                RoleName = "ecsServiceRole",
                ManagedPolicies = new IManagedPolicy[] {
                    ManagedPolicy.FromAwsManagedPolicyName("service-role/AmazonEC2ContainerServiceRole")
                },
                AssumedBy = new ServicePrincipal("ecs.amazonaws.com")
            })
        {
        }
    }
}
