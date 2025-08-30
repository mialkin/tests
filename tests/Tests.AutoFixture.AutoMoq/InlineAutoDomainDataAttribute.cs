using AutoFixture.Xunit3;
using Xunit;

namespace Tests.AutoFixture.AutoMoq;

public class InlineAutoDomainDataAttribute : CompositeDataAttribute
{
    public InlineAutoDomainDataAttribute(params object[] values)
        : base(new InlineDataAttribute(values), new AutoDomainDataAttribute())
    {
    }
}
