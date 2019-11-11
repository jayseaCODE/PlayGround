using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DyingUnitState : IUnitState
{
    Renderer renderer;
    /// <summary>
    /// Carry out what happens when dying
    /// </summary>
    /// <param name="unit"></param>
    public void Execute(Unit unit)
    {
        // Custom property from Dissolve shader used in Material DissolveRed/DissolveBlue
        renderer = unit.gameObject.GetComponent<Renderer>();
        renderer.material.SetFloat("_StartTime", Mathf.Sin(Time.time));
        renderer.material.SetFloat("_Animate", 1.0f);
    }
}
