using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeOut : MonoBehaviour
{
    public Image fadeOut;
    
    void Awake()
    {
        fadeOut.color = Color.black;
    }
    
    void Start()
    {
        FadePraTransparente();
    }
    
    void FadePraPreto()
    {
        StartCoroutine(CR_FadePraPreto(0, 1));
    }
    
    void FadePraTransparente()
    {
        StartCoroutine(CR_FadePraPreto(1, 0));    
    }
    
    IEnumerator CR_FadePraPreto(float a, float b)
    {
        float t = 0;
        float _t = Time.time;
        
        while (t < 1)
        {
            t = Time.time - _t;

            fadeOut.color = Color.Lerp(
                new Color(0f*a, 0f*a, 0f*a, 1f*a),
                new Color(0f*b, 0f*b, 0f*b, 1f*b),
                t
            );

            yield return new WaitForEndOfFrame();
        }
    }
}
