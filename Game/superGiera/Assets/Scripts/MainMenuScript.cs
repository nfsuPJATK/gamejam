using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
//using System.Diagnostics;
//using System.Runtime.Hosting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour
{
   public void playClick()
    {
        //Debug.WriteLine("EXIT");
        Application.Quit();
    }
    public void leaveClick()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);   
    }
}
