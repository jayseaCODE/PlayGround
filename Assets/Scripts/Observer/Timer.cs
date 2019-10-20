using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Timer that utilises the Observer as its behavioural pattern
/// </summary>
public class Timer : MonoBehaviour
{
    private float _timeDurationToSpawnAllies = 10.0f;
    private float _timeDurationToSpawnEnemies = 5.0f;

    public delegate void SpawnAllies();
    public static event SpawnAllies OnTimeToSpawnAllies;

    public delegate void SpawnEnemies();
    public static event SpawnEnemies OnTimeToSpawnEnemies;

    private IEnumerator _coroutine;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return WaitAndSpawnEntities();
    }

    // Update is called once per frame
    private IEnumerator WaitAndSpawnEntities()
    {
        while (Time.time < _timeDurationToSpawnAllies)
        {
            // Yield for a second
            yield return new WaitForSeconds(1.0f);

            if (Mathf.Round(Time.time) == Mathf.Round(_timeDurationToSpawnEnemies))
            {
                // Time to spawn Enemies
                if (OnTimeToSpawnEnemies != null)
                {
                    OnTimeToSpawnEnemies();
                }
            }
        }

        // Time to spawn Allies
        if (OnTimeToSpawnAllies != null)
        {
            OnTimeToSpawnAllies();
        }
    }
}
