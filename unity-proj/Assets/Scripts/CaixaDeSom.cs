using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaixaDeSom : MonoBehaviour
{

    public enum EfeitosSonoros {
        Passos,       // 0
        Escritorio,   // 1
        Bar,          // 2
        Buzina,       // 3
        SomCama,      // 4
        Chuva,        // 5
        Chuveiro,     // 6
        F,            // 7
        G,            // 8
        Celular,      // 9
        lavarRosto,   // 10
        Dirigindo,    // 11
        batidaCarro,  // 12
    }

    public AudioClip clipePassos;       // 0
    public AudioClip clipeEscritorio;   // 1
    public AudioClip clipeBar;          // 2
    public AudioClip clipeBuzina;       // 3
    public AudioClip clipeSomCama;      // 4
    public AudioClip clipeChuva;        // 5
    public AudioClip clipeChuveiro;     // 6
    public AudioClip clipeF;            // 7
    public AudioClip clipeG;            // 8
    public AudioClip clipeCelular;      // 9
    public AudioClip clipeLavarRosto;   // 10
    public AudioClip clipeDirigindo;    // 11
    public AudioClip clipebatidaCarro;  // 12


    AudioClip ClipeCorrespondente(EfeitosSonoros efeito) {
        switch (efeito)
        {
            case EfeitosSonoros.Passos:      return clipePassos;       // 0
            case EfeitosSonoros.Escritorio:  return clipeEscritorio;   // 1
            case EfeitosSonoros.Bar:         return clipeBar;          // 2
            case EfeitosSonoros.Buzina:      return clipeBuzina;       // 3
            case EfeitosSonoros.SomCama:     return clipeSomCama;      // 4
            case EfeitosSonoros.Chuva:       return clipeChuva;        // 5
            case EfeitosSonoros.Chuveiro:    return clipeChuveiro;     // 6
            case EfeitosSonoros.F:           return clipeF;            // 7
            case EfeitosSonoros.G:           return clipeG;            // 8
            case EfeitosSonoros.Celular:     return clipeCelular;      // 9
            case EfeitosSonoros.lavarRosto:  return clipeLavarRosto;   // 10
            case EfeitosSonoros.Dirigindo:   return clipeDirigindo;    // 11
            case EfeitosSonoros.batidaCarro: return clipebatidaCarro;  // 12
        }
        return null;
    }

    public void EmitirEfeitoSonoro(EfeitosSonoros efeito) {
        GameObject novaCaixa = Instantiate<GameObject>(
            new GameObject(string.Concat("Caixa de Som ", efeito.ToString())),
            Vector3.zero,
            Quaternion.identity
        );

        AudioSource novaCaixa_as = novaCaixa.AddComponent<AudioSource>();
        novaCaixa_as.playOnAwake = false;
        novaCaixa_as.loop = false;
        novaCaixa_as.clip = ClipeCorrespondente(efeito);
        novaCaixa_as.Play();
    }

    public void LimparEfeitoSonoro() {

    }
}
