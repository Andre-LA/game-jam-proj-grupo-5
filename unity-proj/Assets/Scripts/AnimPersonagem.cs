using UnityEngine;

public class AnimPersonagem : MonoBehaviour
{
    public DragonBones.UnityArmatureComponent dragonBonesScript;

    public void _MudarVelocidade(float val)
    {
        dragonBonesScript._timeScale = val;
    }
}
