using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class ItemSlot : MonoBehaviour
{
    public Image icon;
    public bool isFilled;
    public Item storedItem;

    public void SetSlot(Item item)
    {
        storedItem = item;
        icon.sprite = item.sprite;
        icon.color = Color.white;
        isFilled = true;
    }

    public void ClearSlot()
    {
        storedItem = null;
        icon.sprite = null;
        icon.color = Color.white;
        isFilled = false;
    }
}
