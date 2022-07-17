using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Cat : Animal
{
    [SerializeField]
    private bool isTail = true;

    void Start()
    {
        name = "Cat";
    }

    public override void DisplayAttribute()
    {
        string tail;
        if (isTail)
            tail = "does";
        else
            tail = "does not";
        textBox.text += "This Cat " + tail + " have a tail.";
    }
}
