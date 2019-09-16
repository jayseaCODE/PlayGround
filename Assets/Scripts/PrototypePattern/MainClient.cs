using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainClient : MonoBehaviour {

    public EnemySpawner enemySpawner;

    private Enemy enemy;
    private int incrementorDrone = 0;
    private int incrementorSniper = 0;

    public void Update()
    {
        Vector3 randomPosition = new Vector3(Random.Range(-10, 10), Random.Range(5, 20), Random.Range(-10, 10));

        if (Input.GetKeyDown(KeyCode.D))
        {
            enemy = enemySpawner.SpawnEnemyThroughPrefabs(EnemyType.Drone);

            enemy.name = "Drone_Clone_" + ++incrementorDrone;
            enemy.transform.SetPositionAndRotation(randomPosition, new Quaternion());
            //enemy.transform.position.Set(Random.Range(0, 20), Random.Range(0, 20), Random.Range(0, 20));
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            enemy = enemySpawner.SpawnEnemyThroughPrefabs(EnemyType.Sniper);

            enemy.name = "Sniper_Clone_" + ++incrementorSniper;
            enemy.transform.SetPositionAndRotation(randomPosition, new Quaternion());
        }
    }
}
