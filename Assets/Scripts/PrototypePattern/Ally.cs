using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class Ally : Unit, ICopyable, IAlly
{
    public ICopyable Copy(string name)
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
