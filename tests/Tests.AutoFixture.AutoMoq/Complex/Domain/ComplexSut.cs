using Tests.AutoFixture.AutoMoq.Services;

namespace Tests.AutoFixture.AutoMoq.Complex.Domain;

public class ComplexSut : IComplexSut
{
    private readonly ICustomService _customService;

    public ComplexSut(ICustomService customService)
    {
        _customService = customService;
    }

    public int Calculate()
    {
        var result = _customService.DoWork();

        return 5 + result;
    }
}
