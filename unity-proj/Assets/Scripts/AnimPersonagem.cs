using UnityEngine;

public class AnimPersonagem : MonoBehaviour
{
    public DragonBones.UnityArmatureComponent dragonBonesScript;

    public void TocarAnim(string nome)
    {
        dragonBonesScript.animation.Play(nome, 1);
    }

    public void RemotoTocarAnim(string obj_anim_qtd)
    {
        string[] ids = obj_anim_qtd.Split('.');
        GameObject remotoGbj = GameObject.Find(ids[0]);
        if (remotoGbj == null)
            Debug.LogWarning("GameObject \"" + ids[0] + "\" não encontrado");

        DragonBones.UnityArmatureComponent dbs = 
            remotoGbj.GetComponent<DragonBones.UnityArmatureComponent>();
        dbs.animation.Play(ids[1], int.Parse(ids[2]));
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
