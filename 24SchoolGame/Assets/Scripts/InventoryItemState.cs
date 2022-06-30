using System;

[Serializable]
public class InventoryItemState : IInventoryItemState
{
    public int itemAmmount;
    public bool isItemEquipped;

    public int amount { get => itemAmmount; set => itemAmmount = value; }
    public bool isEquipped { get => isItemEquipped; set => isItemEquipped = value; }

    public InventoryItemState()
    {
        itemAmmount = 0;
        isItemEquipped = false;
    }
}
