using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class GameUtils{
  public static string DescibeItem<T>(T something ){
  string str = "This item is ";
  str += something.ToString();
  return str;
}
}

