using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : Singleton<Spawner>
{
    public Enemy SpawnEnemy(EnemyType enemyType)
    {
        return EnemyFactory.Instance.GetEnemy(enemyType) as Enemy;
    }

    public Ally SpawnAlly(AllyType allyType)
    {
        return AllyFactory.Instance.GetAlly(allyType) as Ally;
    }
}
