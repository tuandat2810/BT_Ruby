using System.Threading;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public float displayTime = 5.0f;
    public GameObject dialogBox;

    float timerDisplay;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        dialogBox.SetActive(false);
        timerDisplay = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerDisplay > 0)
        {
            timerDisplay -= Time.deltaTime;
            if (timerDisplay <= 0)
            {
                dialogBox.SetActive(false);
            }
        }
    }

    public void showDialog()
    {
        dialogBox.SetActive(true);
        timerDisplay = displayTime;
    }
}
