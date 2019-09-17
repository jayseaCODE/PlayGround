using Assets.Scripts.Interfaces;
using System.Collections;
using System.Collections.Generic;

public abstract class AbstractFactory
{
    public abstract IEnemy GetEnemy();

    public abstract IAlly GetAlly();
}
