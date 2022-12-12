using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Lastquestion2 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(ButtonClick5);

    }
    void ButtonClick5()
    {
        SceneManager.LoadScene("practice2");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
