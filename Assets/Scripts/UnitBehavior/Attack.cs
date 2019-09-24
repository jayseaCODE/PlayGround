using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : IUnitBehavior
{
    public void Command()
    {
        Debug.Log("Unit is now attacking.");
    }
}
