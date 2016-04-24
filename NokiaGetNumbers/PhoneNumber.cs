// Decompiled with JetBrains decompiler
// Type: NokiaGetNumbers.PhoneNumber
// Assembly: NokiaGetNumbers, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87E7A9D7-CBD2-40C9-AF5C-458AE93E5268
// Assembly location: C:\dev\Nokia_get_numbers\NokiaGetNumbers.dll

namespace NokiaGetNumbers
{
  public class PhoneNumber
  {
    public string Number { get; set; }

    public string Name { get; set; }

    public PhoneNumber(string p_number, string p_name)
    {
      this.Number = p_number;
      this.Name = p_name;
    }

    public override string ToString()
    {
      return this.Name;
    }
  }
}
