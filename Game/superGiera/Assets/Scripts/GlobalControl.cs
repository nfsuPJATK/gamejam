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
    public ArrayList allNodes = new ArrayList();

    void Awake()
    {
        allNodes.AddRange(new[] { "Start" });
        allNodes.AddRange(new[] { "1A", "1B", "1C" });
        allNodes.AddRange(new[] { "2A", "2B" });
        allNodes.AddRange(new[] { "3" });
        allNodes.AddRange(new[] { "4A", "4B" });
        allNodes.AddRange(new[] { "5A", "5B", "5C" });
        allNodes.AddRange(new[] { "Boss"});

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
