using UnityEngine;
using UnityEngine.UI;

public class UIEase : MonoBehaviour
{
    public AnimationCurve curve;
    float Timer;
    public bool Active;
    public Image Fill;
    public EOSLobbyRemade lobby;
    private void Update()
    {
        Timer += Active ? Time.deltaTime : -Time.deltaTime;
        Fill.fillAmount = curve.Evaluate(Timer);
        Timer = Mathf.Clamp(Timer, -0.001f, 1.001f);
    }
    public void Activate()
    {
        if (Active)
        {
            lobby.JoinViaCode();
            return;
        }
        Active = true;
    }
}
