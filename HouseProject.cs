class HouseProject
{
    private string name;
    private House[] houses = new House[10];
    public HouseProject(string name, House[] houses)
    {
        this.name = name;
        this.houses = houses;
    }
    public string Name { get => name; set => name = value; }
    internal House[] Houses { get => houses; set => houses = value; }
    public void setHouse(House h, int index)
    {
        this.houses[index] = h;
    }
    public House GetHouse(int index)
    {
        return this.houses[index];
    }
    public void listAllHouse()
    {
        for (int i = 0; i < this.houses.Length; i++)
        {
            if (this.houses[i] != null)
            {
                Console.WriteLine(this.houses[i].ToString());
            }
        }
    }
}
}
