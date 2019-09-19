using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainClient : MonoBehaviour {

    public Spawner spawner;

    private MonoBehaviour entity;
    private int incrementorDrone = 0;
    private int incrementorSniper = 0;
    private int incrementorMedic = 0;

    public void Update()
    {
        Vector3 randomPosition = new Vector3(Random.Range(-10, 10), Random.Range(5, 20), Random.Range(-10, 10));

        if (Input.GetKeyDown(KeyCode.D))
        {
            entity = spawner.SpawnEnemy(EnemyType.Drone);

            entity.name = "Drone_Clone_" + ++incrementorDrone;
            entity.transform.SetPositionAndRotation(randomPosition, new Quaternion());
            //enemy.transform.position.Set(Random.Range(0, 20), Random.Range(0, 20), Random.Range(0, 20));
            (entity as IEnemy).Kill();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            entity = spawner.SpawnEnemy(EnemyType.Sniper);

            entity.name = "Sniper_Clone_" + ++incrementorSniper;
            entity.transform.SetPositionAndRotation(randomPosition, new Quaternion());
            (entity as IEnemy).Kill();
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            entity = spawner.SpawnAlly(AllyType.Medic);

            entity.name = "Medic_Clone_" + ++incrementorMedic;
            entity.transform.SetPositionAndRotation(randomPosition, new Quaternion());
            (entity as IAlly).Rescue();
        }
    }
}
