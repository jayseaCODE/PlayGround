using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : IUnitBehavior
{
    public void Command()
    {
        Debug.Log("Unit is now patrolling.");
    }
}
