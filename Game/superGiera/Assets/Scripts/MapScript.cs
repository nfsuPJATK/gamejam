using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapScript : MonoBehaviour
{
    public void startClick()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
        GlobalControl.Instance.visitedNodes.Add("Start");
        GlobalControl.Instance.currentRow = 1;

    }
    public void OneAClick()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
        GlobalControl.Instance.visitedNodes.Add("1A");
        GlobalControl.Instance.currentRow++;

    }
    public void OneBClick()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
        GlobalControl.Instance.visitedNodes.Add("1B");
        GlobalControl.Instance.currentRow++;

    }
    public void OneCClick()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
        GlobalControl.Instance.visitedNodes.Add("1C");
        GlobalControl.Instance.currentRow++;

    }
    public void TwoAClick()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
        GlobalControl.Instance.visitedNodes.Add("2A");
        GlobalControl.Instance.currentRow++;

    }
    public void TwoBClick()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
        GlobalControl.Instance.visitedNodes.Add("2B");
        GlobalControl.Instance.currentRow++;

    }
    public void ThreeClick()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
        GlobalControl.Instance.visitedNodes.Add("3");
        GlobalControl.Instance.currentRow++;

    }
    public void FourAClick()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
        GlobalControl.Instance.visitedNodes.Add("4A");
        GlobalControl.Instance.currentRow++;

    }
    public void FourBClick()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
        GlobalControl.Instance.visitedNodes.Add("4B");
        GlobalControl.Instance.currentRow++;

    }
    public void FiveAClick()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
        GlobalControl.Instance.visitedNodes.Add("5A");
        GlobalControl.Instance.currentRow++;

    }
    public void FiveBClick()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
        GlobalControl.Instance.visitedNodes.Add("5B");
        GlobalControl.Instance.currentRow++;

    }
    public void FiveCClick()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
        GlobalControl.Instance.visitedNodes.Add("5C");
        GlobalControl.Instance.currentRow++;

    }
    public void BossClick()
    {
        //UnityEngine.SceneManagement.SceneManager.LoadScene(2);
        GlobalControl.Instance.visitedNodes.Add("Boss");
        GlobalControl.Instance.currentRow=0;

    }
}
