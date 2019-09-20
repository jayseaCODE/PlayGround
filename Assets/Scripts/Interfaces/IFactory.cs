using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IFactory
{
    IEnemy GetEnemy(EnemyType enemyType);

    IAlly GetAlly(AllyType allyType);
}
