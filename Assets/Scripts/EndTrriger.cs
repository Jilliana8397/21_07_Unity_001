using UnityEngine;

public class EndTrriger : MonoBehaviour
{
    public GameManager gamemanager;
    void OnTriggerEnter()
    {
        gamemanager.CompleteLevel();
    }
}
