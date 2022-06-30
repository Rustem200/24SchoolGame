﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySlot : IInventorySlot
{
    public bool isFull => amount == capacity;

    public bool isEmpty => item == null;

    public IInventoryItem item { get; private set; }

    public Type itemType => item.type;

    public int amount => isEmpty ? 0 : item.state.amount;

    public int capacity { get; private set; }

    public void Clear()
    {
        if (isEmpty)
            return;

        item.state.amount = 0;
        item = null;
    }

    public void SetItem(IInventoryItem item)
    {
        if (!isEmpty)
            return;

        this.item = item;
        this.capacity = item.info.maxItemsInInventorySlot;
    }
}