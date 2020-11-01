using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class GlobalControl : MonoBehaviour
{
    public static GlobalControl Instance;
    public int currentRow;
    public List<string> visitedNodes;
    public List<List<string>> allNodes = new List<List<string>>();
    public Vector3 prevCameraPosition;

    void Awake()
    {
        allNodes.Add(new List<string>() { "Start" });
        allNodes.Add(new List<string>() { "1A", "1B", "1C" });
        allNodes.Add(new List<string>() { "2A", "2B" });
        allNodes.Add(new List<string>() { "3" });
        allNodes.Add(new List<string>() { "4A", "4B" });
        allNodes.Add(new List<string>() { "5A", "5B", "5C" });
        allNodes.Add(new List<string>() { "Boss"});

        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }
}
