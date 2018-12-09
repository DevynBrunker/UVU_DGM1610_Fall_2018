using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomDrop : MonoBehaviour {

	//This allows me to make an Aray or List with things inside it
	[System.Serializable]
	public class DropTable{
		public string Name;
		public GameObject Item;
		public int Chance;
	}

	//My List
	public List <DropTable> LootTable = new List <DropTable>(); 
	public int DropChance;

	public void Loot(){
	
		//This is the drop chance for the enemy
		int RandomChance = Random.Range (0, 2);

		if(RandomChance <= DropChance){
			int ItemNumber = 0;

			for (int i = 0; i < LootTable.Count; i++){
				ItemNumber += LootTable [i].Chance;
			}

			int RandomValue = Random.Range (0, ItemNumber);
			for (int j = 0; j < LootTable.Count; j++){
				if(RandomValue <= LootTable [j].Chance){
					Instantiate(LootTable[j].Item, transform.position, Quaternion.identity);
					return;
				}
				RandomValue -= LootTable[j].Chance;
			}
		}
	}
}
