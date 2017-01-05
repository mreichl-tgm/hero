﻿using UnityEngine;

public class Inventory : MonoBehaviour {

	[SerializeField]
	private ItemSlot[] baseItems;
	[SerializeField]
	private GameObject[] inventory;
	[SerializeField]
	private ItemSlot[] equipment;
}