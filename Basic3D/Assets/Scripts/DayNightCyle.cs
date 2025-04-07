using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCyle : MonoBehaviour
{
    [SerializeField] private Light lightSource;
    [SerializeField] private float transitionDuration = 15f;
    [SerializeField] private float pauseDuration = 5f;
    [SerializeField] private float maxIntensity = 1;
    [SerializeField] private float minIntensity = 0;
    void Start()
    {
        StartCoroutine(CycleLight());
    }

    private IEnumerator CycleLight()
    {
        while (true)
        {
            yield return StartCoroutine(ChangeLightIntensity(minIntensity, maxIntensity, transitionDuration));

            yield return new WaitForSeconds(pauseDuration);

            yield return StartCoroutine(ChangeLightIntensity(maxIntensity, minIntensity, transitionDuration));

            yield return new WaitForSeconds(pauseDuration);

        }
    }

    private IEnumerator ChangeLightIntensity(float fromIntensity, float toIntensity, float duration)
    {
        float elepsedTime = 0f;
        while(elepsedTime < duration)
        {
            lightSource.intensity = Mathf.Lerp(fromIntensity, toIntensity, elepsedTime / duration);
            elepsedTime += Time.deltaTime;
            yield return null;
        }
        lightSource.intensity = toIntensity;
    }
}
