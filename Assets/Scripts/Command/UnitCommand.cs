using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class UnitCommand
{
    protected Unit _unit;

    public UnitCommand(Unit unit)
    {
        _unit = unit;
    }

    public abstract void Execute();
}
