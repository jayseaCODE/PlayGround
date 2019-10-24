using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Demonstration of the Strategy pattern: Being able to switch behavior dynamically and apply it
/// </summary>
public abstract class Unit : MonoBehaviour, ICopyable
{
    protected IUnitBehavior unitBehavior;

    #region Strategy behavioural pattern implementation
    public void SetBehavior(IUnitBehavior behavior)
    {
        unitBehavior = behavior;
    }
    public void ApplyBehavior()
    {
        unitBehavior.Command();
    }
    #endregion

    public virtual ICopyable Copy()
    {
        return null;
    }
    public abstract ICopyable Copy(string name);
}
