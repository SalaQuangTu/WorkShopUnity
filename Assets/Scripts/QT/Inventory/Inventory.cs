using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    #region bagPack
    public static Inventory bagPack;
    private void Awake()
    {
        bagPack = this;
    }
    #endregion

    public InventoryController controller;

    public GameObject inventory;

    public List<Interactable> items = new List<Interactable>();

    private void Update()
    {
        if (Input.GetButtonDown("Inventory") && !PauseMenu.GameIsPaused)
        {
            SetInventory();
        }
    }

    public void Add (Interactable item)
    {
        items.Add(item);
        controller.AddItem(item);
    }

    public void SetInventory()
    {
        inventory.SetActive(!inventory.activeSelf);
    }
}
