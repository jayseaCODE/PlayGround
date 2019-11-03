using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class GarbageCollector : MonoBehaviour
{
    new Renderer renderer;
    // Destroy everything that enters the trigger
    void OnTriggerEnter(Collider other)
    {
        // Custom property from Dissolve shader used in Material DissolveRed/DissolveBlue
        renderer = other.gameObject.GetComponent<Renderer>();
        renderer.material.SetFloat("_StartTime", Mathf.Sin(Time.time));
        renderer.material.SetFloat("_Animate", 1.0f);
        StartCoroutine(Delay(other.gameObject));
    }

    IEnumerator Delay(GameObject gameObject)
    {
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }
}
