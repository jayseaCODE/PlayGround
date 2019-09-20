using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EnemyType
{
    Drone,
    Sniper
}

/// <summary>
/// Demonstration of using the Factory pattern with the Prototype pattern
/// </summary>
public class EnemyFactory :  Singleton<EnemyFactory>, IFactory
{
    private ICopyable copyable;

    public IAlly GetAlly(AllyType allyType)
    {
        return null;
    }

    /*
    public ICopyable GetEnemy(EnemyType enemyType)
    {
        switch (enemyType)
        {
            case EnemyType.Drone:
                return Instantiate(Resources.Load("Drone", typeof(Enemy)) as Enemy);;
            case EnemyType.Sniper:
                return Instantiate(Resources.Load("Sniper", typeof(Enemy)) as Enemy);
        }
        return null;
    }
    */
    public ICopyable GetEnemy(Enemy enemy, bool usePrefab = true)
    {
        copyable = null;
        if (usePrefab)
        {
            if (enemy.GetType() == typeof(Drone))
            {
                copyable = enemy.Copy("Drone");
            }
            else if (enemy.GetType() == typeof(Sniper))
            {
                copyable = enemy.Copy("Sniper");
            }
        }
        else
        {
            copyable = enemy.Copy();
        }
        
        return copyable as Enemy;
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
