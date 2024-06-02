using System.Collections;
using UnityEngine;

public class ControllEffect : MonoBehaviour
{
    public ViewEffect view;
    private Coroutine currentCoroutine;
    public CheckOnCollision checkingOnCollision;

    public void ControllEfect() 
    {
        if (currentCoroutine != null)
            StopCoroutine(currentCoroutine);

        currentCoroutine = StartCoroutine(DisableColliderForDelay(1.5f)); 
    }

    IEnumerator DisableColliderForDelay(float delay) 
    {
        view.ShowEffect();
        checkingOnCollision.IsProtected = true;
        for (var i = 1f; i >= 0; i -= Time.deltaTime / delay)
        {
            view.effectImage.fillAmount = i;
            yield return null;
        }

        checkingOnCollision.IsProtected = false;
        view.DisapperEffect();
        currentCoroutine = null;
    }
}