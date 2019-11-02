using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blink : MonoBehaviour
{
    float blinkingDuration = 2.0f;
    float currentBlinkingDuration = 0.0f;
    float blinkingRate = 0.1f; // seconds
    new Renderer renderer;
    Color oldColor;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
        oldColor = (renderer.material).GetColor("_Color"); // Custom property from Dissolve shader used in Material DissolveRed/DissolveBlue
    }

    // Update is called once per frame
    void Update()
    {
        if (currentBlinkingDuration < blinkingDuration)
        {
            var lerp = Mathf.PingPong(Time.time, blinkingRate) / blinkingRate;
            renderer.material.color = Color.Lerp(oldColor, Color.clear, lerp);
            currentBlinkingDuration += Time.deltaTime;
        }
        else
        {
            renderer.material.color = oldColor;
        }
    }
}
