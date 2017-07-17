public abstract class Unit
{
    private string id;

    protected Unit(string id)
    {
        this.Id = id;
    }

    public string Id
    {
        get { return this.id; }
        private set { this.id = value; }
    }
}