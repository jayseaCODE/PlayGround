using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Demonstration of the Strategy pattern: Being able to switch behavior dynamically and apply it
/// </summary>
public abstract class Unit : MonoBehaviour
{
    protected IUnitBehavior unitBehavior;

    public void ApplyBehavior()
    {
        unitBehavior.Command();
    }

    public void SetBehavior(IUnitBehavior behavior)
    {
        unitBehavior = behavior;
    }
}
