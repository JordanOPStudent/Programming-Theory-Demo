using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public abstract class Animal : MonoBehaviour
{
    [SerializeField]
    private string Name { get; }

    [SerializeField]
    protected TextMeshProUGUI textBox;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisplayName()
    {
        textBox.text = "He is a " + name + "\n";
    }

    abstract public void DisplayAttribute();

    public void DisplayText()
    {
        DisplayName();
        DisplayAttribute();
    }
}
