using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipalScript : MonoBehaviour
{
    public Transform camera;
    public Animator _animator;

    public void BotaoSobre()
    {
        _animator.Play("Camera_Sobre");
    }

    public void Voltar()
    {
        _animator.Play("Camera_Sobre_Volta");
    }
    public void Sobe()
    {
        _animator.Play("CameraSobe");
    }
    public void SobeVolta()
    {
        _animator.Play("CameraSobe");
    }
}
