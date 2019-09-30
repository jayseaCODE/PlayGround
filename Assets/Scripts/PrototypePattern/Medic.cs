using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

    public class Medic : Ally
    {
    public override ICopyable Copy()
    {
        return Instantiate(Resources.Load("Medic", typeof(Ally)) as Ally);
    }

    public override void Rescue()
        {
            Debug.Log("Medic is here. You will be alright, son.");
        }
    }
