using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Map_Zoom : MonoBehaviour
{
    public RectTransform mapTransform;
    public float zoomSpeed = 0.1f;
    public float minZoom = 1f;
    public float maxZoom = 3f;

    void Update()
    {
        float zoomDelta = -Input.GetAxis("Mouse ScrollWheel") * zoomSpeed * -1f;

        // Clamp the zoom value between minZoom and maxZoom
        float newZoom = Mathf.Clamp(mapTransform.localScale.x + zoomDelta, minZoom, maxZoom);

        // Apply the new scale to the map
        mapTransform.localScale = new Vector3(newZoom, newZoom, 1f);
    }
}
