using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Lastquestion : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(ButtonClick4);

    }
    void ButtonClick4()
    {
        SceneManager.LoadScene("practice1");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
