using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemsEffect : MonoBehaviour {

    public Text nameItem;

	public void UseItem()
    {
        if(nameItem.text == "Heal Potion")
        {
            UseHealPotion();
        }

        if (nameItem.text == "Strengh Potion")
        {
            UseStrenghPotion();
        }
    }

    private void UseHealPotion()
    {
        Debug.Log("HEAAAAAAALEEUH !!!!!");
    }

    private void UseStrenghPotion()
    {
        Debug.Log("POWAAAAAAAAAAAAAAAAAAA !!!!!");
    }
}
