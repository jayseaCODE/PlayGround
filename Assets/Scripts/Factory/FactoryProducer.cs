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
                if (allyFactory == null)
                {
                    GameObject obj = new GameObject();
                    obj.name = "AllyFactory";
                    allyFactory = obj.AddComponent<AllyFactory>();
                }
                return allyFactory;
            case FactoryType.Enemy:
                IFactory enemyFactory = FindObjectOfType<EnemyFactory>();
                if (enemyFactory == null)
                {
                    GameObject obj = new GameObject();
                    obj.name = "EnemyFactory";
                    enemyFactory = obj.AddComponent<EnemyFactory>();
                }
                return enemyFactory;
        }
        return null;
    }
}
