using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tijiao1 : MonoBehaviour {
    Toggle togglered;
    Toggle togglegreen;
    Toggle toggleblue;
   public GameObject right;
    public GameObject wrong;
	// Use this for initialization
	void Start () {
        togglered = GameObject.Find("IsRedOn").GetComponent<Toggle>();
        togglegreen = GameObject.Find("IsGreenOn").GetComponent<Toggle>();
       toggleblue = GameObject.Find("IsBlueOn").GetComponent<Toggle>();
      //  right = GameObject.Find("right");
      // wrong = GameObject.Find("Wrong");
        GetComponent<Button>().onClick.AddListener(ButtonClicktijiao);
    }
	void ButtonClicktijiao()
    {
        if(togglered.isOn==true && togglegreen.isOn==true && toggleblue.isOn == false)
        {
            right.SetActive(true);
        }else if (togglered.isOn == false|| togglegreen ==false )
        {
            wrong.SetActive(true);
        }else if(toggleblue.isOn == true)
        {
            wrong.SetActive(true);
        }else if(togglered ==true && togglegreen.isOn == false  && toggleblue.isOn == false)
        {
            wrong.SetActive(true);
        }
        }
	// Update is called once per frame
	void Update () {
		
	}
}
