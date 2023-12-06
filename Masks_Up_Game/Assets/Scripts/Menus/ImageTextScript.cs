using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class ImageTextScript : MonoBehaviour
{
    public Image image;
    public GameObject fondo;
    public TextMeshProUGUI text;
    public float displayTime = 0.5f;
    public float blinkTime = 0.2f;

    private CanvasGroup canvasGroup;

    void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        canvasGroup.alpha = 0;
    }

    public void ShowImageAndText()
    {
        fondo.SetActive(true);
        StartCoroutine(DisplayImageAndText());
    }

    IEnumerator DisplayImageAndText()
    {
        image.enabled = true;
        text.enabled = true;

        for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / blinkTime)
        {
            canvasGroup.alpha = Mathf.Lerp(0, 1, t);
            yield return null;
        }

        yield return new WaitForSeconds(displayTime);

        for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / blinkTime)
        {
            canvasGroup.alpha = Mathf.Lerp(1, 0, t);
            yield return null;
        }

        fondo.SetActive(false);
        image.enabled = false;
        text.enabled = false;
    }
}