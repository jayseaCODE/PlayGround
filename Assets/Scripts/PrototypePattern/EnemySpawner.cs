using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    public ICopyable copyable;
	
    public Enemy SpawnEnemy(Enemy enemy)
    {
        //copyable = enemy.Copy();
        return copyable as Enemy;
    }

    public Enemy SpawnEnemyThroughPrefabs(Enemy enemy)
    {
        copyable = null;
        if (enemy.GetType() == typeof(Drone))
        {
            copyable = enemy.Copy("Drone");
        }
        else if (enemy.GetType() == typeof(Sniper))
        {
            copyable = enemy.Copy("Sniper");
        }
        return copyable as Enemy;
    }
}
