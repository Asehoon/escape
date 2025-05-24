using UnityEngine;

public class ChangePuzzle : MonoBehaviour
{
    public GameObject puzzleSet;
    public Camera puzzleCam;

    private void OnMouseDown()
    {
        // ���� ī�޶� ã�� (MainCamera �±� �ʿ�)
        Camera mainCam = Camera.main;
        if (mainCam != null)
        {
            mainCam.gameObject.SetActive(false);
        }

        // ���� ��Ʈ Ȱ��ȭ
        if (puzzleSet != null)
        {
            puzzleSet.SetActive(true);
            puzzleCam.gameObject.SetActive(true);
        }

    }
}



