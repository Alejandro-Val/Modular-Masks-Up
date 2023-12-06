using UnityEngine;
using TMPro;

public class GameQuality : MonoBehaviour
{
    public TMP_Dropdown qualityDropdown;

    void Update()
    {
        qualityDropdown.onValueChanged.AddListener(delegate {
            QualitySettings.SetQualityLevel(qualityDropdown.value);
        });
    }
}