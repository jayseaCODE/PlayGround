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
    CreationalPatterns _creationalPatternToUse;
    IFactory _enemyFactory;
    IFactory _allyFactory;

    public Spawner()
    {
        _creationalPatternToUse = CreationalPatterns.Factory;
    }
    public Enemy SpawnEnemy(EnemyType enemyType)
    {
        switch (_creationalPatternToUse)
        {
            case CreationalPatterns.Singleton:
                return EnemyFactory.Instance.GetEnemy(enemyType) as Enemy;
            case CreationalPatterns.Factory:
                if (_enemyFactory == null)
                {
                    _enemyFactory = FactoryProducer.GetFactory(FactoryType.Enemy);
                }
                return _enemyFactory?.GetEnemy(enemyType) as Enemy;
        }
        return null;
    }

    public Ally SpawnAlly(AllyType allyType)
    {
        switch (_creationalPatternToUse)
        {
            case CreationalPatterns.Singleton:
                return AllyFactory.Instance.GetAlly(allyType) as Ally;
            case CreationalPatterns.Factory:
                if (_allyFactory == null)
                {
                    _allyFactory = FactoryProducer.GetFactory(FactoryType.Ally);
                }
                return _allyFactory?.GetAlly(allyType) as Ally;
        }
        return null;
    }
}
