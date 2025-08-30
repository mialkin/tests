using Tests.AutoFixture.AutoMoq.Services;

namespace Tests.AutoFixture.AutoMoq.Complex.Domain;

public class ComplexSut(ICustomService customService) : IComplexSut
{
    public int Calculate()
    {
        var result = customService.DoWork();

        return 5 + result;
    }
}
