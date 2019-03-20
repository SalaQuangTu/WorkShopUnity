using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour {

	public InteracStats info;

    public void AddNewItem(Interactable newItem)
    {
        Debug.Log("a new item for my inventory");
        Inventory.bagPack.Add(newItem);
        Destroy(gameObject);
    }
}
