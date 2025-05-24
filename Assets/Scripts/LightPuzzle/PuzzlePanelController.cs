using UnityEngine;
using System.Collections;

public class PuzzlePanelController : MonoBehaviour
{
    public void ClosePuzzlePanel()
    {
        StartCoroutine(ResetAll(true));
    }
    public void ResetMirror()
    {
        StartCoroutine(ResetAll(false));
    }

    private IEnumerator ResetAll(bool isTake)
    {
        TargetManager.Instance.ResetMirrors();
        yield return null;
        TargetManager.Instance.ResetTargets(isTake);
    }
}