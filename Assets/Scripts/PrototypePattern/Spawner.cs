using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    private AbstractFactory factory;
    public Enemy SpawnEnemy(EnemyType enemyType)
    {
        factory = new EnemyFactory();
        return factory.GetEnemy(enemyType) as Enemy;
    }

    public Ally SpawnAlly(AllyType allyType)
    {
        factory = new AllyFactory();
        return factory.GetAlly(allyType) as Ally;
    }
}
