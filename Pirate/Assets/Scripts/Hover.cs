using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hover : MonoBehaviour
{
    public Button button;
    public Color wanted;
    private Color original;
    private ColorBlock cb;
    // Start is called before the first frame update
    void Start()
    {
        cb = button.colors;
        original = cb.selectedColor;
    }

    // Update is called once per frame
    public void changeWhenHover()
    {
        cb.selectedColor = wanted;
        button.colors = cb;
    }

    public void changeWhenLeaves()
    {
        cb.selectedColor = original;
        button.colors = cb;
    }
}
