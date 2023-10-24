using Solyanka1;

namespace Solyanka1Tests;

public class Tests
{
    [Test]
    public void EvenNumberSequenceTest()
    {
        Assert.That(Program.SequenceGenerator(1, 32), Is.EqualTo("10010110011010010110100110010110"));
    }
    
    [Test]
    public void OddNumberSequenceTest()
    {
        Assert.That(Program.SequenceGenerator(0, 47), Is.EqualTo("01101001100101101001011001101001100101100110100"));
    }
    
    [Test]
    public void NegativeLengthTest()
    {
        Assert.That(Program.SequenceGenerator(0, -4), Is.EqualTo(null));
    }
    
    [Test]
    public void InvalidFirstDigitTest()
    {
        Assert.That(Program.SequenceGenerator(7, 8), Is.EqualTo(null));
    }
    
}