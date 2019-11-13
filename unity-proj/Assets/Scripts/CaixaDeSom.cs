using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaixaDeSom : MonoBehaviour
{
    // algum desses será o escritório
    // algum desses será o bar

    public enum EfeitosSonoros {
        Passos,       // 0
        B,            // 1
        C,            // 2
        Buzina,       // 3
        SomCama,      // 4
        E,            // 5
        Chuveiro,     // 6
        F,            // 7
        G,            // 8
        Celular,      // 9
        lavarRosto,   // 10
        Dirigindo,    // 11
        batidaCarro,  // 12
        L,            // 13
    }

    public AudioClip clipePassos;      // 0
    public AudioClip clipeB;           // 1
    public AudioClip clipeC;           // 2
    public AudioClip clipeBuzina;      // 3
    public AudioClip clipeSomCama;     // 4
    public AudioClip clipeE;           // 5
    public AudioClip clipeChuveiro;    // 6
    public AudioClip clipeF;           // 7
    public AudioClip clipeG;           // 8
    public AudioClip clipeCelular;     // 9
    public AudioClip clipeLavarRosto;  // 10
    public AudioClip clipeDirigindo;   // 11
    public AudioClip clipeBatidaCarro; // 12
    public AudioClip clipeL;           // 13


    AudioClip ClipeCorrespondente(EfeitosSonoros efeito) {
        switch (efeito)
        {
            case EfeitosSonoros.Passos:      return clipePassos;      // 0
            case EfeitosSonoros.B:           return clipeB;           // 1
            case EfeitosSonoros.C:           return clipeC;           // 2
            case EfeitosSonoros.Buzina:      return clipeBuzina;      // 3
            case EfeitosSonoros.SomCama:     return clipeSomCama;     // 4
            case EfeitosSonoros.E:           return clipeE;           // 5
            case EfeitosSonoros.Chuveiro:    return clipeChuveiro;    // 6
            case EfeitosSonoros.F:           return clipeF;           // 7
            case EfeitosSonoros.G:           return clipeG;           // 8
            case EfeitosSonoros.Celular:     return clipeCelular;     // 9
            case EfeitosSonoros.lavarRosto:  return clipeLavarRosto;  // 10
            case EfeitosSonoros.Dirigindo:   return clipeDirigindo;   // 11
            case EfeitosSonoros.batidaCarro: return clipeBatidaCarro; // 12
            case EfeitosSonoros.L:           return clipeL;           // 13
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
