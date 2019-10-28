using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollidedUnitState : IUnitState
{
    /// <summary>
    /// Carry out what happens when collided
    /// </summary>
    /// <param name="unit"></param>
    public void Execute(Unit unit)
    {
        if (unit.gameObject.GetComponent<Blink>() == null)
        {
            unit.gameObject.AddComponent<Blink>();
        }        
    }
}
