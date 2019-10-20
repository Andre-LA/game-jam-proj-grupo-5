using UnityEngine;
using UnityEngine.PostProcessing;

public class ModificadorPosProcess : MonoBehaviour
{
    public PostProcessingProfile perfil;
    [Range(0,1)]
    public float intensidade = 1f;

    

    [ContextMenu("Atualizar Perfil")]
    public void AtualizaPerfil()
    {
        float intensidadeGrain = 0.18f;
        float intensidadeVignette = 0.4f;
        float temperatura = -5f;
        float difSaturacao = 0.64f;
        float difContraste = 0.3f;

        GrainModel.Settings grainSettings = perfil.grain.settings;
        grainSettings.intensity = intensidadeGrain * intensidade;
        perfil.grain.settings = grainSettings;

        VignetteModel.Settings vignetteSettings = perfil.vignette.settings;
        vignetteSettings.intensity = intensidadeVignette * intensidade;
        perfil.vignette.settings = vignetteSettings;

        ColorGradingModel.Settings colorGradingSettings = perfil.colorGrading.settings;
        colorGradingSettings.basic.temperature = temperatura * intensidade;
        colorGradingSettings.basic.saturation = 1 - difSaturacao * intensidade;
        colorGradingSettings.basic.contrast = 1 - difContraste * intensidade;
        colorGradingSettings.colorWheels.log.slope = new Color(1 - 0.183f * intensidade, 1 - 0.152f * intensidade, 1f, 0f);
        colorGradingSettings.colorWheels.log.power = new Color(1 - 0.35f * intensidade, 1 - 0.284f * intensidade, 1f, 0f);

        perfil.colorGrading.settings = colorGradingSettings;
    }
}
