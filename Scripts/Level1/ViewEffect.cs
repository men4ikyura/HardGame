using UnityEngine;
using UnityEngine.UI;

public class ViewEffect : MonoBehaviour
{
    public Text effectText;
    public Image effectImage;

    public void ShowEffect()
    {
        effectImage.gameObject.SetActive(true);
        effectText.gameObject.SetActive(true);
    }

    public void DisapperEffect()
    {
        effectImage.gameObject.SetActive(false);
        effectText.gameObject.SetActive(false);
    }
}
