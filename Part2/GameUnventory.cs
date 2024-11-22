using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUnventory : MonoBehaviour
{
void Start(){
  Inventory inventory1 = new Inventory();
  Inventory inventory2 = new Inventory();
  Inventory inventory3 = new Inventory();

inventory1.AddItem("Healing Potion" );
inventory1.AddItem("Strength Potion");

inventory2.AddItem("Elixir");
inventory2.AddItem("Dark Elixir");

inventory3 = inventory1 + inventory2;
inventory3.ShowItems();

}
}