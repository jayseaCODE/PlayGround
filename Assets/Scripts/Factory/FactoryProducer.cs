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
                IFactory allyFactory = FindObjectOfType<AllyFactoryNonSingleton>();
                if (allyFactory == null)
                {
                    GameObject obj = new GameObject();
                    obj.name = "AllyFactory";
                    allyFactory = obj.AddComponent<AllyFactoryNonSingleton>();
                }
                return allyFactory;
            case FactoryType.Enemy:
                IFactory enemyFactory = FindObjectOfType<EnemyFactoryNonSingleton>();
                if (enemyFactory == null)
                {
                    GameObject obj = new GameObject();
                    obj.name = "EnemyFactory";
                    enemyFactory = obj.AddComponent<EnemyFactoryNonSingleton>();
                }
                return enemyFactory;
        }
        return null;
    }
}
