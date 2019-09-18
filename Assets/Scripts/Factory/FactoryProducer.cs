using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum FactoryType
{
    Enemy,
    Ally
}
public class FactoryProducer : MonoBehaviour
{
    public static AbstractFactory GetFactory(FactoryType factoryType)
    {
        switch (factoryType)
        {
            case FactoryType.Ally:
                AbstractFactory allyFactory = new AllyFactory();
                return allyFactory;
            case FactoryType.Enemy:
                AbstractFactory enemyFactory = new EnemyFactory();
                return enemyFactory;
        }
        return null;
    }
}
