using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {
    public EnemyFactory enemyFactory;
    public Enemy SpawnEnemyThroughPrefabs(EnemyType enemyType)
    {
        return enemyFactory.GetEnemy(enemyType) as Enemy;;
    }
}
