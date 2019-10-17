using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class EnemyFactoryNonSingleton : MonoBehaviour, IFactory
{
    public IAlly GetAlly(AllyType allyType)
    {
        return null;
    }
    public IEnemy GetEnemy(EnemyType enemyType)
    {
        switch (enemyType)
        {
            case EnemyType.Drone:
                return Instantiate(Resources.Load("Drone", typeof(Enemy)) as Enemy);
            case EnemyType.Sniper:
                return Instantiate(Resources.Load("Sniper", typeof(Enemy)) as Enemy);
        }
        return null;
    }
}
