Class Shop
{
  private string name;
  private int value;
  
  public Bag(string name, int value)
  {
    this.name = name;
    this.value = value;
  }
  
  public void Result()
  {
    Console.WriteLine(this.name + ":" + this.value);
  }
}
