using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Eventos : MonoBehaviour
{
    public UnityEvent[] eventos;
    
    public void Executar(int i)
    {
      if (i < eventos.Length)
        eventos[i].Invoke();
    }
}
