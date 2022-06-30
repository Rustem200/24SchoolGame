using UnityEngine;

public interface IInventoryItemInfo
{
    string id { get; }
    int maxItemsInInventorySlot { get; }
    string title { get; }
    string descroption { get; }
    Sprite spriteIcon { get; }
}
