namespace AcmeInc.Product.UnitTests;

public sealed class Class1
{
	[Fact]
	public void Repro()
	{
		string[] items = ["a", "b"];

		Assert.Collection(items,
							value => // Parameter value is only used for precondition checks
							{
								Assert.Equal("a", value);
							},
							value => Assert.Equal("b", value));
	}
}
