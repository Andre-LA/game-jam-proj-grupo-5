using UnityEngine;

public class AnimPersonagem : MonoBehaviour
{
    public DragonBones.UnityArmatureComponent dragonBonesScript;

    public void TocarAnim(string nome)
    {
        dragonBonesScript.animation.Play(nome, 1);
    }
}
