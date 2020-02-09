using Amazon.CDK;
using Amazon.CDK.AWS.IAM;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommonInfrastructure.IAM.Roles
{
    public class DeveloperRole : Role
    {
        public DeveloperRole(Construct scope) 
            : base(scope, "DeveloperRole", new RoleProps()
            {
                RoleName = "Developer",
                AssumedBy = new AnyPrincipal()
            })
        {
        }
    }
}
