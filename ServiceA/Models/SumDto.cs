namespace ServiceA.Models;

public class SumDto
{
    public required int A { get; set; }
    public required int B { get; set; }
    public int? Sum { get; set; }
}