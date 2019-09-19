using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

    public class Medic : Ally
    {
        public override void Rescue()
        {
            Debug.Log("Medic is here. You will be alright, son.");
        }
    }
