﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

    public enum AllyType
    {
        Medic
    }
public class AllyFactory : Singleton<AllyFactory>, IFactory
{
    public IAlly GetAlly(AllyType allyType)
    {
        switch (allyType)
        {
            case AllyType.Medic:
                return Instantiate(Resources.Load("Medic", typeof(Ally)) as Ally);
        }
        return null;
    }

    public IEnemy GetEnemy(EnemyType enemyType)
    {
        return null;
    }
}
