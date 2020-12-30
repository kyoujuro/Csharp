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


public class Part{
  private string m_firstname
  void setName(String name){
    m_firstname = name;
  }
}

public static void SelectSort<T>(T[] array) where T : IComparable<T>
{
  for(int i = 0; i < array.Length -1; i++)
    {
    int min = 1;
    for(int j = i + 1; j < array.Length; j++){
      if(array[min].CompareTo(array[j]) > 0)
      {
        min = j;
      }
    }
      Swap(ref array[min], ref array[i]);
  }
}

public static void Swap<T>(ref T a, ref T b)
{
  var tmp = a;
  a = b;
  b = tmp;
}
