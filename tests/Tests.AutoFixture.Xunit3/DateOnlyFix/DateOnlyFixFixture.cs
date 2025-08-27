using AutoFixture;

namespace Tests.AutoFixture.Xunit3.DateOnlyFix;

public class DateOnlyFixFixture
{
    public static Fixture Create()
    {
        var fixture = new Fixture();
        fixture.Customize<DateOnly>(composer => composer.FromFactory<DateTime>(DateOnly.FromDateTime));
        return fixture;
    }
}
