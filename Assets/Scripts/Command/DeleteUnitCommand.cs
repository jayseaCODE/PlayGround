using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteUnitCommand : UnitCommand
{
    public DeleteUnitCommand(Unit unit) : base(unit)
    {

    }

    public override void Execute()
    {
        Object.Destroy(_unit);
    }
}
