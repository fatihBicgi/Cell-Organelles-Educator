using UnityEngine;
using UnityEngine.UI;

public class OnButtonClicks : MonoBehaviour
{
    public float cooldownDuration = 5f; // Butonun tekrar aktif olmasý için beklenen süre
    private Button button;
    private bool isCooldown;

    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnClickButton);
    }

    private void OnClickButton()
    {
        if (!isCooldown)
        {
            button.interactable = false;
            isCooldown = true;
            Invoke(nameof(EnableButton), cooldownDuration);
        }
    }

    private void EnableButton()
    {
        button.interactable = true;
        isCooldown = false;
    }
}
