using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Backtoexplore : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(ButtonClick1);

    }
    void ButtonClick1()
    {
        SceneManager.LoadScene("muti-target");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
