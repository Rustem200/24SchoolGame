using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIInventoryTester : MonoBehaviour
{
    private IInventoryItemInfo _appleInfo;
    private IInventoryItemInfo _pepperInfo;
    private UIInventorySlot[] _uiSlots;

    public InventoryWithSlots inventory { get; }

    public UIInventoryTester(InventoryItemInfo apple, IInventoryItemInfo pepperInfo, UIInventorySlot[] uiSlots)
    {
        _appleInfo = apple;
        _pepperInfo = pepperInfo;
        _uiSlots = uiSlots;

        inventory = new InventoryWithSlots(15);
        inventory.OnInventoryStateChangedEvent += OnInventoryStateChanged;
    }

    public void FillSlots()
    {
        var allSlots = inventory.GetAllSlots();
        var availableSlots = new List<IInventorySlot>(allSlots);

        var filledSlots = 5;
        for (int i = 0; i < filledSlots; i++)
        {
            var filledSlot = AddRandomApplesIntoRandomSlot(availableSlots);
            availableSlots.Remove(filledSlot);

            filledSlot = AddRandomPepperIntoRandomSlot(availableSlots);
            availableSlots.Remove(filledSlot);
        }

        SetupInventoryUI(inventory);
    }

    private IInventorySlot AddRandomPepperIntoRandomSlot(List<IInventorySlot> slots)
    {
        var rSlotIndex = Random.Range(0, slots.Count);
        var rSlot = slots[rSlotIndex];
        var rCount = Random.Range(1, 4);
        var pepper = new Pepper(_appleInfo);
        pepper.state.amount = rCount;
        inventory.TryToAddToSlot(this, rSlot, pepper);
        return rSlot;
    }

    private IInventorySlot AddRandomApplesIntoRandomSlot(List<IInventorySlot> slots)
    {
        var rSlotIndex = Random.Range(0, slots.Count);
        var rSlot = slots[rSlotIndex];
        var rCount = Random.Range(1, 4);
        var apple = new Apple(_appleInfo);
        apple.state.amount = rCount;
        inventory.TryToAddToSlot(this, rSlot, apple);
        return rSlot;
    }

    private void SetupInventoryUI(InventoryWithSlots inventory)
    {
        var allSlots = inventory.GetAllSlots();
        var allSlotaCount = allSlots.Length;
        for(int i = 0; i < allSlotaCount; i++)
        {
            var slot = allSlots[i];
            var uiSlot = _uiSlots[i];
            uiSlot.SetSlot(slot);
            uiSlot.Refresh();
        }
    }

    private void OnInventoryStateChanged(object sender)
    {
        foreach(var uiSlot in _uiSlots)
        {
            uiSlot.Refresh();
        }
    }
}
