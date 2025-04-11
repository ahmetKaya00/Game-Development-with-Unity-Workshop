using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public static float DonmeHizi = 100f;


    private void Update()
    {
        transform.Rotate(0f, 0f, DonmeHizi * Time.deltaTime);
    }
}
