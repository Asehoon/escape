using UnityEngine;

public class ChangePuzzle : MonoBehaviour
{
    public GameObject puzzleSet;
    public Camera puzzleCam;

    private void OnMouseDown()
    {
        // 메인 카메라 찾기 (MainCamera 태그 필요)
        Camera mainCam = Camera.main;
        if (mainCam != null)
        {
            mainCam.gameObject.SetActive(false);
        }

        // 퍼즐 세트 활성화
        if (puzzleSet != null)
        {
            puzzleSet.SetActive(true);
            puzzleCam.gameObject.SetActive(true);
        }

    }
}



