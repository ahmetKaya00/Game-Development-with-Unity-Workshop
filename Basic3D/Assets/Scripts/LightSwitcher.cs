using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitcher : MonoBehaviour
{
    [SerializeField]
    private Light lightSource;
    [SerializeField]
    private KeyCode toggleKey = KeyCode.L;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(toggleKey))
        {
            lightSource.enabled = !lightSource.enabled;
        }
    }
}
