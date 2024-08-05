using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scroller : MonoBehaviour
{
    [SerializeField] private RawImage rawImage;
    void Update()
    {
        rawImage.uvRect = new Rect(rawImage.uvRect.position + new Vector2(0.2f,0)*Time.deltaTime,rawImage.uvRect.size);
    }
}
