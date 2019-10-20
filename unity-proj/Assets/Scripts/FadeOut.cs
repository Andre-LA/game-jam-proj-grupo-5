using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
        StartCoroutine(CR_FadePraPreto(0, 1, true));
    }
    
    void FadePraTransparente()
    {
        StartCoroutine(CR_FadePraPreto(1, 0, false));    
    }
    
    IEnumerator CR_FadePraPreto(float a, float b, bool irPraProxFase)
    {
        Debug.LogWarning("AAAAAAAAAAAAAAAH");
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
        
        if (irPraProxFase)
          SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
