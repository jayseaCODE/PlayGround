using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateUnitCommand : UnitCommand
{
    public CreateUnitCommand(Unit unit) : base(unit)
    {
    }
    public override void Execute()
    {
        _unit.Copy();
    }
}
