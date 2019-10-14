using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMedicCommand : UnitCommand
{
    public CreateMedicCommand(Medic unit) : base(unit)
    {
    }
    public override void Execute()
    {
        Medic copiedDrone = _unit.Copy() as Medic;
        Vector3 randomPosition = new Vector3(Random.Range(-10, 10), Random.Range(5, 20), Random.Range(-10, 10));
        copiedDrone.transform.SetPositionAndRotation(randomPosition, new Quaternion());
    }
}
