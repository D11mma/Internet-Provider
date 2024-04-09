class Expensive : Average
{
    public int NumberOfMonth { get; set; }
    public string Antiverus {get; set; }
    public Expensive(string name, int numberOfClients, int price, int speed, int traffic, string tvservices, string antivir, int NM)
    : base(name, numberOfClients, price, speed, traffic, tvservices)
    {
        NumberOfMonth = NM;
        this.Antiverus = antivir;
    }
    public override string ToString()
    {
        return base.ToString() + $" Antiverus: {Antiverus}  на {NumberOfMonth} місяців ";
    }
}
