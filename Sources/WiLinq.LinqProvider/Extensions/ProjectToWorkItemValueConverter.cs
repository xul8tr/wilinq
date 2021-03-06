using System;
using Microsoft.TeamFoundation.Core.WebApi;

namespace WiLinq.LinqProvider.Extensions
{
    internal sealed class ProjectToWorkItemValueConverter : WorkItemValueConverter
    {
        public override Type RelatedType => typeof(ProjectInfo);

        public override object Resolve(object obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj), "obj is null.");
            }
            if (!(obj is ProjectInfo project))
            {
                throw new ArgumentException("obj is not a Project", nameof(obj));
            }

            return project.Name;
        }
    }
}