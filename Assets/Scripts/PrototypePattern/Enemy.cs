using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Demonstration of the Prototype pattern through copying by either direct object reference
/// or through prefabs
/// </summary>
public class Enemy : Unit, IEnemy {

    public ICopyable Copy()
    {
        return Instantiate(this);
    }
    public override ICopyable Copy(string name)
    {
        return Instantiate(Resources.Load(name, typeof(Enemy)) as Enemy);
    }

    public virtual void Kill()
    {
        Debug.Log("I am your enemy!");
    }

    void Awake()
    {
        // Default unit behavior for an Enemy
        this.unitBehavior = new Patrol();
    }

    // Use this for initialization
    void Start () {
        this.ApplyBehavior();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
