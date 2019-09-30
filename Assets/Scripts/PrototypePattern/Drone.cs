using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drone : Enemy {

    public override void Kill()
    {
        Debug.Log("*Flies overhead*");
    }

    public void Fly()
    {
        // Implement flying functionality.
    }

    public void Fire()
    {
        // Implement laser fire functionality.
    }

    public override ICopyable Copy()
    {
        return Instantiate(Resources.Load("Drone", typeof(Enemy)) as Enemy);
    }
}
