using AutoFixture.Xunit3;

namespace Tests.AutoFixture.Xunit3.DateOnlyFix;

public class DateOnlyAutoDataAttribute() : AutoDataAttribute(DateOnlyFixFixture.Create);
