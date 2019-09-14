using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, ICopyable {
    public ICopyable Copy(string name)
    {
        return Instantiate(Resources.Load(name, typeof(Enemy)) as Enemy);
        //return Instantiate(this);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
