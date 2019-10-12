using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateSniperCommand : UnitCommand
{
    public CreateSniperCommand(Sniper unit) : base(unit)
    {
    }
    public override void Execute()
    {
        Sniper copiedSniper = _unit.Copy() as Sniper;
        Vector3 randomPosition = new Vector3(Random.Range(-10, 10), Random.Range(5, 20), Random.Range(-10, 10));
        copiedSniper.transform.SetPositionAndRotation(randomPosition, new Quaternion());
    }
}
