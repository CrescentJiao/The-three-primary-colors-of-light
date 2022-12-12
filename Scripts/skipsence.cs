using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class skipsence : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<Button>().onClick.AddListener(ButtonClick);

    }
    void ButtonClick()
    {
        SceneManager.LoadScene("practice1");
    }

    // Update is called once per frame
    void Update () {
		
	}
}
