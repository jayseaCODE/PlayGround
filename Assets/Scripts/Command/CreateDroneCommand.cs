using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateDroneCommand : UnitCommand
{
    public CreateDroneCommand(Drone unit) : base(unit)
    {
    }
    public override void Execute()
    {
        Drone copiedDrone = _unit.Copy() as Drone;
        Vector3 randomPosition = new Vector3(Random.Range(-10, 10), Random.Range(5, 20), Random.Range(-10, 10));
        copiedDrone.transform.SetPositionAndRotation(randomPosition, new Quaternion());
    }
}
