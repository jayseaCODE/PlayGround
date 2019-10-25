using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blink : MonoBehaviour
{
    float blinkingDuration = 0.1f; // seconds
    new Renderer renderer;
    Color oldColor;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
        oldColor = renderer.material.color;
    }

    // Update is called once per frame
    void Update()
    {
        float lerp = Mathf.PingPong(Time.time, blinkingDuration) / blinkingDuration;
        renderer.material.color = Color.Lerp(oldColor, Color.white, lerp);
    }
}
