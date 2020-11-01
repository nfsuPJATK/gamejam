using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.UI;
using Vector3 = UnityEngine.Vector3;
//using UnityEngine.UIElements; 

public class MapLoadScript : MonoBehaviour
{
    /* public Vector3 translateVector(Vector3 org, object x = null, object y = null, object z = null)
     {
         return new Vector3((x == null ? org.x : org.x+(float)x), (y == null ? org.y : org.y+(float)y), (z == null ? org.z : org.z+(float)z));
     }
    */
    // Start is called before the first frame update
    public Vector3 newCameraPosition;
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
        List <string>[] allNodes = GlobalControl.Instance.allNodes.ToArray();
    
        for (int i= 0; i < allNodesNo;i++)
        {
            if (i != GlobalControl.Instance.currentRow)
            {
                foreach (string nodeName in  allNodes[i])
                {
                    Button button = GameObject.Find(nodeName).GetComponent<Button>();
                    button.interactable = false;
                }
            }

        }
        

        Camera camera = GameObject.Find("Camera").GetComponent<Camera>();
        Vector3 cameraPos = camera.transform.position;
        Vector3 newCameraPos = cameraPos;
        if (GlobalControl.Instance.currentRow <= 5)
        {
            if (GlobalControl.Instance.currentRow != 0)
            {
                cameraPos.y = cameraPos.y + (GlobalControl.Instance.currentRow-1) * 400;
            }
            newCameraPos.y = newCameraPos.y + GlobalControl.Instance.currentRow * 400;

        }
        else
        {
            cameraPos.y = cameraPos.y + 4 * 400;
            newCameraPos.y = newCameraPos.y + 5 * 400;
        }
        UnityEngine.Debug.Log("==========");
        UnityEngine.Debug.Log("cameraPos: " + cameraPos);
        UnityEngine.Debug.Log("newCameraPos" + newCameraPos);
        UnityEngine.Debug.Log("==========");
        camera.transform.position = cameraPos;
        newCameraPosition = newCameraPos;
        

    }

    private void Update()
    {
        Camera camera = GameObject.Find("Camera").GetComponent<Camera>();
        camera.transform.position = Vector3.Slerp(camera.transform.position, newCameraPosition, Time.deltaTime);

    }


}
