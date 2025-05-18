using UnityEngine;
using UnityEngine.UI;

public class ItemButtonClicker : MonoBehaviour
{
    public ItemController itemController;
    public GameObject itemDisplayImage; 

    public void OnInventoryButtonClick(int slotIndex)
    {
        ItemSlot slot = itemController.inventorySlots[slotIndex];
        if (slot.isFilled)
        {
            Item item = slot.storedItem;

            // Picture 안에 있는 Image 컴포넌트를 가져와 sprite 설정
            Image imageComponent = itemDisplayImage.GetComponentInChildren<Image>();
            imageComponent.sprite = item.sprite;
            imageComponent.enabled = true;
            itemDisplayImage.SetActive(true);
        }
    }

    public void OnInventoryButtonExit()
    {
        // Image의 sprite 초기화 및 비활성화
        Image imageComponent = itemDisplayImage.GetComponentInChildren<Image>();
        imageComponent.sprite = null;
        imageComponent.enabled = false;

        itemDisplayImage.SetActive(false);
    }
}
