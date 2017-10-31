using System;
using System.Linq.Expressions;
using Nuke.Core;

namespace DigitalParadox.SlowCheetah
{
    public class XDTTransform : ITargetDefinition
    {
        public XDTTransform()
        {
        }

        public ITargetDefinition DependsOn(params Target[] targets)
        {
            throw new NotImplementedException();
        }

        public ITargetDefinition DependsOn(params string[] shadowTargets)
        {
            throw new NotImplementedException();
        }

        public ITargetDefinition Description(string description)
        {
            throw new NotImplementedException();
        }

        public ITargetDefinition Executes(params Action[] actions)
        {
            throw new NotImplementedException();
        }

        public ITargetDefinition Executes<T>(Func<T> action)
        {
            throw new NotImplementedException();
        }

        public ITargetDefinition OnlyWhen(params Func<bool>[] conditions)
        {
            throw new NotImplementedException();
        }

        public ITargetDefinition Requires<T>(params Expression<Func<T>>[] parameterRequirement) where T : class
        {
            throw new NotImplementedException();
        }

        public ITargetDefinition Requires<T>(params Expression<Func<T?>>[] parameterRequirement) where T : struct
        {
            throw new NotImplementedException();
        }

        public ITargetDefinition Requires(params Expression<Func<bool>>[] requirement)
        {
            throw new NotImplementedException();
        }
    }
}
