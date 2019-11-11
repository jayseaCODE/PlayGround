using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Demonstration of the Strategy pattern: Being able to switch behavior dynamically and apply it
/// </summary>
public abstract class Unit : MonoBehaviour, ICopyable
{
    protected IUnitBehavior unitBehavior;
    protected IUnitState unitState;

    #region Prototype creational pattern basic setup
    public virtual ICopyable Copy()
    {
        return null;
    }
    public abstract ICopyable Copy(string name);
    #endregion

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

    #region State behavioural pattern implementation
    protected void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 10) // Layer "Entities"
        {
            unitState = new CollidedUnitState();
            unitState.Execute(this);
        }
    }
    public void OnTriggerDyingUnitState()
    {
        unitState = new DyingUnitState();
        unitState.Execute(this);
    }
    #endregion
}
