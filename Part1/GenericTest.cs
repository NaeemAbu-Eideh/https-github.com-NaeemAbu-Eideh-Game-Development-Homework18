using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class GenericTest: MonoBehaviour{
  void Start(){
  GameContainer<string> gameContainor = new GameContainer<string>();
  gameContainor.SetItem("Healing Potion");
  Debug.Log($"Stored item: {gameContainor.GetItem()}");
 
 Debug.Log(GameUtils.DescibeItem(gameContainor.GetItem()));
}
}
