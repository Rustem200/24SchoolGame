using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "InventoryItemInfo", menuName = "GamePlay/Items/Create New ItemInfo")]
public class InventoryItemInfo : ScriptableObject, IInventoryItemInfo
{
    [SerializeField] private string _id;
    [SerializeField] private string _title;
    [SerializeField] private string _description;
    [SerializeField] private int _maxItemsInInventorySlot;
    [SerializeField] private Sprite _spriteIcon;


    public string id => _id;

    public int maxItemsInInventorySlot => _maxItemsInInventorySlot;

    public string title => _title;

    public string descroption => _description;

    public Sprite spriteIcon => _spriteIcon;
}
