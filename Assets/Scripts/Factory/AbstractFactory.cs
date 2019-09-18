using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractFactory : MonoBehaviour
{
    public abstract IEnemy GetEnemy(EnemyType enemyType);

    public abstract IAlly GetAlly(AllyType allyType);
}
