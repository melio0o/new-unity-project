using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    [SerializeField] private Inventory shopInventory;
    [SerializeField] private ShopItem displayPrefab;
    [SerializeField] private Transform shopContainer;

    public static event Action<Item> OnItemSelled;

    private void Awake()
    {
        LoadInventoryItems();
    }

    private void LoadInventoryItems()
    {
        foreach(Item item in shopInventory.items)
        {
            ShopItem shopItem = Instantiate(displayPrefab, shopContainer);
            shopItem.PopulateDisplay(item);
            shopItem.OnSellItem += HandleItemSelled;
        }
    }

    private void HandleItemSelled(Item item)
    {
        OnItemSelled?.Invoke(item);
    }
}
