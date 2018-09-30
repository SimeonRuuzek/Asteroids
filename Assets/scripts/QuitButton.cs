using UnityEngine;
using System.Collections;

// Quits the player when the user hits escape

public class QuitButton : MonoBehaviour
{

    public void quidGame()
    {
        Application.Quit();
    }
}