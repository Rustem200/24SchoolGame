using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventoryItem : UIItem
{
    [SerializeField] private Image _imageIcon;
    [SerializeField] private Text _textAmmount;

    public IInventoryItem item { get; private set; }

    public void Refresh(IInventorySlot slot)
    {
        if (slot.isEmpty)
        {
            CleanUp();
            return;
        }

        item = slot.item;
        _imageIcon.sprite = item.info.spriteIcon;

        var textAmountEnabled = slot.amount > 1;
        _textAmmount.gameObject.SetActive(textAmountEnabled);

        if (textAmountEnabled)
            _textAmmount.text = $"{slot.amount.ToString()}";

    }
    
    private void CleanUp()
    {
        _textAmmount.gameObject.SetActive(false);
        _imageIcon.gameObject.SetActive(true);
    }
}
