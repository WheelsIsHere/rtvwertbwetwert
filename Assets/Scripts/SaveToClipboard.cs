using UnityEngine;

public class SaveToClipboard : MonoBehaviour
{
    public TMPro.TMP_Text text;
    public void Copy()
    {
        GUIUtility.systemCopyBuffer = text.text;
    }
    private void FixedUpdate()
    {
        text.text = EOSLobbyRemade.instance.currentLobbyId;
    }
}
