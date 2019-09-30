using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public abstract class Ally : Unit, IAlly
{
    public override ICopyable Copy(string name)
    {
        return Instantiate(Resources.Load(name, typeof(Ally)) as Ally);
    }

    public virtual void Rescue()
    {
        Debug.Log("Rescue is on its way! Hang on!");
    }

    void Awake()
    {
        // Default unit behavior for an Ally
        this.unitBehavior = new Patrol();
    }

    // Use this for initialization
    void Start()
    {
        this.ApplyBehavior();
    }
}
