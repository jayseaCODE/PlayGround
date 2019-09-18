using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

    public enum AllyType
    {
        Medic
    }
public class AllyFactory : AbstractFactory
{
    public override IAlly GetAlly(AllyType allyType)
    {
        switch (allyType)
        {
            case AllyType.Medic:
                return Instantiate(Resources.Load("Medic", typeof(Ally)) as Ally);
        }
        return null;
    }

    public override IEnemy GetEnemy(EnemyType enemyType)
    {
        return null;
    }
}
