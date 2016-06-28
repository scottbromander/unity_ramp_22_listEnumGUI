using UnityEngine;
using System.Collections;

public class Pickup : MonoBehaviour {
	public enum PickUpType {
		Star, Key, Heart
	}

	public PickUpType type;
}
