using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Interface to access the Strategy behavioural pattern
/// </summary>
public interface IUnitBehavior
{
    /// <summary>
    /// Carry out this behavior
    /// </summary>
    void Command();
}
