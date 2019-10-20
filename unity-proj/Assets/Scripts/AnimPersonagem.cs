using UnityEngine;

public class AnimPersonagem : MonoBehaviour
{
    public DragonBones.UnityArmatureComponent dragonBonesScript;

    public void TocarAnim(string nome)
    {
        dragonBonesScript.animation.Play(nome, 1);
    }

    public void LoopAnim(string nome)
    {
        dragonBonesScript.animation.Play(nome, 0);
    }

    public void PararAnim()
    {
        dragonBonesScript.animation.Stop();
    }
}
