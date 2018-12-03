using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomDrop : MonoBehaviour {

	//This allows me to make an Aray or List with things inside it
	public class DropTable{
		public string Name;
		public GameObject Item;
		public int Chance;
	}

	//My List
	public List <DropTable> Table = new List <DropTable>(); 
	public int DropChance;

	void Loot(){
		int RandomChance = Random.Range (0, 101);

		if(RandomChance <= DropChance){
			
		}
	}
}
