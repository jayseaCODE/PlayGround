﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Demonstration of the Prototype pattern through copying by either direct object reference
/// or through prefabs
/// </summary>
public class Enemy : MonoBehaviour, ICopyable, IEnemy {

    public ICopyable Copy()
    {
        return Instantiate(this);
    }
    public ICopyable Copy(string name)
    {
        return Instantiate(Resources.Load(name, typeof(Enemy)) as Enemy);
    }

    public virtual void Kill()
    {
        Debug.Log("I am your enemy!");
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
