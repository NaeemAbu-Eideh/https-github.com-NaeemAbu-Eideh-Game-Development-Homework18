using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class GameContainer<T>{
public T item;
public void SetItem(T i){
  item = i;
}
public T GetItem(){
  return item;
}
}

