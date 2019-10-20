using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuPrincipalScript : MonoBehaviour
{
    public Animator _animator;
        
    public void BotaoJogar()
    {
        _animator.Play("CameraJogar");
        StartCoroutine(CarregaCena(1f));
    }

    public void BotaoSobre()
    {
        _animator.Play("CameraSobre");
    }

    public void BotaoSobreVoltar()
    {
        _animator.Play("CameraSobre Volta");
    }
    public void BotaoComoJogar()
    {
        _animator.Play("CameraComoJogar");
    }
    public void BotaoComoJogarVolta()
    {
        _animator.Play("CameraComoJogar Volta");
    }
    public void BotaoSair()
    {
        _animator.Play("CameraSair");   
    }
    public void BotaoSairVolta()
    {
        _animator.Play("CameraSair Volta");
    }
    public void SaidaConfirmada()
    {
        Application.Quit();
    }

    IEnumerator CarregaCena(float segundos)
    {
        yield return new WaitForSeconds(segundos);
        SceneManager.LoadScene("D1C1_quarto");
    }
 
}
