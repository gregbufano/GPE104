using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pawnss : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public virtual void Start()
    {
       
    }

    // Update is called once per frame
    public virtual void Update()
    {
     
    }
    
    public abstract void moveFoward();
    public abstract void moveBackward();
    public abstract void rotateClockwise();
    public abstract void roatateCounterClockwise();
}
