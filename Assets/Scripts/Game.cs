using UnityEngine;

public class Game : MonoBehaviour
{
    public Control Control;
    public enum State
    {
        Playing,
        Win,
        Loss,
    }

    public void OnPlayerDied()
    {
        if (CurrentState != State.Playing) return;

        CurrentState = State.Loss;
        Control.enabled = false;
        Debug.Log("Game Over");


    }
    public void OnPlayerReachedFinish()
    {
        if (CurrentState != State.Playing) return;

        CurrentState = State.Win;
        Control.enabled = false;
        Debug.Log("You Win!");
    }
    public State CurrentState { get; private set; }
    
}
