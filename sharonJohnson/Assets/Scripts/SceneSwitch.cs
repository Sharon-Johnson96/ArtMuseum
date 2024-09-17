using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            switchToScene1();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            switchToScene2();
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            switchToScene3();
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            switchToScene4();
        }
    }

    public void switchToScene1()
    {
        SceneManager.LoadScene(0);
    }

    public void switchToScene2()
    {
        SceneManager.LoadScene(1);
    }

    public void switchToScene3()
    {
        SceneManager.LoadScene(2);
    }

    public void switchToScene4()
    {
        SceneManager.LoadScene(3);
    }
}
