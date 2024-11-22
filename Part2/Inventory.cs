using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory {
 private List<string> list = new List<string>();
 public void AddItem(string i){
   list.Add(i);
}

public void ShowItems(){
  foreach( var i in list){
  Debug.Log(i);
}
}
 public static Inventory operator + (Inventory i1 , Inventory i2){
   Inventory combineList = new Inventory();
  foreach(var i in i1.list){ combineList.AddItem(i);}
  foreach(var i in i2.list){ combineList.AddItem(i);}
  return combineList;
}
}

