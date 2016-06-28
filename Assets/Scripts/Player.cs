using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class Player : MonoBehaviour {
	private InventoryManager inventoryManager;

	// Use this for initialization
	void Start () {
		inventoryManager = GetComponent<InventoryManager> ();
	}

	void OnTriggerEnter2D(Collider2D hit){
		if(hit.CompareTag("Pickup")){
			Pickup item = hit.GetComponent<Pickup> ();
			inventoryManager.Add (item);
			Destroy (hit.gameObject);
		}
	}
}
