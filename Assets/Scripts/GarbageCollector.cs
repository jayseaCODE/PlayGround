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
        if (other.gameObject.layer == 10) // Layer "Entities"
        {
            (other.gameObject.GetComponent<Unit>()).OnTriggerDyingUnitState();
        }
        StartCoroutine(DelayBeforeDestroyingOtherObject(other.gameObject));
    }

    IEnumerator DelayBeforeDestroyingOtherObject(GameObject gameObject)
    {
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }
}
