using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    private Ads ads;
    private void Start()
    {
        ads = FindObjectOfType<Ads>();
        ads.LoadAd();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            ads.LoadInterstitialAd();
            Time.timeScale = 0f;
        }
    }
}
