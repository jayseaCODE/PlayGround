using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    public Enemy SpawnEnemy(EnemyType enemyType)
    {
        var factory = FactoryProducer.GetFactory(FactoryType.Enemy);
        return factory.GetEnemy(enemyType) as Enemy;
    }

    public Ally SpawnAlly(AllyType allyType)
    {
        var factory = FactoryProducer.GetFactory(FactoryType.Ally);
        return factory.GetAlly(allyType) as Ally;
    }
}
