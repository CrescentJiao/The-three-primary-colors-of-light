using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonscript : MonoBehaviour {
    public  Button redminus;
    public Button redplus;
    public Button greenminus;
    public Button greenplus;
    public Button blueminus;
    public Button blueplus;
   public Light redlight;
    public Light greenlight;
    public Light bluelight;
   
    // Use this for initialization
    void Start () {
        //redlight = GameObject.Find("red");
            redplus .onClick.AddListener(redplusClick);
        redminus .onClick.AddListener(redminusClick);
        greenplus.onClick.AddListener(greenplusClick);
        greenminus.onClick.AddListener(greenminusClick);
        blueplus.onClick.AddListener(blueplusClick);
        blueminus.onClick.AddListener(blueminusClick);
    }
    void redplusClick()      {        redlight.intensity += 1;  }
    void redminusClick()    {        redlight.intensity  -=1;    }
    void greenplusClick()   {  greenlight.intensity += 1; }
    void greenminusClick()  {  greenlight.intensity -= 1; }
    void blueplusClick()      {  bluelight.intensity += 1; }
    void blueminusClick()   {  bluelight.intensity -= 1; }
    // Update is called once per frame
    void Update () {
		
	}
}
