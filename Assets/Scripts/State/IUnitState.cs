using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Interface to access the State behavioural pattern
/// </summary>
public interface IUnitState
{
    /// <summary>
    /// Carry out what happens in this state
    /// </summary>
    /// <param name="unit"></param>
    void Execute(Unit unit);
}
