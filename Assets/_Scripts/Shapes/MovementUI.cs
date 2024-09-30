using System.Collections;
using UnityEngine;

public class MovementUI : MonoBehaviour
{
    private WaitForSeconds waitFor5Seconds = new WaitForSeconds(5);

    private void OnEnable()
    {
        StartCoroutine(CloseTimer());
    }

    private IEnumerator CloseTimer()
    {
        yield return waitFor5Seconds;
        print("test");
        gameObject.SetActive(false);
    }

}