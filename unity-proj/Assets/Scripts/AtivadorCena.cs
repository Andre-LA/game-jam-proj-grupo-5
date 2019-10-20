using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtivadorCena : MonoBehaviour
{
    public string estadoAnim;
    string estadoAnimAtual;
    Animator animator;
        
    void Awake()
    {
        animator = GetComponent<Animator>();
    }
    
    public void RemotoAltera(string remotoNome_novoEstado)
    {
        string[] ids = remotoNome_novoEstado.Split('.');
        GameObject remotoGbj = GameObject.Find(ids[0]);
        if (remotoGbj == null)
            Debug.LogWarning("GameObject \"" + ids[0] + "\" não encontrado");
        
        AtivadorCena remoto = remotoGbj.GetComponent<AtivadorCena>();
        remoto.estadoAnim = ids[1];
    }
    
    void Update()
    {
        if (estadoAnimAtual != estadoAnim)
        {
            estadoAnimAtual = estadoAnim;
            animator.Play(estadoAnim);
        }
    }
}
