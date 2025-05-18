using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    public static ItemController Instance { get; private set; }
    public Transform inventoryGrid; // �θ� ������Ʈ (InventoryGrid)
    public List<ItemSlot> inventorySlots = new List<ItemSlot>();
    private int currentSlotIndex = 0;
    private void Awake()
    {
        // �̱��� �ʱ�ȭ
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject); // �ߺ� ����
    }

    void Start()
    {
        inventorySlots.AddRange(inventoryGrid.GetComponentsInChildren<ItemSlot>());
    }
    
    public void AddItemToInventory(Item item)
    {
        if (currentSlotIndex >= inventorySlots.Count)
        {
            Debug.Log("Inventory is full!");
            return;
        }
        inventorySlots[currentSlotIndex].SetSlot(item);
        currentSlotIndex++;
    }


    public void ClearInventorySlot(int slotIndex)
    {
        if (slotIndex < 0 || slotIndex >= inventorySlots.Count)
        {
            Debug.LogWarning("Invalid slot index.");
            return;
        }

        int maxCount = inventorySlots.Count - 1;

        // ���� ���Ե��� ������ ���
        for (int i = slotIndex; i < maxCount; i++)
        {
            if (inventorySlots[i + 1].isFilled)
            {
                inventorySlots[i].SetSlot(inventorySlots[i + 1].storedItem);
            }
            else
            {
                inventorySlots[i].ClearSlot();
                currentSlotIndex = i;
                return; // �ڴ� ������� �� �� ��ܵ� ��
            }
        }

        // ������ ������ �׻� �����
        inventorySlots[maxCount].ClearSlot();

        // currentSlotIndex ������Ʈsdds
        for (int i = 0; i < inventorySlots.Count; i++)
        {
            if (!inventorySlots[i].isFilled)
            {
                currentSlotIndex = i;
                return;
            }
        }

        currentSlotIndex = inventorySlots.Count;
    }

}
