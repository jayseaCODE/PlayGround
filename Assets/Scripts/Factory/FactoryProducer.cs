using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum FactoryType
{
    Enemy,
    Ally
}

public class FactoryProducer : Singleton<FactoryProducer>
{
    public static IFactory GetFactory(FactoryType factoryType)
    {
        switch (factoryType)
        {
            case FactoryType.Ally:
                IFactory allyFactory = FindObjectOfType<AllyFactory>();
                return allyFactory;
            case FactoryType.Enemy:
                IFactory enemyFactory = FindObjectOfType<EnemyFactory>();
                return enemyFactory;
        }
        return null;
    }
}
