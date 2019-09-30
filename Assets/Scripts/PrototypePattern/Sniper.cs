using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sniper : Enemy {
    public override ICopyable Copy()
    {
        return Instantiate(Resources.Load("Sniper", typeof(Enemy)) as Enemy);
    }

    public void Shoot()
    {
        // Implement shooting functionality.
    }
}
