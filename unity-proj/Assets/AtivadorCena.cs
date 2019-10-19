using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtivadorCena : MonoBehaviour
{
    [SerializeField]
    public string estadoAnim;
    string estadoAnimAtual;
    Animator animator;
    
    void Awake()
    {
      animator = GetComponent<Animator>();
    }
    
    public void t1 () { }
    public void t2 (string s) { }
    public void t3 (int x) { }
    
    void Update()
    {
      if (estadoAnimAtual != estadoAnim)
      {
        estadoAnimAtual = estadoAnim;
        animator.Play(estadoAnim);
      }
    }
}
