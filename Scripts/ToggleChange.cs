using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ToggleChange : MonoBehaviour
{
    public Sprite sprite1;
    public Sprite sprite2;
    // Use this for initialization
    void Start()
    {
        Toggle toggle;
        toggle = this.GetComponent<Toggle>();
        toggle.onValueChanged.AddListener(ChangeColor);

    }
    void ChangeColor(bool ison)
    {
        if (ison == true)
        {
            this.GetComponentInChildren<Image>().sprite = sprite2;
        }
        else
        {
            this.GetComponentInChildren<Image>().sprite = sprite1;
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
