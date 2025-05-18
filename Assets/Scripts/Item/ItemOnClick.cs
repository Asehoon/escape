using UnityEngine;

public class ItemOnClick : MonoBehaviour
{
    private bool isClicked = false;

    private void OnMouseDown()
    {
        if (!isClicked)
        {
            Debug.Log("클릭");

            Item item = GetComponent<Item>();
            if (item != null && ItemController.Instance != null)
            {
                ItemController.Instance.AddItemToInventory(item);
                isClicked = true;

                Destroy(gameObject); // 클릭된 아이템 제거 (또는 비활성화 처리 가능)
            }
        }
    }
}
