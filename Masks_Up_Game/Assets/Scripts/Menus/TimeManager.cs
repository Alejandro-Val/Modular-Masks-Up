using UnityEngine;

public class TimeManager : MonoBehaviour
{
    private float playTime;

    void Start()
    {
        playTime = PlayerPrefs.GetFloat("PlayTime", 0f);
    }

    void Update()
    {
        playTime += Time.deltaTime;
        PlayerPrefs.SetFloat("PlayTime", playTime);
        PlayerPrefs.Save();
    }

    void OnApplicationQuit()
    {
        PlayerPrefs.SetFloat("PlayTime", playTime);
        PlayerPrefs.Save();
    }

    public void Reinicio(){
        playTime = 0f;
    }

    public void Actualizar(float NuevasHoras){
        playTime = NuevasHoras;
    }
}