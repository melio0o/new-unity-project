using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Helmet,
    Armor,
    Sword
}

public enum ItemState
{
    ToSell,
    ToBuy,
    Equipped
}

[CreateAssetMenu (fileName = "EquippedItem", menuName = "ScriptableAssets/New Item")]

public class Item : ScriptableObject
{
    [SerializeField] public GameObject Prefab;
    [SerializeField] public Sprite ItemImage;
    [SerializeField] public int ItemPrice;
    [SerializeField] public string ItemName;
    [SerializeField] public ItemType ItemType;
    [SerializeField] public ItemState ItemState;

}