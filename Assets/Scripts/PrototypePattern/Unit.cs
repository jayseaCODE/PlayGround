using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Demonstration of the Strategy pattern: Being able to switch behavior dynamically and apply it
/// </summary>
public abstract class Unit : MonoBehaviour, ICopyable
{
    protected IUnitBehavior unitBehavior;

    public void ApplyBehavior()
    {
        unitBehavior.Command();
    }

    public abstract ICopyable Copy(string name);

    public void SetBehavior(IUnitBehavior behavior)
    {
        unitBehavior = behavior;
    }
}
