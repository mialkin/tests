using AutoFixture.Xunit2;

namespace Tests.AutoFixture.Xunit2.DateOnlyFix;

public class DateOnlyAutoDataAttribute : AutoDataAttribute
{
    public DateOnlyAutoDataAttribute() : base(DateOnlyFixFixture.Create)
    {
    }
}