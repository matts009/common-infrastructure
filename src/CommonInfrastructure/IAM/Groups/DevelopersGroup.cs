using Amazon.CDK;
using Amazon.CDK.AWS.IAM;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommonInfrastructure.IAM.Groups
{
    public class DevelopersGroup : Group
    {
        public DevelopersGroup(Construct scope)
            : base(scope, "DevelopersGroup", new GroupProps()
            {
                GroupName = "Developers"
            })
        {
        }
    }
}
