using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]private List<Camera> cameras;
    void Start()
    {
        activeCamera(0);
    }

    void Update()
    {
        for(int i = 0; i < cameras.Count; i++)
        {
            if(Input.GetKeyDown(KeyCode.Alpha1 + i))
            {
                activeCamera(i);
            }
        }
    }

    void activeCamera(int index)
    {
        if(index < 0 || index >= cameras.Count)
        {
            Debug.LogError("Invalid camera index!");
            return;
        }
        for(int i = 0; i < cameras.Count; i++)
        {
            cameras[i].gameObject.SetActive(i == index);
        }
    }
}
