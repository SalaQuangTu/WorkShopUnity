using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryButton : MonoBehaviour {

    public Text myName;

    public void SetName(string newName)
    {
        myName.text = newName;
    }
}
