using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class Ally : MonoBehaviour, ICopyable, IAlly
{
    public ICopyable Copy(string name)
    {
        return Instantiate(Resources.Load(name, typeof(Ally)) as Ally);
    }

    public virtual void Rescue()
    {
        Debug.Log("Rescue is on its way! Hang on!");
    }
}
