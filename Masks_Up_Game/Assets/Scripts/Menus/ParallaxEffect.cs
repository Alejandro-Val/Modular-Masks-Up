using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxEffect : MonoBehaviour
{
    public float parallaxSpeed;
    private float startPosY;
    private RectTransform rectTransform;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        startPosY = rectTransform.anchoredPosition.y;
    }

    void Update()
    {
        float deltaY = Time.deltaTime * parallaxSpeed;
        rectTransform.anchoredPosition = new Vector2(rectTransform.anchoredPosition.x, startPosY + deltaY);
    }
}
