using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public GameObject plane;
    public GameObject level;
    // Start is called before the first frame update
 public void level1()
    {
        SceneManager.LoadScene(1);
    }
    public void level2()
    {
        SceneManager.LoadScene(2);
    }

    public void level3()
    {
        SceneManager.LoadScene(3);
    }


    public void quit()
    {
        Application.Quit();
    }

    public void  gotomenu()
    {
        SceneManager.LoadScene(0);
    }

    public void completechain()
    {
        plane.SetActive(false);
    }

   
}
