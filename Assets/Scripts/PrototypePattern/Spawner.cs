using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum CreationalPatterns
{
    Singleton,
    Factory,
}

public class Spawner : Singleton<Spawner>
{
    CreationalPatterns CreationalPatternToUse;

    public Spawner()
    {
        CreationalPatternToUse = CreationalPatterns.Factory;
    }
    public Enemy SpawnEnemy(EnemyType enemyType)
    {
        switch (CreationalPatternToUse)
        {
            case CreationalPatterns.Singleton:
                return EnemyFactory.Instance.GetEnemy(enemyType) as Enemy;
            case CreationalPatterns.Factory:
                var factory = FactoryProducer.GetFactory(FactoryType.Enemy);
                return factory.GetEnemy(enemyType) as Enemy;
        }
        return null;
    }

    public Ally SpawnAlly(AllyType allyType)
    {
        switch (CreationalPatternToUse)
        {
            case CreationalPatterns.Singleton:
                return AllyFactory.Instance.GetAlly(allyType) as Ally;
            case CreationalPatterns.Factory:
                var factory = FactoryProducer.GetFactory(FactoryType.Ally);
                return factory.GetAlly(allyType) as Ally;
        }
        return null;
    }
}
