using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sequencia : MonoBehaviour
{
    public AtivadorCena ativadorCenaAlvo;
    public int indice = -1;
    public string[] sequencia;
    
    float tempoAtual;
    float espera = -1;
    
    public void Start()
    {
        Proximo();
    }
    
    public void Proximo()
    {
        indice += 1;
        if (indice < sequencia.Length)
            ativadorCenaAlvo.estadoAnim = sequencia[indice];
    }
    
    public void AbrirEscolhas(string escolhas)
    {
        PainelEscolhas.AbrirEscolhas(escolhas);
    }
    
    public void AbrirTexto(string txtId)
    {
        PainelEscolhas.AbrirTexto(txtId);
    }
    
    public void EsperaEProximo(float t)
    {
        tempoAtual = Time.time;
        espera = t;
    }
    
    void Update()
    {
        if (espera > 0 && Time.time - tempoAtual >= espera)
        {
            espera = -1;
            Proximo();
        }
    }
}
