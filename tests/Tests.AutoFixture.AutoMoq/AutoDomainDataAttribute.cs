using AutoFixture;
using AutoFixture.AutoMoq;
using AutoFixture.Xunit3;

namespace Tests.AutoFixture.AutoMoq;

public class AutoDomainDataAttribute() : AutoDataAttribute(() => new Fixture().Customize(new AutoMoqCustomization()));
