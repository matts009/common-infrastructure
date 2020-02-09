using Amazon.CDK;
using Amazon.CDK.AWS.IAM;
using Amazon.CDK.AWS.S3;
using CommonInfrastructure.IAM.Groups;
using CommonInfrastructure.IAM.Policies;
using CommonInfrastructure.IAM.Roles;

namespace CommonInfrastructure
{
    public class CommonInfrastructureStack : Stack
    {
        internal CommonInfrastructureStack(Construct scope, string id, IStackProps props = null)
            : base(scope, id, props)
        {
            var developersGroup = new DevelopersGroup(this);
            var developerRole = new DeveloperRole(this);

            new DeveloperPolicy(this, developerRole, developersGroup);
        }
    }
}
