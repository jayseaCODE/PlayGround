using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : Singleton<Spawner>
{
    IFactory _allyFactory;
    IFactory _enemyFactory;
    bool _searchedForEnemyFactory;
    bool _searchedForAllyFactory;
    public Spawner()
    {
        _searchedForEnemyFactory = false;
        _searchedForAllyFactory = false;
    }
    public Enemy SpawnEnemy(EnemyType enemyType)
    {
        if (!_searchedForEnemyFactory)
        {
            _enemyFactory = FindObjectOfType<EnemyFactory>();
            _searchedForEnemyFactory = true;
        }
        if (_enemyFactory == null)
        {
            _enemyFactory = gameObject.AddComponent(typeof(EnemyFactory)) as EnemyFactory;
        }

        return _enemyFactory.GetEnemy(enemyType) as Enemy;
    }

    public Ally SpawnAlly(AllyType allyType)
    {
        if (!_searchedForAllyFactory)
        {
            _allyFactory = FindObjectOfType<AllyFactory>();
            _searchedForAllyFactory = true;
        }
        if (_allyFactory == null)
        {
            _allyFactory = gameObject.AddComponent(typeof(AllyFactory)) as AllyFactory;
        }
        return _allyFactory.GetAlly(allyType) as Ally;
    }
}
