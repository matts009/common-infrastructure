﻿using Amazon.CDK;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CommonInfrastructure
{
    sealed class Program
    {
        public static void Main(string[] args)
        {
            var app = new App();
            new CommonInfrastructureStack(app, "CommonInfrastructureStack");
            app.Synth();
        }
    }
}
