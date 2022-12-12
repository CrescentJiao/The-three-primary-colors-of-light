using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SkipScene : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(ButtonClick2);

    }
    void ButtonClick2()
    {
        if (this.name == "Bt1to2")
        {
            print("1-2");
            SceneManager.LoadScene("practice2");
        }
        else if (this.name == "2to1")
        {
            print("2-1");
            SceneManager.LoadScene("practice1");
        }else if (this.name == "2to3")
        {
            print("2-3");
            SceneManager.LoadScene("practice3");
        }else if (this.name == "3to2")
        {
            print("3-2");
            SceneManager.LoadScene("practice2");
        }else if (this.name == "backtoexplore")
        {
            print("back");
            SceneManager.LoadScene("muti-target");
        }else if(this.name== "testto0")
        {
            print("testto0");
            SceneManager.LoadScene("muti-target");
        }else if (this.name == "0totest")
        {
            SceneManager.LoadScene("test");
        }
                
       
    }

    // Update is called once per frame
    void Update()
    {

    }
}
