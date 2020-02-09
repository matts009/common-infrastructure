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
            // roles
            new ECSServiceRole(this);
            var developerRole = new DeveloperRole(this);

            // groups
            var developersGroup = new DevelopersGroup(this);

            // policies
            new DeveloperPolicy(this, developerRole, developersGroup);


        }
    }
}
