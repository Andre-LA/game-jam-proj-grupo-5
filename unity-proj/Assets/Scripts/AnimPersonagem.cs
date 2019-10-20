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
    
    public void FliparX(int def)
    {
        dragonBonesScript.armature.flipX = def != 0;
    }
    
    public void FliparY(int def)
    {
        dragonBonesScript.armature.flipY = def != 0;
    }
}
