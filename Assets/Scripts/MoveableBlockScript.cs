﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveableBlockScript : Unit
{

    protected virtual void Awake() { }
    protected virtual void Start() { }
    protected virtual void Update() { }
    protected virtual void OnTriggerEnter2D(Collider2D collider)
    {      
        Character character = collider.GetComponent<Character>();
    }
}


