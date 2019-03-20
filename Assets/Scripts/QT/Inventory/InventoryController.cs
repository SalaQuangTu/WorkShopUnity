using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryController : MonoBehaviour {

    public GameObject buttonTemplate;

    public void AddItem(Interactable newItem)
    {
        GameObject newButton = Instantiate(buttonTemplate) as GameObject;
        newButton.SetActive(true);

        newButton.GetComponent<InventoryButton>().SetName(newItem.info.name);
        newButton.transform.SetParent(buttonTemplate.transform.parent, false);
    }
}
