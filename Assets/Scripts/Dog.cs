using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dog : Animal
{
    [SerializeField]
    private int legs = 4;

    public void Start()
    {
        name = "Dog";
    }

    public override void DisplayAttribute()
    {
        textBox.text += "This dog has " + legs.ToString() + " legs.";
    }
}
