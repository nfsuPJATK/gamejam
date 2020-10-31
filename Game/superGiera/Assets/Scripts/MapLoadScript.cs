using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.UI; 
//using UnityEngine.UIElements; 

public class MapLoadScript : MonoBehaviour
{
    public Vector3 translateVector(Vector3 org, object x = null, object y = null, object z = null)
    {
        return new Vector3((x == null ? org.x : org.x+(float)x), (y == null ? org.y : org.y+(float)y), (z == null ? org.z : org.z+(float)z));
    }
    // Start is called before the first frame update
    void Start()
    {
        foreach (string nodeName in GlobalControl.Instance.visitedNodes)
        {
            Button button = GameObject.Find(nodeName).GetComponent<Button>();
            ColorBlock cb = button.colors;
            cb.disabledColor = new Color(0, 0, 0, 255);
            button.colors = cb;
        }
        int allNodesNo = GlobalControl.Instance.allNodes.Count;
        ArrayList allNodes = GlobalControl.Instance.allNodes;

        for (int i= 0; i < allNodesNo;i++)
        {
            if (i != GlobalControl.Instance.currentRow)
            {
                foreach (string nodeName in (List<string>) allNodes[i])
                {
                    Button button = GameObject.Find(nodeName).GetComponent<Button>();
                    button.interactable = false;
                }
            }

        }
        Camera camera = GameObject.Find("Camera").GetComponent<Camera>();
        Vector3 cameraPos = camera.transform.position;
        camera.transform.position = 
            Vector3.Slerp(cameraPos, translateVector(cameraPos, translateVector(cameraPos, null, GlobalControl.Instance.currentRow*400, null)), 1);

    }

  
}
