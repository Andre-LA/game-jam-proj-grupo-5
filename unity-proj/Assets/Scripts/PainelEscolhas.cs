using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PainelEscolhas : MonoBehaviour
{
    public Sequencia sequenciaCena;
    public Sequencia[] sequenciasPossiveis;
    
    public GameObject alternativas, txt;
    
    static PainelEscolhas instancia;
    
    static PainelEscolhas ObterInstancia()
    {
        if (instancia == null);
            instancia = FindObjectOfType<PainelEscolhas>();
        return instancia;
    }

    public void EscolherAlternativa(int i)
    {
        sequenciaCena.ativadorCenaAlvo = sequenciasPossiveis[i].ativadorCenaAlvo;
        sequenciaCena.sequencia = sequenciasPossiveis[i].sequencia;
        sequenciaCena.indice = -1;
        sequenciaCena.Proximo();
    }
    
    public static void AbrirEscolhas(string escolhas) { ObterInstancia()._AbrirEscolhas(escolhas); }
    public static void AbrirTexto(string txtId) { ObterInstancia()._AbrirTexto(txtId); }
    
    
    public void _AbrirEscolhas(string escolhas)
    {
        string[] escolhas_strs = escolhas.Split(';');
        
        alternativas.SetActive(true);
        txt.SetActive(false);
        
        for (int i = 0; i < 3; i++)
        {
            Transform escolha = alternativas.transform.GetChild(i).GetChild(0);
            Text escolha_text = escolha.GetComponent<Text>();
            escolha_text.text = escolhas_strs[i];
        }
    }
    
    public void _AbrirTexto(string txtId)
    {
        alternativas.SetActive(false);
        txt.SetActive(true);
        txt.transform.Find("fundo2").Find("txt txt").GetComponent<Text>().text = txtId;
    }
}
